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
using Gwenchana.BussinessLogic;
using System.CodeDom.Compiler;

//using CuaHangMayTinh.UI.Authentication;

namespace Gwenchana
{
    public partial class information: Form
    {
        public int id { get; set; }
        public string temp { get; set; }
        //public CurrentEmployee employee { get; set; }
        public information(int employe)
        {
            InitializeComponent();
            id = employe;
            

            LoadData();
            

        }
        
        void LoadData()
        {
            txt_Name.Enabled = true;
            txt_Age.Enabled = true;
            txt_PhoneNumber.Enabled = true;
            txt_Username.Enabled = true;
            txt_Password.Enabled = true;
            button2.Visible = true;




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
            temp = "ChangeAccount";

            txt_Age.Enabled = false;
            txt_Name.Enabled = false;
            txt_PhoneNumber.Enabled = false;
            txt_Username.Enabled = true;
            txt_Password.Enabled = true;
            button2.Visible = false;
    
           
        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CurrentEmployee employee = new CurrentEmployee();
            employee.GetCurrentEmployee(id);
            if(txt_Age.Text == "" || txt_Name.Text == "" || txt_PhoneNumber.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }
            if (txt_Age.Text.Length > 3 || txt_Age.Text.Length < 1)
            {
                MessageBox.Show("Vui lòng nhập đúng độ tuổi");
                return;
            }
            if (txt_PhoneNumber.Text.Length > 11 || txt_PhoneNumber.Text.Length < 9)
            {
                MessageBox.Show("Vui lòng nhập đúng số điện thoại");
                return;
            }
            if (txt_Username.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin tài khoản");
                return;
            }


            if (temp == "ChangeAccount")
            {
                AccountBLL accountBLL = new AccountBLL();
                Account account = new Account()
                {
                    Id = employee.Account_Id,
                    Username = txt_Username.Text,
                    Password = txt_Password.Text,
                    Role = "Employee"
                };
                if (accountBLL.UpdateAccount(account))
                {
                    MessageBox.Show("Cập nhật thành công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
            else 
            {

                EmployeeBLL employeeBLL = new EmployeeBLL();
                Employee employee1 = new Employee()
                {
                    Empolyee_Id = employee.Employee_Id,
                    employeeName = txt_Name.Text,
                    Age = int.Parse(txt_Age.Text),
                    phoneNumber = txt_PhoneNumber.Text,
                    Account_Id = employee.Account_Id,
                    TrangThai = employee.TrangThai
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

        private void btn_ChangeAccount_Click(object sender, EventArgs e)
        {

        }
    }
}
