using wt_lab4_4mvc_savostikova.Models;

namespace wt_lab4_4mvc_savostikova.Data
{
    public static class DishesData
    {
        public static List<Dish> Dishes = new List<Dish>
        {
            new Dish { Id = 1, Name = "Пицца Маргарита", Category = "Пицца", Price = 25, IsAvailable = true, Description = "Томатный соус, моцарелла, базилик" },
            new Dish { Id = 2, Name = "Суши Филадельфия", Category = "Суши", Price = 35, IsAvailable = true, Description = "Лосось, сливочный сыр, огурец" },
            new Dish { Id = 3, Name = "Бургер Классик", Category = "Бургеры", Price = 18, IsAvailable = true, Description = "Говяжья котлета, сыр, соус" },
            new Dish { Id = 4, Name = "Цезарь с курицей", Category = "Салаты", Price = 15, IsAvailable = false, Description = "Курица, романо, пармезан, сухарики" },
            new Dish { Id = 5, Name = "Тирамису", Category = "Десерты", Price = 12, IsAvailable = true, Description = "Маскарпоне, кофе, какао" }
        };
    }
}