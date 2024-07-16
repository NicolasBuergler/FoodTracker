using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTracker.Models
{
    public class Food
    {
        public FoodType Type { get; set; }
        public DateTime EatingDateTime { get; set; }

    }
}
