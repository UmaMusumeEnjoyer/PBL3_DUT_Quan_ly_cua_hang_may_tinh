﻿
namespace Gwenchana
{
    partial class Receipt
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
            this.lb_SalesOrder = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePetList = new System.Windows.Forms.TabPage();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.btn_ReceiptDetails = new System.Windows.Forms.Button();
            this.btn_ClearFilter = new System.Windows.Forms.Button();
            this.lb_SearchFilters = new System.Windows.Forms.Label();
            this.cbb_ReceiptFilter = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lb_Search = new System.Windows.Forms.Label();
            this.btn_CreateReceipt = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabPagePetDetail = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_LaptopColour = new System.Windows.Forms.TextBox();
            this.labelxxx = new System.Windows.Forms.Label();
            this.txt_stockQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ScreenSize = new System.Windows.Forms.TextBox();
            this.labelxyz = new System.Windows.Forms.Label();
            this.txt_LaptopWeight = new System.Windows.Forms.TextBox();
            this.lb_Email = new System.Windows.Forms.Label();
            this.txt_LaptopPrice = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lb6 = new System.Windows.Forms.Label();
            this.txt_Spetification = new System.Windows.Forms.TextBox();
            this.labelxxxxxx = new System.Windows.Forms.Label();
            this.txt_Manufacturer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_LaptopName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_LaptopID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPagePetList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabPagePetDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_SalesOrder
            // 
            this.lb_SalesOrder.AutoSize = true;
            this.lb_SalesOrder.Font = new System.Drawing.Font("JetBrains Mono", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SalesOrder.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_SalesOrder.Location = new System.Drawing.Point(4, 9);
            this.lb_SalesOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_SalesOrder.Name = "lb_SalesOrder";
            this.lb_SalesOrder.Size = new System.Drawing.Size(152, 43);
            this.lb_SalesOrder.TabIndex = 0;
            this.lb_SalesOrder.Text = "Đơn bán";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(162)))), ((int)(((byte)(161)))));
            this.panel1.Controls.Add(this.lb_SalesOrder);
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
            this.tabPagePetList.Controls.Add(this.dtpEndDate);
            this.tabPagePetList.Controls.Add(this.dtpStartDate);
            this.tabPagePetList.Controls.Add(this.btn_ReceiptDetails);
            this.tabPagePetList.Controls.Add(this.btn_ClearFilter);
            this.tabPagePetList.Controls.Add(this.lb_SearchFilters);
            this.tabPagePetList.Controls.Add(this.cbb_ReceiptFilter);
            this.tabPagePetList.Controls.Add(this.dataGridView);
            this.tabPagePetList.Controls.Add(this.lb_Search);
            this.tabPagePetList.Controls.Add(this.btn_CreateReceipt);
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
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "MMM dd, yyyy";
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(327, 8);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(122, 22);
            this.dtpEndDate.TabIndex = 13;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "MMM dd, yyyy";
            this.dtpStartDate.Enabled = false;
            this.dtpStartDate.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(181, 8);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(122, 22);
            this.dtpStartDate.TabIndex = 12;
            // 
            // btn_ReceiptDetails
            // 
            this.btn_ReceiptDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ReceiptDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(155)))));
            this.btn_ReceiptDetails.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReceiptDetails.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ReceiptDetails.Location = new System.Drawing.Point(751, 208);
            this.btn_ReceiptDetails.Name = "btn_ReceiptDetails";
            this.btn_ReceiptDetails.Size = new System.Drawing.Size(99, 78);
            this.btn_ReceiptDetails.TabIndex = 11;
            this.btn_ReceiptDetails.Text = "Xem chi tiết";
            this.btn_ReceiptDetails.UseVisualStyleBackColor = false;
            this.btn_ReceiptDetails.Click += new System.EventHandler(this.btn_ReceiptDetails_Click);
            // 
            // btn_ClearFilter
            // 
            this.btn_ClearFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ClearFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(155)))));
            this.btn_ClearFilter.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClearFilter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ClearFilter.Location = new System.Drawing.Point(747, 0);
            this.btn_ClearFilter.Name = "btn_ClearFilter";
            this.btn_ClearFilter.Size = new System.Drawing.Size(74, 35);
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
            this.lb_SearchFilters.Location = new System.Drawing.Point(473, 6);
            this.lb_SearchFilters.Name = "lb_SearchFilters";
            this.lb_SearchFilters.Size = new System.Drawing.Size(122, 25);
            this.lb_SearchFilters.TabIndex = 9;
            this.lb_SearchFilters.Text = "Tiêu chí :";
            // 
            // cbb_ReceiptFilter
            // 
            this.cbb_ReceiptFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(90)))));
            this.cbb_ReceiptFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_ReceiptFilter.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_ReceiptFilter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbb_ReceiptFilter.FormattingEnabled = true;
            this.cbb_ReceiptFilter.Items.AddRange(new object[] {
            "Tên nhân viên",
            "Tên khách hàng",
            "Thời gian"});
            this.cbb_ReceiptFilter.Location = new System.Drawing.Point(601, 2);
            this.cbb_ReceiptFilter.Name = "cbb_ReceiptFilter";
            this.cbb_ReceiptFilter.Size = new System.Drawing.Size(140, 33);
            this.cbb_ReceiptFilter.TabIndex = 8;
            this.cbb_ReceiptFilter.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cbb_ReceiptFilter.TextUpdate += new System.EventHandler(this.cbb_LaptopSearch_TextUpdate);
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
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Search.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_Search.Location = new System.Drawing.Point(19, 8);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(133, 25);
            this.lb_Search.TabIndex = 5;
            this.lb_Search.Text = "Tìm kiếm : ";
            // 
            // btn_CreateReceipt
            // 
            this.btn_CreateReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CreateReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(155)))));
            this.btn_CreateReceipt.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateReceipt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_CreateReceipt.Location = new System.Drawing.Point(751, 292);
            this.btn_CreateReceipt.Name = "btn_CreateReceipt";
            this.btn_CreateReceipt.Size = new System.Drawing.Size(99, 78);
            this.btn_CreateReceipt.TabIndex = 4;
            this.btn_CreateReceipt.Text = "Tạo hoá đơn bán";
            this.btn_CreateReceipt.UseVisualStyleBackColor = false;
            this.btn_CreateReceipt.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(155)))));
            this.btn_Search.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Search.Location = new System.Drawing.Point(642, 37);
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
            this.txtSearch.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(24, 41);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(612, 29);
            this.txtSearch.TabIndex = 0;
            // 
            // tabPagePetDetail
            // 
            this.tabPagePetDetail.Controls.Add(this.label5);
            this.tabPagePetDetail.Controls.Add(this.txt_LaptopColour);
            this.tabPagePetDetail.Controls.Add(this.labelxxx);
            this.tabPagePetDetail.Controls.Add(this.txt_stockQuantity);
            this.tabPagePetDetail.Controls.Add(this.label6);
            this.tabPagePetDetail.Controls.Add(this.txt_ScreenSize);
            this.tabPagePetDetail.Controls.Add(this.labelxyz);
            this.tabPagePetDetail.Controls.Add(this.txt_LaptopWeight);
            this.tabPagePetDetail.Controls.Add(this.lb_Email);
            this.tabPagePetDetail.Controls.Add(this.txt_LaptopPrice);
            this.tabPagePetDetail.Controls.Add(this.btnCancel);
            this.tabPagePetDetail.Controls.Add(this.btnSave);
            this.tabPagePetDetail.Controls.Add(this.lb6);
            this.tabPagePetDetail.Controls.Add(this.txt_Spetification);
            this.tabPagePetDetail.Controls.Add(this.labelxxxxxx);
            this.tabPagePetDetail.Controls.Add(this.txt_Manufacturer);
            this.tabPagePetDetail.Controls.Add(this.label4);
            this.tabPagePetDetail.Controls.Add(this.txt_LaptopName);
            this.tabPagePetDetail.Controls.Add(this.label3);
            this.tabPagePetDetail.Controls.Add(this.txt_LaptopID);
            this.tabPagePetDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagePetDetail.Location = new System.Drawing.Point(4, 30);
            this.tabPagePetDetail.Name = "tabPagePetDetail";
            this.tabPagePetDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePetDetail.Size = new System.Drawing.Size(858, 377);
            this.tabPagePetDetail.TabIndex = 1;
            this.tabPagePetDetail.Text = "Thông tin chi tiết";
            this.tabPagePetDetail.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(668, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Màu sắc :";
            // 
            // txt_LaptopColour
            // 
            this.txt_LaptopColour.Location = new System.Drawing.Point(672, 120);
            this.txt_LaptopColour.Name = "txt_LaptopColour";
            this.txt_LaptopColour.Size = new System.Drawing.Size(154, 29);
            this.txt_LaptopColour.TabIndex = 24;
            // 
            // labelxxx
            // 
            this.labelxxx.AutoSize = true;
            this.labelxxx.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelxxx.Location = new System.Drawing.Point(256, 31);
            this.labelxxx.Name = "labelxxx";
            this.labelxxx.Size = new System.Drawing.Size(149, 21);
            this.labelxxx.TabIndex = 23;
            this.labelxxx.Text = "Số lượng tồn kho :";
            // 
            // txt_stockQuantity
            // 
            this.txt_stockQuantity.Location = new System.Drawing.Point(260, 54);
            this.txt_stockQuantity.Name = "txt_stockQuantity";
            this.txt_stockQuantity.Size = new System.Drawing.Size(154, 29);
            this.txt_stockQuantity.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(460, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "Kích thước màn hình :";
            // 
            // txt_ScreenSize
            // 
            this.txt_ScreenSize.Location = new System.Drawing.Point(464, 120);
            this.txt_ScreenSize.Name = "txt_ScreenSize";
            this.txt_ScreenSize.Size = new System.Drawing.Size(183, 29);
            this.txt_ScreenSize.TabIndex = 20;
            // 
            // labelxyz
            // 
            this.labelxyz.AutoSize = true;
            this.labelxyz.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelxyz.Location = new System.Drawing.Point(263, 97);
            this.labelxyz.Name = "labelxyz";
            this.labelxyz.Size = new System.Drawing.Size(89, 21);
            this.labelxyz.TabIndex = 19;
            this.labelxyz.Text = "Cân nặng :";
            // 
            // txt_LaptopWeight
            // 
            this.txt_LaptopWeight.Location = new System.Drawing.Point(267, 120);
            this.txt_LaptopWeight.Name = "txt_LaptopWeight";
            this.txt_LaptopWeight.Size = new System.Drawing.Size(154, 29);
            this.txt_LaptopWeight.TabIndex = 18;
            this.txt_LaptopWeight.TextChanged += new System.EventHandler(this.txt_LaptopWeight_TextChanged);
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email.Location = new System.Drawing.Point(59, 240);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(82, 21);
            this.lb_Email.TabIndex = 17;
            this.lb_Email.Text = "Giá bán : ";
            // 
            // txt_LaptopPrice
            // 
            this.txt_LaptopPrice.Location = new System.Drawing.Point(63, 263);
            this.txt_LaptopPrice.Name = "txt_LaptopPrice";
            this.txt_LaptopPrice.Size = new System.Drawing.Size(380, 29);
            this.txt_LaptopPrice.TabIndex = 16;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(260, 304);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(183, 44);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(63, 304);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(183, 44);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb6.Location = new System.Drawing.Point(59, 175);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(92, 21);
            this.lb6.TabIndex = 13;
            this.lb6.Text = "Cấu hình : ";
            // 
            // txt_Spetification
            // 
            this.txt_Spetification.Location = new System.Drawing.Point(63, 198);
            this.txt_Spetification.Name = "txt_Spetification";
            this.txt_Spetification.Size = new System.Drawing.Size(550, 29);
            this.txt_Spetification.TabIndex = 12;
            // 
            // labelxxxxxx
            // 
            this.labelxxxxxx.AutoSize = true;
            this.labelxxxxxx.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelxxxxxx.Location = new System.Drawing.Point(59, 97);
            this.labelxxxxxx.Name = "labelxxxxxx";
            this.labelxxxxxx.Size = new System.Drawing.Size(106, 21);
            this.labelxxxxxx.TabIndex = 11;
            this.labelxxxxxx.Text = "Nhà sản xuất";
            // 
            // txt_Manufacturer
            // 
            this.txt_Manufacturer.Location = new System.Drawing.Point(63, 120);
            this.txt_Manufacturer.Name = "txt_Manufacturer";
            this.txt_Manufacturer.Size = new System.Drawing.Size(183, 29);
            this.txt_Manufacturer.TabIndex = 10;
            this.txt_Manufacturer.TextChanged += new System.EventHandler(this.txt_Manufacturer_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(460, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tên :";
            // 
            // txt_LaptopName
            // 
            this.txt_LaptopName.Location = new System.Drawing.Point(464, 54);
            this.txt_LaptopName.Name = "txt_LaptopName";
            this.txt_LaptopName.Size = new System.Drawing.Size(183, 29);
            this.txt_LaptopName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_LaptopID
            // 
            this.txt_LaptopID.Location = new System.Drawing.Point(63, 54);
            this.txt_LaptopID.Name = "txt_LaptopID";
            this.txt_LaptopID.Size = new System.Drawing.Size(154, 29);
            this.txt_LaptopID.TabIndex = 6;
            this.txt_LaptopID.TextChanged += new System.EventHandler(this.txtPetId_TextChanged);
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 467);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Receipt";
            this.Text = "Hoá đơn xuất";
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

        private System.Windows.Forms.Label lb_SalesOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePetList;
        private System.Windows.Forms.Label lb_Search;
        private System.Windows.Forms.Button btn_CreateReceipt;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TabPage tabPagePetDetail;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.TextBox txt_Spetification;
        private System.Windows.Forms.Label labelxxxxxx;
        private System.Windows.Forms.TextBox txt_Manufacturer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_LaptopName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_LaptopID;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.TextBox txt_LaptopPrice;
        private System.Windows.Forms.Label labelxxx;
        private System.Windows.Forms.TextBox txt_stockQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ScreenSize;
        private System.Windows.Forms.Label labelxyz;
        private System.Windows.Forms.TextBox txt_LaptopWeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_LaptopColour;
        private System.Windows.Forms.ComboBox cbb_ReceiptFilter;
        private System.Windows.Forms.Label lb_SearchFilters;
        private System.Windows.Forms.Button btn_ClearFilter;
        private System.Windows.Forms.Button btn_ReceiptDetails;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
    }
}