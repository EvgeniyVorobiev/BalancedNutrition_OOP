using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace BalancedNutritionLibrary
{
    public class Day
    {
        public Day()
        {
            Meals= new List<Meal>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }
        public PlannedMenu PlannedMenu { get; set;}
        public List <Meal> Meals { get; set; }
    }
}
