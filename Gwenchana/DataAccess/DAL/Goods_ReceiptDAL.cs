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


        public DataTable GetAllGoodsReceiptsByID(int ID)
        {
            DataTable dt = new DataTable();

            string query = @"
SELECT 
    gr.GoodsReceipt_Id AS [Mã đơn nhập hàng],
    CONVERT(VARCHAR(10), gr.goodsReceiptDate, 103) AS [Ngày nhập hàng],
    e.employeeName AS [Tên nhân viên],
    s.supplierName AS [Tên nhà phân phối],
    p.productName AS [Tên sản phẩm],
    p.Manufacturer AS [Hãng sản xuất],
    d.quantity AS [Số lượng],
    d.productPrice AS [Giá nhập (VNĐ)],
    (d.quantity * d.productPrice) AS [Thành tiền (VNĐ)]
FROM Goods_Receipt gr
JOIN Employee e ON gr.Employee_Id = e.Employee_Id
JOIN Details d ON gr.GoodsReceipt_Id = d.GoodsReceipt_Id
JOIN Product p ON d.Product_Id = p.Product_Id
JOIN Supplier s ON p.Supplier_Id = s.Supplier_Id
WHERE gr.GoodsReceipt_Id = @ID;
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


        public bool ImportProducts(int supplierId, int employeeId, List<Product> products)
        {
            try
            {
                using (SqlConnection conn = _db.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ImportProducts", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Tham số đầu vào
                        cmd.Parameters.AddWithValue("@SupplierID", supplierId);
                        cmd.Parameters.AddWithValue("@EmployeeID", employeeId);

                        // Chuyển danh sách sản phẩm sang JSON format
                        string jsonProductList = Newtonsoft.Json.JsonConvert.SerializeObject(
                            products.Select(p => new
                            {
                                productId = p.Product_Id, // Lưu ý: key này phải trùng với định nghĩa trong procedure
                                quantity = p.quantity,
                                price = p.price
                            })
                        );
                        cmd.Parameters.AddWithValue("@ProductList", jsonProductList);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi khi nhập hàng: " + ex.Message);
                return false;
            }
        }


        public List<GoodsReceiptViewModel> GetAllGoodsReceiptDetails()
        {
            var list = new List<GoodsReceiptViewModel>();
            DbConnect _db1 = new DbConnect();
            using (SqlConnection conn = _db1.GetConnection())
            {
                string sql = @"
        SELECT
            gr.GoodsReceipt_Id,
            gr.goodsReceiptDate,
            e.employeeName,
            p.productName,
            p.Manufacturer,
            s.supplierName,
            d.quantity,
            d.productPrice,
            (d.quantity * d.productPrice) AS TotalAmount
        FROM Goods_Receipt gr
        JOIN Employee e ON gr.Employee_Id = e.Employee_Id
        JOIN Details d ON gr.GoodsReceipt_Id = d.GoodsReceipt_Id
        JOIN Product p ON d.Product_Id = p.Product_Id
        JOIN Supplier s ON p.Supplier_Id = s.Supplier_Id
        ";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new GoodsReceiptViewModel
                            {
                                GoodsReceiptId = reader.GetInt32(0),
                                GoodsReceiptDate = reader.GetDateTime(1),
                                EmployeeName = reader.GetString(2),
                                ProductName = reader.GetString(3),
                                Manufacturer = reader.GetString(4),
                                SupplierName = reader.GetString(5),
                                Quantity = reader.GetInt32(6),
                                ProductPrice = reader.GetDecimal(7),
                                TotalAmount = reader.GetDecimal(8)
                            });
                        }
                    }
                }
            }
            return list;
        }
    }


}
