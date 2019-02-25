using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Resturantreader.DotWebMVC.Models
{
    public class Resturant
    {
        public string ResturantID { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }

        public class ResturantDBContext : DbContext
        {
            public DbSet<Resturant> Resturants { get; set; }
        }
    }
}