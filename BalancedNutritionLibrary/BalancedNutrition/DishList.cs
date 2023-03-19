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
    public partial class DishList : Form
    {
        public DishList()
        {
            InitializeComponent();
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
            {
                List<Dish> dishes = db.Dishes.ToList();
                List <string> dishNames = new List<string>();
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
            DishInfo dishInfo = new DishInfo();
            dishInfo.ShowDialog();
        }
    }
}
