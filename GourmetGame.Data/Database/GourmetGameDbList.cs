using System;
using System.Collections.Generic;
using System.Linq;
using GourmetGame.Data.Database.Interface;
using GourmetGame.Domain.Entities;

namespace GourmetGame.Data.Database
{
    public class GourmetGameDbList : IGourmetGameDb
    {
        public GourmetGameDbList()
        {
            Category = new List<Category>();
            Dish = new List<Dish>();
            PopulateWithSeedData();
        }

        public ICollection<Category> Category { get; set; }
        public ICollection<Dish> Dish { get; set; }

        public ICollection<T> Collection<T>() where T : Entity
        {
            var typeT = typeof(T);
            var type = typeof(GourmetGameDbList);
            var property = type.GetProperties().FirstOrDefault(x => x.Name == typeT.Name);
            if (property == null)
                throw new ArgumentException("Invalid Entity for the database");
            return (ICollection<T>) property.GetValue(this);
        }

        private void PopulateWithSeedData()
        {
            Category.Add(new Category
                {
                    Name = "massa",
                    Dish = new List<Dish>
                    {
                        new Dish
                        {
                            Name = "Lasanha"
                        }
                    }
                }
            );
        }
    }
}