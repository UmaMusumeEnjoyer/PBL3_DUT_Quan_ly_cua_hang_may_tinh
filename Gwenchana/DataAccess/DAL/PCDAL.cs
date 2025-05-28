using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gwenchana.DataAccess.DTO;

namespace Gwenchana.DataAccess.DAL
{
    public class PCDAL
    {
        private readonly DBConnect.DbConnect _db = new DBConnect.DbConnect();

        public List<DTO.PC> GetAllPCs()
        {
            var list = new List<DTO.PC>();
            string sql = "select * from PC join Product on PC.Product_Id = Product.Product_Id";
            DataTable dt = _db.GetData(sql);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new DTO.PC
                {
                    Product_Id = Convert.ToInt32(row["Product_Id"]),
                    productName = row["productName"].ToString(),
                    price = Convert.ToDecimal(row["price"]),
                    stockQuantity = Convert.ToInt32(row["stockQuantity"]),
                    Spetification = row["specification"].ToString(),
                    Manufacturer = row["Manufacturer"].ToString(),
                    Supplier_Id = Convert.ToInt32(row["Supplier_Id"]),

                });
            }
            return list;
        }

        public DataTable GetAllPCsDataTable()
        {
            string sql = "SELECT " +
                "PC.Product_Id, " +
                "PRODUCT.productName, " +
                "PC.specification, " +
                "PRODUCT.Manufacturer, " +
                "PRODUCT.price, " +
                "Product.stockQuantity, " +
                "PRODUCT.Supplier_Id, " +
                "SUPPLIER.supplierName " +
                "FROM PC " +
                "JOIN Product ON PC.Product_Id = PRODUCT.Product_Id " +
                "JOIN Supplier ON PRODUCT.Supplier_Id = SUPPLIER.Supplier_Id";
            return _db.GetData(sql);
        }

        public bool UpdatePC(DTO.PC pc)
        {
            try
            {
                // Cập nhật thông tin trong bảng Product
                string sqlProduct = "UPDATE Product SET productName = @productName, Manufacturer = @Manufacturer, price = @price, stockQuantity = @stockQuantity WHERE Product_Id = @Product_Id";
                var parametersProduct = new[]
                {
                    new SqlParameter("@productName", pc.productName),
                    new SqlParameter("@Manufacturer", pc.Manufacturer),
                    new SqlParameter("@price", pc.price),
                    new SqlParameter("@stockQuantity", pc.stockQuantity),
                    new SqlParameter("@Product_Id", pc.Product_Id)
                };

                // Cập nhật thông tin trong bảng Laptop
                string sqlLaptop = "UPDATE PC SET specification = @specification WHERE Product_Id = @Product_Id";
                var parametersLaptop = new[]
                {
                    new SqlParameter("@specification", pc.Spetification),
                    new SqlParameter("@Product_Id", pc.Product_Id)
                };

                // Thực thi cả hai câu lệnh SQL trong một giao dịch
                return _db.ExecuteNonQuery(sqlProduct, parametersProduct) > 0 &&
                       _db.ExecuteNonQuery(sqlLaptop, parametersLaptop) > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool DeletePC(int id)
        {
            try
            {
                string sql = "DELETE FROM Product WHERE Product_Id = @Product_Id";
                SqlParameter[] parameters = {
                    new SqlParameter("@Product_Id", id)
                };
                return _db.ExecuteNonQuery(sql, parameters) > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool AddPC(PC pc, Product product)
        {
            using (var connection = _db.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // 1. Thêm vào bảng Product
                        var cmdProduct = new SqlCommand(
                            @"INSERT INTO Product (Supplier_Id, productName, price, stockQuantity, Manufacturer)
                              VALUES (@Supplier_Id, @productName, @price, @stockQuantity, @Manufacturer);
                              SELECT CAST(SCOPE_IDENTITY() as int);", connection, transaction);

                        cmdProduct.Parameters.AddWithValue("@Supplier_Id", product.Supplier_Id);
                        cmdProduct.Parameters.AddWithValue("@productName", product.productName);
                        cmdProduct.Parameters.AddWithValue("@price", product.price);
                        cmdProduct.Parameters.AddWithValue("@stockQuantity", product.stockQuantity);
                        cmdProduct.Parameters.AddWithValue("@Manufacturer", (object)product.Manufacturer ?? DBNull.Value);

                        int productId = Convert.ToInt32(cmdProduct.ExecuteScalar());

                        // 2. Thêm vào bảng PC (chú ý tên cột là specification)
                        var cmdPC = new SqlCommand(
                            @"INSERT INTO PC (Product_Id, specification)
                              VALUES (@Product_Id, @specification);", connection, transaction);

                        cmdPC.Parameters.AddWithValue("@Product_Id", productId);
                        cmdPC.Parameters.AddWithValue("@specification", (object)pc.Spetification ?? DBNull.Value);

                        cmdPC.ExecuteNonQuery();

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        // Nếu muốn hiển thị lỗi: MessageBox.Show(ex.Message);
                        return false;
                    }
                }
            }
        }
    }
}
