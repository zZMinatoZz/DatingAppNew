using System.Threading.Tasks;
using DatingApp.API.Dtos;
using DatingApp.API.Entities;

namespace DatingApp.API.Data
{
    public interface IAuthRepository
    {
        Task<User> Login(UserForLoginDto userForLoginDto);
        // Task<User> Register();
    }
}