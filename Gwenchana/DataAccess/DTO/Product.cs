using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gwenchana.DataAccess.DTO
{
    public class Product
    {
        public int Product_Id { get; set; }
        public int? Supplier_Id { get; set; }
        public string productName { get; set; }
        public decimal price { get; set; }
        public int stockQuantity { get; set; }
        public string Manufacturer { get; set; }
    }
}
