using Gwenchana.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
namespace Gwenchana.DataAccess.DAL
{
    public class AccountDAL
    {
        private readonly DBConnect.DbConnect _db = new DBConnect.DbConnect();

        public List<Account> GetAllAccounts()
        {
            var list = new List<Account>(); 
            string sql = "SELECT * FROM Account";

            DataTable dt = _db.GetData(sql);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Account
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Username = row["Username"].ToString(),
                    Password = row["Password"].ToString(),
                   
                    Role = row["Role"].ToString()
                });
            }
            return list;
        }

        public Account GetAccountById(int id)
        {
            string sql = "SELECT * FROM Account WHERE Id = @Id";
            SqlParameter[] parameters = {
                new SqlParameter("@Id", id)
            };
            DataTable dt = _db.GetData(sql, parameters);
            if (dt.Rows.Count == 0) return null;
            DataRow row = dt.Rows[0];
            return new Account
            {
                Id = Convert.ToInt32(row["Id"]),
                Username = row["Username"].ToString(),
                Password = row["Password"].ToString(),
               
                Role = row["Role"].ToString()
            };
        }

        public bool AddAccount(Account account)
        {
            string sql = @"INSERT INTO Account (Username, Password, Role) 
                           VALUES (@Username, @Password, @Role)";
            SqlParameter[] parameters = {
                new SqlParameter("@Username", account.Username),
                new SqlParameter("@Password", account.Password),
              
                new SqlParameter("@Role", account.Role)
            };
            return _db.ExecuteNonQuery(sql, parameters) > 0;
        }

        public bool UpdateAccount(Account account)
        {
            string sql = @"UPDATE Account SET 
                            Username = @Username,
                            Password = @Password,
                            Role = @Role
                           WHERE Id = @Id";
            SqlParameter[] parameters = {
                new SqlParameter("@Username", account.Username),
                new SqlParameter("@Password", account.Password),
           
                new SqlParameter("@Role", account.Role),
                new SqlParameter("@Id", account.Id)
            };
            return _db.ExecuteNonQuery(sql, parameters) > 0;
        }

        public bool DeleteAccount(int id)
        {
            using (var connection = _db.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Bước 1: Cập nhật Account_Id của Employee về NULL
                        using (var updateCmd = new SqlCommand("UPDATE Employee SET Account_Id = NULL WHERE Account_Id = @Id", connection, transaction))
                        {
                            updateCmd.Parameters.AddWithValue("@Id", id);
                            updateCmd.ExecuteNonQuery();
                        }

                        // Bước 2: Xoá tài khoản trong bảng Account
                        using (var deleteCmd = new SqlCommand("DELETE FROM Account WHERE Id = @Id", connection, transaction))
                        {
                            deleteCmd.Parameters.AddWithValue("@Id", id);
                            int rowsAffected = deleteCmd.ExecuteNonQuery();

                            transaction.Commit();
                            return rowsAffected > 0;
                        }
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        public DataTable GetAllAccountDataTable()
        {
            string sql = "SELECT " +
                        "a.*, " +
                        "CASE WHEN EXISTS " +
                        "(SELECT 1 FROM employee e WHERE e.account_Id = a.id) THEN 'YES' " +
                        "ELSE 'NO' " +
                        "END AS TrangThaiTonTai " +
                        "FROM account a " +
                        "WHERE a.role <> 'admin'";
            return _db.GetData(sql);
        }

        public bool AssignEmployee(int id)
        {
            string sql = "INSERT INTO Employee (Account_Id) VALUES (@AccountId)";
            SqlParameter[] parameters = {
                new SqlParameter("@AccountId", id)
            };
            return _db.ExecuteNonQuery(sql, parameters) > 0;
        }

        public int GetID(string username)
        {
            string sql = "SELECT Id FROM Account WHERE Username = @Username";
            SqlParameter[] parameters = {
        new SqlParameter("@Username", username)
        };
            object result = _db.ExecuteScalar(sql, parameters);
            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result);
            }
            return -1; 
        }
    }
}
