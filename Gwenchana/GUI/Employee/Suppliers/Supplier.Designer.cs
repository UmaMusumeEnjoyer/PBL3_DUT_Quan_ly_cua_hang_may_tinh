
using System.Drawing;
using System.Windows.Forms;

namespace Gwenchana
{
    partial class PetView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_supplierManagement = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePetList = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lb_supplierSearch = new System.Windows.Forms.Label();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabPagePetDetail = new System.Windows.Forms.TabPage();
            this.lb_Email = new System.Windows.Forms.Label();
            this.txt_SupplierEmail = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lb_Address = new System.Windows.Forms.Label();
            this.txt_SupplierAddress = new System.Windows.Forms.TextBox();
            this.lb_PhoneNumber = new System.Windows.Forms.Label();
            this.txt_SupplierPhone = new System.Windows.Forms.TextBox();
            this.lb_Name = new System.Windows.Forms.Label();
            this.txt_SupplierName = new System.Windows.Forms.TextBox();
            this.lb_Id = new System.Windows.Forms.Label();
            this.txtPetId = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPagePetList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabPagePetDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_supplierManagement
            // 
            this.lb_supplierManagement.AutoSize = true;
            this.lb_supplierManagement.Font = new System.Drawing.Font("JetBrains Mono", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_supplierManagement.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_supplierManagement.Location = new System.Drawing.Point(4, 9);
            this.lb_supplierManagement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_supplierManagement.Name = "lb_supplierManagement";
            this.lb_supplierManagement.Size = new System.Drawing.Size(247, 43);
            this.lb_supplierManagement.TabIndex = 0;
            this.lb_supplierManagement.Text = "Nhà cung cấp";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(162)))), ((int)(((byte)(161)))));
            this.panel1.Controls.Add(this.lb_supplierManagement);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 56);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePetList);
            this.tabControl1.Controls.Add(this.tabPagePetDetail);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(892, 411);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPagePetList
            // 
            this.tabPagePetList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(162)))), ((int)(((byte)(161)))));
            this.tabPagePetList.Controls.Add(this.dataGridView);
            this.tabPagePetList.Controls.Add(this.lb_supplierSearch);
            this.tabPagePetList.Controls.Add(this.btn_Edit);
            this.tabPagePetList.Controls.Add(this.btn_Add);
            this.tabPagePetList.Controls.Add(this.btn_Search);
            this.tabPagePetList.Controls.Add(this.txtSearch);
            this.tabPagePetList.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagePetList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tabPagePetList.Location = new System.Drawing.Point(4, 30);
            this.tabPagePetList.Name = "tabPagePetList";
            this.tabPagePetList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePetList.Size = new System.Drawing.Size(884, 377);
            this.tabPagePetList.TabIndex = 0;
            this.tabPagePetList.Text = "Danh sách";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.GridColor = System.Drawing.Color.Black;
            this.dataGridView.Location = new System.Drawing.Point(24, 63);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(737, 306);
            this.dataGridView.TabIndex = 7;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // lb_supplierSearch
            // 
            this.lb_supplierSearch.AutoSize = true;
            this.lb_supplierSearch.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_supplierSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_supplierSearch.Location = new System.Drawing.Point(19, 3);
            this.lb_supplierSearch.Name = "lb_supplierSearch";
            this.lb_supplierSearch.Size = new System.Drawing.Size(265, 25);
            this.lb_supplierSearch.TabIndex = 5;
            this.lb_supplierSearch.Text = "Tìm kiếm nhà cung cấp :";
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(155)))));
            this.btn_Edit.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Edit.Location = new System.Drawing.Point(767, 314);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(99, 55);
            this.btn_Edit.TabIndex = 3;
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(155)))));
            this.btn_Add.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Add.Location = new System.Drawing.Point(767, 236);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(99, 55);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(155)))));
            this.btn_Search.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Search.Location = new System.Drawing.Point(668, 27);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(110, 33);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(24, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(638, 33);
            this.txtSearch.TabIndex = 0;
            // 
            // tabPagePetDetail
            // 
            this.tabPagePetDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(221)))));
            this.tabPagePetDetail.Controls.Add(this.lb_Email);
            this.tabPagePetDetail.Controls.Add(this.txt_SupplierEmail);
            this.tabPagePetDetail.Controls.Add(this.btnCancel);
            this.tabPagePetDetail.Controls.Add(this.btnSave);
            this.tabPagePetDetail.Controls.Add(this.lb_Address);
            this.tabPagePetDetail.Controls.Add(this.txt_SupplierAddress);
            this.tabPagePetDetail.Controls.Add(this.lb_PhoneNumber);
            this.tabPagePetDetail.Controls.Add(this.txt_SupplierPhone);
            this.tabPagePetDetail.Controls.Add(this.lb_Name);
            this.tabPagePetDetail.Controls.Add(this.txt_SupplierName);
            this.tabPagePetDetail.Controls.Add(this.lb_Id);
            this.tabPagePetDetail.Controls.Add(this.txtPetId);
            this.tabPagePetDetail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagePetDetail.Location = new System.Drawing.Point(4, 30);
            this.tabPagePetDetail.Name = "tabPagePetDetail";
            this.tabPagePetDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePetDetail.Size = new System.Drawing.Size(884, 377);
            this.tabPagePetDetail.TabIndex = 1;
            this.tabPagePetDetail.Text = "Chi tiết";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email.Location = new System.Drawing.Point(59, 234);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(89, 25);
            this.lb_Email.TabIndex = 17;
            this.lb_Email.Text = "Email :";
            // 
            // txt_SupplierEmail
            // 
            this.txt_SupplierEmail.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SupplierEmail.Location = new System.Drawing.Point(63, 263);
            this.txt_SupplierEmail.Name = "txt_SupplierEmail";
            this.txt_SupplierEmail.Size = new System.Drawing.Size(380, 33);
            this.txt_SupplierEmail.TabIndex = 16;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(155)))));
            this.btnCancel.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Location = new System.Drawing.Point(260, 304);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(183, 44);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(155)))));
            this.btnSave.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Location = new System.Drawing.Point(63, 304);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(183, 44);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lb_Address
            // 
            this.lb_Address.AutoSize = true;
            this.lb_Address.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Address.Location = new System.Drawing.Point(59, 170);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(111, 25);
            this.lb_Address.TabIndex = 13;
            this.lb_Address.Text = "Địa chỉ :";
            // 
            // txt_SupplierAddress
            // 
            this.txt_SupplierAddress.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SupplierAddress.Location = new System.Drawing.Point(63, 198);
            this.txt_SupplierAddress.Name = "txt_SupplierAddress";
            this.txt_SupplierAddress.Size = new System.Drawing.Size(380, 33);
            this.txt_SupplierAddress.TabIndex = 12;
            // 
            // lb_PhoneNumber
            // 
            this.lb_PhoneNumber.AutoSize = true;
            this.lb_PhoneNumber.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PhoneNumber.Location = new System.Drawing.Point(490, 97);
            this.lb_PhoneNumber.Name = "lb_PhoneNumber";
            this.lb_PhoneNumber.Size = new System.Drawing.Size(177, 25);
            this.lb_PhoneNumber.TabIndex = 11;
            this.lb_PhoneNumber.Text = "Số điện thoại :";
            // 
            // txt_SupplierPhone
            // 
            this.txt_SupplierPhone.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SupplierPhone.Location = new System.Drawing.Point(495, 125);
            this.txt_SupplierPhone.Name = "txt_SupplierPhone";
            this.txt_SupplierPhone.Size = new System.Drawing.Size(223, 33);
            this.txt_SupplierPhone.TabIndex = 10;
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.Location = new System.Drawing.Point(59, 97);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(67, 25);
            this.lb_Name.TabIndex = 9;
            this.lb_Name.Text = "Tên :";
            // 
            // txt_SupplierName
            // 
            this.txt_SupplierName.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SupplierName.Location = new System.Drawing.Point(63, 125);
            this.txt_SupplierName.Name = "txt_SupplierName";
            this.txt_SupplierName.Size = new System.Drawing.Size(380, 33);
            this.txt_SupplierName.TabIndex = 8;
            // 
            // lb_Id
            // 
            this.lb_Id.AutoSize = true;
            this.lb_Id.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Id.Location = new System.Drawing.Point(59, 26);
            this.lb_Id.Name = "lb_Id";
            this.lb_Id.Size = new System.Drawing.Size(56, 25);
            this.lb_Id.TabIndex = 7;
            this.lb_Id.Text = "Mã :";
            this.lb_Id.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPetId
            // 
            this.txtPetId.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPetId.Location = new System.Drawing.Point(63, 54);
            this.txtPetId.Name = "txtPetId";
            this.txtPetId.Size = new System.Drawing.Size(154, 33);
            this.txtPetId.TabIndex = 6;
            this.txtPetId.TextChanged += new System.EventHandler(this.txtPetId_TextChanged);
            // 
            // PetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 467);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PetView";
            this.Text = "Nhà cung cấp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPagePetList.ResumeLayout(false);
            this.tabPagePetList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabPagePetDetail.ResumeLayout(false);
            this.tabPagePetDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_supplierManagement;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePetList;
        private System.Windows.Forms.Label lb_supplierSearch;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TabPage tabPagePetDetail;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lb_Address;
        private System.Windows.Forms.TextBox txt_SupplierAddress;
        private System.Windows.Forms.Label lb_PhoneNumber;
        private System.Windows.Forms.TextBox txt_SupplierPhone;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.TextBox txt_SupplierName;
        private System.Windows.Forms.Label lb_Id;
        private System.Windows.Forms.TextBox txtPetId;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.TextBox txt_SupplierEmail;
    }
}