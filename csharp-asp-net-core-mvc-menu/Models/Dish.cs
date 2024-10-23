namespace csharp_asp_net_core_mvc_menu.Models
{
    public class Dish
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public double Price { get; set; }

        public List<DishIngredient>? DishIngredients { get; set; }
    }
}
