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
            PopulateWithSeedData();
        }

        public IList<Category> Category { get; set; }

        public IList<T> Collection<T>() where T : Entity
        {
            var typeT = typeof(T);
            var type = typeof(GourmetGameDbList);
            var property = type.GetProperties().FirstOrDefault(x => x.Name == typeT.Name);
            if (property == null)
                throw new ArgumentException("Invalid Entity for the database");
            return (IList<T>) property.GetValue(this);
        }

        private void PopulateWithSeedData()
        {
            var categoryDefault = new Category {Id = Guid.NewGuid(), Name = "massa"};
            categoryDefault.Dish = new Dish {CategoryId = categoryDefault.Id, Id = Guid.NewGuid(), Name = "Lasanha"};
            Category.Add(categoryDefault);
        }
    }
}