using csharp_asp_net_core_mvc_menu.Models;
using Microsoft.EntityFrameworkCore;
namespace csharp_asp_net_core_mvc_menu.Data
{
    public class MenuContext : DbContext
    {
        public MenuContext( DbContextOptions<MenuContext> options ) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DishIngredient>().HasKey(di => new { di.DishId, di.IngredientId });

            modelBuilder.Entity<DishIngredient>()
                          .HasOne(di => di.Dish)
                          .WithMany(d => d.DishIngredients)
                          .HasForeignKey(di => di.DishId);

            modelBuilder.Entity<DishIngredient>().HasOne(di => di.Ingredient)
                        .WithMany(i => i.DishIngredients)
                        .HasForeignKey(di => di.IngredientId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
