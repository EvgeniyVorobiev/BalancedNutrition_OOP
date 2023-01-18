using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BalancedNutritionLibrary
{
    public class BaseClass
    {
        [Key]
        public int Id { get; set; }
    }
}
