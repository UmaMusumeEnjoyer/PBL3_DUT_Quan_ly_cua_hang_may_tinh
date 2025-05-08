using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gwenchana.DataAccess.DTO
{
    public class Goods_Receipt
    {
        public int GoodsReceipt_Id { get; set; }
        public int Employee_Id { get; set; }
        public DateTime GoodsReceiptDate { get; set; }
    }
}
