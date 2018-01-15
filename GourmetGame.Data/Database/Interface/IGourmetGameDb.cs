using System.Collections.Generic;
using GourmetGame.Domain.Entities;

namespace GourmetGame.Data.Database.Interface
{
    public interface IGourmetGameDb
    {
        IList<Category> Category { get; set; }
        IList<T> Collection<T>() where T : Entity;
    }
}