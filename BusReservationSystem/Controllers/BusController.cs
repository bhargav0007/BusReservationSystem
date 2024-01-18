using Microsoft.AspNetCore.Mvc;
using ReservationDataAccessLayer.Models;
using ReservationServiceLayer.Interfaces;
using ReservationServiceLayer.ViewModel;


namespace BusReservationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        private readonly IBusService _busService;

        public BusController(IBusService busService)
        {
            _busService = busService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BusModel>>> Get()
        {
            var result = await _busService.GetAllData();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(long id)
        {
            var result = await _busService.GetById(id);
            return Ok(result);
        }

        [HttpPost(nameof(PostBus))]
        public async Task<IActionResult> PostBus([FromBody] BusModel bus)
        {
            var result = await _busService.AddData(bus);
            return CreatedAtAction(nameof(PostBus), result);
        }

        [HttpPut("UpdateBus/{id}")]
        public async Task<IActionResult> UpdateBus(long id, [FromBody] BusModel bus)
        {
            var result = await _busService.UpdateData(id, bus);
            return result ? NoContent() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<bool> Delete(long id)
        {
            return await _busService.DeleteData(id);
        }
    }
}
