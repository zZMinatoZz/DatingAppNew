using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DatingApp.API.Data;
using DatingApp.API.Dtos;
using DatingApp.API.Entities;

namespace DatingApp.API.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepo;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepo, IMapper mapper)
        {
            _mapper = mapper;
            _userRepo = userRepo;
        }

        public async Task<User> AddUser(User user)
        {
            return await _userRepo.AddUser(user);
        }

        public async Task<User> GetUserById(int id)
        {
            return await _userRepo.GetUserById(id);
        }

        public async Task<User> GetUserLogin(UserForLoginDto userForLoginDto)
        {
            return await _userRepo.GetUserLogin(userForLoginDto);
        }

        public async Task<bool> HasUserExisted(string username)
        {
            return await _userRepo.HasUserExisted(username);
        }
    }
}