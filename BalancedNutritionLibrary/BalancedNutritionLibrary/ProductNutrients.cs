using System;
using System.Collections.Generic;
using System.Text;

namespace BalancedNutritionLibrary
{
    class ProductNutrients : BaseClass
    {
        public ProductNutrients(int Id, float ProductNutrientWeight)
        {
            this.Id = Id;
            this.ProductNutrientWeight = ProductNutrientWeight;
        }
        public float ProductNutrientWeight { get; set; }
    }
}
