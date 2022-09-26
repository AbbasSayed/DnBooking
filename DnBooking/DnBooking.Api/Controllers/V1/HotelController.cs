using Microsoft.AspNetCore.Mvc;

namespace DnBooking.Api.Controllers.V1
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class HotelController : ControllerBase
    {
        public HotelController()
        {

        }

        [HttpGet]
        public IActionResult GetAllHotels()
        {
            return Ok("Hello from Hotel Controller!");
        }
    }
}
