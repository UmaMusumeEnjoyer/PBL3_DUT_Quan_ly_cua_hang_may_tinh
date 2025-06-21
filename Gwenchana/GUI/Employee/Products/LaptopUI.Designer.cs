
namespace Gwenchana
{
    partial class LaptopUI
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
            this.lb_laptopManagement = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePetList = new System.Windows.Forms.TabPage();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Details = new System.Windows.Forms.Button();
            this.btn_ClearFilter = new System.Windows.Forms.Button();
            this.lb_SearchFilters = new System.Windows.Forms.Label();
            this.cbb_LaptopSearch = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lb_Search = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabPagePetDetail = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.lb_Colour = new System.Windows.Forms.Label();
            this.txt_LaptopColour = new System.Windows.Forms.TextBox();
            this.lb_StockQuantity = new System.Windows.Forms.Label();
            this.txt_stockQuantity = new System.Windows.Forms.TextBox();
            this.lb_ScreenSize = new System.Windows.Forms.Label();
            this.txt_ScreenSize = new System.Windows.Forms.TextBox();
            this.lb_Weight = new System.Windows.Forms.Label();
            this.txt_LaptopWeight = new System.Windows.Forms.TextBox();
            this.lb_Price = new System.Windows.Forms.Label();
            this.txt_LaptopPrice = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lb_Spetifications = new System.Windows.Forms.Label();
            this.txt_Spetification = new System.Windows.Forms.TextBox();
            this.lb_Manufacturer = new System.Windows.Forms.Label();
            this.txt_Manufacturer = new System.Windows.Forms.TextBox();
            this.lb_ProductName = new System.Windows.Forms.Label();
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
            // lb_laptopManagement
            // 
            this.lb_laptopManagement.AutoSize = true;
            this.lb_laptopManagement.Font = new System.Drawing.Font("JetBrains Mono", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_laptopManagement.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_laptopManagement.Location = new System.Drawing.Point(4, 6);
            this.lb_laptopManagement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_laptopManagement.Name = "lb_laptopManagement";
            this.lb_laptopManagement.Size = new System.Drawing.Size(146, 47);
            this.lb_laptopManagement.TabIndex = 0;
            this.lb_laptopManagement.Text = "Laptop";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(162)))), ((int)(((byte)(161)))));
            this.panel1.Controls.Add(this.lb_laptopManagement);
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
            this.tabPagePetList.Controls.Add(this.btn_Add);
            this.tabPagePetList.Controls.Add(this.btn_Details);
            this.tabPagePetList.Controls.Add(this.btn_ClearFilter);
            this.tabPagePetList.Controls.Add(this.lb_SearchFilters);
            this.tabPagePetList.Controls.Add(this.cbb_LaptopSearch);
            this.tabPagePetList.Controls.Add(this.dataGridView);
            this.tabPagePetList.Controls.Add(this.lb_Search);
            this.tabPagePetList.Controls.Add(this.btn_Delete);
            this.tabPagePetList.Controls.Add(this.btn_Edit);
            this.tabPagePetList.Controls.Add(this.btn_Search);
            this.tabPagePetList.Controls.Add(this.txtSearch);
            this.tabPagePetList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagePetList.Location = new System.Drawing.Point(4, 30);
            this.tabPagePetList.Name = "tabPagePetList";
            this.tabPagePetList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePetList.Size = new System.Drawing.Size(858, 377);
            this.tabPagePetList.TabIndex = 0;
            this.tabPagePetList.Text = "Laptop";
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(155)))));
            this.btn_Add.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Add.Location = new System.Drawing.Point(747, 212);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(99, 44);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Details
            // 
            this.btn_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(155)))));
            this.btn_Details.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Details.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Details.Location = new System.Drawing.Point(747, 144);
            this.btn_Details.Name = "btn_Details";
            this.btn_Details.Size = new System.Drawing.Size(99, 62);
            this.btn_Details.TabIndex = 11;
            this.btn_Details.Text = "Chi tiết";
            this.btn_Details.UseVisualStyleBackColor = false;
            this.btn_Details.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ClearFilter
            // 
            this.btn_ClearFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ClearFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(155)))));
            this.btn_ClearFilter.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClearFilter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ClearFilter.Location = new System.Drawing.Point(747, 6);
            this.btn_ClearFilter.Name = "btn_ClearFilter";
            this.btn_ClearFilter.Size = new System.Drawing.Size(74, 28);
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
            // cbb_LaptopSearch
            // 
            this.cbb_LaptopSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(90)))));
            this.cbb_LaptopSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_LaptopSearch.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_LaptopSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbb_LaptopSearch.FormattingEnabled = true;
            this.cbb_LaptopSearch.Items.AddRange(new object[] {
            "Tên",
            "Hãng sản xuất",
            "Cân nặng",
            "Màu sắc"});
            this.cbb_LaptopSearch.Location = new System.Drawing.Point(601, 6);
            this.cbb_LaptopSearch.Name = "cbb_LaptopSearch";
            this.cbb_LaptopSearch.Size = new System.Drawing.Size(140, 29);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle4;
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
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(155)))));
            this.btn_Delete.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Delete.Location = new System.Drawing.Point(747, 314);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(99, 53);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Xoá";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(155)))));
            this.btn_Edit.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Edit.Location = new System.Drawing.Point(747, 262);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(99, 46);
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
            this.btn_Search.Size = new System.Drawing.Size(108, 33);
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
            this.tabPagePetDetail.Controls.Add(this.button2);
            this.tabPagePetDetail.Controls.Add(this.lb_Colour);
            this.tabPagePetDetail.Controls.Add(this.txt_LaptopColour);
            this.tabPagePetDetail.Controls.Add(this.lb_StockQuantity);
            this.tabPagePetDetail.Controls.Add(this.txt_stockQuantity);
            this.tabPagePetDetail.Controls.Add(this.lb_ScreenSize);
            this.tabPagePetDetail.Controls.Add(this.txt_ScreenSize);
            this.tabPagePetDetail.Controls.Add(this.lb_Weight);
            this.tabPagePetDetail.Controls.Add(this.txt_LaptopWeight);
            this.tabPagePetDetail.Controls.Add(this.lb_Price);
            this.tabPagePetDetail.Controls.Add(this.txt_LaptopPrice);
            this.tabPagePetDetail.Controls.Add(this.btnCancel);
            this.tabPagePetDetail.Controls.Add(this.btnSave);
            this.tabPagePetDetail.Controls.Add(this.lb_Spetifications);
            this.tabPagePetDetail.Controls.Add(this.txt_Spetification);
            this.tabPagePetDetail.Controls.Add(this.lb_Manufacturer);
            this.tabPagePetDetail.Controls.Add(this.txt_Manufacturer);
            this.tabPagePetDetail.Controls.Add(this.lb_ProductName);
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(155)))));
            this.button2.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(667, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 44);
            this.button2.TabIndex = 26;
            this.button2.Text = "Quay lại";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb_Colour
            // 
            this.lb_Colour.AutoSize = true;
            this.lb_Colour.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Colour.Location = new System.Drawing.Point(661, 26);
            this.lb_Colour.Name = "lb_Colour";
            this.lb_Colour.Size = new System.Drawing.Size(111, 25);
            this.lb_Colour.TabIndex = 25;
            this.lb_Colour.Text = "Màu sắc :";
            // 
            // txt_LaptopColour
            // 
            this.txt_LaptopColour.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LaptopColour.Location = new System.Drawing.Point(666, 54);
            this.txt_LaptopColour.Name = "txt_LaptopColour";
            this.txt_LaptopColour.Size = new System.Drawing.Size(154, 33);
            this.txt_LaptopColour.TabIndex = 24;
            // 
            // lb_StockQuantity
            // 
            this.lb_StockQuantity.AutoSize = true;
            this.lb_StockQuantity.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_StockQuantity.Location = new System.Drawing.Point(640, 170);
            this.lb_StockQuantity.Name = "lb_StockQuantity";
            this.lb_StockQuantity.Size = new System.Drawing.Size(210, 25);
            this.lb_StockQuantity.TabIndex = 23;
            this.lb_StockQuantity.Text = "Số lượng tồn kho :";
            // 
            // txt_stockQuantity
            // 
            this.txt_stockQuantity.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stockQuantity.Location = new System.Drawing.Point(645, 198);
            this.txt_stockQuantity.Name = "txt_stockQuantity";
            this.txt_stockQuantity.Size = new System.Drawing.Size(183, 33);
            this.txt_stockQuantity.TabIndex = 22;
            // 
            // lb_ScreenSize
            // 
            this.lb_ScreenSize.AutoSize = true;
            this.lb_ScreenSize.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ScreenSize.Location = new System.Drawing.Point(459, 92);
            this.lb_ScreenSize.Name = "lb_ScreenSize";
            this.lb_ScreenSize.Size = new System.Drawing.Size(243, 25);
            this.lb_ScreenSize.TabIndex = 21;
            this.lb_ScreenSize.Text = "Kích thước màn hình :";
            // 
            // txt_ScreenSize
            // 
            this.txt_ScreenSize.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ScreenSize.Location = new System.Drawing.Point(464, 120);
            this.txt_ScreenSize.Name = "txt_ScreenSize";
            this.txt_ScreenSize.Size = new System.Drawing.Size(238, 33);
            this.txt_ScreenSize.TabIndex = 20;
            // 
            // lb_Weight
            // 
            this.lb_Weight.AutoSize = true;
            this.lb_Weight.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Weight.Location = new System.Drawing.Point(262, 92);
            this.lb_Weight.Name = "lb_Weight";
            this.lb_Weight.Size = new System.Drawing.Size(122, 25);
            this.lb_Weight.TabIndex = 19;
            this.lb_Weight.Text = "Cân nặng :";
            // 
            // txt_LaptopWeight
            // 
            this.txt_LaptopWeight.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LaptopWeight.Location = new System.Drawing.Point(267, 120);
            this.txt_LaptopWeight.Name = "txt_LaptopWeight";
            this.txt_LaptopWeight.Size = new System.Drawing.Size(154, 33);
            this.txt_LaptopWeight.TabIndex = 18;
            this.txt_LaptopWeight.TextChanged += new System.EventHandler(this.txt_LaptopWeight_TextChanged);
            this.txt_LaptopWeight.Validating += new System.ComponentModel.CancelEventHandler(this.txt_LaptopWeight_Validating);
            // 
            // lb_Price
            // 
            this.lb_Price.AutoSize = true;
            this.lb_Price.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Price.Location = new System.Drawing.Point(58, 235);
            this.lb_Price.Name = "lb_Price";
            this.lb_Price.Size = new System.Drawing.Size(122, 25);
            this.lb_Price.TabIndex = 17;
            this.lb_Price.Text = "Giá bán : ";
            // 
            // txt_LaptopPrice
            // 
            this.txt_LaptopPrice.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LaptopPrice.Location = new System.Drawing.Point(63, 263);
            this.txt_LaptopPrice.Name = "txt_LaptopPrice";
            this.txt_LaptopPrice.Size = new System.Drawing.Size(380, 33);
            this.txt_LaptopPrice.TabIndex = 16;
            this.txt_LaptopPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txt_LaptopPrice_Validating);
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
            // lb_Spetifications
            // 
            this.lb_Spetifications.AutoSize = true;
            this.lb_Spetifications.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Spetifications.Location = new System.Drawing.Point(58, 170);
            this.lb_Spetifications.Name = "lb_Spetifications";
            this.lb_Spetifications.Size = new System.Drawing.Size(133, 25);
            this.lb_Spetifications.TabIndex = 13;
            this.lb_Spetifications.Text = "Cấu hình : ";
            // 
            // txt_Spetification
            // 
            this.txt_Spetification.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Spetification.Location = new System.Drawing.Point(63, 198);
            this.txt_Spetification.Name = "txt_Spetification";
            this.txt_Spetification.Size = new System.Drawing.Size(550, 33);
            this.txt_Spetification.TabIndex = 12;
            // 
            // lb_Manufacturer
            // 
            this.lb_Manufacturer.AutoSize = true;
            this.lb_Manufacturer.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Manufacturer.Location = new System.Drawing.Point(58, 92);
            this.lb_Manufacturer.Name = "lb_Manufacturer";
            this.lb_Manufacturer.Size = new System.Drawing.Size(144, 25);
            this.lb_Manufacturer.TabIndex = 11;
            this.lb_Manufacturer.Text = "Nhà sản xuất";
            this.lb_Manufacturer.Click += new System.EventHandler(this.lb_Manufacturer_Click);
            // 
            // txt_Manufacturer
            // 
            this.txt_Manufacturer.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Manufacturer.Location = new System.Drawing.Point(63, 120);
            this.txt_Manufacturer.Name = "txt_Manufacturer";
            this.txt_Manufacturer.Size = new System.Drawing.Size(183, 33);
            this.txt_Manufacturer.TabIndex = 10;
            this.txt_Manufacturer.TextChanged += new System.EventHandler(this.txt_Manufacturer_TextChanged);
            // 
            // lb_ProductName
            // 
            this.lb_ProductName.AutoSize = true;
            this.lb_ProductName.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ProductName.Location = new System.Drawing.Point(231, 26);
            this.lb_ProductName.Name = "lb_ProductName";
            this.lb_ProductName.Size = new System.Drawing.Size(67, 25);
            this.lb_ProductName.TabIndex = 9;
            this.lb_ProductName.Text = "Tên :";
            // 
            // txt_LaptopName
            // 
            this.txt_LaptopName.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LaptopName.Location = new System.Drawing.Point(236, 54);
            this.txt_LaptopName.Name = "txt_LaptopName";
            this.txt_LaptopName.Size = new System.Drawing.Size(340, 33);
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
            // LaptopUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 467);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LaptopUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laptop";
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

        private System.Windows.Forms.Label lb_laptopManagement;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePetList;
        private System.Windows.Forms.Label lb_Search;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TabPage tabPagePetDetail;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lb_Spetifications;
        private System.Windows.Forms.TextBox txt_Spetification;
        private System.Windows.Forms.Label lb_Manufacturer;
        private System.Windows.Forms.TextBox txt_Manufacturer;
        private System.Windows.Forms.Label lb_ProductName;
        private System.Windows.Forms.TextBox txt_LaptopName;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.TextBox txt_LaptopID;
        private System.Windows.Forms.Label lb_Price;
        private System.Windows.Forms.TextBox txt_LaptopPrice;
        private System.Windows.Forms.Label lb_StockQuantity;
        private System.Windows.Forms.TextBox txt_stockQuantity;
        private System.Windows.Forms.Label lb_ScreenSize;
        private System.Windows.Forms.TextBox txt_ScreenSize;
        private System.Windows.Forms.Label lb_Weight;
        private System.Windows.Forms.TextBox txt_LaptopWeight;
        private System.Windows.Forms.Label lb_Colour;
        private System.Windows.Forms.TextBox txt_LaptopColour;
        private System.Windows.Forms.ComboBox cbb_LaptopSearch;
        private System.Windows.Forms.Label lb_SearchFilters;
        private System.Windows.Forms.Button btn_ClearFilter;
        private System.Windows.Forms.Button btn_Details;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Add;
    }
}