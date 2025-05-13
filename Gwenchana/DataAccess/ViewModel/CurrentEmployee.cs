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
        public string employeeName { get; set; }
        public int? Age { get; set; }
        public string phoneNumber { get; set; }

        public int? Account_Id { get; set; }

        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        //public string Role { get; set; }

        private readonly DBConnect.DbConnect _db = new DBConnect.DbConnect();

        public CurrentEmployee getCurrentEmployee(int id)
        {
            
            string sql = "SELECT" +
                "E.[Employee_Id] AS [Id]," +
                "E.[employeeName]," +
                "E.[age] AS [Age]," +
                "E.[phoneNumber]," +
                "E.[Account_Id]," +
                "A.[username] AS [Username]," +
                "A.[password] AS [Password]" +
                "FROM" +
                "[dbo].[Employee] E" +
                "LEFT JOIN " +
                "[dbo].[Account] A ON E.[Account_Id] = A.[@Id];";

            SqlParameter[] parameters = {
                new SqlParameter("@Id", id)
            };
            DataTable dataTable = _db.GetData(sql);
            CurrentEmployee currentEmployee = new CurrentEmployee()
            {
                employeeName = dataTable.Rows[0]["employeeName"].ToString(),
                Age = Convert.ToInt32(dataTable.Rows[0]["Age"]),
                phoneNumber = dataTable.Rows[0]["phoneNumber"].ToString(),
                Account_Id = Convert.ToInt32(dataTable.Rows[0]["Account_Id"]),
                Id = Convert.ToInt32(dataTable.Rows[0]["Id"]),
                Username = dataTable.Rows[0]["Username"].ToString(),
                Password = dataTable.Rows[0]["Password"].ToString()
            };
            return currentEmployee;
        }
        
       
    }
}
