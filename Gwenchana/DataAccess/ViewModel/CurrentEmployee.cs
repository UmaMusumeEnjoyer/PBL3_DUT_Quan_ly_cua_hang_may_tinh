using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Gwenchana.DataAccess.ViewModel
{
    public class CurrentEmployee
    {
        public string username { get; set; }
        public string password { get; set; }
        public string employeeName { get; set; }
        public int? Age { get; set; }
        public string phoneNumber { get; set; }

        public int Employee_Id { get; set; }
        public int Account_Id { get; set; }

        private readonly DBConnect.DbConnect _db = new DBConnect.DbConnect();

        public void GetCurrentEmployee(int id)
        {
            string sql = "select * from Account join Employee on Account.Id = Employee.Account_Id and Account_Id = @Account_Id";
            SqlParameter[] parameters = {
                new SqlParameter("@Account_Id", id)
            };
            DataTable dt = _db.GetData(sql, parameters);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                this.Account_Id = Convert.ToInt32(row["Id"]);
                this.username = row["username"].ToString();
                this.password = row["password"].ToString();
           
                this.Employee_Id = Convert.ToInt32(row["Employee_Id"]);
                this.employeeName = row["employeeName"] == DBNull.Value ? "" : row["employeeName"].ToString();
                this.phoneNumber = row["phoneNumber"] == DBNull.Value ? "" : row["phoneNumber"].ToString();
                this.Age = row["age"] == DBNull.Value ? 0 : Convert.ToInt32(row["age"]);
                //this.employeeName = row["employeeName"].ToString();
            }
        }





    }
}
