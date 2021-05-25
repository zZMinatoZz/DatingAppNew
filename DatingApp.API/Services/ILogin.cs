using System.Threading.Tasks;
using DatingApp.API.Dtos;

namespace DatingApp.API.Services
{
    public interface ILogin
    {
        Task<UserForLoginReturnDto> Login(UserForLoginDto userForLoginDto);
    }
}