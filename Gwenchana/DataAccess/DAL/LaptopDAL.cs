using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

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
            string sql = "select Product.Product_Id, PRODUCT.productName,PRODUCT.Manufacturer, Laptop.specification, " +
                "Laptop.weight,Laptop.screenSize, Laptop.colour,PRODUCT.price, PRODUCT.stockQuantity " +
                "from Laptop join Product on Laptop.Product_Id = Product.Product_Id";
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
    }
}
