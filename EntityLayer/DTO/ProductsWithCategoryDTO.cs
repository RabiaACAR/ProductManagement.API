using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.DTO
{
    public class ProductsWithCategoryDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public decimal UnitPrice { get; set; }
        public int Stock { get; set; }

        public bool isActive { get; set; }
    }
}
