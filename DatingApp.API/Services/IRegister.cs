using System.Threading.Tasks;
using DatingApp.API.Dtos;
using DatingApp.API.Entities;

namespace DatingApp.API.Services
{
    public interface IRegister
    {
        Task<UserForLoginReturnDto> Register(UserForRegisterDto userForRegisterDto);
    }
}