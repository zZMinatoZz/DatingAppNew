using System.Threading.Tasks;
using DatingApp.API.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    public class UserController : BaseApiController
    {
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {

        }

        [HttpGet("{id}", Name = "GetUser")]
        public async Task<IActionResult> GetUser(int id)
        {

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, UserForUpdateDto userForUpdateDto)
        {

        }
    }
}