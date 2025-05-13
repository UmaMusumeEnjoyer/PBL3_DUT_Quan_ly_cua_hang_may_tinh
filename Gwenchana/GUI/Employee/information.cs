using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gwenchana.DataAccess.DTO;
using Gwenchana.DataAccess.ViewModel;
using Gwenchana.DataAccess;
using Gwenchana.DataAccess.DBConnect;
using Gwenchana.DataAccess.ViewModel;
using Gwenchana.BussinessLogic;

//using CuaHangMayTinh.UI.Authentication;

namespace Gwenchana
{
    public partial class information: Form
    {
        public int id { get; set; }
        //public CurrentEmployee employee { get; set; }
        public information(int employe)
        {
            InitializeComponent();
            id = employe;

            LoadData();
            

        }
        
        void LoadData()
        {
            
            CurrentEmployee employee = new CurrentEmployee();
            employee.GetCurrentEmployee(id);
            txt_Name.Text = employee.employeeName;
            txt_Age.Text = employee.Age.ToString();
            txt_PhoneNumber.Text = employee.phoneNumber;
            txt_Username.Text = employee.username;
            txt_Password.Text = employee.password;
            

            txt_Username.Enabled = false;
            txt_Password.Enabled = false;

        }

        private void information_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ChangePass_Click(object sender, EventArgs e)
        {

        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CurrentEmployee employee = new CurrentEmployee();
            employee.GetCurrentEmployee(id);
            EmployeeBLL employeeBLL = new EmployeeBLL();
            Employee employee1 = new Employee()
            {
                Empolyee_Id = employee.Employee_Id,
                employeeName = txt_Name.Text,
                Age = int.Parse(txt_Age.Text),
                phoneNumber = txt_PhoneNumber.Text,
                Account_Id = employee.Account_Id
            };

            if (employeeBLL.UpdateEmployee(employee1))
            {
                MessageBox.Show("Cập nhật thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }
    }
}
