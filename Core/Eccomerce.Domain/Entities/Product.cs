using Eccomerce.Domain.Entities.Common;

namespace Eccomerce.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public float Price { get; set; }
        public int Stock { get; set; }  
        public ICollection<Order> Orders { get; set; }
    }
}