using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.API.Entities;

namespace DatingApp.API.Services
{
    public interface IUserService
    {
        Task<User> GetUserById(int id);
        Task<List<User>> GetUsers();
    }
}