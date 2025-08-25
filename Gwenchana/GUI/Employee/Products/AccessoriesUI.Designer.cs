
namespace Gwenchana
{
    partial class AccessoriesUI
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
            this.lb_Accessories = new System.Windows.Forms.Label();
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
            this.btn_Back = new System.Windows.Forms.Button();
            this.lb_StockQuantity = new System.Windows.Forms.Label();
            this.txt_AccessoriesstockQuantity = new System.Windows.Forms.TextBox();
            this.lb_ProductType = new System.Windows.Forms.Label();
            this.txt_AccessoriesType = new System.Windows.Forms.TextBox();
            this.lb_Price = new System.Windows.Forms.Label();
            this.txt_AccessoriesPrice = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lb_Overview = new System.Windows.Forms.Label();
            this.txt_AccessoriesOverview = new System.Windows.Forms.TextBox();
            this.lb_Manufacturer = new System.Windows.Forms.Label();
            this.txt_AccessoriesManufacturer = new System.Windows.Forms.TextBox();
            this.lb_ProductName = new System.Windows.Forms.Label();
            this.txt_AccessoriesName = new System.Windows.Forms.TextBox();
            this.lb_ID = new System.Windows.Forms.Label();
            this.txt_AccessoriesID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPagePetList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabPagePetDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Accessories
            // 
            this.lb_Accessories.AutoSize = true;
            this.lb_Accessories.Font = new System.Drawing.Font("JetBrains Mono", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Accessories.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_Accessories.Location = new System.Drawing.Point(4, 6);
            this.lb_Accessories.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Accessories.Name = "lb_Accessories";
            this.lb_Accessories.Size = new System.Drawing.Size(335, 47);
            this.lb_Accessories.TabIndex = 0;
            this.lb_Accessories.Text = "Linh / Phụ kiện";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(162)))), ((int)(((byte)(161)))));
            this.panel1.Controls.Add(this.lb_Accessories);
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
            this.tabPagePetList.Size = new System.Drawing.Size(884, 377);
            this.tabPagePetList.TabIndex = 0;
            this.tabPagePetList.Text = "Danh sách";
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(155)))));
            this.btn_Add.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Add.Location = new System.Drawing.Point(767, 222);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(99, 39);
            this.btn_Add.TabIndex = 15;
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
            this.btn_Details.Location = new System.Drawing.Point(767, 140);
            this.btn_Details.Name = "btn_Details";
            this.btn_Details.Size = new System.Drawing.Size(99, 76);
            this.btn_Details.TabIndex = 14;
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
            this.btn_ClearFilter.Location = new System.Drawing.Point(773, 4);
            this.btn_ClearFilter.Name = "btn_ClearFilter";
            this.btn_ClearFilter.Size = new System.Drawing.Size(103, 33);
            this.btn_ClearFilter.TabIndex = 13;
            this.btn_ClearFilter.Text = "Xoá";
            this.btn_ClearFilter.UseVisualStyleBackColor = false;
            this.btn_ClearFilter.Click += new System.EventHandler(this.btn_ClearFilter_Click);
            // 
            // lb_SearchFilters
            // 
            this.lb_SearchFilters.AutoSize = true;
            this.lb_SearchFilters.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SearchFilters.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_SearchFilters.Location = new System.Drawing.Point(499, 7);
            this.lb_SearchFilters.Name = "lb_SearchFilters";
            this.lb_SearchFilters.Size = new System.Drawing.Size(122, 25);
            this.lb_SearchFilters.TabIndex = 12;
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
            "Loại"});
            this.cbb_LaptopSearch.Location = new System.Drawing.Point(627, 8);
            this.cbb_LaptopSearch.Name = "cbb_LaptopSearch";
            this.cbb_LaptopSearch.Size = new System.Drawing.Size(140, 29);
            this.cbb_LaptopSearch.TabIndex = 11;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.Color.Black;
            this.dataGridView.Location = new System.Drawing.Point(24, 78);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(737, 291);
            this.dataGridView.TabIndex = 7;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Search.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_Search.Location = new System.Drawing.Point(19, 18);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(122, 25);
            this.lb_Search.TabIndex = 5;
            this.lb_Search.Text = "Tìm kiếm :";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(155)))));
            this.btn_Delete.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Delete.Location = new System.Drawing.Point(767, 319);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(99, 47);
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
            this.btn_Edit.Location = new System.Drawing.Point(767, 267);
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
            this.btn_Search.Location = new System.Drawing.Point(668, 42);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(112, 33);
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
            this.txtSearch.Location = new System.Drawing.Point(24, 46);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(638, 29);
            this.txtSearch.TabIndex = 0;
            // 
            // tabPagePetDetail
            // 
            this.tabPagePetDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(221)))));
            this.tabPagePetDetail.Controls.Add(this.btn_Back);
            this.tabPagePetDetail.Controls.Add(this.lb_StockQuantity);
            this.tabPagePetDetail.Controls.Add(this.txt_AccessoriesstockQuantity);
            this.tabPagePetDetail.Controls.Add(this.lb_ProductType);
            this.tabPagePetDetail.Controls.Add(this.txt_AccessoriesType);
            this.tabPagePetDetail.Controls.Add(this.lb_Price);
            this.tabPagePetDetail.Controls.Add(this.txt_AccessoriesPrice);
            this.tabPagePetDetail.Controls.Add(this.btn_Cancel);
            this.tabPagePetDetail.Controls.Add(this.btn_Save);
            this.tabPagePetDetail.Controls.Add(this.lb_Overview);
            this.tabPagePetDetail.Controls.Add(this.txt_AccessoriesOverview);
            this.tabPagePetDetail.Controls.Add(this.lb_Manufacturer);
            this.tabPagePetDetail.Controls.Add(this.txt_AccessoriesManufacturer);
            this.tabPagePetDetail.Controls.Add(this.lb_ProductName);
            this.tabPagePetDetail.Controls.Add(this.txt_AccessoriesName);
            this.tabPagePetDetail.Controls.Add(this.lb_ID);
            this.tabPagePetDetail.Controls.Add(this.txt_AccessoriesID);
            this.tabPagePetDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagePetDetail.Location = new System.Drawing.Point(4, 30);
            this.tabPagePetDetail.Name = "tabPagePetDetail";
            this.tabPagePetDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePetDetail.Size = new System.Drawing.Size(884, 377);
            this.tabPagePetDetail.TabIndex = 1;
            this.tabPagePetDetail.Text = "Chi tiết";
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(155)))));
            this.btn_Back.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Back.Location = new System.Drawing.Point(693, 304);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(183, 44);
            this.btn_Back.TabIndex = 22;
            this.btn_Back.Text = "Quay về";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // lb_StockQuantity
            // 
            this.lb_StockQuantity.AutoSize = true;
            this.lb_StockQuantity.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_StockQuantity.Location = new System.Drawing.Point(465, 26);
            this.lb_StockQuantity.Name = "lb_StockQuantity";
            this.lb_StockQuantity.Size = new System.Drawing.Size(210, 25);
            this.lb_StockQuantity.TabIndex = 21;
            this.lb_StockQuantity.Text = "Số lượng tồn kho :";
            // 
            // txt_AccessoriesstockQuantity
            // 
            this.txt_AccessoriesstockQuantity.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AccessoriesstockQuantity.Location = new System.Drawing.Point(470, 54);
            this.txt_AccessoriesstockQuantity.Name = "txt_AccessoriesstockQuantity";
            this.txt_AccessoriesstockQuantity.Size = new System.Drawing.Size(183, 29);
            this.txt_AccessoriesstockQuantity.TabIndex = 20;
            // 
            // lb_ProductType
            // 
            this.lb_ProductType.AutoSize = true;
            this.lb_ProductType.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ProductType.Location = new System.Drawing.Point(255, 26);
            this.lb_ProductType.Name = "lb_ProductType";
            this.lb_ProductType.Size = new System.Drawing.Size(177, 25);
            this.lb_ProductType.TabIndex = 19;
            this.lb_ProductType.Text = "Loại sản phẩm :";
            // 
            // txt_AccessoriesType
            // 
            this.txt_AccessoriesType.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AccessoriesType.Location = new System.Drawing.Point(260, 54);
            this.txt_AccessoriesType.Name = "txt_AccessoriesType";
            this.txt_AccessoriesType.Size = new System.Drawing.Size(183, 29);
            this.txt_AccessoriesType.TabIndex = 18;
            // 
            // lb_Price
            // 
            this.lb_Price.AutoSize = true;
            this.lb_Price.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Price.Location = new System.Drawing.Point(58, 235);
            this.lb_Price.Name = "lb_Price";
            this.lb_Price.Size = new System.Drawing.Size(111, 25);
            this.lb_Price.TabIndex = 17;
            this.lb_Price.Text = "Giá bán :";
            // 
            // txt_AccessoriesPrice
            // 
            this.txt_AccessoriesPrice.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AccessoriesPrice.Location = new System.Drawing.Point(63, 263);
            this.txt_AccessoriesPrice.Name = "txt_AccessoriesPrice";
            this.txt_AccessoriesPrice.Size = new System.Drawing.Size(380, 29);
            this.txt_AccessoriesPrice.TabIndex = 16;
            this.txt_AccessoriesPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txt_AccessoriesPrice_Validating);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(155)))));
            this.btn_Cancel.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn_Save.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Save.Location = new System.Drawing.Point(63, 304);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(183, 44);
            this.btn_Save.TabIndex = 14;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lb_Overview
            // 
            this.lb_Overview.AutoSize = true;
            this.lb_Overview.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Overview.Location = new System.Drawing.Point(58, 170);
            this.lb_Overview.Name = "lb_Overview";
            this.lb_Overview.Size = new System.Drawing.Size(133, 25);
            this.lb_Overview.TabIndex = 13;
            this.lb_Overview.Text = "Tổng quan :";
            // 
            // txt_AccessoriesOverview
            // 
            this.txt_AccessoriesOverview.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AccessoriesOverview.Location = new System.Drawing.Point(63, 198);
            this.txt_AccessoriesOverview.Name = "txt_AccessoriesOverview";
            this.txt_AccessoriesOverview.Size = new System.Drawing.Size(590, 29);
            this.txt_AccessoriesOverview.TabIndex = 12;
            // 
            // lb_Manufacturer
            // 
            this.lb_Manufacturer.AutoSize = true;
            this.lb_Manufacturer.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Manufacturer.Location = new System.Drawing.Point(394, 97);
            this.lb_Manufacturer.Name = "lb_Manufacturer";
            this.lb_Manufacturer.Size = new System.Drawing.Size(166, 25);
            this.lb_Manufacturer.TabIndex = 11;
            this.lb_Manufacturer.Text = "Nhà sản xuất :";
            // 
            // txt_AccessoriesManufacturer
            // 
            this.txt_AccessoriesManufacturer.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AccessoriesManufacturer.Location = new System.Drawing.Point(399, 125);
            this.txt_AccessoriesManufacturer.Name = "txt_AccessoriesManufacturer";
            this.txt_AccessoriesManufacturer.Size = new System.Drawing.Size(252, 29);
            this.txt_AccessoriesManufacturer.TabIndex = 10;
            // 
            // lb_ProductName
            // 
            this.lb_ProductName.AutoSize = true;
            this.lb_ProductName.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ProductName.Location = new System.Drawing.Point(58, 97);
            this.lb_ProductName.Name = "lb_ProductName";
            this.lb_ProductName.Size = new System.Drawing.Size(67, 25);
            this.lb_ProductName.TabIndex = 9;
            this.lb_ProductName.Text = "Tên :";
            // 
            // txt_AccessoriesName
            // 
            this.txt_AccessoriesName.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AccessoriesName.Location = new System.Drawing.Point(63, 125);
            this.txt_AccessoriesName.Name = "txt_AccessoriesName";
            this.txt_AccessoriesName.Size = new System.Drawing.Size(251, 29);
            this.txt_AccessoriesName.TabIndex = 8;
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
            // txt_AccessoriesID
            // 
            this.txt_AccessoriesID.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AccessoriesID.Location = new System.Drawing.Point(63, 54);
            this.txt_AccessoriesID.Name = "txt_AccessoriesID";
            this.txt_AccessoriesID.Size = new System.Drawing.Size(154, 29);
            this.txt_AccessoriesID.TabIndex = 6;
            this.txt_AccessoriesID.TextChanged += new System.EventHandler(this.txtPetId_TextChanged);
            // 
            // AccessoriesUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 467);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AccessoriesUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Linh phụ kiện";
            this.Load += new System.EventHandler(this.AccessoriesUI_Load);
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

        private System.Windows.Forms.Label lb_Accessories;
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
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lb_Overview;
        private System.Windows.Forms.TextBox txt_AccessoriesOverview;
        private System.Windows.Forms.Label lb_Manufacturer;
        private System.Windows.Forms.TextBox txt_AccessoriesManufacturer;
        private System.Windows.Forms.Label lb_ProductName;
        private System.Windows.Forms.TextBox txt_AccessoriesName;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.TextBox txt_AccessoriesID;
        private System.Windows.Forms.Label lb_Price;
        private System.Windows.Forms.TextBox txt_AccessoriesPrice;
        private System.Windows.Forms.Label lb_ProductType;
        private System.Windows.Forms.TextBox txt_AccessoriesType;
        private System.Windows.Forms.Label lb_StockQuantity;
        private System.Windows.Forms.TextBox txt_AccessoriesstockQuantity;
        private System.Windows.Forms.Button btn_ClearFilter;
        private System.Windows.Forms.Label lb_SearchFilters;
        private System.Windows.Forms.ComboBox cbb_LaptopSearch;
        private System.Windows.Forms.Button btn_Details;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Add;
    }
}