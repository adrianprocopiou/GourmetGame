using System;

namespace GourmetGame.Domain.Entities
{
    public class Entity
    {
        public Entity()
        {
            Id = new Guid();
        }
        public Guid Id { get; }
    }
}