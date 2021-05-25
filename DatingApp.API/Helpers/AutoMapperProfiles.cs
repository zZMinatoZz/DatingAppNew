using AutoMapper;
using DatingApp.API.Dtos;
using DatingApp.API.Entities;

namespace DatingApp.API.Helpers
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<UserForLoginDto, User>();
            CreateMap<UserForRegisterDto, User>();
        }
    }
}