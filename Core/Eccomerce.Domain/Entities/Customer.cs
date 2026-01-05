using System;
using Eccomerce.Domain.Entities.Common;

namespace Eccomerce.Domain.Entities
{
    public class Customer:BaseEntity
    {
        public ICollection<Order> Orders { get; set; }
        public string Name { get; set; } = string.Empty;

    }
}