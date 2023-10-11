using Microsoft.AspNetCore.Mvc;
using SwaggerTest.BusinessLogic.Interfaces;
using SwaggerTest.Common.DTOs;

namespace SwaggerTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("/login")]
        public IActionResult Login(UserAuthDto userAuthDto)
        {
            try
            {
                var token = _authService.Login(userAuthDto);

                if (!string.IsNullOrEmpty(token))
                {
                    return StatusCode(200, token);
                }

                return StatusCode(401);
            }
            catch (Exception e)
            {
                return StatusCode(400, e.Message);
            }
        }

        [HttpPost("/register")]
        public IActionResult Register(UserCreateDto userCreateDto)
        {
            try
            {
                var isCreated = _authService.Register(userCreateDto);

                if (isCreated)
                {
                    return StatusCode(201);
                }

                return StatusCode(403, "User with this email already exists");
            }
            catch (Exception e)
            {
                return StatusCode(400, e.Message);
            }
        }
    }
}
