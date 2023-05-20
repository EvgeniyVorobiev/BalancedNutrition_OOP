﻿using BalancedNutritionLibrary;
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
                string productName = productNameTextBox.Text;
                float productWeight = (float)Convert.ToDecimal(productWeightTextBox.Text);

                float proteinWeight = (float)Convert.ToDecimal(proteinTextBox.Text);
                float fatsWeight = (float)Convert.ToDecimal(fatsTextBox.Text);
                float carbsWeight = (float)Convert.ToDecimal(carbsTextBox.Text);
                float caloriesWeight = (float)Convert.ToDecimal(caloriesTextBox.Text);

                float CWeight = (float)Convert.ToDecimal(CTextBox.Text);
                float B1Weight = (float)Convert.ToDecimal(B1TextBox.Text);
                float B2Weight = (float)Convert.ToDecimal(B2TextBox.Text);
                float AWeight = (float)Convert.ToDecimal(ATextBox.Text);
                float DWeight = (float)Convert.ToDecimal(DTextBox.Text);

                float CaWeight = (float)Convert.ToDecimal(CaTextBox.Text);
                float PWeight = (float)Convert.ToDecimal(PTextBox.Text);
                float MgWeight = (float)Convert.ToDecimal(MgTextBox.Text);
                float FeWeight = (float)Convert.ToDecimal(FeTextBox.Text);
                float KWeight = (float)Convert.ToDecimal(KTextBox.Text);
                float IWeight = (float)Convert.ToDecimal(ITextBox.Text);
                float SeWeight = (float)Convert.ToDecimal(SeTextBox.Text);
                float FWeight = (float)Convert.ToDecimal(FTextBox.Text);


                List <NutrientsDirectory> nutrients = db.NutrientsDirectories.ToList();
                Product product = new Product { Name = productName, Weight = productWeight,
                    ProductNutrients = new List <ProductNutrients>() };

                ProductNutrients proteins = new ProductNutrients { ProductNutrientWeight = proteinWeight,
                    Product = product, NutrientsDirectory = db.NutrientsDirectories.ToList()[0]};
                ProductNutrients fats = new ProductNutrients { ProductNutrientWeight = fatsWeight,
                Product = product, NutrientsDirectory = db.NutrientsDirectories.ToList()[1] };
                ProductNutrients carbs = new ProductNutrients { ProductNutrientWeight = carbsWeight,
                Product = product, NutrientsDirectory = db.NutrientsDirectories.ToList()[2]};
                ProductNutrients calories = new ProductNutrients { ProductNutrientWeight = caloriesWeight,
                Product = product, NutrientsDirectory = db.NutrientsDirectories.ToList()[3]};

                ProductNutrients C = new ProductNutrients { ProductNutrientWeight = CWeight,
                Product = product, NutrientsDirectory = db.NutrientsDirectories.ToList()[4]};
                ProductNutrients B1 = new ProductNutrients { ProductNutrientWeight = B1Weight,
                Product = product, NutrientsDirectory = db.NutrientsDirectories.ToList()[5]};
                ProductNutrients B2 = new ProductNutrients { ProductNutrientWeight = B2Weight,
                Product = product, NutrientsDirectory = db.NutrientsDirectories.ToList()[6]};
                ProductNutrients A = new ProductNutrients { ProductNutrientWeight = AWeight,
                Product = product, NutrientsDirectory = db.NutrientsDirectories.ToList()[7]};
                ProductNutrients D = new ProductNutrients { ProductNutrientWeight = DWeight,
                Product = product, NutrientsDirectory = db.NutrientsDirectories.ToList()[8]};

                ProductNutrients Ca = new ProductNutrients { ProductNutrientWeight = CaWeight,
                Product = product, NutrientsDirectory = db.NutrientsDirectories.ToList()[9]};
                ProductNutrients P = new ProductNutrients { ProductNutrientWeight = DWeight,
                Product = product, NutrientsDirectory = db.NutrientsDirectories.ToList()[10]};
                ProductNutrients Mg = new ProductNutrients { ProductNutrientWeight = DWeight,
                Product = product, NutrientsDirectory = db.NutrientsDirectories.ToList()[11]};
                ProductNutrients Fe = new ProductNutrients { ProductNutrientWeight = DWeight,
                Product = product, NutrientsDirectory = db.NutrientsDirectories.ToList()[12]};
                ProductNutrients K = new ProductNutrients { ProductNutrientWeight = DWeight,
                Product = product, NutrientsDirectory = db.NutrientsDirectories.ToList()[13]};
                ProductNutrients I = new ProductNutrients { ProductNutrientWeight = DWeight,
                Product = product, NutrientsDirectory = db.NutrientsDirectories.ToList()[14]};
                ProductNutrients Se = new ProductNutrients { ProductNutrientWeight = DWeight,
                Product = product, NutrientsDirectory = db.NutrientsDirectories.ToList()[15]};
                ProductNutrients F = new ProductNutrients { ProductNutrientWeight = DWeight,
                Product = product, NutrientsDirectory = db.NutrientsDirectories.ToList()[16]};

                product.Add();
                db.ProductNutrients.AddRange(proteins, fats, carbs, calories, C, B1, B2, A, D, Ca, P, Mg, Fe,
                    K, I, Se, F);
                db.SaveChanges();
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductCreation_Load(object sender, EventArgs e)
        {

        }
    }
}
