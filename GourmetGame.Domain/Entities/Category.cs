using System.Collections.Generic;

namespace GourmetGame.Domain.Entities
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public Dish Dish { get; set; }
        public ICollection<Category> SubCategories { get; set; }
    }
}