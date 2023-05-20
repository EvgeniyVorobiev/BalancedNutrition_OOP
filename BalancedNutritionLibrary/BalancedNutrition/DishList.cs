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
    public partial class DishList : Form
    {
        public Dish selectedDish = new Dish();
        readonly List<Dish> dishes = new List<Dish> { };

        public DishList()
        {
            InitializeComponent();
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
            {
                    dishes = db.Dishes.ToList();
                    List<string> dishNames = new List<string>();
                    foreach (Dish d in dishes)
                    {
                        listBox1.Items.Add(d.Name);
                        //dishNames.Add(d.Name);
                    }

                //listBox1.Items.AddRange(d
            }    
        }

        private void DishList_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
            {
                selectedDish = db.Dishes.Where(d => d.Name == listBox1.SelectedItem.ToString()).ToList()[0];
                ////selectedDish = db.Dishes.ToList()[listBox1.SelectedIndex];
                ///
                //List <DishNutrients> dishNutrients = db.DishNutrients.Where(dn => dn.Dish == selectedDish).ToList();
                //listBox1.Items.Add(dishNutrients[0].DishNutrientWeight.ToString());
                DishInfo dishInfo = new DishInfo();
                dishInfo.ShowDialog(this);
            }
        }

        public void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
            {
                List <Dish> dishes = db.Dishes.Where(d => EF.Functions.Like(d.Name, "%" + nameTextBox.Text + "%")).ToList();
                listBox1.Items.Clear();
                foreach (Dish d in dishes)
                {
                    listBox1.Items.Add(d.Name);
                }
            }
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
