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
            Application.Exit();
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
                        Dashboard dashboard = new Dashboard();
                        this.Hide();
                        dashboard.ShowDialog();
                        this.Show();

                    }
                    else if (accountBLL.GetRole(username) == "Employee")
                    {
                        MessageBox.Show("Đăng nhập thành công!!!"
                        , "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
