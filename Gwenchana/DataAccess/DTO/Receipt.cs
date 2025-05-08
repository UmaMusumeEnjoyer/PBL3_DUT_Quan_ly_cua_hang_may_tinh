using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gwenchana.DataAccess.DTO
{
    public class Receipt
    {
        public int Receipt_Id { get; set; }
        public int Customer_Id { get; set; }
        public int Employee_Id { get; set; }
        public DateTime receiptDate { get; set; }
    }
}
