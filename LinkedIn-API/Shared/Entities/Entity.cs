using System;

namespace Shared.Entities
{
    public abstract class Entity
    {
        public Guid Id { get; private set; }
        public DateTime DataCriacao { get; private set; }

        public Entity()
        {
            Id = Guid.NewGuid();
            DataCriacao = DateTime.Now;
        }
    }
}
