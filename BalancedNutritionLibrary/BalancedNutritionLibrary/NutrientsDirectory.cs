using System;
using System.Collections.Generic;
using System.Text;

namespace BalancedNutritionLibrary
{
    class NutrientsDirectory : BaseClass
    {
        public NutrientsDirectory(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        public string Name { get; set; }
    }
}
