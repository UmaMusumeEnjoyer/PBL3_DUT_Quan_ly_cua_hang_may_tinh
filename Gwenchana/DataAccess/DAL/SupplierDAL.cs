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
    public class SupplierDAL
    {
        private readonly DBConnect.DbConnect _db = new DBConnect.DbConnect();

        public List<Supplier> GetAllSuppliers()
        {
            var list = new List<DTO.Supplier>();
            string sql = "SELECT * FROM Supplier";
            DataTable dt = _db.GetData(sql);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new DTO.Supplier
                {
                    Supplier_Id = Convert.ToInt32(row["Supplier_Id"]),
                    supplierName = row["supplierName"].ToString(),
                    phoneNumber = row["phoneNumber"].ToString(),
                    address = row["address"].ToString(),
                    email = row["email"].ToString()
                });
            }
            return list;
        }

        public Supplier GetSupplierById(int id)
        {
            string sql = "SELECT * FROM Supplier WHERE Supplier_Id = @Supplier_Id";
            SqlParameter[] parameters = {
                new SqlParameter("@Supplier_Id", id)
            };
            DataTable dt = _db.GetData(sql, parameters);
            if (dt.Rows.Count == 0) return null;
            DataRow row = dt.Rows[0];
            return new Supplier
            {
                Supplier_Id = Convert.ToInt32(row["Supplier_Id"]),
                supplierName = row["supplierName"].ToString(),
                phoneNumber = row["phoneNumber"].ToString(),
                address = row["address"].ToString(),
                email = row["email"].ToString()
            };
        }

        public bool AddSupplier(Supplier supplier)
        {
            string sql = @"INSERT INTO Supplier (supplierName, phoneNumber, address, email) 
                           VALUES (@supplierName, @phoneNumber, @address, @email)";
            SqlParameter[] parameters = {
                new SqlParameter("@supplierName", supplier.supplierName),
                new SqlParameter("@phoneNumber", supplier.phoneNumber),
                new SqlParameter("@address", supplier.address),
                new SqlParameter("@email", supplier.email)
            };
            return _db.ExecuteNonQuery(sql, parameters) > 0;
        }

        public bool UpdateSupplier(Supplier supplier)
        {
            string sql = @"UPDATE Supplier 
                           SET supplierName = @supplierName, phoneNumber = @phoneNumber, address = @address, email = @email 
                           WHERE Supplier_Id = @Supplier_Id";
            SqlParameter[] parameters = {
                new SqlParameter("@Supplier_Id", supplier.Supplier_Id),
                new SqlParameter("@supplierName", supplier.supplierName),
                new SqlParameter("@phoneNumber", supplier.phoneNumber),
                new SqlParameter("@address", supplier.address),
                new SqlParameter("@email", supplier.email)
            };
            return _db.ExecuteNonQuery(sql, parameters) > 0;
        }

        public bool DeleteSupplier(int id)
        {
            // Kiểm tra còn Product nào tham chiếu không
            string checkProduct = "SELECT COUNT(*) FROM Product WHERE Supplier_Id = @Supplier_Id";
            SqlParameter[] parameters = { new SqlParameter("@Supplier_Id", id) };
            int count = (int)_db.ExecuteScalar(checkProduct, parameters);
            if (count > 0)
            {
                // Còn sản phẩm, không cho xoá
                return false;
            }

            // Nếu không còn, thực hiện xoá
            string sql = "DELETE FROM Supplier WHERE Supplier_Id = @Supplier_Id";
            return _db.ExecuteNonQuery(sql, parameters) > 0;
        }

        public DataTable GetAllSuppliersDataTable()
        {
            string sql = "SELECT * FROM Supplier";
            return _db.GetData(sql);
        }
    }
}
