using System;
using System.Collections.Generic;
using System.Text;

namespace BalancedNutritionLibrary
{
    class PlannedMenu : BaseClass
    {
        public PlannedMenu(int Id, DateTime BeginingDate, DateTime EndDate)
        {
            this.Id = Id;
            this.BeginingDate = BeginingDate;
            this.EndDate = EndDate;
        }

        public DateTime BeginingDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
