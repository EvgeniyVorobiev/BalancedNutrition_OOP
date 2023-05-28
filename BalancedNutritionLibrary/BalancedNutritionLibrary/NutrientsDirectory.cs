using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BalancedNutritionLibrary
{
    public class NutrientsDirectory
    {
        public NutrientsDirectory()
        {

        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public List <DishNutrients> DishNutrients { get; set; }
        public List <ProductNutrients> ProductNutrients { get; set; }
    }
}