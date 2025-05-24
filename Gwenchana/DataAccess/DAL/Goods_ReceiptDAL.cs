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
                gr.GoodsReceipt_Id AS [Mã phiếu nhập],
                gr.goodsReceiptDate AS [Ngày nhập hàng],
                e.employeeName AS [Tên nhân viên nhập],
                e.phoneNumber AS [Số điện thoại NV],
                p.Product_Id AS [Mã sản phẩm],
                p.productName AS [Tên sản phẩm],
                d.quantity AS [Số lượng nhập],
                d.productPrice AS [Giá nhập],
                (d.quantity * d.productPrice) AS [Thành tiền],
                s.supplierName AS [Nhà cung cấp],
                p.Manufacturer AS [Hãng sản xuất]
            FROM 
                [dbo].[Goods_Receipt] gr
            INNER JOIN 
                [dbo].[Employee] e ON gr.Employee_Id = e.Employee_Id
            INNER JOIN 
                [dbo].[Details] d ON gr.GoodsReceipt_Id = d.GoodsReceipt_Id
            INNER JOIN 
                [dbo].[Product] p ON d.Product_Id = p.Product_Id
            INNER JOIN 
                [dbo].[Supplier] s ON p.Supplier_Id = s.Supplier_Id
            ORDER BY 
                gr.goodsReceiptDate DESC, gr.GoodsReceipt_Id";

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
