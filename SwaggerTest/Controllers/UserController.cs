using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwaggerTest.BusinessLogic.Interfaces;
using SwaggerTest.Common.DTOs;

namespace SwaggerTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("/getAll")]
        public IActionResult GetAll()
        {
            try
            {
                var users = _userService.GetAll();

                return StatusCode(200, users);
            }
            catch (Exception e)
            {
                return StatusCode(400, e.Message);
            }
        }

        [HttpGet("/get")]
        public IActionResult Get([FromQuery]Identifier identifier)
        {
            try
            {
                var user = _userService.Get(identifier);

                return StatusCode(200, user);
            }
            catch (Exception e)
            {
                return StatusCode(400, e.Message);
            }
        }

        [HttpPut("/update")]
        public IActionResult Update(UserUpdateDto userUpdateDto)
        {
            try
            {
                _userService.Update(userUpdateDto);

                return StatusCode(202);
            }
            catch (Exception e)
            {
                return StatusCode(400, e.Message);
            }
        }

        [HttpDelete("/delete")]
        public IActionResult Delete(Identifier identifier)
        {
            try
            {
                _userService.Delete(identifier);

                return StatusCode(200);
            }
            catch (Exception e)
            {
                return StatusCode(400, e.Message);
            }
        }
    }
}
