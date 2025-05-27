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

        public bool CreateGoodsReceipt(int supplierId, Employee ce, List<Product> list)
        {
            return _goodsReceiptDAL.ImportProducts(supplierId ,ce.Empolyee_Id, list);
        }

        public DataTable GetAllGoodsReceiptsByID(int ID)
        {
            return _goodsReceiptDAL.GetAllGoodsReceiptsByID(ID);
        }

    }
}
