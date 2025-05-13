using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Gwenchana.DataAccess.DBConnect;

namespace Gwenchana.DataAccess.DAL
{
    public class Goods_ReceiptDAL
    {
        DbConnect db = new DbConnect();
        public DataTable GetAllGoodsReceipt()
        {
            string sql = "SELECT * FROM Goods_Receipt";
            return db.GetData(sql);
        }

    }
}
