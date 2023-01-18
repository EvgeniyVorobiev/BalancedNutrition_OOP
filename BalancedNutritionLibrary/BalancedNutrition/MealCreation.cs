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
    public partial class MealCreation : Form
    {
        public string mealname;
        public MealCreation()
        {
            InitializeComponent();
        }

        private void MealCreation_Load(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
            {
                warningLabel.Visible = false;
                if (mealComboBox.Text != "")
                {
                    DateTime date = dateTimePicker.Value;
                    string mealName = mealComboBox.Text;
                    BalancedNutritionLibrary.Day day = new BalancedNutritionLibrary.Day();
                    PlannedMenu plannedMenu = BalancedNutritionForm.menu;
                    List<BalancedNutritionLibrary.Day> days = db.Days.Where(d => d.Date.Date == date.Date
                    && d.PlannedMenu == plannedMenu).ToList();
                    day = days[0];
                    Boolean addMeal = true;
                    foreach (Meal m in db.Meals.ToList())
                    {
                        if (m.Name == mealName && m.Day == day)
                        {
                            warningLabel.ForeColor = Color.Red;
                            warningLabel.Text = "В этот день уже назначен такой прием пищи";
                            warningLabel.Visible = true;
                            addMeal = false;
                        }
                        else addMeal = true;
                    }
                    if (addMeal == true)
                    {
                        Meal meal = new Meal { Name = mealName, Day = day };
                        db.Meals.Add(meal);
                        db.SaveChanges();
                        warningLabel.ForeColor = Color.Green;
                        warningLabel.Text = "Приём пищи добавлен";
                        warningLabel.Visible = true;
                        mealname = meal.Name;
                    }

                }
                else
                {
                    warningLabel.ForeColor = Color.Red;
                    warningLabel.Text = "Наименование не выбрано";
                    warningLabel.Visible = true;
                }
            }
        }

        private void groupTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void warningLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
