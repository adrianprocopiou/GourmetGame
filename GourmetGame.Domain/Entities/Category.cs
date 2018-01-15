using System;

namespace GourmetGame.Domain.Entities
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
        public Dish Dish { get; set; }
    }
}