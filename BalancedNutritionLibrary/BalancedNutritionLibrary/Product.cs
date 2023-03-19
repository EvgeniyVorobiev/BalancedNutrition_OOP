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

        }

        public override void Add()
        {
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
            {
                Product product = new Product { Id = this.Id, Ingredients = this.Ingredients, Name = this.Name,
                ProductNutrients = this.ProductNutrients, Weight = this.Weight};
                db.Products.Add(product);
                db.SaveChanges();
            }
        }

/*        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        public float Weight { get; set; }*/

        public ICollection <Ingredient> Ingredients { get; set; }
        public ICollection <ProductNutrients> ProductNutrients { get; set; }
    }
}
