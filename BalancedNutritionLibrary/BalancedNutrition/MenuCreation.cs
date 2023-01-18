using BalancedNutritionLibrary;
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
        }

        private void groupCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (groupCheckBox.Checked == true)
            {
                servingsNumberLabel.Visible = true;
                servingsNumberTextBox.Visible = true;
            }
            else
            {
                servingsNumberTextBox.Visible = false;
                servingsNumberLabel.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
                string groupName = groupTextBox.Text;
                string userName = BalancedNutritionForm.username;
                List<User> users = db.Users.Where(u => u.Login == userName).ToList();
                User user = users[0];
                if (groupCheckBox.Checked == true)
                {
                    int servingsNumber = Convert.ToInt32(servingsNumberTextBox.Text);
                    PlannedMenu plannedMenu = new PlannedMenu { BeginingDate = beginDate, EndDate = endDate,
                        User = user, Groups = new List<Group>() };
                    Group group = new Group { Name = groupName, NumberOfServings = servingsNumber,
                        PlannedMenus = new List<PlannedMenu>() };
                    plannedMenu.Groups.Add(group);
                    db.Add(plannedMenu);
                    db.Add(group);
                    db.SaveChanges();

                    for (int i = 0; i <= Convert.ToInt32(endDate.Day - beginDate.Day); i++)
                    {
                        DateTime date = beginDate.AddDays(i);
                        BalancedNutritionLibrary.Day day = new BalancedNutritionLibrary.Day
                        { Date = date, PlannedMenu = plannedMenu };
                        db.Days.Add(day);
                    }
                    db.SaveChanges();
                    foreach (BalancedNutritionLibrary.Day d in db.Days.Where(d => d.PlannedMenu == plannedMenu))
                    {
                        days.Add(Convert.ToString(d.Date.Day)+ "." + Convert.ToString(d.Date.Month) + "." + Convert.ToString(d.Date.Year)); 
                    }
                    menu = plannedMenu;
                    Close();
                }
                else
                {
                    PlannedMenu plannedMenu = new PlannedMenu { BeginingDate = beginDate, EndDate = endDate,
                    User = user, Groups = new List<Group>() };
                    List <Group> groups= db.Groups.Where(g => g.Name == groupName).ToList();
                    if (groups.Count > 0)
                    {
                        Group group = groups[0];
                        plannedMenu.Groups.Add(group);
                        db.Add(plannedMenu);
                        db.SaveChanges();

                        for (int i = 0; i <= Convert.ToInt32(endDate.Day - beginDate.Day); i++)
                        {
                            DateTime date = beginDate.AddDays(i);
                            BalancedNutritionLibrary.Day day = new BalancedNutritionLibrary.Day
                            { Date = date, PlannedMenu = plannedMenu };
                            db.Days.Add(day);
                        }
                        db.SaveChanges();
                        foreach (BalancedNutritionLibrary.Day d in db.Days.Where(d => d.PlannedMenu == plannedMenu))
                        {
                            days.Add(Convert.ToString(d.Date.Day) + "." + Convert.ToString(d.Date.Month) + "." + Convert.ToString(d.Date.Year));
                        }
                        menu = plannedMenu;
                        Close();
                    }
                    else 
                    { 
                    
                        warningLabel.Text = "Группа не найдена";
                        warningLabel.Visible = true;
                    }
                    
                }
            }
        }
    }
}
