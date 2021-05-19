using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    public class AuthController : BaseApiController
    {
        [HttpPost("login")]
        public async Task<IActionResult> Login()
        {
            return null;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register()
        {
            return null;
        }
    }
}