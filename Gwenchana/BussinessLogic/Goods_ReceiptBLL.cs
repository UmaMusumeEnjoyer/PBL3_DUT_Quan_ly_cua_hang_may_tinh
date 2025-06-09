using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Gwenchana.DataAccess.DTO;
using Gwenchana.DataAccess.DAL;
using Gwenchana.DataAccess.ViewModel;

namespace Gwenchana.BussinessLogic
{
    public class Goods_ReceiptBLL
    {
        private readonly Goods_ReceiptDAL _goodsReceiptDAL = new Goods_ReceiptDAL();
        public DataTable GetAllGoodsReceipt()
        {
            return _goodsReceiptDAL.GetAllGoodsReceipt();
        }
        public bool CreateGoodsReceipt(Employee ce, List<ProductViewModel> list)
        {
            return _goodsReceiptDAL.ImportProducts(ce.Empolyee_Id, list);
        }
        public DataTable GetAllGoodsReceiptsByID(int ID)
        {
            return _goodsReceiptDAL.GetAllGoodsReceiptsByID(ID);
        }
        public List<GoodsReceiptViewModel> GetAllGoodsReceiptDetails()
        {
            return _goodsReceiptDAL.GetAllGoodsReceiptDetails();
        }

    }
}
