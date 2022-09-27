using DnBooking.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace DnBooking.Api.Controllers.V1
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class HotelsController : ControllerBase
    {
        private DataSource _dataSource;
        public HotelsController(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        [HttpGet]
        public IActionResult GetAllHotels()
        {
            return Ok(_dataSource.Hotels);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetHotelById(int id)
        {
            var hotel = _dataSource.Hotels.FirstOrDefault(h => h.HotelId == id);

            if (hotel == null)
            {
                return NotFound();
            }

            return Ok(hotel);
        }

        [HttpPost]
        public IActionResult CreateHotel(Hotel hotel)
        {
            _dataSource.AddHotel(hotel);
            return CreatedAtAction(nameof(GetHotelById), new { id = hotel.HotelId }, hotel);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateHotel(int id, Hotel hotel)
        {
            var hotelToUpdate = _dataSource.Hotels.FirstOrDefault(h => h.HotelId == id);
            if (hotelToUpdate == null)
            {
                return NotFound($"There is no Hotel with the id : {id}");
            }
            _dataSource.Hotels.Remove(hotelToUpdate);
            _dataSource.Hotels.Add(hotel);
            return NoContent();

        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteHotel(int id)
        {
            var hotel =  _dataSource.Hotels.FirstOrDefault(h => h.HotelId == id);

            if (hotel == null)
            {
                return NotFound($"There is no Hotel with the id : {id}");
            }

            _dataSource.Hotels.Remove(hotel);

            return NoContent();
        }
    }
}
