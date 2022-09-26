using Microsoft.AspNetCore.Mvc;

namespace DnBooking.Api.Controllers.V2
{
    [ApiVersion("2.0")]
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
            return Ok("Hello from Hotel Controller v2 !");
        }
    }
}
