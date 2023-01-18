using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BalancedNutritionLibrary
{
    public class Meal : BaseClass
    {
        public Meal()
        {

        }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public Day Day { get; set; }
        public ICollection <Dish> Dishes { get; set; }
    }
}
