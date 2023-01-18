using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BalancedNutritionLibrary
{
    public class NutrientsDirectory : BaseClass
    {
        public NutrientsDirectory()
        {

        }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public ICollection <DishNutrients> DishNutrients { get; set; }
        public ICollection <ProductNutrients> ProductNutrients { get; set; }
    }
}
