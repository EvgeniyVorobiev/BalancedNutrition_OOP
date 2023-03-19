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
    public partial class DishCreation : Form
    {
        public DishCreation()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void weightLabel_Click(object sender, EventArgs e)
        {

        }

        private void cookingTechnologyLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DishCreation_Load(object sender, EventArgs e)
        {

        }

        private void createDishButton_Click(object sender, EventArgs e)
        {
            WarningLabel.Visible = false;
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
            {
                string name = nameTextBox.Text;
                string cookingMethod = methodComboBox.Text;
                float weight = (float)Convert.ToDecimal(weightTextBox.Text);
                float proteinWeight = (float)Convert.ToDecimal(proteinTextBox.Text);
                float fatsWeight = (float)Convert.ToDecimal(fatsTextBox.Text);
                float carbsWeight = (float)Convert.ToDecimal(carbsTextBox.Text);
                float caloriesWeight = (float)Convert.ToDecimal(caloriesTextBox.Text);
                float B1Weight = (float)Convert.ToDecimal(B1TextBox.Text);
                float B2Weight = (float)Convert.ToDecimal(B2TextBox.Text);
                float CWeight = (float)Convert.ToDecimal(CTextBox.Text);
                string cookingTechnology = technologyTextBox.Text;
                string dishCharacteristic = characteristicTextBox.Text;

                Dish dish = new Dish { Name = name, CookingMethod = cookingMethod, Weight = weight,
                CookingTechnology = cookingTechnology, DishCharacteristic = dishCharacteristic, Meals = new List <Meal> ()};
                
                DishNutrients proteins = new DishNutrients { DishNutrientWeight = proteinWeight,
                    Dish = dish, NutrientsDirectory = db.NutrientsDirectories.ToList()[0]};
                DishNutrients fats = new DishNutrients { DishNutrientWeight = fatsWeight,
                Dish = dish, NutrientsDirectory = db.NutrientsDirectories.ToList()[1] };
                DishNutrients carbs = new DishNutrients { DishNutrientWeight = carbsWeight,
                Dish = dish, NutrientsDirectory = db.NutrientsDirectories.ToList()[2]};
                DishNutrients calories = new DishNutrients { DishNutrientWeight = caloriesWeight,
                Dish = dish, NutrientsDirectory = db.NutrientsDirectories.ToList()[3]};
                DishNutrients B1 = new DishNutrients { DishNutrientWeight = B1Weight,
                Dish = dish, NutrientsDirectory = db.NutrientsDirectories.ToList()[4]};
                DishNutrients B2 = new DishNutrients { DishNutrientWeight = B2Weight,
                Dish = dish, NutrientsDirectory = db.NutrientsDirectories.ToList()[5]};
                DishNutrients C = new DishNutrients { DishNutrientWeight = CWeight,
                Dish = dish, NutrientsDirectory = db.NutrientsDirectories.ToList()[6]};

                db.Dishes.Add(dish);
                db.DishNutrients.AddRange(proteins, fats, carbs, calories, B1, B2, C);
                db.SaveChanges();

                nameTextBox.Clear();
                weightTextBox.Clear();
                proteinTextBox.Clear();
                fatsTextBox.Clear();
                carbsTextBox.Clear();
                caloriesTextBox.Clear();
                B1TextBox.Clear();
                B2TextBox.Clear();
                CTextBox.Clear();
                technologyTextBox.Clear();
                characteristicTextBox.Clear();

                WarningLabel.ForeColor = Color.Green;
                WarningLabel.Text = "Блюдо добавлено в базу данных";
                WarningLabel.Visible = true;
            }
        }

        private void technologyTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
