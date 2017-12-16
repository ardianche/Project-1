using Restaurant_IMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_IMS.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Restaurant>  Restaurants { get; set; }
        public string currentMessage { get; set; }
    }
}
