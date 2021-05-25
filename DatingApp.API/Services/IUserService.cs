using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.API.Dtos;
using DatingApp.API.Entities;

namespace DatingApp.API.Services
{
    public interface IUserService
    {
        Task<User> GetUserById(int id);
        
        Task<User> GetUserLogin(UserForLoginDto userForLoginDto);

        Task<bool> HasUserExisted(string username);

        Task<User> AddUser(User user);
    }
}