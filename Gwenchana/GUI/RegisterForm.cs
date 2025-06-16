using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;
using System.Data.SqlClient;
using Gwenchana.BussinessLogic;

namespace Gwenchana
{
    public partial class RegisterForm : Form
    {

        public RegisterForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Enable double buffering to reduce flickering
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

        private void signup_loginBtn_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if(signup_username.Text == ""
                || signup_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string username = signup_username.Text.Trim();
                string password = signup_password.Text.Trim();
                AccountBLL accountBLL = new AccountBLL();
                if (accountBLL.Register(username, password, "Employee"))
                {
                    MessageBox.Show("Đăng ký thành công"
                        , "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Login loginForm = new Login();
                    loginForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username đã tồn tại!!!"
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void signup_showPass_CheckedChanged(object sender, EventArgs e)
        {
            signup_password.PasswordChar = signup_showPass.Checked ? '\0' : '*';
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
