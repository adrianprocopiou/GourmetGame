﻿using System;

namespace GourmetGame.Domain.Entities
{
    public class Dish : Entity
    {
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
    }
}