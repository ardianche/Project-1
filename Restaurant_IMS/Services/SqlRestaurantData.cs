using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restaurant_IMS.Models;
using Restaurant_IMS.Data;
using Microsoft.EntityFrameworkCore;

namespace Restaurant_IMS.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private RestaurantDbContext _context;

        public SqlRestaurantData(RestaurantDbContext context)
        {
            _context = context;
        }
        public Restaurant Add(Restaurant restaurant)
        {
            _context.Restaurants.Add(restaurant);
            _context.SaveChanges();
            return restaurant;
        }

        public Restaurant Get(int id)
        {
            return _context.Restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()

        {
            return _context.Restaurants.OrderBy(r => r.emri);
        }

        public Restaurant Update(Restaurant restaurant)
        {
            _context.Attach(restaurant).State = 
                EntityState.Modified;
            _context.SaveChanges();
            return restaurant;
        }
    }
}
