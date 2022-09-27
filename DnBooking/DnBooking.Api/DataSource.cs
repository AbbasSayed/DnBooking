using DnBooking.Domain.Models;

namespace DnBooking.Api
{
    public class DataSource
    {
        public DataSource()
        {
            Hotels = GetHotels();
        }

        public List<Hotel> Hotels { get; set; }

        private List<Hotel> GetHotels()
        {
            return new List<Hotel>
            {
                new Hotel
                {
                    HotelId = 1,
                    Name = "Conquistador",
                    Stars = 3,
                    Country = "Puerto Rico",
                    City = "Fajardo",
                    Description = "Some nice description"
                },

                new Hotel
                {
                    HotelId = 2,
                    Name = "The Westin",
                    Stars = 4,
                    Country = "USA",
                    City = "Seattle",
                    Description = "Some nice description"
                }
            };
        }

        public void AddHotel(Hotel hotel)
        {
            var maxHotelId =  Hotels.Max(h => h.HotelId);
            hotel.HotelId = maxHotelId + 1;
            Hotels.Add(hotel);
        }

        
    }
}
