using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eccomerce.Application.ViewModels.Products
{
    public class VM_Create_Product
    {
        public string Name { get; set; } = string.Empty;
        public float Price { get; set; }
        public int Stock { get; set; }
    }
}