using DatingApp.API.Entities;

namespace DatingApp.API.Services
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}