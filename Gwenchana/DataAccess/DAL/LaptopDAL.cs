using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Gwenchana.DataAccess.DBConnect;
using Gwenchana.DataAccess.DTO;
using System.Diagnostics;
using System.Drawing;

namespace Gwenchana.DataAccess.DAL
{
    public class LaptopDAL
    {
        private readonly DBConnect.DbConnect _db = new DBConnect.DbConnect();
        public List<DTO.Laptop> GetAllLaptops()
        {
            var list = new List<DTO.Laptop>();
            string sql = "select * from Laptop join Product on Laptop.Product_Id = Product.Product_Id";
            DataTable dt = _db.GetData(sql);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new DTO.Laptop
                {
                    Product_Id = Convert.ToInt32(row["Product_Id"]),
                    productName = row["productName"].ToString(),
                    price = Convert.ToDecimal(row["price"]),
                    stockQuantity = Convert.ToInt32(row["stockQuantity"]),
                    Weight = Convert.ToDecimal(row["weight"]),
                    screenSize = row["screenSize"].ToString(),
                    Spectification = row["specification"].ToString(),
                    Colour = row["colour"].ToString(),
                    Manufacturer = row["Manufacturer"].ToString(),
                });
            }
            return list;
        }

        public DataTable GetAllLaptopsDataTable()
        {
            string sql = "SELECT Product.Product_Id, " +
                         "Product.productName, " +
                         "Product.Manufacturer, " +
                         "Laptop.specification, " +
                         "Laptop.weight, " +
                         "Laptop.screenSize, " +
                         "Laptop.colour, " +
                         "Product.price, " +
                         "Product.stockQuantity, " +
                         "Product.Supplier_Id, " +
                         "Supplier.supplierName " +
                         "FROM Laptop " +
                         "JOIN Product ON Laptop.Product_Id = Product.Product_Id " +
                         "JOIN Supplier ON Product.Supplier_Id = Supplier.Supplier_Id";
            return _db.GetData(sql);
        }

        public bool UpdateLaptop(DTO.Laptop laptop)
        {
            try
            {
                // Cập nhật thông tin trong bảng Product
                string sqlProduct = "UPDATE Product SET productName = @productName, Manufacturer = @Manufacturer, price = @price, stockQuantity = @stockQuantity WHERE Product_Id = @Product_Id";
                var parametersProduct = new[]
                {
                    new SqlParameter("@productName", laptop.productName),
                    new SqlParameter("@Manufacturer", laptop.Manufacturer),
                    new SqlParameter("@price", laptop.price),
                    new SqlParameter("@stockQuantity", laptop.stockQuantity),
                    new SqlParameter("@Product_Id", laptop.Product_Id)
                };

                // Cập nhật thông tin trong bảng Laptop
                string sqlLaptop = "UPDATE Laptop SET weight = @weight, screenSize = @screenSize, specification = @specification, colour = @colour WHERE Product_Id = @Product_Id";
                var parametersLaptop = new[]
                {
                    new SqlParameter("@weight", laptop.Weight),
                    new SqlParameter("@screenSize", laptop.screenSize),
                    new SqlParameter("@specification", laptop.Spectification),
                    new SqlParameter("@colour", laptop.Colour),
                    new SqlParameter("@Product_Id", laptop.Product_Id)
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

        public bool DeleteLaptop(int id)
        {
            try
            {
                string sql = "DELETE FROM Laptop WHERE Product_Id = @Product_Id";
                var parameters = new[]
                {
                    new SqlParameter("@Product_Id", id)
                };
                return _db.ExecuteNonQuery(sql, parameters) > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool AddLaptop(DTO.Laptop laptop, DTO.Product product)
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

                        // 2. Thêm vào bảng Laptop
                        var cmdLaptop = new SqlCommand(
                            @"INSERT INTO Laptop (Product_Id, weight, screenSize, specification, colour)
                      VALUES (@Product_Id, @weight, @screenSize, @specification, @colour);", connection, transaction);

                        cmdLaptop.Parameters.AddWithValue("@Product_Id", productId);
                        cmdLaptop.Parameters.AddWithValue("@weight", laptop.Weight);
                        cmdLaptop.Parameters.AddWithValue("@screenSize", (object)laptop.screenSize ?? DBNull.Value);
                        cmdLaptop.Parameters.AddWithValue("@specification", (object)laptop.Spectification ?? DBNull.Value);
                        cmdLaptop.Parameters.AddWithValue("@colour", (object)laptop.Colour ?? DBNull.Value);

                        cmdLaptop.ExecuteNonQuery();

                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }
    }
}
