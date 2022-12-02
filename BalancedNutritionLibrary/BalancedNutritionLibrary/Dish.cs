using System;
using System.Collections.Generic;
using System.Text;

namespace BalancedNutritionLibrary
{
    class Dish : BaseClass
    {
        public Dish(int Id, string Name, string CookingMethod, float DishWeight, string CookingTechnology, string DishCharacteristic)
        {
            this.Id = Id;
            this.Name = Name;
            this.DishWeight = DishWeight;
            this.CookingMethod = CookingMethod;
            this.CookingTechnology = CookingTechnology;
            this.DishCharacteristic = DishCharacteristic;
        }
        public string Name;
        public string CookingMethod { get; set; }
        public float DishWeight { get; set; }
        public string CookingTechnology { get; set; }
        public string DishCharacteristic { get; set; }
    }
}
