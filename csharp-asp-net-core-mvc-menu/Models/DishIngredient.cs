﻿namespace csharp_asp_net_core_mvc_menu.Models
{
    public class DishIngredient
    {
        public int DishId { get; set; }
        
        public Dish Dish { get; set; }

        public int IngredientId { get; set; }

        public Ingredient Ingredient { get; set; }
    }
}
