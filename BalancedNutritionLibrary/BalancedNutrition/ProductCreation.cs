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
    public partial class ProductCreation : Form
    {
        public ProductCreation()
        {
            InitializeComponent();
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
            {
                string productName = productNameLabel.Text;
                float productWeight = (float)Convert.ToDecimal(productWeightTextBox.Text);
                float proteinWeight = (float)Convert.ToDecimal(proteinTextBox.Text);
                float fatsWeight = (float)Convert.ToDecimal(fatsTextBox.Text);
                float carbsWeight = (float)Convert.ToDecimal(carbsTextBox.Text);
                float caloriesWeight = (float)Convert.ToDecimal(caloriesTextBox.Text);
                float B1Weight = (float)Convert.ToDecimal(B1TextBox.Text);
                float B2Weight = (float)Convert.ToDecimal(B2TextBox.Text);
                float CWeight = (float)Convert.ToDecimal(CTextBox.Text);
                List <NutrientsDirectory> nutrients = db.NutrientsDirectories.ToList();
                Product product = new Product { Name = productName, ProductWeight = productWeight,
                    ProductNutrients = new List <ProductNutrients>() };

                ProductNutrients proteins = new ProductNutrients { ProductNutrientWeight = proteinWeight,
                    Product = product, NutrientsDirectory = db.NutrientsDirectories.ToList()[0]};
                ProductNutrients fats = new ProductNutrients { ProductNutrientWeight = fatsWeight,
                Product = product, NutrientsDirectory = db.NutrientsDirectories.ToList()[1] };
                ProductNutrients carbs = new ProductNutrients { ProductNutrientWeight = carbsWeight,
                Product = product, NutrientsDirectory = db.NutrientsDirectories.ToList()[2]};
                ProductNutrients calories = new ProductNutrients { ProductNutrientWeight = caloriesWeight,
                Product = product, NutrientsDirectory = db.NutrientsDirectories.ToList()[3]};
                ProductNutrients B1 = new ProductNutrients { ProductNutrientWeight = B1Weight,
                Product = product, NutrientsDirectory = db.NutrientsDirectories.ToList()[4]};
                ProductNutrients B2 = new ProductNutrients { ProductNutrientWeight = B2Weight,
                Product = product, NutrientsDirectory = db.NutrientsDirectories.ToList()[5]};
                ProductNutrients C = new ProductNutrients { ProductNutrientWeight = CWeight,
                Product = product, NutrientsDirectory = db.NutrientsDirectories.ToList()[6]};

                db.Products.Add(product);
                db.ProductNutrients.AddRange(proteins, fats, carbs, calories, B1, B2, C);
                db.SaveChanges();
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
