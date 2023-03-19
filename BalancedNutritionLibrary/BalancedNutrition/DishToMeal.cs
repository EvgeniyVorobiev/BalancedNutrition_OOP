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
    public partial class DishToMeal : Form
    {
        public DishToMeal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
            {
                DateTime dateTime = dateTimePicker.Value;
                string mealName = mealComboBox.Text;
                string dishName = textBox1.Text;
                Dish dish = db.Dishes.Where(d => d.Name == dishName).ToList()[0];
                PlannedMenu plannedMenu = BalancedNutritionForm.menu;
                BalancedNutritionLibrary.Day day =
                    db.Days.Where(d => d.PlannedMenu == plannedMenu && d.Date.Date == dateTime.Date).ToList()[0];
                Meal meal = db.Meals.Where(m => m.Day == day).ToList()[0];
                meal.Dishes.Add(dish);
                db.SaveChanges();

            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
