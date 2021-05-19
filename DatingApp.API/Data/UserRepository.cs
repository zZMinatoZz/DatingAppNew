using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.API.Dtos;
using DatingApp.API.Entities;
using DatingApp.API.Services;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;
        private readonly IPasswordService _passwordService;
        public UserRepository(DataContext context, IPasswordService passwordService)
        {
            _context = context;
            _passwordService = passwordService;
        }
        public async Task<User> GetUserById(int id)
        {
            return await _context.Users.FirstOrDefaultAsync(user => user.UserId == id);
        }

        public async Task<User> GetUserLogin(UserForLoginDto userForLoginDto)
        {
            return await _context.Users.FirstOrDefaultAsync(user => user.Username == userForLoginDto.Username);
        }

        public async Task<bool> HasUserExisted(UserForLoginDto userForLoginDto)
        {
            if(await _context.Users.AnyAsync(user => user.Username == userForLoginDto.Username)) return true;

            return false;
        }

        // public async Task<List<User>> GetUsers()
        // {
        //     throw new System.NotImplementedException();
        // }


    }
}