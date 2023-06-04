using BalancedNutritionLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
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
    public partial class MenuCreation : Form
    {
        public List<string> days = new List<string>();
        public PlannedMenu menu = new PlannedMenu();
        public MenuCreation()
        {
            InitializeComponent();
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
            {
                List<Group> groups = db.Groups.ToList();
                foreach (Group group in groups)
                {
                    groupComboBox.Items.Add(group.Name);
                }
            }

        }

        private void MenuCreation_Load(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            warningLabel.Visible = false;
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
            {
                DateTime beginDate = beginingDateTimePicker.Value;
                DateTime endDate = endDateTimePicker.Value;
                string groupName = groupComboBox.Text;
                string userName = BalancedNutritionForm.username;
                List<User> users = db.Users.Where(u => u.Login == userName).ToList();
                User user = users[0];
                if (beginDate < endDate && groupName != "")
                {
                    PlannedMenu plannedMenu = new PlannedMenu
                    {
                        BeginingDate = beginDate,
                        EndDate = endDate,
                        User = user,
                        Group = new Group(),
                        Days = new List<BalancedNutritionLibrary.Day> { }
                    };
                    if (db.Groups.Where(g => g.Name == groupName).ToList().Count > 0)
                    {
                        Group group = db.Groups.Where(g => g.Name == groupName).ToList().Last();
                        plannedMenu.Group = group;

                        for (int i = 0; i <= Convert.ToInt32((endDate.Date - beginDate.Date).Days); i++)
                        {
                            DateTime date = beginDate.AddDays(i);
                            BalancedNutritionLibrary.Day day = new BalancedNutritionLibrary.Day
                            { Date = date, PlannedMenu = plannedMenu, Meals = new List<Meal>() };
                            if (mealCheckBox1.Checked == true) day.Meals.Add(new Meal { Name = "Завтрак", Dishes = new List<Dish> { } });
                            if (mealCheckBox1.Checked == true) day.Meals.Add(new Meal { Name = "Обед", Dishes = new List<Dish> { } });
                            if (mealCheckBox1.Checked == true) day.Meals.Add(new Meal { Name = "Полдник", Dishes = new List<Dish> { } });
                            if (mealCheckBox1.Checked == true) day.Meals.Add(new Meal { Name = "Ужин", Dishes = new List<Dish> { } });
                            //   db.Days.Add(day);
                            plannedMenu.Days.Add(day);
                            //   db.SaveChanges();
                        }

                        foreach (BalancedNutritionLibrary.Day d in db.Days.Where(d => d.PlannedMenu == plannedMenu))
                        {
                            days.Add(Convert.ToString(d.Date.Day) + "." + Convert.ToString(d.Date.Month) + "." + Convert.ToString(d.Date.Year));
                        }
                        db.Add(plannedMenu);
                        db.SaveChanges();
                        menu = plannedMenu;
                        Close();
                    }
                    else
                    {

                        warningLabel.Text = "Группа не найдена";
                        warningLabel.Visible = true;
                    }
                }
                else
                {
                    warningLabel.Text = "Проверьте правильность введённых данных";
                    warningLabel.Visible = true;
                }
            }
        }

        private void mealCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupComboBox_TextUpdate(object sender, EventArgs e)
        {
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
            {
                if (groupComboBox.Text != "") 
                {
                    groupComboBox.Items.Clear();
                    List<Group> groups = db.Groups.Where(g => EF.Functions.Like(g.Name, "%" + groupComboBox.Text + "%")).ToList();
                    foreach (Group group in groups)
                    {
                        groupComboBox.Items.Add(group.Name);
                    } 
                }
                else if (groupComboBox.Text == "")
                {
                    groupComboBox.Items.Clear();
                    List<Group> groups = db.Groups.ToList();
                    foreach (Group group in groups)
                    {
                        groupComboBox.Items.Add(group.Name);
                    }
                }
            }
        }
    }
}
