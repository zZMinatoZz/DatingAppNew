using System.Threading.Tasks;
using AutoMapper;
using DatingApp.API.Dtos;
using DatingApp.API.Entities;

namespace DatingApp.API.Services
{
    public class RegisterService : IRegister
    {
        private readonly IUserService _userService;
        private readonly IPasswordService _passwordService;
        private readonly IMapper _mapper;
        private readonly ITokenService _tokenService;
        public RegisterService(IUserService userService, IPasswordService passwordService, IMapper mapper, ITokenService tokenService)
        {
            _mapper = mapper;
            _userService = userService;
            _passwordService = passwordService;
            _tokenService = tokenService;
        }
        public async Task<UserForLoginReturnDto> Register(UserForRegisterDto userForRegisterDto)
        {

            if (await _userService.HasUserExisted(userForRegisterDto.Username)) return null;

            var userToCreate = _mapper.Map<User>(userForRegisterDto);
            
            byte[] passwordHash, passwordSalt;

            _passwordService.CreatePasswordHash(userForRegisterDto.Password, out passwordHash, out passwordSalt);

            userToCreate.PasswordHash = passwordHash;
            userToCreate.PasswordSalt = passwordSalt;

            var userAfterSaved = await _userService.AddUser(userToCreate);

            if(userAfterSaved == null) return null;

            string token = _tokenService.CreateToken(userAfterSaved);

            return new UserForLoginReturnDto {
                Username = userAfterSaved.Username,
                Token = token
            };
        }
    }
}