using System.Threading.Tasks;
using DatingApp.API.Dtos;

namespace DatingApp.API.Services
{
    public class AuthService : IAuthService
    {
        private readonly ILogin _loginService;
        private readonly IRegister _registerService;
        public AuthService(ILogin loginService, IRegister registerService)
        {
            _loginService = loginService;
            _registerService = registerService;
        }
        public async Task<UserForLoginReturnDto> Login(UserForLoginDto userForLoginDto)
        {
            return await _loginService.Login(userForLoginDto);
        }

        public async Task<UserForLoginReturnDto> Register(UserForRegisterDto userForRegisterDto)
        {
            return await _registerService.Register(userForRegisterDto);
        }
    }
}