using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BalancedNutritionLibrary
{
    public class Role : BaseClass
    {
        public Role()
        {

        }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        public ICollection <User> Users { get; set; }

    }
}
