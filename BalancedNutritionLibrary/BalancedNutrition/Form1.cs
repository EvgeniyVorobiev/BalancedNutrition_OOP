using BalancedNutritionLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BalancedNutrition
{
    public partial class BalancedNutritionForm : Form
    {
        public static string username = "";
        public static PlannedMenu menu = new PlannedMenu();
        List<menuResultSet> menuResultSet = new List<menuResultSet>();

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
                Role role1 = new Role { Name = "Àäìèíèñòðàòîð" };
                Role role2 = new Role { Name = "Äèåòîëîã" };
                Role role3 = new Role { Name = "Ðîäèòåëü" };




                //db.Roles.AddRange(role1, role2, role3);

                NutrientsDirectory nutrientsDirectory1 = new NutrientsDirectory { Name = "Áåëêè" };
                NutrientsDirectory nutrientsDirectory2 = new NutrientsDirectory { Name = "Æèðû" };
                NutrientsDirectory nutrientsDirectory3 = new NutrientsDirectory { Name = "Óãëåðîäû" };
                NutrientsDirectory nutrientsDirectory4 = new NutrientsDirectory { Name = "Êàëîðèéíîñòü" };

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


                List<BalancedNutritionLibrary.Day> daysMenu = menu.Days.ToList();
                List<Meal> mealsMenu = new List<Meal> { };
                List<Dish> dishesMenu = new List<Dish> { };
                menuResultSet.Clear();
                menuDataGridView.Rows.Clear();
                foreach (BalancedNutritionLibrary.Day day in daysMenu)
                {
                    mealsMenu.AddRange(db.Meals.Where(m => m.Day == day).Include(m => m.Dishes).Include(m => m.Day));
                }
                foreach (Meal meal in mealsMenu)
                {
                    foreach (Dish dish in db.Dishes.Include(d => d.Meals))
                    {
                        dishesMenu.AddRange(meal.Dishes);
                    }
                }

                foreach (BalancedNutritionLibrary.Day day in daysMenu)
                {
                    foreach (Meal meal in mealsMenu)
                    {
                        foreach (Dish dish in meal.Dishes)
                        {
                            if (day.Id == meal.Day.Id)
                                menuResultSet.Add(new menuResultSet()
                                {
                                    day = day,
                                    dish = dish,
                                    meal = meal
                                }
                            );
                        }
                    }
                }

/*                foreach(Dish dish in dishesMenu)
                {
                    foreach (Meal meal in dish.Meals) 
                    {
                        foreach (BalancedNutritionLibrary.Day day in daysMenu)
                        {
                            if (day.Id == meal.Day.Id)
                            menuResultSet.Add(new menuResultSet()
                            {
                                date = day.Date,
                                dishName = dish.Name,
                                mealName = meal.Name
                            }
                            );
                        }  
                    }
                }*/

                for (int i = 0; i < menuResultSet.Count; i++)
                {
                    menuDataGridView.Rows.Add(menuResultSet[i].day.Date, menuResultSet[i].meal.Name, menuResultSet[i].dish.Name, "Óäàëèòü");   
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
            if (menuDataGridView.CurrentCell.Value == "Óäàëèòü")
            {
                DeleteDishFromMeal deleteDishFromMeal = new DeleteDishFromMeal();
                deleteDishFromMeal.MealAndDishLoad(menuResultSet[menuDataGridView.CurrentRow.Index].meal,
                    menuResultSet[menuDataGridView.CurrentRow.Index].dish);
                deleteDishFromMeal.ShowDialog();
            }    
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ìåíþToolStripMenuItem_Click(object sender, EventArgs e)
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
                groupNameLabel.Text = "Ãðóïïà " + menu.Group.Name;
            }
            else
            {
                WarningLabel.Text = "Äëÿ ñîçäàíèÿ ìåíþ íåîáõîäèìî âîéòè â àêêàóíò";
                WarningLabel.Visible = true;
            }
        }

        private void ñîçäàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void WarningLabel_Click(object sender, EventArgs e)
        {

        }

        private void îòêðûòüToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ïðè¸ìÏèùèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MealCreation mealCreation= new MealCreation();
            mealCreation.ShowDialog();
            menuDataGridView.Rows.Add(mealCreation.mealname);
        }

        private void ïðîäóêòToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductCreation productCreation = new ProductCreation();
            productCreation.ShowDialog();
        }

        private void èíãðèäèåíòToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngregientCreation ingrigientCreation = new IngregientCreation();
            ingrigientCreation.ShowDialog();
        }

        private void áëþäîToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DishCreation dishCreation = new DishCreation();
            dishCreation.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void èíãðèäèåíòÂÁëþäîToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngregientCreation ingrigientCreation = new IngregientCreation();
            ingrigientCreation.ShowDialog();
        }

        private void äîáàâèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void áëþäîÂÏðè¸ìÏèùèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DishToMeal dishToMeal = new DishToMeal();
            dishToMeal.ShowDialog();
        }

        private void ñïèñîêÁëþäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DishList dishList = new DishList();
            dishList.ShowDialog();
        }

        private void ïðîäóêòToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ProductCreation productCreation = new ProductCreation();
            productCreation.ShowDialog();
        }

        private void ñïèñîêÏðîäóêòîâToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductList productList = new ProductList();
            productList.ShowDialog();
        }

        private void ïëàíîâîåÌåíþToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoginLabel.Visible == true)
            {
                WarningLabel.Visible = false;
                OpenPlannedMenu openPlannedMenu = new OpenPlannedMenu();
                openPlannedMenu.ShowDialog();
                //menu = openPlannedMenu.menu;
                idLabel.Text = "ID " + menu.Id;
                menuDateLabel.Text = menu.BeginingDate.Day.ToString() + "." + menu.BeginingDate.Month +
                    "." + menu.BeginingDate.Year + "-" + menu.EndDate.Day + "." +
                    menu.EndDate.Month + "." + menu.EndDate.Year;
                groupNameLabel.Text = "Ãðóïïà " + menu.Group.Name;
            }
            else
            {
                WarningLabel.Text = "Äëÿ îòêðûòèÿ ìåíþ, íåîáõîäèìî âîéòè â àêêàóíò";
                WarningLabel.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (menu.Id == 0)
            {
                WarningLabel.Text = "Äëÿ äîáàâëåíèÿ áëþäà â ìåíþ, íåîáõîäèìî îòêðûòü èëè ñîçäàòü ìåíþ";
                WarningLabel.Visible = true;
            }

            DishToMeal dishToMeal = new DishToMeal();
            dishToMeal.PlannedMenuLoad(menu);
            dishToMeal.ShowDialog();
        }
    }
}