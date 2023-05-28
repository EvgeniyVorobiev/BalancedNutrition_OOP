﻿using BalancedNutritionLibrary;
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
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
            {
                menu = db.PlannedMenus.Include(pm => pm.Days).Where(pm => pm.Id == Convert.ToInt32(plannedMenuTextBox.Text)).First();
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
        }
    }
}
