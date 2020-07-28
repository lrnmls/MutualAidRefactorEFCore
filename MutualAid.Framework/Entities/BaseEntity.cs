using System;
using System.Collections.Generic;
using System.Text;

namespace MutualAid.Framework.Entities
{
    public abstract class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }
}
