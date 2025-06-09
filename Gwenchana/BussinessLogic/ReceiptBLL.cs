using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gwenchana.DataAccess.DAL;
using System.Data;
using Gwenchana.DataAccess.ViewModel;
using Gwenchana.DataAccess.DTO;

namespace Gwenchana.BussinessLogic
{
    public class ReceiptBLL
    {
        private readonly ReceiptDAL _receiptDAL = new ReceiptDAL();
        public bool AddReceipt()
        {
             return _receiptDAL.AddReceipts();
            
        }
        public DataTable GetAllReceipts()
        {
            return _receiptDAL.GetAllReceipts();
        }
        public DataTable GetAllReceiptsByID(int ID)
        {
            return _receiptDAL.GetAllReceiptsByID(ID);
        }
        public bool createReceipt(Employee ce, Customer cs, List<Product> list, decimal finalTotal)
        {
            return _receiptDAL.CreateReceipt(ce, cs, list, finalTotal);
        }
        public List<ReceiptViewModel> getallreceipts()
        {
            return _receiptDAL.Getdetailreceipts();
        }
    }
}
