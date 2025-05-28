using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Gwenchana.DataAccess.DBConnect;
using Gwenchana.DataAccess.DTO;

namespace Gwenchana.DataAccess.DAL
{
    public class CustomerDAL
    {
        private readonly DBConnect.DbConnect _db = new DBConnect.DbConnect();
        public List<Customer> GetAllCustomers()
        {
            var list = new List<Customer>();
            string sql = "SELECT * FROM Customer";
            DataTable dt = _db.GetData(sql);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Customer
                {
                    Customer_Id = Convert.ToInt32(row["Customer_Id"]),
                    customerName = row["customerName"].ToString(),
                    email = row["email"].ToString(),
                    phoneNumber = row["phoneNumber"].ToString(),
                    address = row["address"].ToString()
                });
            }
            return list;
        }

        public DataTable GetAllCustomersDataTable()
        {
            string sql = "SELECT c.*, COUNT(r.Receipt_Id) AS SoDonDaThucHien FROM Customer c LEFT JOIN Receipt r ON c.Customer_Id = r.Customer_Id GROUP BY c.Customer_Id, c.customerName, c.phoneNumber, c.address, c.email";
            DataTable dt = _db.GetData(sql);
            return dt;
        }

        public bool AddCustomer(Customer customer)
        {
            string sql = @"INSERT INTO Customer (customerName, email, phoneNumber, address) 
                           VALUES (@Name, @Email, @PhoneNumber, @Address)";
            SqlParameter[] parameters = {
                new SqlParameter("@Name", customer.customerName),
                new SqlParameter("@Email", customer.email),
                new SqlParameter("@PhoneNumber", customer.phoneNumber),
                new SqlParameter("@Address", customer.address)
            };
            int result = _db.ExecuteNonQuery(sql, parameters);
            return result > 0;
        }
        public bool UpdateCustomer(Customer customer)
        {
            string sql = @"UPDATE Customer 
                           SET customerName = @Name, email = @Email, phoneNumber = @PhoneNumber, address = @Address 
                           WHERE Customer_Id = @Id";
            SqlParameter[] parameters = {
                new SqlParameter("@Id", customer.Customer_Id),
                new SqlParameter("@Name", customer.customerName),
                new SqlParameter("@Email", customer.email),
                new SqlParameter("@PhoneNumber", customer.phoneNumber),
                new SqlParameter("@Address", customer.address)
            };
            int result = _db.ExecuteNonQuery(sql, parameters);
            return result > 0;
        }
    }
}
