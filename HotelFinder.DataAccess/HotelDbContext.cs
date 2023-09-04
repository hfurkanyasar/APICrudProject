using HotelFinder.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace HotelFinder.DataAccess
{
    public class HotelDbContext : DbContext

    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options): base(options)
        {

        }
        public DbSet<Hotel> Hotels { get; set; }
    }
}
