using HotelFinder.DataAccess.Abstract;
using HotelFinder.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelFİnder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private IHotelRepository _repo;
        public HotelsController(IHotelRepository repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public List<Hotel> Get()
        {
            return _repo.GetallHotels();
        }
        [HttpGet("{id}")]
        public Hotel Get(int id)
        {
            return _repo.GetHotelByID(id);
        }

        [HttpPost]
        public Hotel Post([FromBody]Hotel hotel)
        {
            return _repo.CreateHotel(hotel);
        }
        [HttpPut]
        public Hotel Put([FromBody] Hotel hotel)
        {
            return _repo.UpdateHotel(hotel);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repo.DeleteHotel(id);
        }
    }
}
