using Restaurant_IMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_IMS.ViewModels
{
    public class RestaurantEdit
    {
        [Required, MaxLength(80)]
        public string emri { get; set; }
        public Kuzhina Kuzhina { get; set; }
    }
}
