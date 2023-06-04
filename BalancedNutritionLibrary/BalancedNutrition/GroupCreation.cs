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
    public partial class GroupCreation : Form
    {
        public GroupCreation()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (groupTextBox.Text != "" && servingsNumberTextBox.Text != "")
            { 
                try
                {
                    using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
                    {
                        if (db.Groups.Where(g => g.Name == groupTextBox.Text).ToList().Count > 0)
                        {
                            warningLabel.Visible = true;
                            warningLabel.ForeColor = Color.Red;
                            warningLabel.Text = "Группа с таким названием уже есть";
                        }
                        else
                        {
                            string groupName = groupTextBox.Text;
                            int servingsNumber = Convert.ToInt32(servingsNumberTextBox.Text);
                            Group group = new Group
                            {
                                Name = groupName,
                                NumberOfServings = servingsNumber,
                                PlannedMenus = new List<PlannedMenu>()
                            };
                            db.Add(group);
                            db.SaveChanges();
                            warningLabel.Visible = true;
                            warningLabel.ForeColor = Color.Green;
                            warningLabel.Text = "Группа создана";
                        }
                    }
                }
                catch (FormatException ex)
                {
                    warningLabel.Visible = true;
                    warningLabel.ForeColor = Color.Red;
                    warningLabel.Text = "Проверьте правильность введённых данных";
                }
            }
            else
            {
                warningLabel.Visible = true;
                warningLabel.ForeColor= Color.Red;
                warningLabel.Text = "Проверьте правильность введённых данных";
            }
        }
    }
}
