using System;
using System.Collections.Generic;
using System.Text;

namespace BalancedNutritionLibrary
{
    class Day : BaseClass
    {
        public Day( int Id, DateTime Date)
        {
            this.Id = Id;
            this.Date = Date;
        }
        public DateTime Date { get; set; }
    }
}
