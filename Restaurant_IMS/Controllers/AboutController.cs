using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_IMS.Controllers
{
    [Route("[controller]/[action]")]
    public class AboutController
    { 
       
        public string Phone()
        {
            return "numri";
        }
        
        public string Address()
        {
            return "LLap";
        }
    }
}
