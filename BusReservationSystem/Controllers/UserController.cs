using Microsoft.AspNetCore.Mvc;
using ReservationDataAccessLayer.Models;
using ReservationServiceLayer.Interfaces;
using ReservationServiceLayer.ViewModel;

namespace BusReservationSystem.Controllers
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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserModel>>> GetUserData()
        {
            var result = await _userService.GetAllData();
            return Ok(result);
        }

        [HttpGet("Id")]
        public async Task<IActionResult> GetUserDetailsById(long Id)
        {
            var result = await _userService.GetById(Id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(UserModel user)
        {
            var result = await _userService.AddData(user);
            return CreatedAtAction("AddUser", result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser(User user)
        {
            var result = await _userService.UpdateData(user);
            return NoContent();
        }

        [HttpDelete("Id")]
        public async Task<IActionResult> DeleteUser(long Id)
        {
            var result = await _userService.DeleteData(Id);
            return result == true ? Ok() : NotFound();

        }


    }
}
