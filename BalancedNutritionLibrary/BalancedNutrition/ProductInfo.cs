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
    public partial class ProductInfo : Form
    {
        public Product selectedProduct = new Product();
        public ProductList productList1 = new ProductList();
        
        public ProductInfo()
        {
            InitializeComponent();
        }

        private void productCreationLabel_Click(object sender, EventArgs e)
        {

        }

        private void ProductInfo_Load(object sender, EventArgs e)
        {
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
            {
                ProductList productList = (ProductList)Owner;
                productList1 = productList;
                Product selectedProduct = productList.selectedProduct;

                productNameTextBox.Text = selectedProduct.Name;
                productWeightTextBox.Text = selectedProduct.Weight.ToString();

                List<ProductNutrients> productNutrients = db.ProductNutrients.Where(pn => pn.Product == selectedProduct).ToList();
                proteinTextBox.Text = productNutrients[0].ProductNutrientWeight.ToString();
                fatsTextBox.Text = productNutrients[1].ProductNutrientWeight.ToString();
                carbsTextBox.Text = productNutrients[2].ProductNutrientWeight.ToString();
                caloriesTextBox.Text = productNutrients[3].ProductNutrientWeight.ToString();

                CTextBox.Text = productNutrients[4].ProductNutrientWeight.ToString();
                B1TextBox.Text = productNutrients[5].ProductNutrientWeight.ToString();
                B2TextBox.Text = productNutrients[6].ProductNutrientWeight.ToString();
                ATextBox.Text = productNutrients[7].ProductNutrientWeight.ToString();
                DTextBox.Text = productNutrients[8].ProductNutrientWeight.ToString();

                CaTextBox.Text = productNutrients[9].ProductNutrientWeight.ToString();
                PTextBox.Text = productNutrients[10].ProductNutrientWeight.ToString();
                MgTextBox.Text = productNutrients[11].ProductNutrientWeight.ToString();
                FeTextBox.Text = productNutrients[12].ProductNutrientWeight.ToString();
                KTextBox.Text = productNutrients[13].ProductNutrientWeight.ToString();
                ITextBox.Text = productNutrients[14].ProductNutrientWeight.ToString();
                SeTextBox.Text = productNutrients[15].ProductNutrientWeight.ToString();
                FTextBox.Text = productNutrients[16].ProductNutrientWeight.ToString();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
            {
                db.ProductNutrients.RemoveRange(db.Products.Include(p => p.ProductNutrients).Where(p => p.Name == productNameTextBox.Text).ToList()[0].ProductNutrients.ToList());
                db.Products.Remove(db.Products.Include(p => p.ProductNutrients).
                    Include(p => p.Ingredients).Where(p => p.Name == productNameTextBox.Text).ToList()[0]);
                

                db.SaveChanges();
                productList1.RefreshProducts();
                Close();
            }
        }
    }
}
