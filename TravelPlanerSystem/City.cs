using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlanerSystem
{
    public class City
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual List<Attraction> Attractions { get; set; }
        public virtual List<Hotel> Hotels { get; set; }
    }
}
