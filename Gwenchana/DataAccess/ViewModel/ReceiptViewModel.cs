using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gwenchana.DataAccess.ViewModel
{
    public class ReceiptViewModel
    {
        public int Receipt_Id { get; set; }
        public string ReceiptDate { get; set; }
        public string EmployeeName { get; set; }
        public string CustomerName { get; set; }
        public string ProductName { get; set; }
        public string Manufacturer { get; set; }
        public int Quantity { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }


}
