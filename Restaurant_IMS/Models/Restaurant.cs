using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_IMS.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public int Property { get; set;}

        public String emri { get; set; }

        public Kuzhina Kuzhina { get; set; }
    }
}
