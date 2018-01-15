using System;
using System.Collections.Generic;
using System.Linq;
using GourmetGame.Domain.Entities;
using GourmetGame.Domain.Repository.Interface;

namespace GourmetGame.Data.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public override IEnumerable<Category> GetAll()
        {
            return _dbSet.Where(x => x.CategoryId == default(Guid));
        }
    }
}