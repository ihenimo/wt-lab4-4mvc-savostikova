using System.ComponentModel.DataAnnotations;

namespace wt_lab4_4mvc_savostikova.Models
{
    public class Dish
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Введите название блюда")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Введите категорию")]
        public string Category { get; set; } = string.Empty;

        [Range(1, 10000, ErrorMessage = "Цена должна быть от 1 до 10000")]
        public decimal Price { get; set; }

        public bool IsAvailable { get; set; }

        public string Description { get; set; } = string.Empty;
    }
}