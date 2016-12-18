using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TravelPlanerSystem
{
    public class Flight
    {        
        public int ID { get; set; }      
           
        public virtual City CityFrom { get; set; }   
        
        public virtual City CityTo { get; set; }
        
        public DateTime DateFlight { get; set; }
        
        public int FreePlaceCount { get; set; }

        public decimal CostTikcet { get; set; }
    }
}
