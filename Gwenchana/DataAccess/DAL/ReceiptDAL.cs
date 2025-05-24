using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Gwenchana.DataAccess.DBConnect;
using Gwenchana.DataAccess.DTO;
using Gwenchana.DataAccess.ViewModel;

namespace Gwenchana.DataAccess.DAL
{
    public class ReceiptDAL
    {
        private readonly DbConnect _db = new DbConnect();

        public DataTable GetAllReceipts()
        {
            DataTable dt = new DataTable();

            string query = @"
        SELECT 
            r.Receipt_Id,
            CONVERT(VARCHAR(10), r.receiptDate, 103) AS [Ngày xuất hàng], -- DD/MM/YYYY
            e.employeeName AS [Tên nhân viên],
            e.phoneNumber AS [SĐT nhân viên],
            c.customerName AS [Tên khách hàng],
            c.phoneNumber AS [SĐT khách hàng],
            c.address AS [Địa chỉ khách hàng],
            ISNULL(r.ReceiptTotal, 0) AS [Tổng tiền (VNĐ)]
        FROM Receipt r
        JOIN Employee e ON r.Employee_Id = e.Employee_Id
        JOIN Customer c ON r.Customer_Id = c.Customer_Id
        ORDER BY r.receiptDate DESC, r.Receipt_Id;
    ";

            using (SqlConnection conn = _db.GetConnection())
            {
                conn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(dt);
                }
            }

            return dt;
        }

        public DataTable GetAllReceiptsByID(int ID)
        {
            DataTable dt = new DataTable();

            string query = @"
                SELECT 
                    r.Receipt_Id AS [Mã đơn hàng],
                    CONVERT(VARCHAR(10), r.receiptDate, 103) AS [Ngày xuất hàng],
                    e.employeeName AS [Tên nhân viên],
                    c.customerName AS [Tên khách hàng],
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
                WHERE r.Receipt_Id = @ID;
            ";

            using (SqlConnection conn = _db.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public List<ReceiptViewModel> Getdetailreceipts ()
        {
            List<ReceiptViewModel> list = new List<ReceiptViewModel>();
            DataTable dt = new DataTable();

            string query = @"
        SELECT 
            r.Receipt_Id AS [Mã đơn hàng],
            CONVERT(VARCHAR(10), r.receiptDate, 103) AS [Ngày xuất hàng],
            e.employeeName AS [Tên nhân viên],
            c.customerName AS [Tên khách hàng],
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
       
    ";

            using (SqlConnection conn = _db.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            foreach (DataRow row in dt.Rows)
            {
                var detail = new ReceiptViewModel
                {
                    Receipt_Id = Convert.ToInt32(row["Mã đơn hàng"]),
                    ReceiptDate = row["Ngày xuất hàng"].ToString(),
                    EmployeeName = row["Tên nhân viên"].ToString(),
                    CustomerName = row["Tên khách hàng"].ToString(),
                    ProductName = row["Tên sản phẩm"].ToString(),
                    Manufacturer = row["Hãng sản xuất"].ToString(),
                    Quantity = Convert.ToInt32(row["Số lượng"]),
                    ProductPrice = Convert.ToDecimal(row["Giá bán (VNĐ)"]),
                    TotalPrice = Convert.ToDecimal(row["Thành tiền (VNĐ)"])
                };

                list.Add(detail);
            }

            return list;
        }





        public bool AddReceipts()
        {
            return true;
        }

        public bool CreateReceipt(Employee ce, Customer cs, List<Product> list)
        {
            try
            {
                using (SqlConnection conn = _db.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_CreateOrder", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@CustomerID", cs.Customer_Id);
                        cmd.Parameters.AddWithValue("@EmployeeID", ce.Empolyee_Id);

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
                System.Windows.Forms.MessageBox.Show("Lỗi khi tạo hóa đơn: " + ex.Message);
                return false;
            }
        }
    }
}
