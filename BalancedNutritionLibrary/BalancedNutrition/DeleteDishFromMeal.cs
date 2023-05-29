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
    public partial class DeleteDishFromMeal : Form
    {
        public Meal mealMenu = new Meal();
        public Dish dishMenu = new Dish();

        public void MealAndDishLoad(Meal meal, Dish dish)
        {
            mealMenu = meal;
            dishMenu = dish;
        }
        public DeleteDishFromMeal()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext()) 
            {
                mealMenu = db.Meals.Include(m => m.Dishes).Where(m => m.Id == mealMenu.Id).ToList().Last();
                dishMenu = db.Dishes.Include(d => d.Meals).Where(d => d.Id == dishMenu.Id).ToList().Last();
                mealMenu.Dishes.Remove(dishMenu);
                db.SaveChanges();
                Close();
            }

            
        }
    }
}
