using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp
{
    public enum RatingHotel
    {
        OneStar = 1,
        TwoStar = 2,
        ThreeStar = 3,
        FourStar = 4,
        FiveStar = 5
    }
    public class Hotel
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public RatingHotel Rating { get; set; }
        [Required]
        public string Location { get; set; }
    }
}
