using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BalancedNutritionLibrary
{
    public class AppContext : DbContext
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<PlannedMenu> PlannedMenus { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Ingredient> Ingridients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<DishNutrients> DishNutrients { get; set; }
        public DbSet<ProductNutrients> ProductNutrients { get; set; }
        public DbSet<NutrientsDirectory> NutrientsDirectories { get; set; }


        public AppContext() : base()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=bndb;Username=postgres");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>()
                .HasMany(r => r.Users)
                .WithOne(u => u.Role);
            modelBuilder.Entity<Role>()
                .HasKey(r => r.Id);
            modelBuilder.Entity<Role>()
                .Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(20);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users);
            modelBuilder.Entity<User>()
                .HasKey(r => r.Id);
            modelBuilder.Entity<User>()
                .Property(u => u.Login)
                .IsRequired()
                .HasMaxLength(30);
            modelBuilder.Entity<User>()
                .Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(64);

            modelBuilder.Entity<PlannedMenu>()
                .HasOne(pm => pm.User)
                .WithMany(u => u.PlannedMenus);
            modelBuilder.Entity<PlannedMenu>()
                .HasKey(pm => pm.Id);
            modelBuilder.Entity<PlannedMenu>()
                .Property(pm => pm.BeginingDate)
                .IsRequired()
                 .HasColumnType("timestamp without time zone");
            modelBuilder.Entity<PlannedMenu>()
                .Property(pm => pm.EndDate)
                .IsRequired()
                .HasColumnType("timestamp without time zone");

            modelBuilder.Entity<Day>()
                .HasOne(day => day.PlannedMenu)
                .WithMany(pm => pm.Days);
            modelBuilder.Entity<Day>()
                .HasKey(day => day.Id);
            modelBuilder.Entity<Day>()
                .Property(day => day.Date)
                .IsRequired()
                .HasColumnType("timestamp without time zone");

            modelBuilder.Entity<Meal>()
                .HasOne(meal => meal.Day)
                .WithMany(day => day.Meals);
            modelBuilder.Entity<Meal>()
                .HasKey(meal => meal.Id);
            modelBuilder.Entity<Meal>()
                .Property(meal => meal.Name)
                .IsRequired()
                .HasMaxLength(30);

            modelBuilder.Entity<Group>()
                .HasMany(g => g.PlannedMenus)
                .WithMany(pm => pm.Groups);
            modelBuilder.Entity<Group>()
                .HasKey(g => g.Id);
            modelBuilder.Entity<Group>()
                .Property(g => g.Name)
                .IsRequired()
                .HasMaxLength(30);
            modelBuilder.Entity<Group>()
                .Property(g => g.NumberOfServings)
                .IsRequired();

            modelBuilder.Entity<Dish>()
                .HasMany(dish => dish.Meals)
                .WithMany(meal => meal.Dishes);
            modelBuilder.Entity<Dish>()
                .HasKey(dish => dish.Id);
            modelBuilder.Entity<Dish>()
                .Property(dish => dish.Name)
                .IsRequired()
                .HasMaxLength(30);
            modelBuilder.Entity<Dish>()
                .Property(dish => dish.Weight)
                .IsRequired();
            modelBuilder.Entity<Dish>()
                .Property(dish => dish.DishCharacteristic)
                .IsRequired();
            modelBuilder.Entity<Dish>()
                .Property(dish => dish.CookingMethod)
                .IsRequired();
            modelBuilder.Entity<Dish>()
                .Property(dish => dish.CookingTechnology)
                .IsRequired();

            modelBuilder.Entity<Ingredient>()
                .HasOne(i => i.Dish)
                .WithMany(dish => dish.Ingredients);
            /*            modelBuilder.Entity<Ingredient>()
                            .HasMany(i => i.Products)
                            .WithMany(p => p.Ingridients);*/
            modelBuilder.Entity<Ingredient>()
                .HasKey(i => i.Id);
            modelBuilder.Entity<Ingredient>()
                .Property(i => i.Name)
                .IsRequired()
                .HasMaxLength(30);
            modelBuilder.Entity<Ingredient>()
                .Property(i => i.WastePercent)
                .IsRequired();
            modelBuilder.Entity<Ingredient>()
                .Property(i => i.IngredientWaste)
                .IsRequired();
            modelBuilder.Entity<Ingredient>()
                .Property(i => i.CookingMethod)
                .IsRequired();

            modelBuilder.Entity<Product>()
                .HasMany(product => product.Ingredients)
                .WithMany(i => i.Products);
            modelBuilder.Entity<Product>()
                .HasKey(product => product.Id);
            modelBuilder.Entity<Product>()
                .Property(product => product.Name)
                .IsRequired()
                .HasMaxLength(30);
            modelBuilder.Entity<Product>()
                .Property(product => product.Weight)
                .IsRequired();

            modelBuilder.Entity<ProductNutrients>()
                .HasOne(pn => pn.Product)
                .WithMany(product => product.ProductNutrients);
            modelBuilder.Entity<ProductNutrients>()
                .HasKey(product => product.Id);
            modelBuilder.Entity<ProductNutrients>()
                .Property(pn => pn.ProductNutrientWeight);

            modelBuilder.Entity<DishNutrients>()
                .HasOne(dn => dn.Dish)
                .WithMany(dish => dish.DishNutrients);
            modelBuilder.Entity<DishNutrients>()
                .HasKey(dn => dn.Id);
            modelBuilder.Entity<DishNutrients>()
                .Property(dn => dn.DishNutrientWeight)
                .IsRequired();

            modelBuilder.Entity<NutrientsDirectory>()
                .HasMany(nd => nd.ProductNutrients)
                .WithOne(pn => pn.NutrientsDirectory);
            modelBuilder.Entity<NutrientsDirectory>()
                .HasMany(nd => nd.DishNutrients)
                .WithOne(dn => dn.NutrientsDirectory);
            modelBuilder.Entity<NutrientsDirectory>()
                .HasKey(nd => nd.Id);
            modelBuilder.Entity<NutrientsDirectory>()
                .Property(nd => nd.Name)
                .IsRequired()
                .HasMaxLength(30);
        }
    }
}