using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Restaurant_IMS.Models
{
    public class Restaurant
    {
        public int Id { get; set; }

        public int Property { get; set;}
        [Display(Name ="Restaurant Name")]
        [Required, MaxLength(80)]
        public string emri { get; set; }

        public Kuzhina Kuzhina { get; set; }
    }
}
