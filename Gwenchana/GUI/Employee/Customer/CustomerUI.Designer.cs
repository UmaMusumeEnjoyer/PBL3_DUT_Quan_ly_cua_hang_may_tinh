
namespace Gwenchana
{
    partial class CustomerUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_CustomerManagement = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePetList = new System.Windows.Forms.TabPage();
            this.btn_Details = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_ClearFilter = new System.Windows.Forms.Button();
            this.lb_SearchFilters = new System.Windows.Forms.Label();
            this.cbb_LaptopSearch = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lb_Search = new System.Windows.Forms.Label();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabPagePetDetail = new System.Windows.Forms.TabPage();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lb_Email = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lb_OrderMade = new System.Windows.Forms.Label();
            this.txt_sodondathuchien = new System.Windows.Forms.TextBox();
            this.lb_Address = new System.Windows.Forms.Label();
            this.btn_Address = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lb_PhoneNumber = new System.Windows.Forms.Label();
            this.txt_phoneNumber = new System.Windows.Forms.TextBox();
            this.lb_CustomerName = new System.Windows.Forms.Label();
            this.txt_LaptopName = new System.Windows.Forms.TextBox();
            this.lb_ID = new System.Windows.Forms.Label();
            this.txt_LaptopID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPagePetList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabPagePetDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_CustomerManagement
            // 
            this.lb_CustomerManagement.AutoSize = true;
            this.lb_CustomerManagement.Font = new System.Drawing.Font("JetBrains Mono", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CustomerManagement.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_CustomerManagement.Location = new System.Drawing.Point(4, 9);
            this.lb_CustomerManagement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_CustomerManagement.Name = "lb_CustomerManagement";
            this.lb_CustomerManagement.Size = new System.Drawing.Size(399, 43);
            this.lb_CustomerManagement.TabIndex = 0;
            this.lb_CustomerManagement.Text = "Thông tin khách hàng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(162)))), ((int)(((byte)(161)))));
            this.panel1.Controls.Add(this.lb_CustomerManagement);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 56);
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
            this.tabControl1.Size = new System.Drawing.Size(866, 411);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPagePetList
            // 
            this.tabPagePetList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(162)))), ((int)(((byte)(161)))));
            this.tabPagePetList.Controls.Add(this.btn_Details);
            this.tabPagePetList.Controls.Add(this.btn_Add);
            this.tabPagePetList.Controls.Add(this.btn_ClearFilter);
            this.tabPagePetList.Controls.Add(this.lb_SearchFilters);
            this.tabPagePetList.Controls.Add(this.cbb_LaptopSearch);
            this.tabPagePetList.Controls.Add(this.dataGridView);
            this.tabPagePetList.Controls.Add(this.lb_Search);
            this.tabPagePetList.Controls.Add(this.btn_Edit);
            this.tabPagePetList.Controls.Add(this.btn_Search);
            this.tabPagePetList.Controls.Add(this.txtSearch);
            this.tabPagePetList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagePetList.Location = new System.Drawing.Point(4, 30);
            this.tabPagePetList.Name = "tabPagePetList";
            this.tabPagePetList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePetList.Size = new System.Drawing.Size(858, 377);
            this.tabPagePetList.TabIndex = 0;
            this.tabPagePetList.Text = "Danh sách";
            // 
            // btn_Details
            // 
            this.btn_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(155)))));
            this.btn_Details.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Details.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Details.Location = new System.Drawing.Point(741, 297);
            this.btn_Details.Name = "btn_Details";
            this.btn_Details.Size = new System.Drawing.Size(99, 70);
            this.btn_Details.TabIndex = 12;
            this.btn_Details.Text = "Chi tiết";
            this.btn_Details.UseVisualStyleBackColor = false;
            this.btn_Details.Click += new System.EventHandler(this.btn_ChiTiet_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(155)))));
            this.btn_Add.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Add.Location = new System.Drawing.Point(741, 229);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(99, 37);
            this.btn_Add.TabIndex = 11;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_addCustomer_Click);
            // 
            // btn_ClearFilter
            // 
            this.btn_ClearFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ClearFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(155)))));
            this.btn_ClearFilter.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClearFilter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ClearFilter.Location = new System.Drawing.Point(747, 0);
            this.btn_ClearFilter.Name = "btn_ClearFilter";
            this.btn_ClearFilter.Size = new System.Drawing.Size(78, 35);
            this.btn_ClearFilter.TabIndex = 10;
            this.btn_ClearFilter.Text = "Xoá";
            this.btn_ClearFilter.UseVisualStyleBackColor = false;
            this.btn_ClearFilter.Click += new System.EventHandler(this.btn_ClearFilter_Click);
            // 
            // lb_SearchFilters
            // 
            this.lb_SearchFilters.AutoSize = true;
            this.lb_SearchFilters.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SearchFilters.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_SearchFilters.Location = new System.Drawing.Point(473, 7);
            this.lb_SearchFilters.Name = "lb_SearchFilters";
            this.lb_SearchFilters.Size = new System.Drawing.Size(122, 25);
            this.lb_SearchFilters.TabIndex = 9;
            this.lb_SearchFilters.Text = "Tiêu chí :";
            // 
            // cbb_LaptopSearch
            // 
            this.cbb_LaptopSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(90)))));
            this.cbb_LaptopSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_LaptopSearch.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_LaptopSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbb_LaptopSearch.FormattingEnabled = true;
            this.cbb_LaptopSearch.Items.AddRange(new object[] {
            "Tên",
            "Số điện thoại"});
            this.cbb_LaptopSearch.Location = new System.Drawing.Point(601, 2);
            this.cbb_LaptopSearch.Name = "cbb_LaptopSearch";
            this.cbb_LaptopSearch.Size = new System.Drawing.Size(140, 33);
            this.cbb_LaptopSearch.TabIndex = 8;
            this.cbb_LaptopSearch.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cbb_LaptopSearch.TextUpdate += new System.EventHandler(this.cbb_LaptopSearch_TextUpdate);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.GridColor = System.Drawing.Color.Black;
            this.dataGridView.Location = new System.Drawing.Point(24, 73);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(711, 296);
            this.dataGridView.TabIndex = 7;
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Search.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_Search.Location = new System.Drawing.Point(22, 12);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(133, 25);
            this.lb_Search.TabIndex = 5;
            this.lb_Search.Text = "Tìm kiếm : ";
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(155)))));
            this.btn_Edit.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Edit.Location = new System.Drawing.Point(741, 162);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(99, 36);
            this.btn_Edit.TabIndex = 3;
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(155)))));
            this.btn_Search.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Search.Location = new System.Drawing.Point(642, 37);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(124, 33);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(24, 41);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(612, 29);
            this.txtSearch.TabIndex = 0;
            // 
            // tabPagePetDetail
            // 
            this.tabPagePetDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(221)))));
            this.tabPagePetDetail.Controls.Add(this.btn_Back);
            this.tabPagePetDetail.Controls.Add(this.lb_Email);
            this.tabPagePetDetail.Controls.Add(this.txt_Email);
            this.tabPagePetDetail.Controls.Add(this.lb_OrderMade);
            this.tabPagePetDetail.Controls.Add(this.txt_sodondathuchien);
            this.tabPagePetDetail.Controls.Add(this.lb_Address);
            this.tabPagePetDetail.Controls.Add(this.btn_Address);
            this.tabPagePetDetail.Controls.Add(this.btn_Cancel);
            this.tabPagePetDetail.Controls.Add(this.btn_Save);
            this.tabPagePetDetail.Controls.Add(this.lb_PhoneNumber);
            this.tabPagePetDetail.Controls.Add(this.txt_phoneNumber);
            this.tabPagePetDetail.Controls.Add(this.lb_CustomerName);
            this.tabPagePetDetail.Controls.Add(this.txt_LaptopName);
            this.tabPagePetDetail.Controls.Add(this.lb_ID);
            this.tabPagePetDetail.Controls.Add(this.txt_LaptopID);
            this.tabPagePetDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagePetDetail.Location = new System.Drawing.Point(4, 30);
            this.tabPagePetDetail.Name = "tabPagePetDetail";
            this.tabPagePetDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePetDetail.Size = new System.Drawing.Size(858, 377);
            this.tabPagePetDetail.TabIndex = 1;
            this.tabPagePetDetail.Text = "Thông tin chi tiết";
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(155)))));
            this.btn_Back.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Back.Location = new System.Drawing.Point(667, 304);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(183, 44);
            this.btn_Back.TabIndex = 22;
            this.btn_Back.Text = "Quay lại";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email.Location = new System.Drawing.Point(311, 170);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(89, 25);
            this.lb_Email.TabIndex = 21;
            this.lb_Email.Text = "Email :";
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(316, 198);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(307, 33);
            this.txt_Email.TabIndex = 20;
            // 
            // lb_OrderMade
            // 
            this.lb_OrderMade.AutoSize = true;
            this.lb_OrderMade.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_OrderMade.Location = new System.Drawing.Point(311, 92);
            this.lb_OrderMade.Name = "lb_OrderMade";
            this.lb_OrderMade.Size = new System.Drawing.Size(243, 25);
            this.lb_OrderMade.TabIndex = 19;
            this.lb_OrderMade.Text = "Số đơn đã thực hiện :";
            // 
            // txt_sodondathuchien
            // 
            this.txt_sodondathuchien.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sodondathuchien.Location = new System.Drawing.Point(316, 120);
            this.txt_sodondathuchien.Name = "txt_sodondathuchien";
            this.txt_sodondathuchien.Size = new System.Drawing.Size(183, 33);
            this.txt_sodondathuchien.TabIndex = 18;
            // 
            // lb_Address
            // 
            this.lb_Address.AutoSize = true;
            this.lb_Address.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Address.Location = new System.Drawing.Point(58, 235);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(111, 25);
            this.lb_Address.TabIndex = 17;
            this.lb_Address.Text = "Địa chỉ :";
            // 
            // btn_Address
            // 
            this.btn_Address.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Address.Location = new System.Drawing.Point(63, 263);
            this.btn_Address.Name = "btn_Address";
            this.btn_Address.Size = new System.Drawing.Size(380, 33);
            this.btn_Address.TabIndex = 16;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(155)))));
            this.btn_Cancel.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Cancel.Location = new System.Drawing.Point(260, 304);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(183, 44);
            this.btn_Cancel.TabIndex = 15;
            this.btn_Cancel.Text = "Huỷ";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(155)))));
            this.btn_Save.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Save.Location = new System.Drawing.Point(63, 304);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(183, 44);
            this.btn_Save.TabIndex = 14;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lb_PhoneNumber
            // 
            this.lb_PhoneNumber.AutoSize = true;
            this.lb_PhoneNumber.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PhoneNumber.Location = new System.Drawing.Point(58, 170);
            this.lb_PhoneNumber.Name = "lb_PhoneNumber";
            this.lb_PhoneNumber.Size = new System.Drawing.Size(177, 25);
            this.lb_PhoneNumber.TabIndex = 13;
            this.lb_PhoneNumber.Text = "Số điện thoại :";
            // 
            // txt_phoneNumber
            // 
            this.txt_phoneNumber.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phoneNumber.Location = new System.Drawing.Point(63, 198);
            this.txt_phoneNumber.Name = "txt_phoneNumber";
            this.txt_phoneNumber.Size = new System.Drawing.Size(227, 33);
            this.txt_phoneNumber.TabIndex = 12;
            // 
            // lb_CustomerName
            // 
            this.lb_CustomerName.AutoSize = true;
            this.lb_CustomerName.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CustomerName.Location = new System.Drawing.Point(58, 92);
            this.lb_CustomerName.Name = "lb_CustomerName";
            this.lb_CustomerName.Size = new System.Drawing.Size(188, 25);
            this.lb_CustomerName.TabIndex = 9;
            this.lb_CustomerName.Text = "Tên khách hàng :";
            // 
            // txt_LaptopName
            // 
            this.txt_LaptopName.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LaptopName.Location = new System.Drawing.Point(63, 120);
            this.txt_LaptopName.Name = "txt_LaptopName";
            this.txt_LaptopName.Size = new System.Drawing.Size(183, 33);
            this.txt_LaptopName.TabIndex = 8;
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ID.Location = new System.Drawing.Point(58, 26);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(56, 25);
            this.lb_ID.TabIndex = 7;
            this.lb_ID.Text = "Mã :";
            this.lb_ID.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_LaptopID
            // 
            this.txt_LaptopID.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LaptopID.Location = new System.Drawing.Point(63, 54);
            this.txt_LaptopID.Name = "txt_LaptopID";
            this.txt_LaptopID.Size = new System.Drawing.Size(154, 33);
            this.txt_LaptopID.TabIndex = 6;
            this.txt_LaptopID.TextChanged += new System.EventHandler(this.txtPetId_TextChanged);
            // 
            // CustomerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 467);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "CustomerUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin khách hàng";
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

        private System.Windows.Forms.Label lb_CustomerManagement;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePetList;
        private System.Windows.Forms.Label lb_Search;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TabPage tabPagePetDetail;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lb_PhoneNumber;
        private System.Windows.Forms.TextBox txt_phoneNumber;
        private System.Windows.Forms.Label lb_CustomerName;
        private System.Windows.Forms.TextBox txt_LaptopName;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.TextBox txt_LaptopID;
        private System.Windows.Forms.Label lb_Address;
        private System.Windows.Forms.TextBox btn_Address;
        private System.Windows.Forms.ComboBox cbb_LaptopSearch;
        private System.Windows.Forms.Label lb_SearchFilters;
        private System.Windows.Forms.Button btn_ClearFilter;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lb_OrderMade;
        private System.Windows.Forms.TextBox txt_sodondathuchien;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Button btn_Details;
        private System.Windows.Forms.Button btn_Back;
    }
}