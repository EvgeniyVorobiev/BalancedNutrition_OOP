using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BalancedNutritionLibrary
{
    public class Ingridient : BaseClass
    {
        public Ingridient()
        {

        }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        public float IngridientWaste { get; set; }
        [Required]
        public float WastePercent { get; set; }
        [Required]
        public string CookingMethod { get; set; }
        public Dish Dish { get; set; }
        public ICollection <Product> Products { get; set; }
    }
}
