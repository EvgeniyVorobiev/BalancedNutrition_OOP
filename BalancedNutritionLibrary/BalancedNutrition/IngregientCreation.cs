using BalancedNutritionLibrary;
using Microsoft.EntityFrameworkCore;
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
    public partial class IngregientCreation : Form
    {
        public static List <Ingredient> ingredients = new List<Ingredient>();
        public IngregientCreation()
        {
            InitializeComponent();
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
            {
                List<Product> products = db.Products.ToList();
                foreach (Product product in products)
                {
                    productNameComboBox.Items.Add(product.Name);
                }
            }
        }
        private void productTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cookingMethodLabel_Click(object sender, EventArgs e)
        {

        }

        private void ingredientCreateButton_Click(object sender, EventArgs e)
        {
            if (ingridientTextBox.Text != "" && productNameComboBox.Text != "" && methodComboBox.Text != ""
                && wasteTextBox.Text != "")
            {
                try
                {
                    using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
                    {
                        string ingredientName = ingridientTextBox.Text;
                        string productName = productNameComboBox.Text;
                        string cookingMethod = methodComboBox.Text;
                        float weightWaste = (float)Convert.ToDecimal(wasteTextBox.Text);

                        Product product = db.Products.Include(p => p.ProductNutrients).Where(p => p.Name == productName).ToList()[0];
                        float productWeight = product.Weight;

                        Ingredient ingredient = new Ingredient
                        {
                            Name = ingredientName,
                            CookingMethod = cookingMethod,
                            IngredientWaste = weightWaste,
                            WastePercent = (((productWeight - weightWaste) * 100) / productWeight),
                            Product = product
                        };
                        ingredients.Add(ingredient);
                        db.SaveChanges();

                        ingredientName = "";
                        ingridientTextBox.Text = "";
                        productName = "";
                        productNameComboBox.Text = "";
                        
                        warningLabel.Visible = true;
                        warningLabel.ForeColor = Color.Green;
                        warningLabel.Text = "Ингредиент добавлен в блюдо";
                    }
                }
                catch 
                {
                    warningLabel.Visible = true;
                    warningLabel.ForeColor = Color.Red;
                    warningLabel.Text = "Проверьте правильность введённых данных";
                }
            }
            else
            {
                warningLabel.Visible = true;
                warningLabel.ForeColor = Color.Red;
                warningLabel.Text = "Проверьте правильность введённых данных";
            }
        }

        private void IngrigientCreation_Load(object sender, EventArgs e)
        {

        }

        private void productNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void productNameComboBox_TextUpdate(object sender, EventArgs e)
        {
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
            {
                if (productNameComboBox.Text == "")
                {
                    productNameComboBox.Items.Clear();
                    List<Product> products = db.Products.ToList();
                    foreach (Product product in products)
                    {
                        productNameComboBox.Items.Add(product.Name);
                    }
                }
                else if (productNameComboBox.Text != "")
                {
                    productNameComboBox.Items.Clear();
                    List<Product> products = db.Products.Where(p => EF.Functions.Like(p.Name, "%" + productNameComboBox.Text + "%")).ToList();
                    foreach (Product product in products)
                    {
                        productNameComboBox.Items.Add(product.Name);
                    }
                }
            }
        }
    }
}
