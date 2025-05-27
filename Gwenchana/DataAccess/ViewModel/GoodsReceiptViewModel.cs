using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gwenchana.DataAccess.ViewModel
{
    public class GoodsReceiptViewModel
    {
        public int GoodsReceiptId { get; set; }
        public DateTime GoodsReceiptDate { get; set; }
        public string EmployeeName { get; set; }
        public string ProductName { get; set; }
        public string Manufacturer { get; set; }
        public string SupplierName { get; set; }
        public int Quantity { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
