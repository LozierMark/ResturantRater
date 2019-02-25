using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Restaurantreader.DotWebMVC.Models
{
    public class Restaurant
    {
        public string RestaurantID { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }

        public class RestaurantDBContext : DbContext
        {
            public DbSet<Restaurant> Restaurants { get; set; }
        }
    }
}