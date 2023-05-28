using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BalancedNutritionLibrary
{
    public class PlannedMenu
    {
        public PlannedMenu()
        {
            Days = new List<Day>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime BeginingDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public User User { get; set; }
        public List <Day> Days { get; set; }
        public Group Group { get; set; }
    }
}
