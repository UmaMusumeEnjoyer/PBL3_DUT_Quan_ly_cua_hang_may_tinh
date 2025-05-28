using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gwenchana.DataAccess;

using System.Data.SqlClient;
using Gwenchana.BussinessLogic;
using Gwenchana.DataAccess.ViewModel;

namespace Gwenchana
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }

        private void login_signupBtn_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
            this.Hide();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if(login_username.Text == ""
                || login_password.Text == "")
            {
                MessageBox.Show("Không được phép bỏ trống!!!"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string username = login_username.Text.Trim();
                string password = login_password.Text.Trim();

                AccountBLL accountBLL = new AccountBLL();

                if (accountBLL.Login(username, password))
                {

                    if(accountBLL.GetRole(username) == "Admin")
                    {
                        //Dashboard dashboard = new Dashboard();
                        EmployeeMenu1 dashboard = new EmployeeMenu1();
                        login_username.Text = "";
                        login_password.Text = "";
                        this.Hide();
                        dashboard.ShowDialog();
                        this.Show();

                    }
                    else if (accountBLL.GetRole(username) == "Employee")
                    {
                        int id = accountBLL.GetId(username);
                        EmployeeMenu employeeDashboard = new EmployeeMenu(id);

                        CurrentEmployee employee = new CurrentEmployee();

                        employee.GetCurrentEmployee(id);
                        if (employee.employeeName == null)
                        {
                            MessageBox.Show(
                                "Tài khoản chưa được cấp quyền. Vui lòng liên hệ với Admin để được gán.",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                            return;
                        }

                        login_username.Text = "";
                        login_password.Text = "";
                        this.Hide();
                        employeeDashboard.ShowDialog();
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!!!"
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
