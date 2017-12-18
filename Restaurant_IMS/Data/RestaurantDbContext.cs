using Microsoft.EntityFrameworkCore;
using Restaurant_IMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_IMS.Data
{

    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext (DbContextOptions options) : base(options)
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
