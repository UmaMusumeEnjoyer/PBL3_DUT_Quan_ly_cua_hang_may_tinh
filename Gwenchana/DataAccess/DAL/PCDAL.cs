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
            string sql = "select " +
                "PC.Product_Id, " +
                "PRODUCT.productName," +
                "PC.specification, " +
                "PRODUCT.Manufacturer, " +
                "PRODUCT.price, " +
                "Product.stockQuantity  " +
                "from PC join Product on PC.Product_Id = PRODUCT.Product_Id";
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
    }
}
