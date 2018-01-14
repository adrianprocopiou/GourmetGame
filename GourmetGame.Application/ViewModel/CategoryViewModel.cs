using System.Collections.Generic;

namespace GourmetGame.Application.ViewModel
{
    public class CategoryViewModel
    {
        public string Name { get; set; }
        public List<DishViewModel> Dish { get; set; }
        public List<CategoryViewModel> SubCategories { get; set; }
    }
}