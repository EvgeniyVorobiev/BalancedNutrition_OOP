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

        }

        public override void Add()
        {
            using (BalancedNutritionLibrary.AppContext db = new BalancedNutritionLibrary.AppContext())
            {
                Dish dish = new Dish { Id = this.Id, Name = this.Name, CookingMethod = this.CookingMethod, 
                CookingTechnology = this.CookingTechnology, DishCharacteristic = this.DishCharacteristic,
                Weight = this.Weight, DishNutrients = this.DishNutrients, Ingridients = this.Ingridients,
                Meals = this.Meals};
                db.Add(dish);
                db.SaveChanges();
            }
        }

        //[Key]
        //public int Id {get; set;} 

        [Required]
        public string CookingMethod { get; set; }
        [Required]
        public string CookingTechnology { get; set; }
        [Required]
        public string DishCharacteristic { get; set; }
        public ICollection <Meal> Meals { get; set; }
        public ICollection <Ingredient> Ingridients { get; set; }
        public ICollection <DishNutrients> DishNutrients { get; set; }
    }
}
