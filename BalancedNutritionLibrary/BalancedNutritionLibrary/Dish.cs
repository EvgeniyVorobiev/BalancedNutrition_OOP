using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BalancedNutritionLibrary
{
    public class Dish : ProductDishBaseClass
    {
        public Dish()
        {
            Meals = new List<Meal>();
            Ingredients= new List<Ingredient>();
            DishNutrients = new List<DishNutrients>();
        }

        public override void Add()
        {
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
            {
                Dish dish = new Dish { Id = this.Id, Name = this.Name, CookingMethod = this.CookingMethod, 
                CookingTechnology = this.CookingTechnology, DishCharacteristic = this.DishCharacteristic,
                Weight = this.Weight, DishNutrients = this.DishNutrients, Ingredients = this.Ingredients,
                Meals = this.Meals};
                db.Add(dish);
            }
        }

        [Required]
        public string CookingMethod { get; set; }
        [Required]
        public string CookingTechnology { get; set; }
        [Required]
        public string DishCharacteristic { get; set; }
        public List <Meal> Meals { get; set; }
        public List <Ingredient> Ingredients { get; set; }
        public List<DishNutrients> DishNutrients { get; set; }
    }
}