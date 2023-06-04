using BalancedNutritionLibrary;
using Microsoft.EntityFrameworkCore;
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
            if (plannedMenuTextBox.Text != "")
            {
                label1.Visible = false;
                using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
                {
                    if (db.PlannedMenus.Where(pm => pm.Id == Convert.ToInt32(plannedMenuTextBox.Text)).ToList().Count > 0 )
                    {
                        menu = db.PlannedMenus.Include(pm => pm.Days).Include(pm => pm.Group).Where(pm => pm.Id == Convert.ToInt32(plannedMenuTextBox.Text)).First();
                        days = db.Days.Include(d => d.Meals).Where(d => d.PlannedMenu.Id == menu.Id).ToList();
                        menu.Days = days;
                        Group groupPM = new Group();
                        foreach (Group group in db.Groups)
                        {
                            foreach (PlannedMenu plannedMenu in group.PlannedMenus)
                            {
                                if (plannedMenu.Id == menu.Id)
                                    groupPM = group;
                            }
                        }

                        BalancedNutritionForm.PlannedMenuLoad(menu);
                        Close();
                    }
                    else
                    {
                        label1.Visible = true;
                        label1.ForeColor = Color.Red;
                        label1.Text = "Проверьте правильность введенных данных";
                    }
                }
            }
            else
            {
                label1.Visible = true;
                label1.ForeColor = Color.Red;
                label1.Text = "Проверьте правильность введенных данных";
            }
        }
    }
}
