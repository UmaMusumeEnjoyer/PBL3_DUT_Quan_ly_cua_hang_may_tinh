using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Gwenchana.DataAccess.DAL
{
    public class ProductDAL
    {
        private readonly DBConnect.DbConnect _db = new DBConnect.DbConnect();
        public List<DTO.Product> GetAllProducts()
        {
            var list = new List<DTO.Product>();
            string sql = "SELECT * FROM Product";
            DataTable dt = _db.GetData(sql);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new DTO.Product
                {
                    Product_Id = Convert.ToInt32(row["Product_Id"]),
                    Supplier_Id = Convert.ToInt32(row["Supplier_Id"]),
                    productName = row["productName"].ToString(),
                    price = Convert.ToDecimal(row["price"]),
                    stockQuantity = Convert.ToInt32(row["stockQuantity"]),
                    Manufacturer = row["Manufacturer"].ToString(),
                });
            }
            return list;

        }
        public DataTable GetAllProductsDataTable()
        {
            string sql = "SELECT * FROM Product";
            return _db.GetData(sql);
        }
        public DTO.Product GetProduct(int productId) 
        {
            string sql = "SELECT * FROM Product WHERE Product_Id = @Product_Id";
            SqlParameter[] parameters = {
                new SqlParameter("@Product_Id", productId)
            };
            DataTable dt = _db.GetData(sql, parameters);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new DTO.Product
                {
                    Product_Id = Convert.ToInt32(row["Product_Id"]),
                    Supplier_Id = Convert.ToInt32(row["Supplier_Id"]),
                    productName = row["productName"].ToString(),
                    price = Convert.ToDecimal(row["price"]),
                    stockQuantity = Convert.ToInt32(row["stockQuantity"]),
                    Manufacturer = row["Manufacturer"].ToString(),
                };
            }
            return null;
        }
    }
}
