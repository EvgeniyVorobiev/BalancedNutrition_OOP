using BalancedNutritionLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Npgsql;
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

                Role role1 = new Role { Name = "�������������" };
                Role role2 = new Role { Name = "��������" };
                Role role3 = new Role { Name = "��������" };
                if (db.Roles.Where(r => r.Name == role1.Name).ToList().Count == 0 &&
                    db.Roles.Where(r => r.Name == role2.Name).ToList().Count == 0 &&
                    db.Roles.Where(r => r.Name == role3.Name).ToList().Count == 0)
                {
                    db.Roles.AddRange(role1, role2, role3);

                    NutrientsDirectory nutrientsDirectory1 = new NutrientsDirectory { Name = "����� (�/���)" };
                    NutrientsDirectory nutrientsDirectory2 = new NutrientsDirectory { Name = "���� (�/���)" };
                    NutrientsDirectory nutrientsDirectory3 = new NutrientsDirectory { Name = "�������� (�/���)" };
                    NutrientsDirectory nutrientsDirectory4 = new NutrientsDirectory { Name = "������������ (����/���)" };

                    NutrientsDirectory nutrientsDirectory5 = new NutrientsDirectory { Name = "C (��/���)" };
                    NutrientsDirectory nutrientsDirectory6 = new NutrientsDirectory { Name = "B1 (��/���)" };
                    NutrientsDirectory nutrientsDirectory7 = new NutrientsDirectory { Name = "B2 (��/���)" };
                    NutrientsDirectory nutrientsDirectory8 = new NutrientsDirectory { Name = "A (���.���/���)" };
                    NutrientsDirectory nutrientsDirectory9 = new NutrientsDirectory { Name = "D (���/���)" };

                    NutrientsDirectory nutrientsDirectory10 = new NutrientsDirectory { Name = "Ca (��/���)" };
                    NutrientsDirectory nutrientsDirectory11 = new NutrientsDirectory { Name = "P (��/���)" };
                    NutrientsDirectory nutrientsDirectory12 = new NutrientsDirectory { Name = "Mg (��/���)" };
                    NutrientsDirectory nutrientsDirectory13 = new NutrientsDirectory { Name = "Fe (��/���)" };
                    NutrientsDirectory nutrientsDirectory14 = new NutrientsDirectory { Name = "K (��/���)" };
                    NutrientsDirectory nutrientsDirectory15 = new NutrientsDirectory { Name = "I (��/���)" };
                    NutrientsDirectory nutrientsDirectory16 = new NutrientsDirectory { Name = "Se (��/���)" };
                    NutrientsDirectory nutrientsDirectory17 = new NutrientsDirectory { Name = "F (��/���)" };

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
                                dishesMenu.AddRange(meal.Dishes);   
                        }

                        foreach (Dish dish in dishesMenu)
                        {
                            dish.Meals = db.Dishes.Include(d => d.Meals).Where(d => d.Id == dish.Id).ToList().Last().Meals;
                            dish.DishNutrients = db.Dishes.Include(d => d.DishNutrients).Where(d => d.Id == dish.Id).ToList().Last().DishNutrients;
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
                            if (RoleLabel.Text == "��������" || RoleLabel.Text == "�������������")
                                menuDataGridView.Rows.Add(menuResultSet[i].day.Date.ToShortDateString(), menuResultSet[i].meal.Name, menuResultSet[i].dish.Name, "�������");
                            else
                            {
                                menuDataGridView.Rows.Add(menuResultSet[i].day.Date.ToShortDateString(), menuResultSet[i].meal.Name, menuResultSet[i].dish.Name);
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
                        bool isAdded = false;
                        int c2 = 0;
                        foreach (Dish dish in dishesMenu)
                        {
                            foreach (Ingredient ingredient in db.Ingridients.Include(i => i.Product).Where(i => i.Dish.Id == dish.Id).ToList())
                            {
                                for (int i = 0; i < productResultSet.Count; i++)
                                {
                                    if (productResultSet[i].Product.Id == ingredient.Product.Id)
                                    {
                                        c2 = i;
                                        isAdded = true;
                                        break;
                                    }
                                    else isAdded = false;
                                }
                                if (isAdded == false)
                                {
                                    productResultSet.Add(new ProductResultSet() { Product = ingredient.Product,
                                        Weight = ingredient.Product.Weight });
                                }
                                else
                                {
                                    productResultSet[c2].Weight += ingredient.Product.Weight;
                                }
                            }
                        }
                        
                
                        



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
                                nutrientsDataGridView.Rows.Add(dayNutrients[i].DayDate.ToShortDateString(), dayNutrients[i].Nutrients[j].NutrientName,
                                dayNutrients[i].Nutrients[j].NutrientWeight, normNutrients[j]);
                            }
                        }

                        foreach (DishValuesInMeal dishValuesInMeal in dishValuesInMeals)
                        {
                            if (dishValuesInMeal.Meal.Name == "�������")
                                dishWeightDataGridView.Rows.Add(dishValuesInMeal.Meal.Day.Date.ToShortDateString(), dishValuesInMeal.Meal.Name, dishValuesInMeal.Weight,
                                    normDishValuesInMeals[0]);
                            else if (dishValuesInMeal.Meal.Name == "����")
                                dishWeightDataGridView.Rows.Add(dishValuesInMeal.Meal.Day.Date.ToShortDateString(), dishValuesInMeal.Meal.Name, dishValuesInMeal.Weight,
                                    normDishValuesInMeals[1]);
                            else if (dishValuesInMeal.Meal.Name == "�������")
                                dishWeightDataGridView.Rows.Add(dishValuesInMeal.Meal.Day.Date.ToShortDateString(), dishValuesInMeal.Meal.Name, dishValuesInMeal.Weight,
                                    normDishValuesInMeals[2]);
                            else if (dishValuesInMeal.Meal.Name == "����")
                                dishWeightDataGridView.Rows.Add(dishValuesInMeal.Meal.Day.Date.ToShortDateString(), dishValuesInMeal.Meal.Name, dishValuesInMeal.Weight,
                                    normDishValuesInMeals[3]);
                        }

                        foreach (ProductResultSet resultSet in productResultSet)
                        {
                            productsDataGridView.Rows.Add(resultSet.Product.Name, resultSet.Weight,
                                resultSet.Weight * menu.Group.NumberOfServings);
                        }





                        WarningLabel.ForeColor = Color.Green;
                        WarningLabel.Text = "������ � ���� ���������";
                        WarningLabel.Visible = true;
                    }
                }
                catch
                {
                    WarningLabel.ForeColor = Color.Red;
                    WarningLabel.Text = "��������� ������ ��� ���������� ������ � ����";
                    WarningLabel.Visible = true;
                }
            }
            else
            {
                if (RoleLabel.Text != "")
                {
                    WarningLabel.ForeColor = Color.Red;
                    WarningLabel.Text = "�������� ���� �� �������";
                    WarningLabel.Visible = true;
                }
                else 
                {
                    WarningLabel.ForeColor = Color.Red;
                    WarningLabel.Text = "���������� ��������� ����";
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

                if (RoleLabel.Text == "�������������")
                {
                    �������ToolStripMenuItem.Visible = true;
                    �������ToolStripMenuItem.Visible = true;
                    button2.Visible = true;
                    ������ToolStripMenuItem.Visible = true;
                }
                else if (RoleLabel.Text == "��������")
                {
                    �������ToolStripMenuItem.Visible = true;
                    �������ToolStripMenuItem.Visible = true;
                    button2.Visible = true;
                    ������ToolStripMenuItem.Visible = false;
                }
                else if (RoleLabel.Text == "��������")
                {
                    �������ToolStripMenuItem.Visible = false;
                    �������ToolStripMenuItem.Visible = true;
                    button2.Visible = false;
                    ������ToolStripMenuItem.Visible = false;
                }
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
            groupNameLabel.Text = "������";
            WarningLabel.Text = "";
            menuDataGridView.Rows.Clear();
            nutrientsDataGridView.Rows.Clear();
            dishWeightDataGridView.Rows.Clear();
            productsDataGridView.Rows.Clear();

        }

        private void RoleLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (menuDataGridView.CurrentCell.Value == "�������")
            {
                DeleteDishFromMeal deleteDishFromMeal = new DeleteDishFromMeal();
                deleteDishFromMeal.MealAndDishLoad(menuResultSet[menuDataGridView.CurrentRow.Index].meal,
                    menuResultSet[menuDataGridView.CurrentRow.Index].dish);
                deleteDishFromMeal.ShowDialog();

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
                                dishesMenu.AddRange(meal.Dishes);
                            }

                            foreach (Dish dish in dishesMenu)
                            {
                                dish.Meals = db.Dishes.Include(d => d.Meals).Where(d => d.Id == dish.Id).ToList().Last().Meals;
                                dish.DishNutrients = db.Dishes.Include(d => d.DishNutrients).Where(d => d.Id == dish.Id).ToList().Last().DishNutrients;
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
                                if (RoleLabel.Text == "��������" || RoleLabel.Text == "�������������")
                                    menuDataGridView.Rows.Add(menuResultSet[i].day.Date.ToShortDateString(), menuResultSet[i].meal.Name, menuResultSet[i].dish.Name, "�������");
                                else
                                {
                                    menuDataGridView.Rows.Add(menuResultSet[i].day.Date.ToShortDateString(), menuResultSet[i].meal.Name, menuResultSet[i].dish.Name);
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
                            bool isAdded = false;
                            int c2 = 0;
                            foreach (Dish dish in dishesMenu)
                            {
                                foreach (Ingredient ingredient in db.Ingridients.Include(i => i.Product).Where(i => i.Dish.Id == dish.Id).ToList())
                                {
                                    for (int i = 0; i < productResultSet.Count; i++)
                                    {
                                        if (productResultSet[i].Product.Id == ingredient.Product.Id)
                                        {
                                            c2 = i;
                                            isAdded = true;
                                            break;
                                        }
                                        else isAdded = false;
                                    }
                                    if (isAdded == false)
                                    {
                                        productResultSet.Add(new ProductResultSet()
                                        {
                                            Product = ingredient.Product,
                                            Weight = ingredient.Product.Weight
                                        });
                                    }
                                    else
                                    {
                                        productResultSet[c2].Weight += ingredient.Product.Weight;
                                    }
                                }
                            }






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
                                    nutrientsDataGridView.Rows.Add(dayNutrients[i].DayDate.ToShortDateString(), dayNutrients[i].Nutrients[j].NutrientName,
                                    dayNutrients[i].Nutrients[j].NutrientWeight, normNutrients[j]);
                                }
                            }

                            foreach (DishValuesInMeal dishValuesInMeal in dishValuesInMeals)
                            {
                                if (dishValuesInMeal.Meal.Name == "�������")
                                    dishWeightDataGridView.Rows.Add(dishValuesInMeal.Meal.Day.Date.ToShortDateString(), dishValuesInMeal.Meal.Name, dishValuesInMeal.Weight,
                                        normDishValuesInMeals[0]);
                                else if (dishValuesInMeal.Meal.Name == "����")
                                    dishWeightDataGridView.Rows.Add(dishValuesInMeal.Meal.Day.Date.ToShortDateString(), dishValuesInMeal.Meal.Name, dishValuesInMeal.Weight,
                                        normDishValuesInMeals[1]);
                                else if (dishValuesInMeal.Meal.Name == "�������")
                                    dishWeightDataGridView.Rows.Add(dishValuesInMeal.Meal.Day.Date.ToShortDateString(), dishValuesInMeal.Meal.Name, dishValuesInMeal.Weight,
                                        normDishValuesInMeals[2]);
                                else if (dishValuesInMeal.Meal.Name == "����")
                                    dishWeightDataGridView.Rows.Add(dishValuesInMeal.Meal.Day.Date.ToShortDateString(), dishValuesInMeal.Meal.Name, dishValuesInMeal.Weight,
                                        normDishValuesInMeals[3]);
                            }

                            foreach (ProductResultSet resultSet in productResultSet)
                            {
                                productsDataGridView.Rows.Add(resultSet.Product.Name, resultSet.Weight,
                                    resultSet.Weight * menu.Group.NumberOfServings);
                            }





                            WarningLabel.ForeColor = Color.Green;
                            WarningLabel.Text = "������ � ���� ���������";
                            WarningLabel.Visible = true;
                        }
                    }
                    catch
                    {
                        WarningLabel.ForeColor = Color.Red;
                        WarningLabel.Text = "��������� ������ ��� ���������� ������ � ����";
                        WarningLabel.Visible = true;
                    }
                }
                else
                {
                    if (RoleLabel.Text != "")
                    {
                        WarningLabel.ForeColor = Color.Red;
                        WarningLabel.Text = "�������� ���� �� �������";
                        WarningLabel.Visible = true;
                    }
                    else
                    {
                        WarningLabel.ForeColor = Color.Red;
                        WarningLabel.Text = "���������� ��������� ����";
                        WarningLabel.Visible = true;
                    }
                }
            }    
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoginLabel.Visible == true && (RoleLabel.Text == "�������������" || RoleLabel.Text == "��������"))
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
                groupNameLabel.Text = "������ " + menu.Group.Name;
                }
            }
            else if (RoleLabel.Text == "��������")
            {
                WarningLabel.ForeColor = Color.Red;
                WarningLabel.Text = "��� �������� ����, ���������� ����� ���� '��������' ��� '�������������'";
                WarningLabel.Visible = true;
            }
            else
            {
                WarningLabel.ForeColor = Color.Red;
                WarningLabel.Text = "��� �������� ����, ���������� ����� � �������";
                WarningLabel.Visible = true;
            }
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void WarningLabel_Click(object sender, EventArgs e)
        {

        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoginLabel.Visible == true && (RoleLabel.Text == "�������������" || RoleLabel.Text == "��������"))
            {
                DishCreation dishCreation = new DishCreation();
                dishCreation.ShowDialog();
            }
            else if (RoleLabel.Text == "��������")
            {
                WarningLabel.ForeColor = Color.Red;
                WarningLabel.Text = "��� �������� �����, ���������� ����� ���� '��������' ��� '�������������'";
                WarningLabel.Visible = true;
            }
            else
            {
                WarningLabel.ForeColor = Color.Red;
                WarningLabel.Text = "��� �������� �����, ���������� ��������� ����";
                WarningLabel.Visible = true;
            }
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DishList dishList = new DishList();
            dishList.ShowDialog();
        }

        private void �������ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (RoleLabel.Text == "�������������" || RoleLabel.Text == "��������")
            {
                ProductCreation productCreation = new ProductCreation();
                productCreation.ShowDialog();
            }
            else if (RoleLabel.Text == "��������")
            {
                WarningLabel.ForeColor = Color.Red;
                WarningLabel.Text = "��� �������� ��������, ���������� ����� ���� '��������' ��� '�������������'";
                WarningLabel.Visible = true;
            }
            else
            {
                WarningLabel.ForeColor = Color.Red;
                WarningLabel.Text = "��� �������� ��������, ���������� ��������� ����";
                WarningLabel.Visible = true;
            }
        }

        private void ���������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductList productList = new ProductList();
            productList.ShowDialog();
        }

        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
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
                    groupNameLabel.Text = "������ " + menu.Group.Name;
                }

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
                                dishesMenu.AddRange(meal.Dishes);
                            }

                            foreach (Dish dish in dishesMenu)
                            {
                                dish.Meals = db.Dishes.Include(d => d.Meals).Where(d => d.Id == dish.Id).ToList().Last().Meals;
                                dish.DishNutrients = db.Dishes.Include(d => d.DishNutrients).Where(d => d.Id == dish.Id).ToList().Last().DishNutrients;
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
                                if (RoleLabel.Text == "��������" || RoleLabel.Text == "�������������")
                                    menuDataGridView.Rows.Add(menuResultSet[i].day.Date.ToShortDateString(), menuResultSet[i].meal.Name, menuResultSet[i].dish.Name, "�������");
                                else
                                {
                                    menuDataGridView.Rows.Add(menuResultSet[i].day.Date.ToShortDateString(), menuResultSet[i].meal.Name, menuResultSet[i].dish.Name);
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
                            bool isAdded = false;
                            int c2 = 0;
                            foreach (Dish dish in dishesMenu)
                            {
                                foreach (Ingredient ingredient in db.Ingridients.Include(i => i.Product).Where(i => i.Dish.Id == dish.Id).ToList())
                                {
                                    for (int i = 0; i < productResultSet.Count; i++)
                                    {
                                        if (productResultSet[i].Product.Id == ingredient.Product.Id)
                                        {
                                            c2 = i;
                                            isAdded = true;
                                            break;
                                        }
                                        else isAdded = false;
                                    }
                                    if (isAdded == false)
                                    {
                                        productResultSet.Add(new ProductResultSet()
                                        {
                                            Product = ingredient.Product,
                                            Weight = ingredient.Product.Weight
                                        });
                                    }
                                    else
                                    {
                                        productResultSet[c2].Weight += ingredient.Product.Weight;
                                    }
                                }
                            }






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
                                    nutrientsDataGridView.Rows.Add(dayNutrients[i].DayDate.ToShortDateString(), dayNutrients[i].Nutrients[j].NutrientName,
                                    dayNutrients[i].Nutrients[j].NutrientWeight, normNutrients[j]);
                                }
                            }

                            foreach (DishValuesInMeal dishValuesInMeal in dishValuesInMeals)
                            {
                                if (dishValuesInMeal.Meal.Name == "�������")
                                    dishWeightDataGridView.Rows.Add(dishValuesInMeal.Meal.Day.Date.ToShortDateString(), dishValuesInMeal.Meal.Name, dishValuesInMeal.Weight,
                                        normDishValuesInMeals[0]);
                                else if (dishValuesInMeal.Meal.Name == "����")
                                    dishWeightDataGridView.Rows.Add(dishValuesInMeal.Meal.Day.Date.ToShortDateString(), dishValuesInMeal.Meal.Name, dishValuesInMeal.Weight,
                                        normDishValuesInMeals[1]);
                                else if (dishValuesInMeal.Meal.Name == "�������")
                                    dishWeightDataGridView.Rows.Add(dishValuesInMeal.Meal.Day.Date.ToShortDateString(), dishValuesInMeal.Meal.Name, dishValuesInMeal.Weight,
                                        normDishValuesInMeals[2]);
                                else if (dishValuesInMeal.Meal.Name == "����")
                                    dishWeightDataGridView.Rows.Add(dishValuesInMeal.Meal.Day.Date.ToShortDateString(), dishValuesInMeal.Meal.Name, dishValuesInMeal.Weight,
                                        normDishValuesInMeals[3]);
                            }

                            foreach (ProductResultSet resultSet in productResultSet)
                            {
                                productsDataGridView.Rows.Add(resultSet.Product.Name, resultSet.Weight,
                                    resultSet.Weight * menu.Group.NumberOfServings);
                            }





                            WarningLabel.ForeColor = Color.Green;
                            WarningLabel.Text = "������ � ���� ���������";
                            WarningLabel.Visible = true;
                        }
                    }
                    catch
                    {
                        WarningLabel.ForeColor = Color.Red;
                        WarningLabel.Text = "��������� ������ ��� ���������� ������ � ����";
                        WarningLabel.Visible = true;
                    }
                }
                else
                {
                    if (RoleLabel.Text != "")
                    {
                        WarningLabel.ForeColor = Color.Red;
                        WarningLabel.Text = "�������� ���� �� �������";
                        WarningLabel.Visible = true;
                    }
                    else
                    {
                        WarningLabel.ForeColor = Color.Red;
                        WarningLabel.Text = "���������� ��������� ����";
                        WarningLabel.Visible = true;
                    }
                }
            
        }
            else
            {
                WarningLabel.Text = "��� �������� ����, ���������� ����� � �������";
                WarningLabel.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (menu.Id == 0)
            {
                WarningLabel.ForeColor = Color.Red;
                WarningLabel.Text = "��� ���������� ����� � ����, ���������� ������� ��� ������� ����";
                WarningLabel.Visible = true;
            }
            else if (RoleLabel.Text == "��������")
            {
                WarningLabel.ForeColor = Color.Red;
                WarningLabel.Text = "��� ���������� ����� � ����, ���������� ����� ���� '��������' ��� '�������������'";
                WarningLabel.Visible = true;
            }
            else
            {
                WarningLabel.Visible = false;
                DishToMeal dishToMeal = new DishToMeal();
                dishToMeal.PlannedMenuLoad(menu);
                dishToMeal.ShowDialog();

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
                                dishesMenu.AddRange(meal.Dishes);
                            }

                            foreach (Dish dish in dishesMenu)
                            {
                                dish.Meals = db.Dishes.Include(d => d.Meals).Where(d => d.Id == dish.Id).ToList().Last().Meals;
                                dish.DishNutrients = db.Dishes.Include(d => d.DishNutrients).Where(d => d.Id == dish.Id).ToList().Last().DishNutrients;
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
                                if (RoleLabel.Text == "��������" || RoleLabel.Text == "�������������")
                                    menuDataGridView.Rows.Add(menuResultSet[i].day.Date.ToShortDateString(), menuResultSet[i].meal.Name, menuResultSet[i].dish.Name, "�������");
                                else
                                {
                                    menuDataGridView.Rows.Add(menuResultSet[i].day.Date.ToShortDateString(), menuResultSet[i].meal.Name, menuResultSet[i].dish.Name);
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
                            bool isAdded = false;
                            int c2 = 0;
                            foreach (Dish dish in dishesMenu)
                            {
                                foreach (Ingredient ingredient in db.Ingridients.Include(i => i.Product).Where(i => i.Dish.Id == dish.Id).ToList())
                                {
                                    for (int i = 0; i < productResultSet.Count; i++)
                                    {
                                        if (productResultSet[i].Product.Id == ingredient.Product.Id)
                                        {
                                            c2 = i;
                                            isAdded = true;
                                            break;
                                        }
                                        else isAdded = false;
                                    }
                                    if (isAdded == false)
                                    {
                                        productResultSet.Add(new ProductResultSet()
                                        {
                                            Product = ingredient.Product,
                                            Weight = ingredient.Product.Weight
                                        });
                                    }
                                    else
                                    {
                                        productResultSet[c2].Weight += ingredient.Product.Weight;
                                    }
                                }
                            }






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
                                    nutrientsDataGridView.Rows.Add(dayNutrients[i].DayDate.ToShortDateString(), dayNutrients[i].Nutrients[j].NutrientName,
                                    dayNutrients[i].Nutrients[j].NutrientWeight, normNutrients[j]);
                                }
                            }

                            foreach (DishValuesInMeal dishValuesInMeal in dishValuesInMeals)
                            {
                                if (dishValuesInMeal.Meal.Name == "�������")
                                    dishWeightDataGridView.Rows.Add(dishValuesInMeal.Meal.Day.Date.ToShortDateString(), dishValuesInMeal.Meal.Name, dishValuesInMeal.Weight,
                                        normDishValuesInMeals[0]);  
                                else if (dishValuesInMeal.Meal.Name == "����")
                                    dishWeightDataGridView.Rows.Add(dishValuesInMeal.Meal.Day.Date.ToShortDateString(), dishValuesInMeal.Meal.Name, dishValuesInMeal.Weight,
                                        normDishValuesInMeals[1]);
                                else if (dishValuesInMeal.Meal.Name == "�������")
                                    dishWeightDataGridView.Rows.Add(dishValuesInMeal.Meal.Day.Date.ToShortDateString(), dishValuesInMeal.Meal.Name, dishValuesInMeal.Weight,
                                        normDishValuesInMeals[2]);
                                else if (dishValuesInMeal.Meal.Name == "����")
                                    dishWeightDataGridView.Rows.Add(dishValuesInMeal.Meal.Day.Date.ToShortDateString(), dishValuesInMeal.Meal.Name, dishValuesInMeal.Weight,
                                        normDishValuesInMeals[3]);
                            }

                            foreach (ProductResultSet resultSet in productResultSet)
                            {
                                productsDataGridView.Rows.Add(resultSet.Product.Name, resultSet.Weight,
                                    resultSet.Weight * menu.Group.NumberOfServings);
                            }





                            WarningLabel.ForeColor = Color.Green;
                            WarningLabel.Text = "������ � ���� ���������";
                            WarningLabel.Visible = true;
                        }
                    }
                    catch
                    {
                        WarningLabel.ForeColor = Color.Red;
                        WarningLabel.Text = "��������� ������ ��� ���������� ������ � ����";
                        WarningLabel.Visible = true;
                    }
                }
                else
                {
                    if (RoleLabel.Text != "")
                    {
                        WarningLabel.ForeColor = Color.Red;
                        WarningLabel.Text = "�������� ���� �� �������";
                        WarningLabel.Visible = true;
                    }
                    else
                    {
                        WarningLabel.ForeColor = Color.Red;
                        WarningLabel.Text = "���������� ��������� ����";
                        WarningLabel.Visible = true;
                    }
                }
            }
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RoleLabel.Text == "�������������")
            {
                GroupCreation groupCreation = new GroupCreation();
                groupCreation.ShowDialog();
            }
            else if (RoleLabel.Text == "��������" || RoleLabel.Text == "��������")
            {
                WarningLabel.ForeColor = Color.Red;
                WarningLabel.Text = "������ ������������� ����� ��������� ������";
                WarningLabel.Visible = true;
            }
            else
            {
                WarningLabel.ForeColor = Color.Red;
                WarningLabel.Text = "��� �������� ������, ���������� ��������� ����";
                WarningLabel.Visible = true;
            }
        }
    }
}