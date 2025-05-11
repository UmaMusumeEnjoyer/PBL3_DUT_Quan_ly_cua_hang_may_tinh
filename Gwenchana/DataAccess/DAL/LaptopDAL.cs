using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
                    productName = row["product_Name"].ToString(),
                    price = Convert.ToDecimal(row["price"]),
                    stockQuantity = Convert.ToInt32(row["stockQuantity"]),
                    Weight = Convert.ToInt32(row["weight"]),
                    screenSize = Convert.ToDecimal(row["screenSize"]),
                    Spectification = row["spectification"].ToString(),
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
    }
}
