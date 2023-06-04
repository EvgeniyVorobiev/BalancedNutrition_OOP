using BalancedNutritionLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Windows.Forms;

namespace BalancedNutrition
{
    public partial class BalancedNutritionForm : Form
    {
        public static string username = "";
        public static PlannedMenu menu = new PlannedMenu();
        List<MenuResultSet> menuResultSet = new List<MenuResultSet>();
        List<BalancedNutritionLibrary.Day> daysMenu = new List<BalancedNutritionLibrary.Day> { };
        List<Meal> mealsMenu = new List<Meal> { };
        List<Dish> dishesMenu = new List<Dish> { };
        List<DayNutrients> dayNutrients = new List<DayNutrients>();
        List<float> normNutrients = new List<float> {54, 60, 261, 1800,
        50, 0.9f, 1, 500, 10, 900, 800, 200, 10, 600, 0.1f, 0.02f, 2};

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

                NutrientsDirectory nutrientsDirectory1 = new NutrientsDirectory { Name = "Áåëêè (ã/ñóò)" };
                NutrientsDirectory nutrientsDirectory2 = new NutrientsDirectory { Name = "Æèðû (ã/ñóò)" };
                NutrientsDirectory nutrientsDirectory3 = new NutrientsDirectory { Name = "Óãëåðîäû (ã/ñóò)" };
                NutrientsDirectory nutrientsDirectory4 = new NutrientsDirectory { Name = "Êàëîðèéíîñòü (êêàë/ñóò)" };

                NutrientsDirectory nutrientsDirectory5 = new NutrientsDirectory { Name = "C (ìã/ñóò)" };
                NutrientsDirectory nutrientsDirectory6 = new NutrientsDirectory { Name = "B1 (ìã/ñóò)" };
                NutrientsDirectory nutrientsDirectory7 = new NutrientsDirectory { Name = "B2 (ìã/ñóò)" };
                NutrientsDirectory nutrientsDirectory8 = new NutrientsDirectory { Name = "A (ðåò.ýêâ/ñóò)" };
                NutrientsDirectory nutrientsDirectory9 = new NutrientsDirectory { Name = "D (ìêã/ñóò)" };

                NutrientsDirectory nutrientsDirectory10 = new NutrientsDirectory { Name = "Ca (ìã/ñóò)" };
                NutrientsDirectory nutrientsDirectory11 = new NutrientsDirectory { Name = "P (ìã/ñóò)" };
                NutrientsDirectory nutrientsDirectory12 = new NutrientsDirectory { Name = "Mg (ìã/ñóò)" };
                NutrientsDirectory nutrientsDirectory13 = new NutrientsDirectory { Name = "Fe (ìã/ñóò)" };
                NutrientsDirectory nutrientsDirectory14 = new NutrientsDirectory { Name = "K (ìã/ñóò)" };
                NutrientsDirectory nutrientsDirectory15 = new NutrientsDirectory { Name = "I (ìã/ñóò)" };
                NutrientsDirectory nutrientsDirectory16 = new NutrientsDirectory { Name = "Se (ìã/ñóò)" };
                NutrientsDirectory nutrientsDirectory17 = new NutrientsDirectory { Name = "F (ìã/ñóò)" };



                /*                db.AddRange(nutrientsDirectory1, nutrientsDirectory2, nutrientsDirectory3, nutrientsDirectory4,
                                   nutrientsDirectory5, nutrientsDirectory6, nutrientsDirectory7, nutrientsDirectory8, nutrientsDirectory9,
                                   nutrientsDirectory10, nutrientsDirectory11, nutrientsDirectory12, nutrientsDirectory13, nutrientsDirectory14,
                                   nutrientsDirectory15, nutrientsDirectory16, nutrientsDirectory17);*/
                //db.SaveChanges();


                daysMenu = menu.Days.ToList();
                mealsMenu.Clear();
                dishesMenu.Clear();
                menuResultSet.Clear();
                menuDataGridView.Rows.Clear();

                foreach (BalancedNutritionLibrary.Day day in daysMenu)
                {
                    mealsMenu.AddRange(db.Meals.Where(m => m.Day == day).Include(m => m.Dishes).Include(m => m.Day));
                }
                foreach (Meal meal in mealsMenu)
                {
                    foreach (Dish dish in db.Dishes.Include(d => d.Meals).Include(d => d.DishNutrients))
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
                                menuResultSet.Add(new MenuResultSet()
                                {
                                    day = day,
                                    dish = dish,
                                    meal = meal,
                                    dishNutrients = dish.DishNutrients
                                }
                            );
                        }
                    }
                }

                for (int i = 0; i < menuResultSet.Count; i++)
                {
                    menuDataGridView.Rows.Add(menuResultSet[i].day.Date, menuResultSet[i].meal.Name, menuResultSet[i].dish.Name, "Óäàëèòü");
                }




                dayNutrients.Clear();
                nutrientsDataGridView.Rows.Clear();
                for (int i = 0; i < daysMenu.Count; i++)
                {
                    dayNutrients.Add(new DayNutrients());
                    dayNutrients[i].DayDate = daysMenu[i].Date;
                    for (int j = 0; j < mealsMenu.Count; j++)
                    {
                        if (mealsMenu[j].Day.Id == daysMenu[i].Id)
                        {
                            for (int k = 0; k < mealsMenu[j].Dishes.Count; k++)
                            {
                                for (int l = 0; l < 17; l++)
                                {
                                    if (dayNutrients[i].Nutrients.Count < 17) { dayNutrients[i].Nutrients.Add(new Nutrient { }); }

                                    dayNutrients[i].Nutrients[l].NutrientName = db.DishNutrients.Include(dn => dn.NutrientsDirectory)
                                    .Include(dn => dn.Dish).Where(dn => dn.Dish.Id == mealsMenu[j].Dishes[k].Id)
                                    .ToList()[l].NutrientsDirectory.Name;
                                    dayNutrients[i].Nutrients[l].NutrientWeight += db.DishNutrients
                                        .Where(dn => dn.Dish.Id == mealsMenu[j].Dishes[k].Id).ToList()[l].DishNutrientWeight;
                                }

                            }
                        }
                    }
                }

                for (int i = 0; i < dayNutrients.Count; i++)
                {
                    for (int j = 0; j < dayNutrients[i].Nutrients.Count; j++)
                    {
                        nutrientsDataGridView.Rows.Add(dayNutrients[i].DayDate, dayNutrients[i].Nutrients[j].NutrientName,
                        dayNutrients[i].Nutrients[j].NutrientWeight, normNutrients[j]);
                    }
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
                if (menu.Id != 0) 
                { 
                idLabel.Text = "ID " + menu.Id;
                menuDateLabel.Text = menu.BeginingDate.Day.ToString() +"." + menu.BeginingDate.Month +
                    "." + menu.BeginingDate.Year + "-" + menu.EndDate.Day + "." +
                    menu.EndDate.Month + "." + menu.EndDate.Year;
                groupNameLabel.Text = "Ãðóïïà " + menu.Group.Name;
                }
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
                if (menu.Id != 0)
                {
                    idLabel.Text = "ID " + menu.Id;
                    menuDateLabel.Text = menu.BeginingDate.Day.ToString() + "." + menu.BeginingDate.Month +
                        "." + menu.BeginingDate.Year + "-" + menu.EndDate.Day + "." +
                        menu.EndDate.Month + "." + menu.EndDate.Year;
                    groupNameLabel.Text = "Ãðóïïà " + menu.Group.Name;
                }
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
            else
            {
                WarningLabel.Visible = false;
                DishToMeal dishToMeal = new DishToMeal();
                dishToMeal.PlannedMenuLoad(menu);
                dishToMeal.ShowDialog();
            }
        }

        private void ãðóïïóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupCreation groupCreation = new GroupCreation();
            groupCreation.ShowDialog();
        }
    }
}