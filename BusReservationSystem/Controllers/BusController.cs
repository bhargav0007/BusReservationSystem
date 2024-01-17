using Microsoft.AspNetCore.Mvc;
using ReservationServiceLayer;
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
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] BusModel bus)
        {
            var result = await _busService.AddData(bus);
            return CreatedAtAction("Create Bus", result);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
