using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BalancedNutritionLibrary
{
    public class Meal
    {
        public Meal()
        {
            Dishes = new List<Dish>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public Day Day { get; set; }
        public List <Dish> Dishes { get; set; }
    }
}
