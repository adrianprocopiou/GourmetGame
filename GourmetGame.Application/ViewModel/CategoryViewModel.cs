using System;

namespace GourmetGame.Application.ViewModel
{
    public class CategoryViewModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public bool IsCategorySelected { get; set; }
        public Guid CategoryId { get; set; }
        public DishViewModel Dish { get; set; }
    }
}