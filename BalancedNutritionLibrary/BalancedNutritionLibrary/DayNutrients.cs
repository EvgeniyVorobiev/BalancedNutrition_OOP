using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedNutritionLibrary
{
    public class DayNutrients
    {
        public DayNutrients()
        {
            Nutrients = new List<Nutrient> { };
        }
        public DateTime DayDate { get; set; }
        public List<Nutrient> Nutrients { get; set; }


    }
    public class Nutrient
    {
        public Nutrient() 
        { 

        }
        public string NutrientName { get; set; }
        public float NutrientWeight { get; set; }
    }
}

