using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedNutritionLibrary
{
    public class MenuResultSet
    {
        public MenuResultSet()
        {
            dishNutrients = new List<DishNutrients> {};
        }
        public BalancedNutritionLibrary.Day day{ get; set; }
        public Meal meal { get; set; }
        public Dish dish { get; set; }
        public List <DishNutrients> dishNutrients { get; set; }
    }
}
