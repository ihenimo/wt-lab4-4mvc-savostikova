using Microsoft.AspNetCore.Mvc;
using wt_lab4_4mvc_savostikova.Models;
using wt_lab4_4mvc_savostikova.Data;

namespace wt_lab4_4mvc_savostikova.Controllers
{
    public class DishController : Controller
    {
        public IActionResult Index()
        {
            return View(DishesData.Dishes);
        }

        public IActionResult Details(int id)
        {
            var dish = DishesData.Dishes.FirstOrDefault(d => d.Id == id);
            if (dish == null) return NotFound();
            return View(dish);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Dish dish)
        {
            if (!ModelState.IsValid)
            {
                return View(dish);
            }

            dish.Id = DishesData.Dishes.Max(d => d.Id) + 1;
            DishesData.Dishes.Add(dish);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var dish = DishesData.Dishes.FirstOrDefault(d => d.Id == id);
            if (dish == null) return NotFound();
            return View(dish);
        }

        [HttpPost]
        public IActionResult Edit(Dish dish)
        {
            if (!ModelState.IsValid)
            {
                return View(dish);
            }

            var existing = DishesData.Dishes.FirstOrDefault(d => d.Id == dish.Id);
            if (existing != null)
            {
                existing.Name = dish.Name;
                existing.Category = dish.Category;
                existing.Price = dish.Price;
                existing.Description = dish.Description;
                existing.IsAvailable = dish.IsAvailable;
            }
            return RedirectToAction("Index");
        }

        // === НОВЫЕ МЕТОДЫ ДЛЯ УДАЛЕНИЯ ===
        public IActionResult Delete(int id)
        {
            var dish = DishesData.Dishes.FirstOrDefault(d => d.Id == id);
            if (dish == null) return NotFound();
            return View(dish);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var dish = DishesData.Dishes.FirstOrDefault(d => d.Id == id);
            if (dish != null)
            {
                DishesData.Dishes.Remove(dish);
            }
            return RedirectToAction("Index");
        }
    }
}