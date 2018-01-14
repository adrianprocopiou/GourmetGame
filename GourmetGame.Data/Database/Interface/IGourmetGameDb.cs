using System.Collections.Generic;
using GourmetGame.Domain.Entities;

namespace GourmetGame.Data.Database.Interface
{
    public interface IGourmetGameDb
    {
        ICollection<Category> Category { get; set; }
        ICollection<Dish> Dish { get; set; }
        ICollection<T> Collection<T>() where T : Entity;
    }
}