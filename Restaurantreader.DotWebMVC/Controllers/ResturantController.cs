using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static Restaurantreader.DotWebMVC.Models.Restaurant;

namespace Restaurantreader.DotWebMVC.Controllers
{
    public class RestaurantController : Controller
    {
        private RestaurantDBContext db = new RestaurantDBContext();
        // GET: Restaurant
        public ActionResult Index()
        {
            return View(db.Restaurants.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}