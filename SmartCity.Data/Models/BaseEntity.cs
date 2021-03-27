using System;

namespace SmartCity.Data.Models
{
    public abstract class BaseEntity
    {
        public virtual Guid Id { get; set; }
    }
}