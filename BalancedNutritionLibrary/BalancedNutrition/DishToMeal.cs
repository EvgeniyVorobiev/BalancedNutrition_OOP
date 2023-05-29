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
    public partial class DishToMeal : Form
    {
        PlannedMenu plannedMenu = new PlannedMenu();
        public Dish selectedDish = new Dish();
        readonly List<Dish> dishes = new List<Dish> { };
        public void PlannedMenuLoad(PlannedMenu plannedMenu)
        {
            this.plannedMenu = plannedMenu;
        }
        public DishToMeal()
        {
            InitializeComponent();
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
            {

                dishes = db.Dishes.ToList();
                foreach (Dish d in dishes)
                {
                    listBox1.Items.Add(d.Name);
                    dishComboBox.Items.Add(d.Name);
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
            {
                bool dateBool = true;
                bool mealBool = false;
                bool dishBool = false;

                if (dateTimePicker.Value.Date > plannedMenu.EndDate.Date || dateTimePicker.Value.Date < plannedMenu.BeginingDate.Date)
                    dateBool = false;
                
                foreach (Meal meal1 in db.Meals.ToList())
                {
                    if (meal1.Name == mealComboBox.Text)
                    {
                        mealBool = true;
                        break;
                    }
                }
                foreach (Dish dish1 in db.Dishes.ToList())
                {
                    if (dish1.Name == dishComboBox.Text)
                    {
                        dishBool = true;
                        break;
                    }
                }
                if (dateBool == true && mealBool == true && dishBool == true) {
                    statusLabel.Hide();
                    DateTime dateTime = dateTimePicker.Value;
                    string mealName = mealComboBox.Text;
                    string dishName = dishComboBox.Text;
                    Dish dish = db.Dishes.Where(d => d.Name == dishName).ToList()[0];
                    //PlannedMenu plannedMenu = BalancedNutritionForm.menu;
                    BalancedNutritionLibrary.Day day =
                        db.Days.Where(d => d.PlannedMenu == plannedMenu && d.Date.Date == dateTime.Date).ToList()[0];
                    Meal meal = db.Meals.Where(m => m.Day == day && m.Name == mealName).ToList()[0];
                    meal.Dishes = new List<Dish> { dish };
                    db.Meals.Update(meal);
                    db.SaveChanges(); 
                }
                else {
                    statusLabel.Show();
                    statusLabel.ForeColor = Color.Red;
                    statusLabel.Text = "Проверьте правильность введённых данных";
                }
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dishTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
            {
                /*                if (dishComboBox.Text != "")
                                {
                                    List<Dish> dishes = db.Dishes.Where(d => EF.Functions.Like(d.Name, "%" + dishComboBox.Text + "%")).ToList();
                                    listBox1.Items.Clear();
                                    dishComboBox.Items.Clear();
                                    foreach (Dish d in dishes)
                                    {
                                        listBox1.Items.Add(d.Name);
                                        dishComboBox.Items.Add(d.Name);
                                    }
                                }
                                else
                                {
                                    List<Dish> dishes = db.Dishes.ToList();
                                    listBox1.Items.Clear();
                                    dishComboBox.Items.Clear();
                                    foreach (Dish d in dishes)
                                    {
                                        listBox1.Items.Add(d.Name);
                                        dishComboBox.Items.Add(d.Name);
                                    }
                                }*/
            }
            /*            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
                        {
                            List<Dish> dishes = db.Dishes.Where(d => EF.Functions.Like(d.Name, "%" + dishComboBox.Text + "%")).ToList();
                            listBox1.Items.Clear();
                            dishComboBox.Items.Clear();
                            foreach (Dish d in dishes)
                            {
                                listBox1.Items.Add(d.Name);
                                dishComboBox.Items.Add(d.Name);
                            }
                        }*/
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
                        {
                            selectedDish = db.Dishes.Where(d => d.Name == listBox1.SelectedItem.ToString()).ToList()[0];
                            DishInfo dishInfo = new DishInfo();
                            dishInfo.ShowDialog(this);
                        }*/
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Load("C:\\Курсовой проект. ООП\\BalancedNutritionLibrary\\pictures\\search_blue.png");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext()) 
            {
                if (dishComboBox.Text != "")
                {
                    List<Dish> dishes = db.Dishes.Where(d => EF.Functions.Like(d.Name, "%" + dishComboBox.Text + "%")).ToList();
                    listBox1.Items.Clear();
                    dishComboBox.Items.Clear();
                    foreach (Dish d in dishes)
                    {
                        listBox1.Items.Add(d.Name);
                        dishComboBox.Items.Add(d.Name);
                    }
                }
                else
                {
                    List<Dish> dishes = db.Dishes.ToList();
                    listBox1.Items.Clear();
                    dishComboBox.Items.Clear();
                    foreach (Dish d in dishes)
                    {
                        listBox1.Items.Add(d.Name);
                        dishComboBox.Items.Add(d.Name);
                    }
                }
            } 
    }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Load("C:\\Курсовой проект. ООП\\BalancedNutritionLibrary\\pictures\\search_black.png");
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
            {
                selectedDish = db.Dishes.Where(d => d.Name == listBox1.SelectedItem.ToString()).ToList()[0];
                ////selectedDish = db.Dishes.ToList()[listBox1.SelectedIndex];
                ///
                //List <DishNutrients> dishNutrients = db.DishNutrients.Where(dn => dn.Dish == selectedDish).ToList();
                //listBox1.Items.Add(dishNutrients[0].DishNutrientWeight.ToString());
                DishInfo dishInfo = new DishInfo();
                dishInfo.DishLoad(selectedDish);
                dishInfo.ShowDialog(this);
            }
        }
    }
}
