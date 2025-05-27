using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Gwenchana.DataAccess.DTO;
using System.Data.SqlClient;

namespace Gwenchana.DataAccess.DAL
{
    public class AccessoriesDAL
    {
        DBConnect.DbConnect db = new DBConnect.DbConnect();
        public List<DTO.Accessories> GetAllAccessories()
        {
            var list = new List<DTO.Accessories>();
            string sql = "select * from Accessories join Product on Accessories.Product_Id = Product.Product_Id";
            DataTable dt = db.GetData(sql);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new DTO.Accessories
                {
                    Product_Id = Convert.ToInt32(row["Product_Id"]),
                    productName = row["productName"].ToString(),
                    price = Convert.ToDecimal(row["price"]),
                    stockQuantity = Convert.ToInt32(row["stockQuantity"]),
                    Overview = row["overview"].ToString(),
                    Manufacturer = row["Manufacturer"].ToString(),
                    Type = row["type"].ToString(),
                });
            }
            return list;
        }

        public DataTable GetAllAccessoriesDataTable()
        {
            string sql = "SELECT Accessories.Product_Id, " +
                         "Product.productName, " +
                         "Product.Manufacturer, " +
                         "Accessories.overview, " +
                         "Accessories.type, " +
                         "Product.price, " +
                         "Product.stockQuantity, " +
                         "Product.Supplier_Id, " +
                         "Supplier.supplierName " +
                         "FROM Accessories " +
                         "JOIN Product ON Accessories.Product_Id = Product.Product_Id " +
                         "JOIN Supplier ON Product.Supplier_Id = Supplier.Supplier_Id";
            return db.GetData(sql);
        }

        public bool DeleteAccessories(int id) 
        {
            try
            {
                string sql = "DELETE FROM Accessories WHERE Product_Id = @Product_Id";
                var parameters = new[]
                {
                    new SqlParameter("@Product_Id", id)
                };
                return db.ExecuteNonQuery(sql, parameters) > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateAccessories(DTO.Accessories accessories)
        {
            try
            {
                // Cập nhật thông tin trong bảng Product
                string sqlProduct = "UPDATE Product SET productName = @productName, Manufacturer = @Manufacturer, price = @price, stockQuantity = @stockQuantity WHERE Product_Id = @Product_Id";
                var parametersProduct = new[]
                {
                    new SqlParameter("@productName", accessories.productName),
                    new SqlParameter("@Manufacturer", accessories.Manufacturer),
                    new SqlParameter("@price", accessories.price),
                    new SqlParameter("@stockQuantity", accessories.stockQuantity),
                    new SqlParameter("@Product_Id", accessories.Product_Id)
                };
                // Cập nhật thông tin trong bảng Accessories
                string sqlAccessories = "UPDATE Accessories SET overview = @overview, type = @type WHERE Product_Id = @Product_Id";
                var parametersAccessories = new[]
                {
                    new SqlParameter("@overview", accessories.Overview),
                    new SqlParameter("@type", accessories.Type),
                    new SqlParameter("@Product_Id", accessories.Product_Id)
                };
                // Thực thi cả hai câu lệnh SQL trong một giao dịch
                return db.ExecuteNonQuery(sqlProduct, parametersProduct) > 0 &&
                       db.ExecuteNonQuery(sqlAccessories, parametersAccessories) > 0;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }
    }
}
