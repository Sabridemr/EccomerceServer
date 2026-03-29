using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eccomerce.Application.ViewModels.Products
{
    public class VM_Update_Product
    {
        public string Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public float Price { get; set; }
        public int Stock { get; set; }
    }
}