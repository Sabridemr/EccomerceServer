using Eccomerce.Domain.Entities.Common;

namespace Eccomerce.Domain.Entities
{
    public class Order : BaseEntity
    {
        public string Description { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public ICollection<Product> Products { get; set; }
        public Customer Customer { get; set; }
    }
}