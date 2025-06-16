
namespace Gwenchana
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Sigup = new System.Windows.Forms.Button();
            this.lb_ShowPassword = new System.Windows.Forms.CheckBox();
            this.signup_password = new System.Windows.Forms.TextBox();
            this.lb_Password = new System.Windows.Forms.Label();
            this.signup_username = new System.Windows.Forms.TextBox();
            this.lb_Username = new System.Windows.Forms.Label();
            this.lb_SignUp = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_ShopName = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lb_Login = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Sigup
            // 
            this.btn_Sigup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.btn_Sigup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sigup.FlatAppearance.BorderSize = 0;
            this.btn_Sigup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btn_Sigup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btn_Sigup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sigup.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sigup.ForeColor = System.Drawing.Color.White;
            this.btn_Sigup.Location = new System.Drawing.Point(294, 292);
            this.btn_Sigup.Name = "btn_Sigup";
            this.btn_Sigup.Size = new System.Drawing.Size(93, 34);
            this.btn_Sigup.TabIndex = 3;
            this.btn_Sigup.Text = "ĐĂNG KÝ";
            this.btn_Sigup.UseVisualStyleBackColor = false;
            this.btn_Sigup.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // lb_ShowPassword
            // 
            this.lb_ShowPassword.AutoSize = true;
            this.lb_ShowPassword.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ShowPassword.Location = new System.Drawing.Point(443, 253);
            this.lb_ShowPassword.Name = "lb_ShowPassword";
            this.lb_ShowPassword.Size = new System.Drawing.Size(117, 20);
            this.lb_ShowPassword.TabIndex = 2;
            this.lb_ShowPassword.Text = "Hiện mật khẩu";
            this.lb_ShowPassword.UseVisualStyleBackColor = true;
            this.lb_ShowPassword.CheckedChanged += new System.EventHandler(this.signup_showPass_CheckedChanged);
            // 
            // signup_password
            // 
            this.signup_password.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_password.Location = new System.Drawing.Point(294, 217);
            this.signup_password.Multiline = true;
            this.signup_password.Name = "signup_password";
            this.signup_password.PasswordChar = '*';
            this.signup_password.Size = new System.Drawing.Size(261, 30);
            this.signup_password.TabIndex = 1;
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Password.Location = new System.Drawing.Point(291, 197);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(72, 17);
            this.lb_Password.TabIndex = 14;
            this.lb_Password.Text = "Mật khẩu";
            // 
            // signup_username
            // 
            this.signup_username.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_username.Location = new System.Drawing.Point(294, 153);
            this.signup_username.Multiline = true;
            this.signup_username.Name = "signup_username";
            this.signup_username.Size = new System.Drawing.Size(261, 30);
            this.signup_username.TabIndex = 0;
            // 
            // lb_Username
            // 
            this.lb_Username.AutoSize = true;
            this.lb_Username.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Username.Location = new System.Drawing.Point(291, 133);
            this.lb_Username.Name = "lb_Username";
            this.lb_Username.Size = new System.Drawing.Size(112, 17);
            this.lb_Username.TabIndex = 12;
            this.lb_Username.Text = "Tên đăng nhập";
            // 
            // lb_SignUp
            // 
            this.lb_SignUp.AutoSize = true;
            this.lb_SignUp.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SignUp.Location = new System.Drawing.Point(290, 60);
            this.lb_SignUp.Name = "lb_SignUp";
            this.lb_SignUp.Size = new System.Drawing.Size(199, 25);
            this.lb_SignUp.TabIndex = 11;
            this.lb_SignUp.Text = "Đăng ký tài khoản";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(551, 7);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(17, 18);
            this.exit.TabIndex = 10;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(90)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lb_ShopName);
            this.panel1.Controls.Add(this.btn_Login);
            this.panel1.Controls.Add(this.lb_Login);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 400);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Gwenchana.Properties.Resources.Trường_Đại_học_Bách_khoa__Đại_học_Đà_Nẵng_svg__1_;
            this.pictureBox2.Location = new System.Drawing.Point(31, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(198, 148);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_ShopName
            // 
            this.lb_ShopName.AutoSize = true;
            this.lb_ShopName.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ShopName.ForeColor = System.Drawing.Color.White;
            this.lb_ShopName.Location = new System.Drawing.Point(17, 213);
            this.lb_ShopName.Name = "lb_ShopName";
            this.lb_ShopName.Size = new System.Drawing.Size(233, 27);
            this.lb_ShopName.TabIndex = 2;
            this.lb_ShopName.Text = "Cửa hàng máy tính";
            this.lb_ShopName.Click += new System.EventHandler(this.label6_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(22, 356);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(226, 31);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "ĐĂNG NHẬP";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.signup_loginBtn_Click);
            // 
            // lb_Login
            // 
            this.lb_Login.AutoSize = true;
            this.lb_Login.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Login.ForeColor = System.Drawing.Color.White;
            this.lb_Login.Location = new System.Drawing.Point(24, 337);
            this.lb_Login.Name = "lb_Login";
            this.lb_Login.Size = new System.Drawing.Size(224, 16);
            this.lb_Login.TabIndex = 0;
            this.lb_Login.Text = "Đăng nhập vào tài khoản của bạn";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(575, 400);
            this.Controls.Add(this.btn_Sigup);
            this.Controls.Add(this.lb_ShowPassword);
            this.Controls.Add(this.signup_password);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.signup_username);
            this.Controls.Add(this.lb_Username);
            this.Controls.Add(this.lb_SignUp);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Sigup;
        private System.Windows.Forms.CheckBox lb_ShowPassword;
        private System.Windows.Forms.TextBox signup_password;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.TextBox signup_username;
        private System.Windows.Forms.Label lb_Username;
        private System.Windows.Forms.Label lb_SignUp;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_ShopName;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lb_Login;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}