namespace csharp_asp_net_core_mvc_menu.Models
{
    public class Ingredient
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<DishIngredient>? DishIngredients { get; set; }
    }
}
