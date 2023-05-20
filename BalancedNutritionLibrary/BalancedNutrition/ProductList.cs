using BalancedNutritionLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
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
    public partial class ProductList : Form
    {
        public Product selectedProduct = new Product();
        readonly List<Product> products = new List<Product> { };
        public ProductList()
        {
            InitializeComponent();
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
            {
                products = db.Products.ToList();
                List<string> productNames = new List<string>();
                foreach (Product p in products)
                {
                    listBox1.Items.Add(p.Name);
                    //dishNames.Add(d.Name);
                }

                //listBox1.Items.AddRange(d
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
            {
                List<Product> products = db.Products.Where(p => EF.Functions.Like(p.Name, "%" + nameTextBox.Text + "%")).ToList();
                listBox1.Items.Clear();
                foreach (Product p in products)
                {
                    listBox1.Items.Add(p.Name);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
            {
                selectedProduct = db.Products.Where(d => d.Name == listBox1.SelectedItem.ToString()).ToList()[0];
                ////selectedDish = db.Dishes.ToList()[listBox1.SelectedIndex];
                ///
                //List <DishNutrients> dishNutrients = db.DishNutrients.Where(dn => dn.Dish == selectedDish).ToList();
                //listBox1.Items.Add(dishNutrients[0].DishNutrientWeight.ToString());
                ProductInfo productInfo = new ProductInfo();
                productInfo.ShowDialog(this);
            }
        }
    }
}
