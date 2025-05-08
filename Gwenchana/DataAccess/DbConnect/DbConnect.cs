using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gwenchana.DataAccess.DBConnect
{
    public class DbConnect
    {
        private static readonly string connectionString = "Server=ADMIN-PC;Database=PBL3;Integrated Security=True";


        // Chạy truy vấn SQL và trả về DataTable
        public DataTable GetData(string sql, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        conn.Open();
                        using (var da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetData Error] {ex.Message}");
                throw new DataException("Database operation failed", ex);
            }
            return dt;
        }


        //Số dòng bị ảnh hưởng bởi câu lệnh SQL
        public int ExecuteNonQuery(string sql, SqlParameter[] parameters = null)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        conn.Open();
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ExecuteNonQuery Error] {ex.Message}");
                throw new DataException("Database operation failed", ex);
            }
        }


        //Trả về giá trị đầu tiên trong kết quả của câu lệnh SQL
        public object ExecuteScalar(string sql, SqlParameter[] parameters = null)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        conn.Open();
                        return cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ExecuteScalar Error] {ex.Message}");
                throw new DataException("Database operation failed", ex);
            }
        }

        //Thực thi stored procedure và trả về 1 giá trị đơn. Vd: Max, Min,...
        protected object ExecuteSpScalar(string sp, SqlParameter[] parameters = null)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand(sp, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }

        //Thực thi một hành động trong một giao dịch
        public void ExecuteTransaction(Action<SqlConnection, SqlTransaction> action)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        action(conn, tran);
                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }


        //Thực thi stored procedure và trả về DataTable
        protected DataTable ExecuteSp(string sp, SqlParameter[] parameters = null)
        {
            var dt = new DataTable();
            using (var conn = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand(sp, conn))
                {
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (parameters != null) cmd.Parameters.AddRange(parameters);

                        conn.Open();
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        //Thực thi stored procedure và trả về số dòng bị ảnh hưởng
        protected int ExecuteSpNonQuery(string sp, SqlParameter[] parameters = null)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand(sp, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
