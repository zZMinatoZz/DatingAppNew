using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.API.Dtos;
using DatingApp.API.Entities;

namespace DatingApp.API.Data
{
    public interface IUserRepository
    {
        Task<User> GetUserById(int id);

        // Task<List<User>> GetUsers();

        Task<User> GetUserLogin(UserForLoginDto userForLoginDto);

        Task<bool> HasUserExisted(string username);

        Task<User> AddUser(User user);
    }
}