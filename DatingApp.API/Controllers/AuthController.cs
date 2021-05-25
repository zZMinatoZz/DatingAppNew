using System.Threading.Tasks;
using AutoMapper;
using DatingApp.API.Dtos;
using DatingApp.API.Entities;
using DatingApp.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    public class AuthController : BaseApiController
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login(UserForLoginDto userForLoginDto)
        {
            var userForReturn = await _authService.Login(userForLoginDto);

            if (userForReturn == null) return BadRequest("Username or Password is incorrect!");

            return Ok(userForReturn);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
        {
            var userForReturn = await _authService.Register(userForRegisterDto);

            if(userForReturn == null) return BadRequest("Username has already existed!");

            return StatusCode(201);
        }
    }
}