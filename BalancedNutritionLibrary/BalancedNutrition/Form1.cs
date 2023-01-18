using BalancedNutritionLibrary;
using Microsoft.Extensions.Options;

namespace BalancedNutrition
{
    public partial class BalancedNutritionForm : Form
    {
        //BalancedNutritionLibrary.AppContext context;
        //IServiceProvider serviceProvider;
        public static string username = "";
        public static PlannedMenu menu= new PlannedMenu();

        public BalancedNutritionForm()
        {
            InitializeComponent();
            //serviceProvider = provider;
            //context = new BalancedNutritionLibrary.AppContext();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext()) 
            {
                Role role1 = new Role { Name = "�������������" };
                Role role2 = new Role { Name = "����������� �������" };
                Role role3 = new Role { Name = "��������" };



                /*Dish dish1 = new Dish { Name = "���� � �����", DishWeight = 0.25f, CookingMethod = "�����",
                CookingTechnology = "������, �������, ��� �������� ��������, ��������� - ���������...",
                DishCharacteristic = "����� �� ����������, ��������� ����� �������. ���� �����-�������..."};
                Dish dish2 = new Dish { Name = "�������� �������", DishWeight = 0.2f, CookingMethod = "�����",
                CookingTechnology = "�������� ��������� ���������, ������ � ������� ��������...",
                DishCharacteristic = "����� �������� ������� ���������, ���������� ����������..."};
                Dish dish3 = new Dish { Name = "������� �������", DishWeight = 0.25f, CookingMethod = "�������",
                CookingTechnology = "���������� �������� ������ ������� ������...",
                DishCharacteristic = "����� �������� ������� � �������..."};
                Dish dish4 = new Dish { Name = "������ �� ������� �������", DishWeight = 0.15f, CookingMethod = "�����",
                CookingTechnology = "�������������� ������� ����� ��� ����� �������� ������� �����...",
                DishCharacteristic = "�����, ����� �� ������������, ������� � ������..."};

                Product product1 = new Product { Name = "������", ProductWeight = 0.05f };
                Product product2 = new Product { Name = "��� ��������", ProductWeight = 0.02f };
                Product product3 = new Product { Name = "���������", ProductWeight = 0.05f };
                Product product4 = new Product { Name = "�������", ProductWeight = 0.04f };
                Product product5 = new Product { Name = "����", ProductWeight = 0.02f };
                Product product6 = new Product { Name = "���������", ProductWeight = 0.05f };
                Product product7 = new Product { Name = "�������", ProductWeight = 0.02f };

                Ingridient ingridient1 = new Ingridient { Name = product1.Name, CookingMethod = "�����",
                IngridientWaste = 0.01f, WastePercent = (0.01f / product1.ProductWeight )};
                Ingridient ingridient2 = new Ingridient { Name = product2.Name, CookingMethod = "�����",
                IngridientWaste = 0.005f, WastePercent = (0.005f / product2.ProductWeight )};
                Ingridient ingridient3 = new Ingridient { Name = product3.Name, CookingMethod = "�����",
                IngridientWaste = 0.02f, WastePercent = (0.02f / product3.ProductWeight )};
                Ingridient ingridient4 = new Ingridient { Name = product4.Name, CookingMethod = "�������",
                IngridientWaste = 0.005f, WastePercent = (0.005f / product4.ProductWeight )};
                Ingridient ingridient5 = new Ingridient { Name = product5.Name, CookingMethod = "���������",
                IngridientWaste = 0.0004f, WastePercent = (0.0004f / product5.ProductWeight )};
                Ingridient ingridient6 = new Ingridient { Name = product6.Name, CookingMethod = "�����",
                IngridientWaste = 0.0009f, WastePercent = (0.0009f / product6.ProductWeight )};
                Ingridient ingridient7 = new Ingridient { Name = product7.Name, CookingMethod = "�����",
                IngridientWaste = 0.003f, WastePercent = (0.002f / product7.ProductWeight )};

                NutrientsDirectory nutrientsDirectory1 = new NutrientsDirectory { Name = "�����" };
                NutrientsDirectory nutrientsDirectory2 = new NutrientsDirectory { Name = "����" };
                NutrientsDirectory nutrientsDirectory3 = new NutrientsDirectory { Name = "��������" };
                NutrientsDirectory nutrientsDirectory4 = new NutrientsDirectory { Name = "������������" };
                NutrientsDirectory nutrientsDirectory5 = new NutrientsDirectory { Name = "B1" };
                NutrientsDirectory nutrientsDirectory6 = new NutrientsDirectory { Name = "B2" };
                NutrientsDirectory nutrientsDirectory7 = new NutrientsDirectory { Name = "C" };

                *//*DishNutrients dishNutrients1 = new DishNutrients { Dish = dish1, 
                    NutrientsDirectories = { nutrientsDirectory1 }, DishNutrientWeight = 0.004f  };
                DishNutrients dishNutrients2 = new DishNutrients { Dish = dish2,
                    NutrientsDirectories = { nutrientsDirectory2 }, DishNutrientWeight = 0.002f  };
                DishNutrients dishNutrients3 = new DishNutrients { Dish = dish3, 
                    NutrientsDirectories = { nutrientsDirectory3 }, DishNutrientWeight = 0.021f  };
                DishNutrients dishNutrients4 = new DishNutrients { Dish = dish4, 
                    NutrientsDirectories = { nutrientsDirectory4 }, DishNutrientWeight = 0.120f  };

                ProductNutrients productNutrients1 = new ProductNutrients { Product = product1, 
                    NutrientsDirectories = { nutrientsDirectory1 }, ProductNutrientWeight = 0.004f  };
                ProductNutrients productNutrients2 = new ProductNutrients { Product = product1, 
                    NutrientsDirectories = { nutrientsDirectory2 }, ProductNutrientWeight = 0.002f  };
                ProductNutrients productNutrients3 = new ProductNutrients { Product = product1, 
                    NutrientsDirectories = { nutrientsDirectory3 }, ProductNutrientWeight = 0.021f  };
                ProductNutrients productNutrients4 = new ProductNutrients { Product = product1, 
                    NutrientsDirectories = { nutrientsDirectory4 }, ProductNutrientWeight = 0.120f  };*//*

                db.Dishes.AddRange(dish1, dish2, dish3, dish4);
                db.Products.AddRange(product1, product2, product3,
                    product4, product5, product6, product7);
                db.Ingridients.AddRange(ingridient1, ingridient2, ingridient3, ingridient4,
                    ingridient5, ingridient6, ingridient7);
                db.NutrientsDirectories.AddRange(nutrientsDirectory1, nutrientsDirectory2, nutrientsDirectory3,
                    nutrientsDirectory4, nutrientsDirectory5, nutrientsDirectory6, nutrientsDirectory7);
                *//*db.ProductNutrients.AddRange(productNutrients1, productNutrients2, productNutrients3, productNutrients4);
                db.DishNutrients.AddRange(dishNutrients1, dishNutrients2, dishNutrients3, dishNutrients4);*/


                //db.Roles.AddRange(role1, role2, role3);

                NutrientsDirectory nutrientsDirectory1 = new NutrientsDirectory { Name = "�����" };
                NutrientsDirectory nutrientsDirectory2 = new NutrientsDirectory { Name = "����" };
                NutrientsDirectory nutrientsDirectory3 = new NutrientsDirectory { Name = "��������" };
                NutrientsDirectory nutrientsDirectory4 = new NutrientsDirectory { Name = "������������" };
                NutrientsDirectory nutrientsDirectory5 = new NutrientsDirectory { Name = "B1" };
                NutrientsDirectory nutrientsDirectory6 = new NutrientsDirectory { Name = "B2" };
                NutrientsDirectory nutrientsDirectory7 = new NutrientsDirectory { Name = "C" };
                //db.AddRange(nutrientsDirectory1, nutrientsDirectory2, nutrientsDirectory3, nutrientsDirectory4,
                //   nutrientsDirectory5, nutrientsDirectory6, nutrientsDirectory7);
                db.SaveChanges();

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

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
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
            }
            else
            {
                WarningLabel.Text = "��� �������� ���� ���������� ����� � �������";
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

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MealCreation mealCreation= new MealCreation();
            mealCreation.ShowDialog();
            menuDataGridView.Rows.Add(mealCreation.mealname);
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductCreation productCreation = new ProductCreation();
            productCreation.ShowDialog();
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngrigientCreation ingrigientCreation = new IngrigientCreation();
            ingrigientCreation.ShowDialog();
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DishCreation dishCreation = new DishCreation();
            dishCreation.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ����������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngrigientCreation ingrigientCreation = new IngrigientCreation();
            ingrigientCreation.ShowDialog();
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}