using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedNutritionLibrary
{
    public class ProductResultSet
    {
        public ProductResultSet() 
        {
            Weight = 0;
        }
        public Product Product { get; set; }
        public float Weight;
    }
}
