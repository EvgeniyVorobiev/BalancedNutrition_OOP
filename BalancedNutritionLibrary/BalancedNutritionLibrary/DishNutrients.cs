using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BalancedNutritionLibrary
{
    public class DishNutrients
    {
        public DishNutrients()
        {

        }
        [Key]
        public int Id { get; set; }

        [Required]
        public float DishNutrientWeight { get; set; }
        public Dish Dish { get; set; }
        public NutrientsDirectory NutrientsDirectory { get; set; }
    }
}
