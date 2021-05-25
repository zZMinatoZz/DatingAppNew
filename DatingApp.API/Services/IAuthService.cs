using System.Threading.Tasks;
using DatingApp.API.Dtos;

namespace DatingApp.API.Services
{
    public interface IAuthService
    {
        Task<UserForLoginReturnDto> Login(UserForLoginDto userForLoginDto);
        
        Task<UserForLoginReturnDto> Register(UserForRegisterDto userForRegisterDto);
    }
}