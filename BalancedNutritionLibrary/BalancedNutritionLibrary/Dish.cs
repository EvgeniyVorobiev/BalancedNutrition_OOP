using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BalancedNutritionLibrary
{
    public class Dish : BaseClass
    {
        public Dish()
        {

        }

        [Required]
        [MaxLength(30)]
        public string Name;
        [Required]
        public string CookingMethod { get; set; }
        [Required]
        public float DishWeight { get; set; }
        [Required]
        public string CookingTechnology { get; set; }
        [Required]
        public string DishCharacteristic { get; set; }
        public ICollection <Meal> Meals { get; set; }
        public ICollection <Ingridient> Ingridients { get; set; }
        public ICollection <DishNutrients> DishNutrients { get; set; }
    }
}
