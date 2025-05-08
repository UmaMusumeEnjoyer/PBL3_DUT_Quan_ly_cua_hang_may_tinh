using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gwenchana.DataAccess.DTO
{
    public class Details
    {
        public int Details_Id { get; set; }
        public int? GoodsReceipt_Id { get; set; }
        public int? Receipt_Id { get; set; }
        public int Product_Id { get; set; }
        public int quantity { get; set; }
        public decimal productPrice { get; set; }

    }
}
