using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BalancedNutritionLibrary
{
    public class User
    {
        public User()
        {
            PlannedMenus = new List<PlannedMenu>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Login { get; set; }
        [Required]
        [MaxLength(32)]
        public string Password { get; set; }
        public Role Role { get; set; }
        public List <PlannedMenu> PlannedMenus { get; set; }
    }
}
