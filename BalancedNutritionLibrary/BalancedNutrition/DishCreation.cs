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
            try
            {
                
                using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
                {
                    if (db.Dishes.Where(d => d.Name == nameTextBox.Text).ToList().Count > 0)
                    {
                        WarningLabel.ForeColor = Color.Red;
                        WarningLabel.Text = "Блюдо с таким названием уже есть";
                        WarningLabel.Visible = true;
                    }
                    else
                    {
                        string name = nameTextBox.Text;
                        string cookingMethod = methodComboBox.Text;
                        float weight = (float)Convert.ToDecimal(weightTextBox.Text);
                        string cookingTechnology = technologyTextBox.Text;
                        string dishCharacteristic = characteristicTextBox.Text;

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

                        Dish dish = new Dish
                        {
                            Name = name,
                            CookingMethod = cookingMethod,
                            Weight = weight,
                            CookingTechnology = cookingTechnology,
                            DishCharacteristic = dishCharacteristic,
                            Meals = new List<Meal>(),
                            Ingredients = new List<Ingredient>()
                        };

                        DishNutrients proteins = new DishNutrients
                        {
                            DishNutrientWeight = proteinWeight,
                            Dish = dish,
                            NutrientsDirectory = db.NutrientsDirectories.ToList()[0]
                        };
                        DishNutrients fats = new DishNutrients
                        {
                            DishNutrientWeight = fatsWeight,
                            Dish = dish,
                            NutrientsDirectory = db.NutrientsDirectories.ToList()[1]
                        };
                        DishNutrients carbs = new DishNutrients
                        {
                            DishNutrientWeight = carbsWeight,
                            Dish = dish,
                            NutrientsDirectory = db.NutrientsDirectories.ToList()[2]
                        };
                        DishNutrients calories = new DishNutrients
                        {
                            DishNutrientWeight = caloriesWeight,
                            Dish = dish,
                            NutrientsDirectory = db.NutrientsDirectories.ToList()[3]
                        };

                        DishNutrients C = new DishNutrients
                        {
                            DishNutrientWeight = CWeight,
                            Dish = dish,
                            NutrientsDirectory = db.NutrientsDirectories.ToList()[4]
                        };
                        DishNutrients B1 = new DishNutrients
                        {
                            DishNutrientWeight = B1Weight,
                            Dish = dish,
                            NutrientsDirectory = db.NutrientsDirectories.ToList()[5]
                        };
                        DishNutrients B2 = new DishNutrients
                        {
                            DishNutrientWeight = B2Weight,
                            Dish = dish,
                            NutrientsDirectory = db.NutrientsDirectories.ToList()[6]
                        };
                        DishNutrients A = new DishNutrients
                        {
                            DishNutrientWeight = AWeight,
                            Dish = dish,
                            NutrientsDirectory = db.NutrientsDirectories.ToList()[7]
                        };
                        DishNutrients D = new DishNutrients
                        {
                            DishNutrientWeight = DWeight,
                            Dish = dish,
                            NutrientsDirectory = db.NutrientsDirectories.ToList()[8]
                        };

                        DishNutrients Ca = new DishNutrients
                        {
                            DishNutrientWeight = CaWeight,
                            Dish = dish,
                            NutrientsDirectory = db.NutrientsDirectories.ToList()[9]
                        };
                        DishNutrients P = new DishNutrients
                        {
                            DishNutrientWeight = DWeight,
                            Dish = dish,
                            NutrientsDirectory = db.NutrientsDirectories.ToList()[10]
                        };
                        DishNutrients Mg = new DishNutrients
                        {
                            DishNutrientWeight = DWeight,
                            Dish = dish,
                            NutrientsDirectory = db.NutrientsDirectories.ToList()[11]
                        };
                        DishNutrients Fe = new DishNutrients
                        {
                            DishNutrientWeight = DWeight,
                            Dish = dish,
                            NutrientsDirectory = db.NutrientsDirectories.ToList()[12]
                        };
                        DishNutrients K = new DishNutrients
                        {
                            DishNutrientWeight = DWeight,
                            Dish = dish,
                            NutrientsDirectory = db.NutrientsDirectories.ToList()[13]
                        };
                        DishNutrients I = new DishNutrients
                        {
                            DishNutrientWeight = DWeight,
                            Dish = dish,
                            NutrientsDirectory = db.NutrientsDirectories.ToList()[14]
                        };
                        DishNutrients Se = new DishNutrients
                        {
                            DishNutrientWeight = DWeight,
                            Dish = dish,
                            NutrientsDirectory = db.NutrientsDirectories.ToList()[15]
                        };
                        DishNutrients F = new DishNutrients
                        {
                            DishNutrientWeight = DWeight,
                            Dish = dish,
                            NutrientsDirectory = db.NutrientsDirectories.ToList()[16]
                        };

                        for (int i = 0; i < IngregientCreation.ingredients.Count; i++)
                            IngregientCreation.ingredients[i].Dish = dish;

                        

                        dish.Add();
                        db.DishNutrients.AddRange(proteins, fats, carbs, calories, C, B1, B2, A, D,
                            Ca, P, Mg, Fe, K, I, Se, F);
                        foreach (Ingredient ingredient in IngregientCreation.ingredients)
                        {
                            Product product = db.Products.Where(p => p.Id == ingredient.Product.Id).ToList().Last();
                            product.Ingredients.Add(ingredient);
                            db.Products.Update(product);
                        }
                        db.SaveChanges();

                        nameTextBox.Clear();
                        weightTextBox.Text = "0";
                        proteinTextBox.Text = "0";
                        fatsTextBox.Text = "0";
                        carbsTextBox.Text = "0";
                        caloriesTextBox.Text = "0";
                        CTextBox.Text = "0";
                        B1TextBox.Text = "0";
                        B2TextBox.Text = "0";
                        ATextBox.Text = "0";
                        DTextBox.Text = "0";
                        CaTextBox.Text = "0";
                        PTextBox.Text = "0";
                        MgTextBox.Text = "0";
                        FeTextBox.Text = "0";
                        KTextBox.Text = "0";
                        ITextBox.Text = "0";
                        SeTextBox.Text = "0";
                        FTextBox.Text = "0";
                        technologyTextBox.Clear();
                        characteristicTextBox.Clear();

                        ingredientListBox.Items.Clear();
                        IngregientCreation.ingredients.Clear();

                        WarningLabel.ForeColor = Color.Green;
                        WarningLabel.Text = "Блюдо добавлено в базу данных";
                        WarningLabel.Visible = true;
                    }
                }
            }
            catch
            {
                WarningLabel.ForeColor = Color.Red;
                WarningLabel.Text = "Проверьте правильность введённых данных";
                WarningLabel.Visible = true;
            }
        }

        private void technologyTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ingridientButton_Click(object sender, EventArgs e)
        {
            IngregientCreation ingregientCreation = new IngregientCreation();
            ingregientCreation.ShowDialog();
            ingredientListBox.Items.Clear();
            for (int i = 0; i < IngregientCreation.ingredients.Count; i++)
            {
                ingredientListBox.Items.Add(IngregientCreation.ingredients[i].Name);
            }
            float productWeight = 0;
            float proteinWeight = 0;
            float fatsWeight = 0;
            float carbsWeight = 0;
            float caloriesWeight = 0;

            float CWeight = 0;
            float B1Weight = 0;
            float B2Weight = 0;
            float AWeight = 0;
            float DWeight = 0;

            float CaWeight = 0;
            float PWeight = 0;
            float MgWeight = 0;
            float FeWeight = 0;
            float KWeight = 0;
            float IWeight = 0;
            float SeWeight = 0;
            float FWeight = 0;
            foreach (Ingredient ingredient in IngregientCreation.ingredients)
            {
                productWeight += ingredient.Product.Weight - ingredient.IngredientWaste;
                proteinWeight += ingredient.Product.ProductNutrients[0].ProductNutrientWeight;
                fatsWeight += ingredient.Product.ProductNutrients[1].ProductNutrientWeight;
                carbsWeight += ingredient.Product.ProductNutrients[2].ProductNutrientWeight;
                caloriesWeight += ingredient.Product.ProductNutrients[3].ProductNutrientWeight;
                CWeight += ingredient.Product.ProductNutrients[4].ProductNutrientWeight;
                B1Weight += ingredient.Product.ProductNutrients[5].ProductNutrientWeight;
                B2Weight += ingredient.Product.ProductNutrients[6].ProductNutrientWeight;
                AWeight += ingredient.Product.ProductNutrients[7].ProductNutrientWeight;
                DWeight += ingredient.Product.ProductNutrients[8].ProductNutrientWeight;
                CaWeight += ingredient.Product.ProductNutrients[9].ProductNutrientWeight;
                PWeight += ingredient.Product.ProductNutrients[10].ProductNutrientWeight;
                MgWeight += ingredient.Product.ProductNutrients[11].ProductNutrientWeight;
                FeWeight += ingredient.Product.ProductNutrients[12].ProductNutrientWeight;
                KWeight += ingredient.Product.ProductNutrients[13].ProductNutrientWeight;
                IWeight += ingredient.Product.ProductNutrients[14].ProductNutrientWeight;
                SeWeight += ingredient.Product.ProductNutrients[15].ProductNutrientWeight;
                FWeight += ingredient.Product.ProductNutrients[16].ProductNutrientWeight;
            }
            weightTextBox.Text = productWeight.ToString();
            proteinTextBox.Text = proteinWeight.ToString();
            fatsTextBox.Text = fatsWeight.ToString();
            carbsTextBox.Text = carbsWeight.ToString();
            caloriesTextBox.Text = caloriesWeight.ToString();
            CTextBox.Text = CWeight.ToString();
            B1TextBox.Text = B1Weight.ToString();
            B2TextBox.Text = B2Weight.ToString();
            ATextBox.Text = AWeight.ToString();
            DTextBox.Text = DWeight.ToString();
            CaTextBox.Text = CaWeight.ToString();
            PTextBox.Text = PWeight.ToString();
            MgTextBox.Text = MgWeight.ToString();
            FeTextBox.Text = FeWeight.ToString();
            KTextBox.Text = KWeight.ToString();
            ITextBox.Text = IWeight.ToString();
            SeTextBox.Text = SeWeight.ToString();
            FTextBox.Text = FWeight.ToString();

        }

        private void ingridientListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
