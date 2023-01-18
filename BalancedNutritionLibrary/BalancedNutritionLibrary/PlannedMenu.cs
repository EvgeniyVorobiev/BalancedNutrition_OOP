using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BalancedNutritionLibrary
{
    public class PlannedMenu : BaseClass
    {
        public PlannedMenu()
        {

        }

        [Required]
        public DateTime BeginingDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public User User { get; set; }
        public ICollection <Day> Days { get; set; }
        public ICollection <Group> Groups { get; set; }
    }
}
