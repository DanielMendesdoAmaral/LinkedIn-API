using System;
using System.ComponentModel.DataAnnotations;

namespace Shared.Entities
{
    public abstract class Entity
    {
        [Key]
        public Guid Id { get; private set; }
        public DateTime DataCriacao { get; private set; }

        public Entity()
        {
            Id = Guid.NewGuid();
            DataCriacao = DateTime.Now;
        }
    }
}
