using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BalancedNutritionLibrary
{
    public class Group 
    {
        public Group()
        {

        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        public int NumberOfServings { get; set; }
        public ICollection <PlannedMenu> PlannedMenus { get; set;}
    }
}
