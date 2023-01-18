using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BalancedNutritionLibrary
{
    public class Product : BaseClass
    {
        public Product()
        {

        }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        public float ProductWeight { get; set; }
        [Required]
        public Ingridient Ingridient { get; set; }
        public ICollection <ProductNutrients> ProductNutrients { get; set; }
    }
}
