using Gwenchana.BussinessLogic;
using Gwenchana.LanguagePack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gwenchana
{
    public partial class RegisterForm : Form
    {

        public RegisterForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Enable double buffering to reduce flickering
            UpdateComponent(LanguageClass.Language);
        }

        private void UpdateComponent(string language)
        {
            Resource.Culture = string.IsNullOrEmpty(language) ? null : new CultureInfo(language);
            lb_ShopName.Text = Resource.lb_ShopName;
            lb_ShopName.Left = (this.panel1.Width - lb_ShopName.Width) / 2;
            lb_Login.Text = Resource.lb_Login;
            lb_Login.Left = (this.panel1.Width - lb_Login.Width) / 2;
            btn_Login.Text = Resource.btn_Login;
            lb_SignUp.Text = Resource.lb_SignUp;
            lb_Username.Text = Resource.lb_Username;
            lb_Password.Text = Resource.lb_Password;
            lb_ShowPassword.Text = Resource.lb_ShowPassword;
            lb_SignUp.Text = Resource.lb_SignUp;
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
            signup_password.PasswordChar = lb_ShowPassword.Checked ? '\0' : '*';
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
