using Microsoft.AspNetCore.Mvc;
using Restaurant_IMS.Models;
using Restaurant_IMS.Services;
using Restaurant_IMS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_IMS.Controllers
{
    public class HomeController : Controller 
    {
        private  IRestaurantData _restaurantData;
        private IGreeter _greeter;

        public HomeController (IRestaurantData restaurantData
            ,IGreeter greeter)
        {
            _restaurantData = restaurantData;
            _greeter = greeter;
        }
        public IActionResult Index()
        {
            var model = new HomeIndexViewModel();
            model.Restaurants = _restaurantData.GetAll();
            model.currentMessage = _greeter.GetMessageOfTheDay();
            return View(model);
        }

        public IActionResult Details(int id)
        { 
            var model = _restaurantData.Get(id);
            if(model == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(RestaurantEdit model)
        {
            var newRestaurant = new Restaurant();
            newRestaurant.emri = model.emri;
            newRestaurant.Kuzhina = model.Kuzhina;

            newRestaurant = _restaurantData.Add(newRestaurant);

            return RedirectToAction(nameof(Details), new { id = newRestaurant.Id });
        }
    }
}
