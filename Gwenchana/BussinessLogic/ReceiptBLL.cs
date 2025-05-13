using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gwenchana.DataAccess.DAL;
using System.Data;

namespace Gwenchana.BussinessLogic
{
    public class ReceiptBLL
    {
        private readonly ReceiptDAL _receiptDAL = new ReceiptDAL();
        //public List<DTO.Receipt> GetAllReceipts()
        //{
        //    return _receiptDAL.GetAllReceipts();
        //}
        //public DTO.Receipt GetReceiptById(int id)
        //{
        //    return _receiptDAL.GetReceiptById(id);
        //}
        public bool AddReceipt(Receipt receipt)
        {
            // _receiptDAL.AddReceipt(receipt);
            return true;
        }
        //public bool UpdateReceipt(DTO.Receipt receipt)
        //{
        //    return _receiptDAL.UpdateReceipt(receipt);
        //}
        //public bool DeleteReceipt(int id)
        //{
        //    return _receiptDAL.DeleteReceipt(id);
        //}
        public DataTable GetAllReceipts()
        {
            return _receiptDAL.GetAllReceipts();
        }
    }
}
