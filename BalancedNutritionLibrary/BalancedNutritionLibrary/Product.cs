using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BalancedNutritionLibrary
{
    public class Product : ProductDishBaseClass
    {
        public Product()
        {
            Ingredients = new List<Ingredient>();
            ProductNutrients = new List<ProductNutrients>();
        }

        public override void Add()
        {
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
            {
                Product product = new Product { Id = this.Id, Ingredients = this.Ingredients, Name = this.Name,
                ProductNutrients = this.ProductNutrients, Weight = this.Weight};
                db.Products.Add(product);
            }
        }

        public List <Ingredient> Ingredients { get; set; }
        public List <ProductNutrients> ProductNutrients { get; set; }
    }
}