using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedNutritionLibrary
{
    public class DishValuesInMeal
    {
        public DishValuesInMeal()
        {
            Weight = 0;
        }
        public Meal Meal = new Meal();
        public float Weight;
    }
}
