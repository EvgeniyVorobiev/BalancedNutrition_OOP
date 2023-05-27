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
    public partial class DishInfo : Form
    {
        //Dish dish = BalancedNutrition.
        Dish selectedDish = new Dish();
        public DishInfo()
        {
            InitializeComponent();
        }
        public void DishLoad(Dish selectedDish)
        {
            this.selectedDish = selectedDish;
        }
        private void DishInfo_Load(object sender, EventArgs e)
        {
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
            {

                nameTextBox.Text = selectedDish.Name;
                methodTextBox.Text = selectedDish.CookingMethod;
                weightTextBox.Text = selectedDish.Weight.ToString();
                technologyTextBox.Text = selectedDish.CookingTechnology;
                characteristicTextBox.Text = selectedDish.DishCharacteristic;
                
                List<DishNutrients> dishNutrients = db.DishNutrients.Where(dn => dn.Dish == selectedDish).ToList();
                proteinTextBox.Text = dishNutrients[0].DishNutrientWeight.ToString();
                fatsTextBox.Text = dishNutrients[1].DishNutrientWeight.ToString();
                carbsTextBox.Text = dishNutrients[2].DishNutrientWeight.ToString();
                caloriesTextBox.Text = dishNutrients[3].DishNutrientWeight.ToString();

                CTextBox.Text = dishNutrients[4].DishNutrientWeight.ToString();
                B1TextBox.Text = dishNutrients[5].DishNutrientWeight.ToString();
                B2TextBox.Text = dishNutrients[6].DishNutrientWeight.ToString();
                ATextBox.Text = dishNutrients[7].DishNutrientWeight.ToString();
                DTextBox.Text = dishNutrients[8].DishNutrientWeight.ToString();

                CaTextBox.Text = dishNutrients[9].DishNutrientWeight.ToString();
                PTextBox.Text = dishNutrients[10].DishNutrientWeight.ToString();
                MgTextBox.Text = dishNutrients[11].DishNutrientWeight.ToString();
                FeTextBox.Text = dishNutrients[12].DishNutrientWeight.ToString();
                KTextBox.Text = dishNutrients[13].DishNutrientWeight.ToString();
                ITextBox.Text = dishNutrients[14].DishNutrientWeight.ToString();
                SeTextBox.Text = dishNutrients[15].DishNutrientWeight.ToString();
                FTextBox.Text = dishNutrients[16].DishNutrientWeight.ToString();

                List<Ingredient> dishIngredients = db.Ingridients.Where(i => i.Dish == selectedDish).ToList();
                foreach (Ingredient ingredient in dishIngredients)
                {
                    ingredientListBox.Items.Add(ingredient.Name);
                }
            }
        }

        private void ingredientListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
