
namespace Gwenchana
{
    partial class AddProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_AddProduct = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLaptop = new System.Windows.Forms.TabPage();
            this.lb_LaptopSupplierName = new System.Windows.Forms.Label();
            this.ccb_NhaCungCap1 = new System.Windows.Forms.ComboBox();
            this.lb_LaptopColor = new System.Windows.Forms.Label();
            this.txt_LaptopColour = new System.Windows.Forms.TextBox();
            this.lb_LaptopScreenSize = new System.Windows.Forms.Label();
            this.txt_ScreenSize = new System.Windows.Forms.TextBox();
            this.lb_LaptopWeight = new System.Windows.Forms.Label();
            this.txt_LaptopWeight = new System.Windows.Forms.TextBox();
            this.lb_LaptopPrice = new System.Windows.Forms.Label();
            this.txt_LaptopPrice = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_LaptopSave = new System.Windows.Forms.Button();
            this.lb_LaptopSpecs = new System.Windows.Forms.Label();
            this.txt_Spetification = new System.Windows.Forms.TextBox();
            this.lb_ManufacturerLaptop = new System.Windows.Forms.Label();
            this.txt_Manufacturer = new System.Windows.Forms.TextBox();
            this.lb_LaptopName = new System.Windows.Forms.Label();
            this.txt_LaptopName = new System.Windows.Forms.TextBox();
            this.tabPagePC = new System.Windows.Forms.TabPage();
            this.lb_PcSupplierName = new System.Windows.Forms.Label();
            this.ccb_NhaCungCap2 = new System.Windows.Forms.ComboBox();
            this.lb_PcPrice = new System.Windows.Forms.Label();
            this.txt_pcPrice = new System.Windows.Forms.TextBox();
            this.btn_Cancel1 = new System.Windows.Forms.Button();
            this.btn_SavePC = new System.Windows.Forms.Button();
            this.lb_PcSpecs = new System.Windows.Forms.Label();
            this.txt_pcSpecs = new System.Windows.Forms.TextBox();
            this.lb_PcManufacturer = new System.Windows.Forms.Label();
            this.txt_pcManufacturer = new System.Windows.Forms.TextBox();
            this.lb_PcName = new System.Windows.Forms.Label();
            this.txt_pcName = new System.Windows.Forms.TextBox();
            this.tabPageAccessories = new System.Windows.Forms.TabPage();
            this.lb_AccessorySupplierName = new System.Windows.Forms.Label();
            this.ccb_NhaCungCap3 = new System.Windows.Forms.ComboBox();
            this.lb_AccessoryType = new System.Windows.Forms.Label();
            this.txt_AccessoriesType = new System.Windows.Forms.TextBox();
            this.lb_AccessoriesPrice = new System.Windows.Forms.Label();
            this.txt_AccessoriesPrice = new System.Windows.Forms.TextBox();
            this.btn_Cancel2 = new System.Windows.Forms.Button();
            this.btn_AccessoriesSave = new System.Windows.Forms.Button();
            this.lb_AccOverview = new System.Windows.Forms.Label();
            this.txt_AccessoriesOverview = new System.Windows.Forms.TextBox();
            this.lb_ManufacturerAcc = new System.Windows.Forms.Label();
            this.txt_AccessoriesManufacturer = new System.Windows.Forms.TextBox();
            this.lb_AccessoriesName = new System.Windows.Forms.Label();
            this.txt_AccessoriesName = new System.Windows.Forms.TextBox();
            this.lb_AddProduct.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageLaptop.SuspendLayout();
            this.tabPagePC.SuspendLayout();
            this.tabPageAccessories.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm sản phẩm";
            // 
            // lb_AddProduct
            // 
            this.lb_AddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(162)))), ((int)(((byte)(161)))));
            this.lb_AddProduct.Controls.Add(this.label1);
            this.lb_AddProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_AddProduct.Location = new System.Drawing.Point(0, 0);
            this.lb_AddProduct.Name = "lb_AddProduct";
            this.lb_AddProduct.Size = new System.Drawing.Size(866, 56);
            this.lb_AddProduct.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageLaptop);
            this.tabControl1.Controls.Add(this.tabPagePC);
            this.tabControl1.Controls.Add(this.tabPageAccessories);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(866, 411);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageLaptop
            // 
            this.tabPageLaptop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(162)))), ((int)(((byte)(161)))));
            this.tabPageLaptop.Controls.Add(this.lb_LaptopSupplierName);
            this.tabPageLaptop.Controls.Add(this.ccb_NhaCungCap1);
            this.tabPageLaptop.Controls.Add(this.lb_LaptopColor);
            this.tabPageLaptop.Controls.Add(this.txt_LaptopColour);
            this.tabPageLaptop.Controls.Add(this.lb_LaptopScreenSize);
            this.tabPageLaptop.Controls.Add(this.txt_ScreenSize);
            this.tabPageLaptop.Controls.Add(this.lb_LaptopWeight);
            this.tabPageLaptop.Controls.Add(this.txt_LaptopWeight);
            this.tabPageLaptop.Controls.Add(this.lb_LaptopPrice);
            this.tabPageLaptop.Controls.Add(this.txt_LaptopPrice);
            this.tabPageLaptop.Controls.Add(this.btn_Cancel);
            this.tabPageLaptop.Controls.Add(this.btn_LaptopSave);
            this.tabPageLaptop.Controls.Add(this.lb_LaptopSpecs);
            this.tabPageLaptop.Controls.Add(this.txt_Spetification);
            this.tabPageLaptop.Controls.Add(this.lb_ManufacturerLaptop);
            this.tabPageLaptop.Controls.Add(this.txt_Manufacturer);
            this.tabPageLaptop.Controls.Add(this.lb_LaptopName);
            this.tabPageLaptop.Controls.Add(this.txt_LaptopName);
            this.tabPageLaptop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageLaptop.Location = new System.Drawing.Point(4, 30);
            this.tabPageLaptop.Name = "tabPageLaptop";
            this.tabPageLaptop.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLaptop.Size = new System.Drawing.Size(858, 377);
            this.tabPageLaptop.TabIndex = 1;
            this.tabPageLaptop.Text = "Laptop";
            // 
            // lb_LaptopSupplierName
            // 
            this.lb_LaptopSupplierName.AutoSize = true;
            this.lb_LaptopSupplierName.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LaptopSupplierName.Location = new System.Drawing.Point(518, 235);
            this.lb_LaptopSupplierName.Name = "lb_LaptopSupplierName";
            this.lb_LaptopSupplierName.Size = new System.Drawing.Size(166, 25);
            this.lb_LaptopSupplierName.TabIndex = 27;
            this.lb_LaptopSupplierName.Text = "Nhà cung cấp :";
            // 
            // ccb_NhaCungCap1
            // 
            this.ccb_NhaCungCap1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(90)))));
            this.ccb_NhaCungCap1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccb_NhaCungCap1.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccb_NhaCungCap1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ccb_NhaCungCap1.FormattingEnabled = true;
            this.ccb_NhaCungCap1.Location = new System.Drawing.Point(523, 263);
            this.ccb_NhaCungCap1.Name = "ccb_NhaCungCap1";
            this.ccb_NhaCungCap1.Size = new System.Drawing.Size(241, 33);
            this.ccb_NhaCungCap1.TabIndex = 26;
            this.ccb_NhaCungCap1.SelectedIndexChanged += new System.EventHandler(this.ccb_NhaCungCap1_SelectedIndexChanged);
            // 
            // lb_LaptopColor
            // 
            this.lb_LaptopColor.AutoSize = true;
            this.lb_LaptopColor.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LaptopColor.Location = new System.Drawing.Point(656, 170);
            this.lb_LaptopColor.Name = "lb_LaptopColor";
            this.lb_LaptopColor.Size = new System.Drawing.Size(111, 25);
            this.lb_LaptopColor.TabIndex = 25;
            this.lb_LaptopColor.Text = "Màu sắc :";
            // 
            // txt_LaptopColour
            // 
            this.txt_LaptopColour.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LaptopColour.Location = new System.Drawing.Point(661, 198);
            this.txt_LaptopColour.Name = "txt_LaptopColour";
            this.txt_LaptopColour.Size = new System.Drawing.Size(154, 29);
            this.txt_LaptopColour.TabIndex = 24;
            // 
            // lb_LaptopScreenSize
            // 
            this.lb_LaptopScreenSize.AutoSize = true;
            this.lb_LaptopScreenSize.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LaptopScreenSize.Location = new System.Drawing.Point(459, 92);
            this.lb_LaptopScreenSize.Name = "lb_LaptopScreenSize";
            this.lb_LaptopScreenSize.Size = new System.Drawing.Size(243, 25);
            this.lb_LaptopScreenSize.TabIndex = 21;
            this.lb_LaptopScreenSize.Text = "Kích thước màn hình :";
            // 
            // txt_ScreenSize
            // 
            this.txt_ScreenSize.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ScreenSize.Location = new System.Drawing.Point(464, 120);
            this.txt_ScreenSize.Name = "txt_ScreenSize";
            this.txt_ScreenSize.Size = new System.Drawing.Size(183, 29);
            this.txt_ScreenSize.TabIndex = 20;
            // 
            // lb_LaptopWeight
            // 
            this.lb_LaptopWeight.AutoSize = true;
            this.lb_LaptopWeight.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LaptopWeight.Location = new System.Drawing.Point(262, 92);
            this.lb_LaptopWeight.Name = "lb_LaptopWeight";
            this.lb_LaptopWeight.Size = new System.Drawing.Size(122, 25);
            this.lb_LaptopWeight.TabIndex = 19;
            this.lb_LaptopWeight.Text = "Cân nặng :";
            // 
            // txt_LaptopWeight
            // 
            this.txt_LaptopWeight.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LaptopWeight.Location = new System.Drawing.Point(267, 120);
            this.txt_LaptopWeight.Name = "txt_LaptopWeight";
            this.txt_LaptopWeight.Size = new System.Drawing.Size(154, 29);
            this.txt_LaptopWeight.TabIndex = 18;
            this.txt_LaptopWeight.TextChanged += new System.EventHandler(this.txt_LaptopWeight_TextChanged);
            this.txt_LaptopWeight.Validating += new System.ComponentModel.CancelEventHandler(this.txt_LaptopWeight_Validating);
            // 
            // lb_LaptopPrice
            // 
            this.lb_LaptopPrice.AutoSize = true;
            this.lb_LaptopPrice.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LaptopPrice.Location = new System.Drawing.Point(58, 235);
            this.lb_LaptopPrice.Name = "lb_LaptopPrice";
            this.lb_LaptopPrice.Size = new System.Drawing.Size(122, 25);
            this.lb_LaptopPrice.TabIndex = 17;
            this.lb_LaptopPrice.Text = "Giá bán : ";
            // 
            // txt_LaptopPrice
            // 
            this.txt_LaptopPrice.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LaptopPrice.Location = new System.Drawing.Point(63, 263);
            this.txt_LaptopPrice.Name = "txt_LaptopPrice";
            this.txt_LaptopPrice.Size = new System.Drawing.Size(380, 29);
            this.txt_LaptopPrice.TabIndex = 16;
            this.txt_LaptopPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txt_LaptopPrice_Validating);
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
            // btn_LaptopSave
            // 
            this.btn_LaptopSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(155)))));
            this.btn_LaptopSave.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LaptopSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_LaptopSave.Location = new System.Drawing.Point(63, 304);
            this.btn_LaptopSave.Name = "btn_LaptopSave";
            this.btn_LaptopSave.Size = new System.Drawing.Size(183, 44);
            this.btn_LaptopSave.TabIndex = 14;
            this.btn_LaptopSave.Text = "Lưu";
            this.btn_LaptopSave.UseVisualStyleBackColor = false;
            this.btn_LaptopSave.Click += new System.EventHandler(this.btn_LaptopSave_Click);
            // 
            // lb_LaptopSpecs
            // 
            this.lb_LaptopSpecs.AutoSize = true;
            this.lb_LaptopSpecs.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LaptopSpecs.Location = new System.Drawing.Point(58, 170);
            this.lb_LaptopSpecs.Name = "lb_LaptopSpecs";
            this.lb_LaptopSpecs.Size = new System.Drawing.Size(133, 25);
            this.lb_LaptopSpecs.TabIndex = 13;
            this.lb_LaptopSpecs.Text = "Cấu hình : ";
            // 
            // txt_Spetification
            // 
            this.txt_Spetification.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Spetification.Location = new System.Drawing.Point(63, 198);
            this.txt_Spetification.Name = "txt_Spetification";
            this.txt_Spetification.Size = new System.Drawing.Size(550, 29);
            this.txt_Spetification.TabIndex = 12;
            // 
            // lb_ManufacturerLaptop
            // 
            this.lb_ManufacturerLaptop.AutoSize = true;
            this.lb_ManufacturerLaptop.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ManufacturerLaptop.Location = new System.Drawing.Point(58, 92);
            this.lb_ManufacturerLaptop.Name = "lb_ManufacturerLaptop";
            this.lb_ManufacturerLaptop.Size = new System.Drawing.Size(144, 25);
            this.lb_ManufacturerLaptop.TabIndex = 11;
            this.lb_ManufacturerLaptop.Text = "Nhà sản xuất";
            // 
            // txt_Manufacturer
            // 
            this.txt_Manufacturer.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Manufacturer.Location = new System.Drawing.Point(63, 120);
            this.txt_Manufacturer.Name = "txt_Manufacturer";
            this.txt_Manufacturer.Size = new System.Drawing.Size(183, 29);
            this.txt_Manufacturer.TabIndex = 10;
            this.txt_Manufacturer.TextChanged += new System.EventHandler(this.txt_Manufacturer_TextChanged);
            // 
            // lb_LaptopName
            // 
            this.lb_LaptopName.AutoSize = true;
            this.lb_LaptopName.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LaptopName.Location = new System.Drawing.Point(58, 20);
            this.lb_LaptopName.Name = "lb_LaptopName";
            this.lb_LaptopName.Size = new System.Drawing.Size(67, 25);
            this.lb_LaptopName.TabIndex = 9;
            this.lb_LaptopName.Text = "Tên :";
            // 
            // txt_LaptopName
            // 
            this.txt_LaptopName.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LaptopName.Location = new System.Drawing.Point(63, 48);
            this.txt_LaptopName.Name = "txt_LaptopName";
            this.txt_LaptopName.Size = new System.Drawing.Size(286, 29);
            this.txt_LaptopName.TabIndex = 8;
            // 
            // tabPagePC
            // 
            this.tabPagePC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(162)))), ((int)(((byte)(161)))));
            this.tabPagePC.Controls.Add(this.lb_PcSupplierName);
            this.tabPagePC.Controls.Add(this.ccb_NhaCungCap2);
            this.tabPagePC.Controls.Add(this.lb_PcPrice);
            this.tabPagePC.Controls.Add(this.txt_pcPrice);
            this.tabPagePC.Controls.Add(this.btn_Cancel1);
            this.tabPagePC.Controls.Add(this.btn_SavePC);
            this.tabPagePC.Controls.Add(this.lb_PcSpecs);
            this.tabPagePC.Controls.Add(this.txt_pcSpecs);
            this.tabPagePC.Controls.Add(this.lb_PcManufacturer);
            this.tabPagePC.Controls.Add(this.txt_pcManufacturer);
            this.tabPagePC.Controls.Add(this.lb_PcName);
            this.tabPagePC.Controls.Add(this.txt_pcName);
            this.tabPagePC.Location = new System.Drawing.Point(4, 30);
            this.tabPagePC.Name = "tabPagePC";
            this.tabPagePC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePC.Size = new System.Drawing.Size(858, 377);
            this.tabPagePC.TabIndex = 2;
            this.tabPagePC.Text = "PC";
            // 
            // lb_PcSupplierName
            // 
            this.lb_PcSupplierName.AutoSize = true;
            this.lb_PcSupplierName.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PcSupplierName.Location = new System.Drawing.Point(482, 178);
            this.lb_PcSupplierName.Name = "lb_PcSupplierName";
            this.lb_PcSupplierName.Size = new System.Drawing.Size(166, 25);
            this.lb_PcSupplierName.TabIndex = 33;
            this.lb_PcSupplierName.Text = "Nhà cung cấp :";
            // 
            // ccb_NhaCungCap2
            // 
            this.ccb_NhaCungCap2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(90)))));
            this.ccb_NhaCungCap2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccb_NhaCungCap2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ccb_NhaCungCap2.FormattingEnabled = true;
            this.ccb_NhaCungCap2.Location = new System.Drawing.Point(487, 207);
            this.ccb_NhaCungCap2.Name = "ccb_NhaCungCap2";
            this.ccb_NhaCungCap2.Size = new System.Drawing.Size(241, 29);
            this.ccb_NhaCungCap2.TabIndex = 32;
            // 
            // lb_PcPrice
            // 
            this.lb_PcPrice.AutoSize = true;
            this.lb_PcPrice.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PcPrice.Location = new System.Drawing.Point(37, 178);
            this.lb_PcPrice.Name = "lb_PcPrice";
            this.lb_PcPrice.Size = new System.Drawing.Size(111, 25);
            this.lb_PcPrice.TabIndex = 31;
            this.lb_PcPrice.Text = "Giá bán :";
            // 
            // txt_pcPrice
            // 
            this.txt_pcPrice.Location = new System.Drawing.Point(42, 206);
            this.txt_pcPrice.Name = "txt_pcPrice";
            this.txt_pcPrice.Size = new System.Drawing.Size(380, 29);
            this.txt_pcPrice.TabIndex = 30;
            this.txt_pcPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txt_pcPrice_Validating);
            // 
            // btn_Cancel1
            // 
            this.btn_Cancel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(155)))));
            this.btn_Cancel1.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Cancel1.Location = new System.Drawing.Point(245, 303);
            this.btn_Cancel1.Name = "btn_Cancel1";
            this.btn_Cancel1.Size = new System.Drawing.Size(183, 44);
            this.btn_Cancel1.TabIndex = 29;
            this.btn_Cancel1.Text = "Huỷ";
            this.btn_Cancel1.UseVisualStyleBackColor = false;
            this.btn_Cancel1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_SavePC
            // 
            this.btn_SavePC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(155)))));
            this.btn_SavePC.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SavePC.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_SavePC.Location = new System.Drawing.Point(48, 303);
            this.btn_SavePC.Name = "btn_SavePC";
            this.btn_SavePC.Size = new System.Drawing.Size(183, 44);
            this.btn_SavePC.TabIndex = 28;
            this.btn_SavePC.Text = "Lưu";
            this.btn_SavePC.UseVisualStyleBackColor = false;
            this.btn_SavePC.Click += new System.EventHandler(this.btn_SavePC_Click);
            // 
            // lb_PcSpecs
            // 
            this.lb_PcSpecs.AutoSize = true;
            this.lb_PcSpecs.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PcSpecs.Location = new System.Drawing.Point(37, 113);
            this.lb_PcSpecs.Name = "lb_PcSpecs";
            this.lb_PcSpecs.Size = new System.Drawing.Size(122, 25);
            this.lb_PcSpecs.TabIndex = 27;
            this.lb_PcSpecs.Text = "Cấu hình :";
            // 
            // txt_pcSpecs
            // 
            this.txt_pcSpecs.Location = new System.Drawing.Point(42, 141);
            this.txt_pcSpecs.Name = "txt_pcSpecs";
            this.txt_pcSpecs.Size = new System.Drawing.Size(767, 29);
            this.txt_pcSpecs.TabIndex = 26;
            this.txt_pcSpecs.TextChanged += new System.EventHandler(this.txt_pcSpecs_TextChanged);
            // 
            // lb_PcManufacturer
            // 
            this.lb_PcManufacturer.AutoSize = true;
            this.lb_PcManufacturer.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PcManufacturer.Location = new System.Drawing.Point(410, 40);
            this.lb_PcManufacturer.Name = "lb_PcManufacturer";
            this.lb_PcManufacturer.Size = new System.Drawing.Size(166, 25);
            this.lb_PcManufacturer.TabIndex = 25;
            this.lb_PcManufacturer.Text = "Nhà sản xuất :";
            // 
            // txt_pcManufacturer
            // 
            this.txt_pcManufacturer.Location = new System.Drawing.Point(415, 68);
            this.txt_pcManufacturer.Name = "txt_pcManufacturer";
            this.txt_pcManufacturer.Size = new System.Drawing.Size(183, 29);
            this.txt_pcManufacturer.TabIndex = 24;
            // 
            // lb_PcName
            // 
            this.lb_PcName.AutoSize = true;
            this.lb_PcName.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PcName.Location = new System.Drawing.Point(37, 40);
            this.lb_PcName.Name = "lb_PcName";
            this.lb_PcName.Size = new System.Drawing.Size(67, 25);
            this.lb_PcName.TabIndex = 23;
            this.lb_PcName.Text = "Tên :";
            // 
            // txt_pcName
            // 
            this.txt_pcName.Location = new System.Drawing.Point(42, 68);
            this.txt_pcName.Name = "txt_pcName";
            this.txt_pcName.Size = new System.Drawing.Size(315, 29);
            this.txt_pcName.TabIndex = 22;
            // 
            // tabPageAccessories
            // 
            this.tabPageAccessories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(162)))), ((int)(((byte)(161)))));
            this.tabPageAccessories.Controls.Add(this.lb_AccessorySupplierName);
            this.tabPageAccessories.Controls.Add(this.ccb_NhaCungCap3);
            this.tabPageAccessories.Controls.Add(this.lb_AccessoryType);
            this.tabPageAccessories.Controls.Add(this.txt_AccessoriesType);
            this.tabPageAccessories.Controls.Add(this.lb_AccessoriesPrice);
            this.tabPageAccessories.Controls.Add(this.txt_AccessoriesPrice);
            this.tabPageAccessories.Controls.Add(this.btn_Cancel2);
            this.tabPageAccessories.Controls.Add(this.btn_AccessoriesSave);
            this.tabPageAccessories.Controls.Add(this.lb_AccOverview);
            this.tabPageAccessories.Controls.Add(this.txt_AccessoriesOverview);
            this.tabPageAccessories.Controls.Add(this.lb_ManufacturerAcc);
            this.tabPageAccessories.Controls.Add(this.txt_AccessoriesManufacturer);
            this.tabPageAccessories.Controls.Add(this.lb_AccessoriesName);
            this.tabPageAccessories.Controls.Add(this.txt_AccessoriesName);
            this.tabPageAccessories.Location = new System.Drawing.Point(4, 30);
            this.tabPageAccessories.Name = "tabPageAccessories";
            this.tabPageAccessories.Size = new System.Drawing.Size(858, 377);
            this.tabPageAccessories.TabIndex = 3;
            this.tabPageAccessories.Text = "Linh / Phụ kiện";
            // 
            // lb_AccessorySupplierName
            // 
            this.lb_AccessorySupplierName.AutoSize = true;
            this.lb_AccessorySupplierName.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AccessorySupplierName.Location = new System.Drawing.Point(449, 199);
            this.lb_AccessorySupplierName.Name = "lb_AccessorySupplierName";
            this.lb_AccessorySupplierName.Size = new System.Drawing.Size(166, 25);
            this.lb_AccessorySupplierName.TabIndex = 39;
            this.lb_AccessorySupplierName.Text = "Nhà cung cấp :";
            // 
            // ccb_NhaCungCap3
            // 
            this.ccb_NhaCungCap3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(90)))));
            this.ccb_NhaCungCap3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccb_NhaCungCap3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ccb_NhaCungCap3.FormattingEnabled = true;
            this.ccb_NhaCungCap3.Location = new System.Drawing.Point(454, 227);
            this.ccb_NhaCungCap3.Name = "ccb_NhaCungCap3";
            this.ccb_NhaCungCap3.Size = new System.Drawing.Size(241, 29);
            this.ccb_NhaCungCap3.TabIndex = 38;
            // 
            // lb_AccessoryType
            // 
            this.lb_AccessoryType.AutoSize = true;
            this.lb_AccessoryType.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AccessoryType.Location = new System.Drawing.Point(654, 60);
            this.lb_AccessoryType.Name = "lb_AccessoryType";
            this.lb_AccessoryType.Size = new System.Drawing.Size(177, 25);
            this.lb_AccessoryType.TabIndex = 35;
            this.lb_AccessoryType.Text = "Loại sản phẩm :";
            // 
            // txt_AccessoriesType
            // 
            this.txt_AccessoriesType.Location = new System.Drawing.Point(659, 88);
            this.txt_AccessoriesType.Name = "txt_AccessoriesType";
            this.txt_AccessoriesType.Size = new System.Drawing.Size(183, 29);
            this.txt_AccessoriesType.TabIndex = 34;
            // 
            // lb_AccessoriesPrice
            // 
            this.lb_AccessoriesPrice.AutoSize = true;
            this.lb_AccessoriesPrice.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AccessoriesPrice.Location = new System.Drawing.Point(42, 198);
            this.lb_AccessoriesPrice.Name = "lb_AccessoriesPrice";
            this.lb_AccessoriesPrice.Size = new System.Drawing.Size(111, 25);
            this.lb_AccessoriesPrice.TabIndex = 33;
            this.lb_AccessoriesPrice.Text = "Giá bán :";
            // 
            // txt_AccessoriesPrice
            // 
            this.txt_AccessoriesPrice.Location = new System.Drawing.Point(47, 226);
            this.txt_AccessoriesPrice.Name = "txt_AccessoriesPrice";
            this.txt_AccessoriesPrice.Size = new System.Drawing.Size(380, 29);
            this.txt_AccessoriesPrice.TabIndex = 32;
            this.txt_AccessoriesPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txt_AccessoriesPrice_Validating);
            // 
            // btn_Cancel2
            // 
            this.btn_Cancel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(155)))));
            this.btn_Cancel2.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Cancel2.Location = new System.Drawing.Point(244, 267);
            this.btn_Cancel2.Name = "btn_Cancel2";
            this.btn_Cancel2.Size = new System.Drawing.Size(183, 44);
            this.btn_Cancel2.TabIndex = 31;
            this.btn_Cancel2.Text = "Huỷ";
            this.btn_Cancel2.UseVisualStyleBackColor = false;
            this.btn_Cancel2.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_AccessoriesSave
            // 
            this.btn_AccessoriesSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(155)))));
            this.btn_AccessoriesSave.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AccessoriesSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_AccessoriesSave.Location = new System.Drawing.Point(47, 267);
            this.btn_AccessoriesSave.Name = "btn_AccessoriesSave";
            this.btn_AccessoriesSave.Size = new System.Drawing.Size(183, 44);
            this.btn_AccessoriesSave.TabIndex = 30;
            this.btn_AccessoriesSave.Text = "Lưu";
            this.btn_AccessoriesSave.UseVisualStyleBackColor = false;
            this.btn_AccessoriesSave.Click += new System.EventHandler(this.btn_AccessoriesSave_Click);
            // 
            // lb_AccOverview
            // 
            this.lb_AccOverview.AutoSize = true;
            this.lb_AccOverview.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AccOverview.Location = new System.Drawing.Point(42, 133);
            this.lb_AccOverview.Name = "lb_AccOverview";
            this.lb_AccOverview.Size = new System.Drawing.Size(133, 25);
            this.lb_AccOverview.TabIndex = 29;
            this.lb_AccOverview.Text = "Tổng quan :";
            // 
            // txt_AccessoriesOverview
            // 
            this.txt_AccessoriesOverview.Location = new System.Drawing.Point(47, 161);
            this.txt_AccessoriesOverview.Name = "txt_AccessoriesOverview";
            this.txt_AccessoriesOverview.Size = new System.Drawing.Size(590, 29);
            this.txt_AccessoriesOverview.TabIndex = 28;
            // 
            // lb_ManufacturerAcc
            // 
            this.lb_ManufacturerAcc.AutoSize = true;
            this.lb_ManufacturerAcc.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ManufacturerAcc.Location = new System.Drawing.Point(378, 60);
            this.lb_ManufacturerAcc.Name = "lb_ManufacturerAcc";
            this.lb_ManufacturerAcc.Size = new System.Drawing.Size(166, 25);
            this.lb_ManufacturerAcc.TabIndex = 27;
            this.lb_ManufacturerAcc.Text = "Nhà sản xuất :";
            // 
            // txt_AccessoriesManufacturer
            // 
            this.txt_AccessoriesManufacturer.Location = new System.Drawing.Point(383, 88);
            this.txt_AccessoriesManufacturer.Name = "txt_AccessoriesManufacturer";
            this.txt_AccessoriesManufacturer.Size = new System.Drawing.Size(252, 29);
            this.txt_AccessoriesManufacturer.TabIndex = 26;
            // 
            // lb_AccessoriesName
            // 
            this.lb_AccessoriesName.AutoSize = true;
            this.lb_AccessoriesName.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AccessoriesName.Location = new System.Drawing.Point(42, 60);
            this.lb_AccessoriesName.Name = "lb_AccessoriesName";
            this.lb_AccessoriesName.Size = new System.Drawing.Size(67, 25);
            this.lb_AccessoriesName.TabIndex = 25;
            this.lb_AccessoriesName.Text = "Tên :";
            // 
            // txt_AccessoriesName
            // 
            this.txt_AccessoriesName.Location = new System.Drawing.Point(47, 88);
            this.txt_AccessoriesName.Name = "txt_AccessoriesName";
            this.txt_AccessoriesName.Size = new System.Drawing.Size(251, 29);
            this.txt_AccessoriesName.TabIndex = 24;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 467);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lb_AddProduct);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm sản phẩm";
            this.lb_AddProduct.ResumeLayout(false);
            this.lb_AddProduct.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageLaptop.ResumeLayout(false);
            this.tabPageLaptop.PerformLayout();
            this.tabPagePC.ResumeLayout(false);
            this.tabPagePC.PerformLayout();
            this.tabPageAccessories.ResumeLayout(false);
            this.tabPageAccessories.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel lb_AddProduct;
        private System.Windows.Forms.TabPage tabPageLaptop;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_LaptopSave;
        private System.Windows.Forms.Label lb_LaptopSpecs;
        private System.Windows.Forms.TextBox txt_Spetification;
        private System.Windows.Forms.Label lb_ManufacturerLaptop;
        private System.Windows.Forms.TextBox txt_Manufacturer;
        private System.Windows.Forms.Label lb_LaptopName;
        private System.Windows.Forms.TextBox txt_LaptopName;
        private System.Windows.Forms.Label lb_LaptopPrice;
        private System.Windows.Forms.TextBox txt_LaptopPrice;
        private System.Windows.Forms.Label lb_LaptopScreenSize;
        private System.Windows.Forms.TextBox txt_ScreenSize;
        private System.Windows.Forms.Label lb_LaptopWeight;
        private System.Windows.Forms.TextBox txt_LaptopWeight;
        private System.Windows.Forms.Label lb_LaptopColor;
        private System.Windows.Forms.TextBox txt_LaptopColour;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePC;
        private System.Windows.Forms.TabPage tabPageAccessories;
        private System.Windows.Forms.Label lb_PcPrice;
        private System.Windows.Forms.TextBox txt_pcPrice;
        private System.Windows.Forms.Button btn_Cancel1;
        private System.Windows.Forms.Button btn_SavePC;
        private System.Windows.Forms.Label lb_PcSpecs;
        private System.Windows.Forms.TextBox txt_pcSpecs;
        private System.Windows.Forms.Label lb_PcManufacturer;
        private System.Windows.Forms.TextBox txt_pcManufacturer;
        private System.Windows.Forms.Label lb_PcName;
        private System.Windows.Forms.TextBox txt_pcName;
        private System.Windows.Forms.Label lb_AccessoryType;
        private System.Windows.Forms.TextBox txt_AccessoriesType;
        private System.Windows.Forms.Label lb_AccessoriesPrice;
        private System.Windows.Forms.TextBox txt_AccessoriesPrice;
        private System.Windows.Forms.Button btn_Cancel2;
        private System.Windows.Forms.Button btn_AccessoriesSave;
        private System.Windows.Forms.Label lb_AccOverview;
        private System.Windows.Forms.TextBox txt_AccessoriesOverview;
        private System.Windows.Forms.Label lb_ManufacturerAcc;
        private System.Windows.Forms.TextBox txt_AccessoriesManufacturer;
        private System.Windows.Forms.Label lb_AccessoriesName;
        private System.Windows.Forms.TextBox txt_AccessoriesName;
        private System.Windows.Forms.Label lb_LaptopSupplierName;
        private System.Windows.Forms.ComboBox ccb_NhaCungCap1;
        private System.Windows.Forms.Label lb_PcSupplierName;
        private System.Windows.Forms.ComboBox ccb_NhaCungCap2;
        private System.Windows.Forms.Label lb_AccessorySupplierName;
        private System.Windows.Forms.ComboBox ccb_NhaCungCap3;
    }
}