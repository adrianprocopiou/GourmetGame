using System;

namespace GourmetGame.Application.ViewModel
{
    public class DishViewModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
    }
}