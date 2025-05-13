using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Gwenchana.DataAccess.DBConnect;
using Gwenchana.DataAccess.DTO;

namespace Gwenchana.DataAccess.DAL
{
    public class ReceiptDAL
    {
        private readonly DBConnect.DbConnect _db = new DBConnect.DbConnect();
        public DataTable GetAllReceipts()
        {
            DataTable dt = new DataTable();

            string query = @"
        SELECT 
            r.Receipt_Id AS [Mã đơn xuất hàng],
            CONVERT(VARCHAR(10), r.receiptDate, 103) AS [Ngày xuất hàng], -- Định dạng DD/MM/YYYY
            e.employeeName AS [Tên nhân viên bán hàng],
            e.phoneNumber AS [Số điện thoại nhân viên],
            c.customerName AS [Tên khách hàng],
            c.phoneNumber AS [Số điện thoại khách hàng],
            c.address AS [Địa chỉ khách hàng],
            p.productName AS [Tên sản phẩm],
            p.Manufacturer AS [Hãng sản xuất],
            d.quantity AS [Số lượng],
            d.productPrice AS [Giá bán (VNĐ)],
            (d.quantity * d.productPrice) AS [Thành tiền (VNĐ)]
        FROM Receipt r
        JOIN Employee e ON r.Employee_Id = e.Employee_Id
        JOIN Customer c ON r.Customer_Id = c.Customer_Id
        JOIN Details d ON r.Receipt_Id = d.Receipt_Id
        JOIN Product p ON d.Product_Id = p.Product_Id
        ORDER BY r.receiptDate DESC, r.Receipt_Id, p.productName;
    ";

            using (SqlConnection conn = _db.GetConnection()) // giả sử bạn có hàm này
            {
                conn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(dt);
                }
            }

            return dt;
        }

        public bool AddReceipts()
        {
            return true;
        }

    }
}
