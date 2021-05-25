using System.Threading.Tasks;
using DatingApp.API.Dtos;

namespace DatingApp.API.Services
{
    public class LoginService : ILogin
    {
        private readonly IUserService _userService;
        private readonly IPasswordService _passwordService;
        private readonly ITokenService _tokenService;
        public LoginService(IUserService userService, IPasswordService passwordService, ITokenService tokenService)
        {
            _tokenService = tokenService;
            _passwordService = passwordService;
            _userService = userService;

        }
        public async Task<UserForLoginReturnDto> Login(UserForLoginDto userForLoginDto)
        {
            var user = await _userService.GetUserLogin(userForLoginDto);

            if (user == null) return null;

            if (!_passwordService.VerifyPasswordHash(userForLoginDto.Password, user.PasswordHash, user.PasswordSalt)) return null;

            var token = _tokenService.CreateToken(user);

            return new UserForLoginReturnDto {
                Username = user.Username,
                Token = token
            };
        }
    }
}