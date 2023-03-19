using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BalancedNutritionLibrary
{
    public class ProductNutrients 
    {
        public ProductNutrients()
        {

        }
        [Key]
        public int Id { get; set; }

        [Required]
        public float ProductNutrientWeight { get; set; }
        public Product Product { get; set; }
        public NutrientsDirectory NutrientsDirectory { get; set; }
    }
}
