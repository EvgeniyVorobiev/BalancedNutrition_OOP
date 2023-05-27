using BalancedNutritionLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalancedNutrition
{
    public partial class OpenPlannedMenu : Form
    {
        public List<BalancedNutritionLibrary.Day> days = new List<BalancedNutritionLibrary.Day>();
        public PlannedMenu menu = new PlannedMenu();
        public Group group = new Group();
        public OpenPlannedMenu()
        {
            InitializeComponent();
        }

        private void openPlannedMenuButton_Click(object sender, EventArgs e)
        {
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
            {
                menu = db.PlannedMenus.Where(pm => pm.Id == Convert.ToInt32(plannedMenuTextBox.Text)).First();
                days = db.Days.Where(d => d.PlannedMenu.Id == menu.Id).ToList();
                group = menu.Group;
                BalancedNutritionForm.PlannedMenuLoad(menu);
                Close();
            }
        }
    }
}
