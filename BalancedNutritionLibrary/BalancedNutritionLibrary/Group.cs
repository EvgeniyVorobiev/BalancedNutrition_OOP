using System;
using System.Collections.Generic;
using System.Text;

namespace BalancedNutritionLibrary
{
    class Group : BaseClass
    {
        public Group(int Id, string Name, int NumberOfServings)
        {
            this.Id = Id;
            this.Name = Name;
            this.NumberOfServings = NumberOfServings;
        }
        public string Name { get; set; }
        public int NumberOfServings { get; set; }
    }
}
