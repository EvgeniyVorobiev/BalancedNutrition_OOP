using BalancedNutritionLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BalancedNutrition
{
    public partial class BalancedNutritionForm : Form
    {
        public static string username = "";
        public static PlannedMenu menu = new PlannedMenu();

        public BalancedNutritionForm()
        {
            InitializeComponent();
        }
        public static void PlannedMenuLoad (PlannedMenu plannedMenu)
        {
           menu = plannedMenu;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext()) 
            {
                Role role1 = new Role { Name = "Àäìèíèñòğàòîğ" };
                Role role2 = new Role { Name = "Äèåòîëîã" };
                Role role3 = new Role { Name = "Ğîäèòåëü" };




                //db.Roles.AddRange(role1, role2, role3);

                NutrientsDirectory nutrientsDirectory1 = new NutrientsDirectory { Name = "Áåëêè" };
                NutrientsDirectory nutrientsDirectory2 = new NutrientsDirectory { Name = "Æèğû" };
                NutrientsDirectory nutrientsDirectory3 = new NutrientsDirectory { Name = "Óãëåğîäû" };
                NutrientsDirectory nutrientsDirectory4 = new NutrientsDirectory { Name = "Êàëîğèéíîñòü" };

                NutrientsDirectory nutrientsDirectory5 = new NutrientsDirectory { Name = "C" };
                NutrientsDirectory nutrientsDirectory6 = new NutrientsDirectory { Name = "B1" };
                NutrientsDirectory nutrientsDirectory7 = new NutrientsDirectory { Name = "B2" };
                NutrientsDirectory nutrientsDirectory8 = new NutrientsDirectory { Name = "A" };
                NutrientsDirectory nutrientsDirectory9 = new NutrientsDirectory { Name = "D" };

                NutrientsDirectory nutrientsDirectory10 = new NutrientsDirectory { Name = "Ca" };
                NutrientsDirectory nutrientsDirectory11 = new NutrientsDirectory { Name = "P" };
                NutrientsDirectory nutrientsDirectory12 = new NutrientsDirectory { Name = "Mg" };
                NutrientsDirectory nutrientsDirectory13 = new NutrientsDirectory { Name = "Fe" };
                NutrientsDirectory nutrientsDirectory14 = new NutrientsDirectory { Name = "K" };
                NutrientsDirectory nutrientsDirectory15 = new NutrientsDirectory { Name = "I" };
                NutrientsDirectory nutrientsDirectory16 = new NutrientsDirectory { Name = "Se" };
                NutrientsDirectory nutrientsDirectory17 = new NutrientsDirectory { Name = "F" };

/*                db.AddRange(nutrientsDirectory1, nutrientsDirectory2, nutrientsDirectory3, nutrientsDirectory4,
                   nutrientsDirectory5, nutrientsDirectory6, nutrientsDirectory7, nutrientsDirectory8, nutrientsDirectory9,
                   nutrientsDirectory10, nutrientsDirectory11, nutrientsDirectory12, nutrientsDirectory13, nutrientsDirectory14,
                   nutrientsDirectory15, nutrientsDirectory16, nutrientsDirectory17);*/



                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 5; j++)
                    {
                        //
                        //menuDataGridView.Rows.Add("aboba");

                            }



                //db.SaveChanges();

                /*foreach (Role r in db.Roles)
                {
                    dataGridView1.Rows.Add($"{r.Id}", $"{r.Name}");
                }*/
                // dataGridViewColumn = new DataGridViewColumn { HeaderText = "", CellType = string };
                //dataGridViewColumncolumn
                //dataGridView1.Columns.Add(dataGridViewColumn);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            if (loginForm.log != "")
            {
                LoginLinkLabel.Visible = false;
                LoginLabel.Text = loginForm.log;
                username = loginForm.log;
                RoleLabel.Text = loginForm.role;
                LoginPictureBox.Visible = true;
                LoginLabel.Visible = true;
                RoleLabel.Visible = true;
                OutLabel.Visible = true;

            }
        }

        private void OutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginLinkLabel.Visible = true;
            LoginLabel.Visible = false;
            RoleLabel.Visible = false;
            OutLabel.Visible = false;
            LoginPictureBox.Visible = false;
        }

        private void RoleLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ìåíşToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoginLabel.Visible == true)
            {
                WarningLabel.Visible = false;
                MenuCreation menuCreation = new MenuCreation();
                menuCreation.ShowDialog();
                menuDataGridView.Rows.Clear();
                string[] days = new string[menuCreation.days.Count + 1];
                days[0] = "";
                for (int i = 1; i < days.Length; i++)
                {
                    days[i] = menuCreation.days[i-1];
                }
                menuDataGridView.Rows.Add(days);
                menu = menuCreation.menu;
                idLabel.Text = "ID " + menu.Id;
                menuDateLabel.Text = menu.BeginingDate.Day.ToString() +"." + menu.BeginingDate.Month +
                    "." + menu.BeginingDate.Year + "-" + menu.EndDate.Day + "." +
                    menu.EndDate.Month + "." + menu.EndDate.Year;
                groupNameLabel.Text = "Ãğóïïà " + menu.Group.Name;
            }
            else
            {
                WarningLabel.Text = "Äëÿ ñîçäàíèÿ ìåíş íåîáõîäèìî âîéòè â àêêàóíò";
                WarningLabel.Visible = true;
            }
        }

        private void ñîçäàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void WarningLabel_Click(object sender, EventArgs e)
        {

        }

        private void îòêğûòüToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ïğè¸ìÏèùèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MealCreation mealCreation= new MealCreation();
            mealCreation.ShowDialog();
            menuDataGridView.Rows.Add(mealCreation.mealname);
        }

        private void ïğîäóêòToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductCreation productCreation = new ProductCreation();
            productCreation.ShowDialog();
        }

        private void èíãğèäèåíòToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngregientCreation ingrigientCreation = new IngregientCreation();
            ingrigientCreation.ShowDialog();
        }

        private void áëşäîToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DishCreation dishCreation = new DishCreation();
            dishCreation.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void èíãğèäèåíòÂÁëşäîToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngregientCreation ingrigientCreation = new IngregientCreation();
            ingrigientCreation.ShowDialog();
        }

        private void äîáàâèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DishToMeal dishToMeal = new DishToMeal();
            dishToMeal.PlannedMenuLoad(menu);
            dishToMeal.ShowDialog();
        }

        private void áëşäîÂÏğè¸ìÏèùèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DishToMeal dishToMeal = new DishToMeal();
            dishToMeal.ShowDialog();
        }

        private void ñïèñîêÁëşäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DishList dishList = new DishList();
            dishList.ShowDialog();
        }

        private void ïğîäóêòToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ProductCreation productCreation = new ProductCreation();
            productCreation.ShowDialog();
        }

        private void ñïèñîêÏğîäóêòîâToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductList productList = new ProductList();
            productList.ShowDialog();
        }

        private void ïëàíîâîåÌåíşToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoginLabel.Visible == true)
            {
                WarningLabel.Visible = false;
                OpenPlannedMenu openPlannedMenu = new OpenPlannedMenu();
                openPlannedMenu.ShowDialog();
                menuDataGridView.Rows.Clear();
                string[] days = new string[openPlannedMenu.days.Count + 1];
                days[0] = "";
                for (int i = 1; i < days.Length; i++)
                {
                    days[i] = openPlannedMenu.days[i - 1].Date.ToString();
                }
                menuDataGridView.Rows.Add(days);
                menu = openPlannedMenu.menu;
                idLabel.Text = "ID " + menu.Id;
                menuDateLabel.Text = menu.BeginingDate.Day.ToString() + "." + menu.BeginingDate.Month +
                    "." + menu.BeginingDate.Year + "-" + menu.EndDate.Day + "." +
                    menu.EndDate.Month + "." + menu.EndDate.Year;
                //groupNameLabel.Text = "Ãğóïïà " + menu.Groups.ToList().Last().Name;
            }
            else
            {
                WarningLabel.Text = "Äëÿ îòêğûòèÿ ìåíş íåîáõîäèìî âîéòè â àêêàóíò";
                WarningLabel.Visible = true;
            }
        }
    }
}