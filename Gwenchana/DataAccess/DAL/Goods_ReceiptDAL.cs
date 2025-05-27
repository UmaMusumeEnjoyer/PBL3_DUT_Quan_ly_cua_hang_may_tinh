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
        private readonly DBConnect.DbConnect _db = new DBConnect.DbConnect();
        public DataTable GetAllGoodsReceipt()
        {
            string query = @"
SELECT 
    gr.GoodsReceipt_Id AS [Mã đơn nhập hàng],
    CONVERT(VARCHAR(10), gr.goodsReceiptDate, 103) AS [Ngày nhập hàng],
    e.employeeName AS [Tên nhân viên],
    p.productName AS [Tên sản phẩm],
    p.Manufacturer AS [Hãng sản xuất],
    s.supplierName AS [Tên nhà phân phối],
    d.quantity AS [Số lượng],
    d.productPrice AS [Giá nhập (VNĐ)],
    (d.quantity * d.productPrice) AS [Thành tiền (VNĐ)]
FROM Goods_Receipt gr
JOIN Employee e ON gr.Employee_Id = e.Employee_Id
JOIN Details d ON gr.GoodsReceipt_Id = d.GoodsReceipt_Id
JOIN Product p ON d.Product_Id = p.Product_Id
JOIN Supplier s ON p.Supplier_Id = s.Supplier_Id";

            return _db.GetData(query);
        }

        public int InsertGoodsReceipt(int employeeId, DateTime receiptDate)
        {
            string query = @"INSERT INTO Goods_Receipt (Employee_Id, goodsReceiptDate) VALUES (@Employee_Id, @goodsReceiptDate); SELECT SCOPE_IDENTITY();";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Employee_Id", employeeId),
                new SqlParameter("@goodsReceiptDate", receiptDate)
            };
            object result = _db.ExecuteScalar(query, parameters);
            return Convert.ToInt32(result);
        }

        public void InsertGoodsReceiptDetails(int goodsReceiptId, List<Gwenchana.DataAccess.DTO.Details> detailsList)
        {
            foreach (var detail in detailsList)
            {
                string query = @"INSERT INTO Details (GoodsReceipt_Id, Product_Id, quantity, productPrice) VALUES (@GoodsReceipt_Id, @Product_Id, @quantity, @productPrice)";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@GoodsReceipt_Id", goodsReceiptId),
                    new SqlParameter("@Product_Id", detail.Product_Id),
                    new SqlParameter("@quantity", detail.quantity),
                    new SqlParameter("@productPrice", detail.productPrice)
                };
                _db.ExecuteNonQuery(query, parameters);
            }
        }

    }
}
