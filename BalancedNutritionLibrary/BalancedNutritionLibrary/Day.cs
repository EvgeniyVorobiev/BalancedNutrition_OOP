using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace BalancedNutritionLibrary
{
    public class Day : BaseClass
    {
        public Day()
        {

        }

        [Required]
        public DateTime Date { get; set; }
        public PlannedMenu PlannedMenu { get; set;}
        public ICollection <Meal> Meals { get; set; }
    }
}
