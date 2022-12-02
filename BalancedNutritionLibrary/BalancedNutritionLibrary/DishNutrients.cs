using System;
using System.Collections.Generic;
using System.Text;

namespace BalancedNutritionLibrary
{
    class DishNutrients : BaseClass
    {
        public DishNutrients(int Id, float DishNutrientWeight)
        {
            this.Id = Id;
            this.DishNutrientWeight = DishNutrientWeight;
        }
        public float DishNutrientWeight { get; set; }
    }
}
