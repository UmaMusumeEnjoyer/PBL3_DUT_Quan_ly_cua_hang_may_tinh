using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Gwenchana.DataAccess.DTO;
using Gwenchana.DataAccess.DAL;

namespace Gwenchana.BussinessLogic
{
    public class Goods_ReceiptBLL
    {
        private readonly Goods_ReceiptDAL _goodsReceiptDAL = new Goods_ReceiptDAL();
        public DataTable GetAllGoodsReceipt()
        {
            return _goodsReceiptDAL.GetAllGoodsReceipt();
        }
    }
}
