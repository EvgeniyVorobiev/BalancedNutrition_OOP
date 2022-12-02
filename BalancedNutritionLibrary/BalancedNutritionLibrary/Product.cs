using System;
using System.Collections.Generic;
using System.Text;

namespace BalancedNutritionLibrary
{
    class Product : BaseClass
    {
        public Product(int Id, string Name, float ProductWeight)
        {
            this.Id = Id;
            this.Name = Name;
            this.ProductWeight = ProductWeight;
        }
        public string Name { get; set; }
        public float ProductWeight { get; set; }
    }
}
