using Gwenchana.BussinessLogic;
using Gwenchana.DataAccess;
using Gwenchana.DataAccess.ViewModel;
using Gwenchana.LanguagePack;
using Gwenchana.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gwenchana
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
            UpdateComponent(LanguageClass.Language);
            this.DoubleBuffered = true; // Enable double buffering to reduce flickering
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

            regForm.ShowDialog();
            this.Hide();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = lb_ShowPassword.Checked ? '\0' : '*';
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
                        if (employee.TrangThai == "Đã nghỉ việc")
                        {
                            MessageBox.Show(
                                "Bạn đã nghỉ việc! Không thể đăng nhập vào ứng dụng.",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                            return;
                        }

                        EmployeeMenu employeeDashboard = new EmployeeMenu(id);
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
        private string currentCulture = "";
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (comboBox1.SelectedItem.ToString() == "Tiếng Việt")
            {
                currentCulture = "vi-vn";
                LanguageClass.Language = currentCulture;
            }
            else if (comboBox1.SelectedItem.ToString() == "English")
            {
                currentCulture = "en-us";
                LanguageClass.Language = currentCulture;
            }
            else if (comboBox1.SelectedItem.ToString() == "日本語")
            {
                currentCulture = "ja-jp";
                LanguageClass.Language = currentCulture;
            }
            UpdateComponent(LanguageClass.Language);
        }

        private void UpdateComponent(string language)
        {
            Resource.Culture = string.IsNullOrEmpty(language) ? null : new CultureInfo(language);
            lb_ShopName.Text = Resource.lb_ShopName;
            lb_ShopName.Left = (this.panel1.Width - lb_ShopName.Width) / 2; // Center the label
            lb_Sigup.Text = Resource.lb_Sigup;
            lb_Sigup.Left = (this.panel1.Width - lb_Sigup.Width) / 2; // Center the label
            btn_Sigup.Text = Resource.btn_Sigup;
            btn_Sigup.Left = (this.panel1.Width - btn_Sigup.Width) / 2; // Center the button

            btn_Login.Text = Resource.btn_Login;
            lb_ShowPassword.Text = Resource.lb_ShowPassword;
            lb_Username.Text = Resource.lb_Username;
            lb_Password.Text = Resource.lb_Password;
            lb_Language.Text = Resource.lb_Language;
            lb_Login.Text = Resource.lb_Login;

        }
    }
}
