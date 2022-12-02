using System;
using System.Collections.Generic;
using System.Text;

namespace BalancedNutritionLibrary
{
    class Ingridient : BaseClass
    {
        public Ingridient(int Id, string Name, float IngridientWaste, float WastePercent, string CookingMethod)
        {
            this.Id = Id;
            this.Name = Name;
            this.IngridientWaste = IngridientWaste;
            this.WastePercent = WastePercent;
            this.CookingMethod = CookingMethod;
        }
        public string Name { get; set; }
        public float IngridientWaste { get; set; }
        public float WastePercent { get; set; }
        public string CookingMethod { get; set; }
    }
}
