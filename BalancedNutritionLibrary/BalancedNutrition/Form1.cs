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
        List<DishValuesInMeal> dishValuesInMeals = new List<DishValuesInMeal> { };
        List<DayNutrients> dayNutrients = new List<DayNutrients>();
        List<ProductResultSet> productResultSet = new List<ProductResultSet>();
        List<float> normNutrients = new List<float> {54, 60, 261, 1800,
        50, 0.9f, 1, 500, 10, 900, 800, 200, 10, 600, 0.1f, 0.02f, 2};
        List<float> normDishValuesInMeals = new List<float> { 400, 600, 250, 450 };

        public BalancedNutritionForm()
        {
            InitializeComponent();
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
            {

                Role role1 = new Role { Name = "Администратор" };
                Role role2 = new Role { Name = "Диетолог" };
                Role role3 = new Role { Name = "Родитель" };
                if (db.Roles.Where(r => r.Name == role1.Name).ToList().Count == 0 &&
                    db.Roles.Where(r => r.Name == role2.Name).ToList().Count == 0 &&
                    db.Roles.Where(r => r.Name == role3.Name).ToList().Count == 0)
                {
                    db.Roles.AddRange(role1, role2, role3);

                    NutrientsDirectory nutrientsDirectory1 = new NutrientsDirectory { Name = "Белки (г/сут)" };
                    NutrientsDirectory nutrientsDirectory2 = new NutrientsDirectory { Name = "Жиры (г/сут)" };
                    NutrientsDirectory nutrientsDirectory3 = new NutrientsDirectory { Name = "Углероды (г/сут)" };
                    NutrientsDirectory nutrientsDirectory4 = new NutrientsDirectory { Name = "Калорийность (ккал/сут)" };

                    NutrientsDirectory nutrientsDirectory5 = new NutrientsDirectory { Name = "C (мг/сут)" };
                    NutrientsDirectory nutrientsDirectory6 = new NutrientsDirectory { Name = "B1 (мг/сут)" };
                    NutrientsDirectory nutrientsDirectory7 = new NutrientsDirectory { Name = "B2 (мг/сут)" };
                    NutrientsDirectory nutrientsDirectory8 = new NutrientsDirectory { Name = "A (рет.экв/сут)" };
                    NutrientsDirectory nutrientsDirectory9 = new NutrientsDirectory { Name = "D (мкг/сут)" };

                    NutrientsDirectory nutrientsDirectory10 = new NutrientsDirectory { Name = "Ca (мг/сут)" };
                    NutrientsDirectory nutrientsDirectory11 = new NutrientsDirectory { Name = "P (мг/сут)" };
                    NutrientsDirectory nutrientsDirectory12 = new NutrientsDirectory { Name = "Mg (мг/сут)" };
                    NutrientsDirectory nutrientsDirectory13 = new NutrientsDirectory { Name = "Fe (мг/сут)" };
                    NutrientsDirectory nutrientsDirectory14 = new NutrientsDirectory { Name = "K (мг/сут)" };
                    NutrientsDirectory nutrientsDirectory15 = new NutrientsDirectory { Name = "I (мг/сут)" };
                    NutrientsDirectory nutrientsDirectory16 = new NutrientsDirectory { Name = "Se (мг/сут)" };
                    NutrientsDirectory nutrientsDirectory17 = new NutrientsDirectory { Name = "F (мг/сут)" };

                    db.AddRange(nutrientsDirectory1, nutrientsDirectory2, nutrientsDirectory3, nutrientsDirectory4,
                       nutrientsDirectory5, nutrientsDirectory6, nutrientsDirectory7, nutrientsDirectory8, nutrientsDirectory9,
                       nutrientsDirectory10, nutrientsDirectory11, nutrientsDirectory12, nutrientsDirectory13, nutrientsDirectory14,
                       nutrientsDirectory15, nutrientsDirectory16, nutrientsDirectory17);
                    db.SaveChanges();
                }
            }
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
            if (RoleLabel.Text != "" && menu.Id != 0)
            {
                try
                {
                    using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
                    {
                        daysMenu = menu.Days.ToList();
                        mealsMenu.Clear();
                        dishesMenu.Clear();
                        menuResultSet.Clear();
                        dishValuesInMeals.Clear();
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
                            if (RoleLabel.Text == "Диетолог" || RoleLabel.Text == "Администратор")
                                menuDataGridView.Rows.Add(menuResultSet[i].day.Date, menuResultSet[i].meal.Name, menuResultSet[i].dish.Name, "Удалить");
                            else
                            {
                                menuDataGridView.Rows.Add(menuResultSet[i].day.Date, menuResultSet[i].meal.Name, menuResultSet[i].dish.Name);
                            }
                        }

                        int c = 0;
                        dishValuesInMeals.Clear();
                        foreach (BalancedNutritionLibrary.Day day in daysMenu)
                        {
                            foreach (Meal meal in mealsMenu)
                            {
                                if (day.Id == meal.Day.Id && meal.Dishes.Count > 0)
                                {
                                    bool isAdd = false;
                                    foreach (Dish dish in meal.Dishes)
                                    {
                                        if (day.Id == meal.Day.Id)
                                            if (isAdd == false)
                                            {
                                                dishValuesInMeals.Add(new DishValuesInMeal()
                                                {
                                                    Meal = meal,
                                                    Weight = dish.Weight
                                                });
                                                isAdd = true;
                                            }
                                            else
                                            {
                                                dishValuesInMeals[c].Weight += dish.Weight;
                                            }
                                    }
                                    c++;
                                }
                            }
                        }

                        productResultSet.Clear();
                        
                        foreach (Dish dish in dishesMenu) 
                
                        



                        dayNutrients.Clear();
                        nutrientsDataGridView.Rows.Clear();
                        dishWeightDataGridView.Rows.Clear();
                        productsDataGridView.Rows.Clear();
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

                        foreach (DishValuesInMeal dishValuesInMeal in dishValuesInMeals)
                        {
                            dishWeightDataGridView.Rows.Add(dishValuesInMeal.Meal.Day.Date, dishValuesInMeal.Meal.Name, dishValuesInMeal.Weight);
                        }

                        foreach (ProductResultSet resultSet in productResultSet)
                        {
                            productsDataGridView.Rows.Add(resultSet.Product.Name, resultSet.Product.Weight,
                                resultSet.Product.Weight * menu.Group.NumberOfServings);
                        }





                        WarningLabel.ForeColor = Color.Green;
                        WarningLabel.Text = "Данные в меню обновлены";
                        WarningLabel.Visible = true;
                    }
                }
                catch 
                {
                    WarningLabel.ForeColor = Color.Red;
                    WarningLabel.Text = "Произошла ошибка при обновлении данных в меню";
                    WarningLabel.Visible = true;
                }
            }
            else
            {
                if (RoleLabel.Text != "")
                {
                    WarningLabel.ForeColor = Color.Red;
                    WarningLabel.Text = "Плановое меню не выбрано";
                    WarningLabel.Visible = true;
                }
                else 
                {
                    WarningLabel.ForeColor = Color.Red;
                    WarningLabel.Text = "Необходимо выполнить вход";
                    WarningLabel.Visible = true;
                }
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
            RoleLabel.Text = "";
            username = "";
            OutLabel.Visible = false;
            LoginPictureBox.Visible = false;
            menu.Id = 0;
            idLabel.Text = "ID";
            menuDateLabel.Text = "xx.xx.xxxx - xx.xx.xxxx";
            groupNameLabel.Text = "Группа";

        }

        private void RoleLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (menuDataGridView.CurrentCell.Value == "Удалить")
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

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoginLabel.Visible == true && (RoleLabel.Text == "Администратор" || RoleLabel.Text == "Диетолог"))
            {
                WarningLabel.Visible = false;
                MenuCreation menuCreation = new MenuCreation();
                menuCreation.ShowDialog();
                menuDataGridView.Rows.Clear();
                nutrientsDataGridView.Rows.Clear();
                dishWeightDataGridView.Rows.Clear();
                productsDataGridView.Rows.Clear();
                menu = menuCreation.menu;
                if (menu.Id != 0) 
                { 
                idLabel.Text = "ID " + menu.Id;
                menuDateLabel.Text = menu.BeginingDate.Day.ToString() +"." + menu.BeginingDate.Month +
                    "." + menu.BeginingDate.Year + "-" + menu.EndDate.Day + "." +
                    menu.EndDate.Month + "." + menu.EndDate.Year;
                groupNameLabel.Text = "Группа " + menu.Group.Name;
                }
            }
            else if (RoleLabel.Text == "Родитель")
            {
                WarningLabel.ForeColor = Color.Red;
                WarningLabel.Text = "Для создания меню, необходимо иметь роль 'Диетолог' или 'Администратор'";
                WarningLabel.Visible = true;
            }
            else
            {
                WarningLabel.ForeColor = Color.Red;
                WarningLabel.Text = "Для создания меню, необходимо войти в аккаунт";
                WarningLabel.Visible = true;
            }
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void WarningLabel_Click(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void блюдоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoginLabel.Visible == true && (RoleLabel.Text == "Администратор" || RoleLabel.Text == "Диетолог"))
            {
                DishCreation dishCreation = new DishCreation();
                dishCreation.ShowDialog();
            }
            else if (RoleLabel.Text == "Родитель")
            {
                WarningLabel.ForeColor = Color.Red;
                WarningLabel.Text = "Для создания блюда, необходимо иметь роль 'Диетолог' или 'Администратор'";
                WarningLabel.Visible = true;
            }
            else
            {
                WarningLabel.ForeColor = Color.Red;
                WarningLabel.Text = "Для создания блюда, необходимо выполнить вход";
                WarningLabel.Visible = true;
            }
        }

        private void списокБлюдToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DishList dishList = new DishList();
            dishList.ShowDialog();
        }

        private void продуктToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (RoleLabel.Text == "Администратор" || RoleLabel.Text == "Диетолог")
            {
                ProductCreation productCreation = new ProductCreation();
                productCreation.ShowDialog();
            }
            else if (RoleLabel.Text == "Родитель")
            {
                WarningLabel.ForeColor = Color.Red;
                WarningLabel.Text = "Для создания продукта, необходимо иметь роль 'Диетолог' или 'Администратор'";
                WarningLabel.Visible = true;
            }
            else
            {
                WarningLabel.ForeColor = Color.Red;
                WarningLabel.Text = "Для создания продукта, необходимо выполнить вход";
                WarningLabel.Visible = true;
            }
        }

        private void списокПродуктовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductList productList = new ProductList();
            productList.ShowDialog();
        }

        private void плановоеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoginLabel.Visible == true)
            {
                WarningLabel.Visible = false;
                OpenPlannedMenu openPlannedMenu = new OpenPlannedMenu();
                openPlannedMenu.ShowDialog();
                menuDataGridView.Rows.Clear();

                if (menu.Id != 0)
                {
                    idLabel.Text = "ID " + menu.Id;
                    menuDateLabel.Text = menu.BeginingDate.Day.ToString() + "." + menu.BeginingDate.Month +
                        "." + menu.BeginingDate.Year + "-" + menu.EndDate.Day + "." +
                        menu.EndDate.Month + "." + menu.EndDate.Year;
                    groupNameLabel.Text = "Группа " + menu.Group.Name;
                }
            }
            else
            {
                WarningLabel.Text = "Для открытия меню, необходимо войти в аккаунт";
                WarningLabel.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (menu.Id == 0 && RoleLabel.Text != "")
            {
                WarningLabel.Text = "Для добавления блюда в меню, необходимо открыть или создать меню";
                WarningLabel.Visible = true;
            }
            else if (RoleLabel.Text == "Родитель")
            {
                WarningLabel.ForeColor = Color.Red;
                WarningLabel.Text = "Для добавления блюда в меню, необходимо иметь роль 'Диетолог' или 'Администратор'";
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

        private void группуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RoleLabel.Text == "Администратор")
            {
                GroupCreation groupCreation = new GroupCreation();
                groupCreation.ShowDialog();
            }
            else if (RoleLabel.Text == "Родитель" || RoleLabel.Text == "Диетолог")
            {
                WarningLabel.ForeColor = Color.Red;
                WarningLabel.Text = "Только администратор может создавать группы";
                WarningLabel.Visible = true;
            }
            else
            {
                WarningLabel.ForeColor = Color.Red;
                WarningLabel.Text = "Для создания группы, необходимо выполнить вход";
                WarningLabel.Visible = true;
            }
        }
    }
}