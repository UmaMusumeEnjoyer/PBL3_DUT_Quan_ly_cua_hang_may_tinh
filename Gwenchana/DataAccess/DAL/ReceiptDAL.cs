using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Gwenchana.DataAccess.DBConnect;
using Gwenchana.DataAccess.DTO;
using Gwenchana.DataAccess.ViewModel;
using System.Windows.Forms;
using System.ComponentModel;

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

        public bool createReceipt(Employee ce, Customer cs, List<Product> list)
        {
            try
            {
                using (SqlConnection conn = _db.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_CreateOrder", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        cmd.Parameters.AddWithValue("@CustomerID", cs.Customer_Id);
                        cmd.Parameters.AddWithValue("@EmployeeID", ce.Empolyee_Id);
                        //cmd.Parameters.AddWithValue("@EmployeeID", ce.Empolyee_Id);

                        // Chuyển list sản phẩm thành chuỗi JSON
                        string jsonProductList = Newtonsoft.Json.JsonConvert.SerializeObject(
                            list.Select(p => new
                            {
                                productId = p.Product_Id,
                                quantity = p.quantity,
                                price = p.price
                            })
                        );

                        cmd.Parameters.AddWithValue("@ProductList", jsonProductList);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo hóa đơn: " + ex.Message);
                return false;
            }
        }


    }
}
