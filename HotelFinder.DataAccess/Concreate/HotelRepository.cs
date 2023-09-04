using HotelFinder.DataAccess.Abstract;
using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAccess.Concreate
{
    public class HotelRepository : IHotelRepository
    {
        private readonly HotelDbContext _cnn;
        public HotelRepository(HotelDbContext cnn)
        {
            _cnn = cnn;
        }
        public Hotel CreateHotel(Hotel hotel)
        {
            _cnn.Hotels.Add(hotel);
            _cnn.SaveChanges();
            return hotel;
        }

        public void DeleteHotel(int id)
        {
            var deletedHotel = GetHotelByID(id);
            _cnn.Hotels.Remove(deletedHotel);
            _cnn.SaveChanges();
        }

        public List<Hotel> GetallHotels()
        {
            return _cnn.Hotels.ToList();
        }

        public Hotel GetHotelByID(int id)
        {

            return _cnn.Hotels.Find(id);

        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            _cnn.Hotels.Update(hotel);
            _cnn.SaveChanges();
            return hotel;
        }
    }
}
