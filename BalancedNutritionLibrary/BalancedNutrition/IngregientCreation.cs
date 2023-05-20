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
    public partial class IngregientCreation : Form
    {
        public static List <Ingredient> ingredients = new List<Ingredient>();
        public IngregientCreation()
        {
            InitializeComponent();
        }

        private void productTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cookingMethodLabel_Click(object sender, EventArgs e)
        {

        }

        private void ingredientCreateButton_Click(object sender, EventArgs e)
        {
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
            {
                string ingredientName = ingridientTextBox.Text;
                string productName = productNameTextBox.Text;
                string cookingMethod = methodComboBox.Text;
                float weightWaste = (float)Convert.ToDecimal(wasteTextBox.Text);

                Product product = db.Products.Where(p => p.Name == productName).ToList()[0];
                float productWeight = product.Weight;
                
                Ingredient ingredient = new Ingredient { 
                    Name = ingredientName, CookingMethod = cookingMethod,IngredientWaste = weightWaste,
                    WastePercent = (((productWeight - weightWaste) * 100)/productWeight)};
                ingredients.Add(ingredient);

                
                
                db.SaveChanges();

            }
        }

        private void IngrigientCreation_Load(object sender, EventArgs e)
        {

        }
    }
}
