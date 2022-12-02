using System;
using System.Collections.Generic;
using System.Text;

namespace BalancedNutritionLibrary
{
    public class Role : BaseClass
    {
        public Role(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        public string Name { get; set; }
        

    }
}
