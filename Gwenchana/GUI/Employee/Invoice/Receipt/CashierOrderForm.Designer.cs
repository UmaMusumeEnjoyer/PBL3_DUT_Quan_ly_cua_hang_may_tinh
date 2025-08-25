
namespace Gwenchana
{
    partial class CashierOrderForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_ProductList = new System.Windows.Forms.Label();
            this.dgv_Product = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_productPrice = new System.Windows.Forms.TextBox();
            this.txt_productName = new System.Windows.Forms.TextBox();
            this.cashierOrderForm_clearBtn = new System.Windows.Forms.Button();
            this.btn_productAdd = new System.Windows.Forms.Button();
            this.cashierOrderForm_price = new System.Windows.Forms.Label();
            this.lb_ProductPrice = new System.Windows.Forms.Label();
            this.lb_ProductQuantity = new System.Windows.Forms.Label();
            this.productQuantity = new System.Windows.Forms.NumericUpDown();
            this.cashierOrderForm_prodName = new System.Windows.Forms.Label();
            this.lb_Productname = new System.Windows.Forms.Label();
            this.cbb_ProductID = new System.Windows.Forms.ComboBox();
            this.lb_ProductID = new System.Windows.Forms.Label();
            this.ccb_ProductFilter = new System.Windows.Forms.ComboBox();
            this.lb_ProductType = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_TaoHoaDon = new System.Windows.Forms.Button();
            this.cashierOrderForm_receiptBtn = new System.Windows.Forms.Button();
            this.txt_finalTotal = new System.Windows.Forms.Label();
            this.lb_FinalTotal = new System.Windows.Forms.Label();
            this.txt_salePercent = new System.Windows.Forms.TextBox();
            this.lb_SalePercent = new System.Windows.Forms.Label();
            this.lb_totalAmount = new System.Windows.Forms.Label();
            this.lb_TongTien = new System.Windows.Forms.Label();
            this.dgv_Order = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantity)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lb_ProductList);
            this.panel1.Controls.Add(this.dgv_Product);
            this.panel1.Location = new System.Drawing.Point(18, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 477);
            this.panel1.TabIndex = 0;
            // 
            // lb_ProductList
            // 
            this.lb_ProductList.AutoSize = true;
            this.lb_ProductList.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ProductList.Location = new System.Drawing.Point(12, 21);
            this.lb_ProductList.Name = "lb_ProductList";
            this.lb_ProductList.Size = new System.Drawing.Size(232, 25);
            this.lb_ProductList.TabIndex = 3;
            this.lb_ProductList.Text = "Danh sách mặt hàng :";
            // 
            // dgv_Product
            // 
            this.dgv_Product.AllowUserToAddRows = false;
            this.dgv_Product.AllowUserToDeleteRows = false;
            this.dgv_Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgv_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Product.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgv_Product.EnableHeadersVisualStyles = false;
            this.dgv_Product.Location = new System.Drawing.Point(16, 59);
            this.dgv_Product.Name = "dgv_Product";
            this.dgv_Product.ReadOnly = true;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Product.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgv_Product.RowHeadersVisible = false;
            this.dgv_Product.Size = new System.Drawing.Size(1011, 404);
            this.dgv_Product.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txt_productPrice);
            this.panel2.Controls.Add(this.txt_productName);
            this.panel2.Controls.Add(this.cashierOrderForm_clearBtn);
            this.panel2.Controls.Add(this.btn_productAdd);
            this.panel2.Controls.Add(this.cashierOrderForm_price);
            this.panel2.Controls.Add(this.lb_ProductPrice);
            this.panel2.Controls.Add(this.lb_ProductQuantity);
            this.panel2.Controls.Add(this.productQuantity);
            this.panel2.Controls.Add(this.cashierOrderForm_prodName);
            this.panel2.Controls.Add(this.lb_Productname);
            this.panel2.Controls.Add(this.cbb_ProductID);
            this.panel2.Controls.Add(this.lb_ProductID);
            this.panel2.Controls.Add(this.ccb_ProductFilter);
            this.panel2.Controls.Add(this.lb_ProductType);
            this.panel2.Location = new System.Drawing.Point(18, 516);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 333);
            this.panel2.TabIndex = 1;
            // 
            // txt_productPrice
            // 
            this.txt_productPrice.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productPrice.Location = new System.Drawing.Point(155, 163);
            this.txt_productPrice.Name = "txt_productPrice";
            this.txt_productPrice.Size = new System.Drawing.Size(306, 33);
            this.txt_productPrice.TabIndex = 32;
            // 
            // txt_productName
            // 
            this.txt_productName.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productName.Location = new System.Drawing.Point(158, 106);
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.Size = new System.Drawing.Size(306, 35);
            this.txt_productName.TabIndex = 31;
            // 
            // cashierOrderForm_clearBtn
            // 
            this.cashierOrderForm_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.cashierOrderForm_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrderForm_clearBtn.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_clearBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrderForm_clearBtn.Location = new System.Drawing.Point(833, 254);
            this.cashierOrderForm_clearBtn.Name = "cashierOrderForm_clearBtn";
            this.cashierOrderForm_clearBtn.Size = new System.Drawing.Size(194, 49);
            this.cashierOrderForm_clearBtn.TabIndex = 24;
            this.cashierOrderForm_clearBtn.Text = "Xoá toàn bộ";
            this.cashierOrderForm_clearBtn.UseVisualStyleBackColor = false;
            this.cashierOrderForm_clearBtn.Click += new System.EventHandler(this.cashierOrderForm_clearBtn_Click_1);
            // 
            // btn_productAdd
            // 
            this.btn_productAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btn_productAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_productAdd.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productAdd.ForeColor = System.Drawing.Color.White;
            this.btn_productAdd.Location = new System.Drawing.Point(27, 254);
            this.btn_productAdd.Name = "btn_productAdd";
            this.btn_productAdd.Size = new System.Drawing.Size(194, 49);
            this.btn_productAdd.TabIndex = 22;
            this.btn_productAdd.Text = "Thêm";
            this.btn_productAdd.UseVisualStyleBackColor = false;
            this.btn_productAdd.Click += new System.EventHandler(this.cashierOrderForm_addBtn_Click);
            // 
            // cashierOrderForm_price
            // 
            this.cashierOrderForm_price.AutoSize = true;
            this.cashierOrderForm_price.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_price.Location = new System.Drawing.Point(140, 170);
            this.cashierOrderForm_price.Name = "cashierOrderForm_price";
            this.cashierOrderForm_price.Size = new System.Drawing.Size(0, 17);
            this.cashierOrderForm_price.TabIndex = 21;
            // 
            // lb_ProductPrice
            // 
            this.lb_ProductPrice.AutoSize = true;
            this.lb_ProductPrice.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ProductPrice.Location = new System.Drawing.Point(23, 168);
            this.lb_ProductPrice.Name = "lb_ProductPrice";
            this.lb_ProductPrice.Size = new System.Drawing.Size(90, 19);
            this.lb_ProductPrice.TabIndex = 20;
            this.lb_ProductPrice.Text = "Giá (đ) :";
            // 
            // lb_ProductQuantity
            // 
            this.lb_ProductQuantity.AutoSize = true;
            this.lb_ProductQuantity.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ProductQuantity.Location = new System.Drawing.Point(563, 113);
            this.lb_ProductQuantity.Name = "lb_ProductQuantity";
            this.lb_ProductQuantity.Size = new System.Drawing.Size(99, 19);
            this.lb_ProductQuantity.TabIndex = 19;
            this.lb_ProductQuantity.Text = "Số lượng :";
            // 
            // productQuantity
            // 
            this.productQuantity.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productQuantity.Location = new System.Drawing.Point(695, 106);
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.Size = new System.Drawing.Size(212, 33);
            this.productQuantity.TabIndex = 18;
            this.productQuantity.ValueChanged += new System.EventHandler(this.cashierOrderForm_quantity_ValueChanged);
            // 
            // cashierOrderForm_prodName
            // 
            this.cashierOrderForm_prodName.AutoSize = true;
            this.cashierOrderForm_prodName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_prodName.Location = new System.Drawing.Point(140, 113);
            this.cashierOrderForm_prodName.Name = "cashierOrderForm_prodName";
            this.cashierOrderForm_prodName.Size = new System.Drawing.Size(0, 17);
            this.cashierOrderForm_prodName.TabIndex = 17;
            // 
            // lb_Productname
            // 
            this.lb_Productname.AutoSize = true;
            this.lb_Productname.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Productname.Location = new System.Drawing.Point(17, 113);
            this.lb_Productname.Name = "lb_Productname";
            this.lb_Productname.Size = new System.Drawing.Size(135, 19);
            this.lb_Productname.TabIndex = 16;
            this.lb_Productname.Text = "Tên sản phẩm :";
            // 
            // cbb_ProductID
            // 
            this.cbb_ProductID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_ProductID.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_ProductID.FormattingEnabled = true;
            this.cbb_ProductID.Location = new System.Drawing.Point(695, 37);
            this.cbb_ProductID.Name = "cbb_ProductID";
            this.cbb_ProductID.Size = new System.Drawing.Size(212, 35);
            this.cbb_ProductID.TabIndex = 15;
            this.cbb_ProductID.SelectedIndexChanged += new System.EventHandler(this.cbb_ProductID_SelectedIndexChanged);
            // 
            // lb_ProductID
            // 
            this.lb_ProductID.AutoSize = true;
            this.lb_ProductID.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ProductID.Location = new System.Drawing.Point(563, 46);
            this.lb_ProductID.Name = "lb_ProductID";
            this.lb_ProductID.Size = new System.Drawing.Size(126, 19);
            this.lb_ProductID.TabIndex = 14;
            this.lb_ProductID.Text = "Mã sản phẩm :";
            // 
            // ccb_ProductFilter
            // 
            this.ccb_ProductFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccb_ProductFilter.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccb_ProductFilter.FormattingEnabled = true;
            this.ccb_ProductFilter.Items.AddRange(new object[] {
            "Laptop",
            "PC",
            "Linh/ Phụ kiện"});
            this.ccb_ProductFilter.Location = new System.Drawing.Point(158, 44);
            this.ccb_ProductFilter.Name = "ccb_ProductFilter";
            this.ccb_ProductFilter.Size = new System.Drawing.Size(212, 35);
            this.ccb_ProductFilter.TabIndex = 13;
            this.ccb_ProductFilter.SelectedIndexChanged += new System.EventHandler(this.ccb_ProductFilter_SelectedIndexChanged);
            // 
            // lb_ProductType
            // 
            this.lb_ProductType.AutoSize = true;
            this.lb_ProductType.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ProductType.Location = new System.Drawing.Point(17, 46);
            this.lb_ProductType.Name = "lb_ProductType";
            this.lb_ProductType.Size = new System.Drawing.Size(63, 19);
            this.lb_ProductType.TabIndex = 12;
            this.lb_ProductType.Text = "Loại :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btn_TaoHoaDon);
            this.panel3.Controls.Add(this.cashierOrderForm_receiptBtn);
            this.panel3.Controls.Add(this.txt_finalTotal);
            this.panel3.Controls.Add(this.lb_FinalTotal);
            this.panel3.Controls.Add(this.txt_salePercent);
            this.panel3.Controls.Add(this.lb_SalePercent);
            this.panel3.Controls.Add(this.lb_totalAmount);
            this.panel3.Controls.Add(this.lb_TongTien);
            this.panel3.Controls.Add(this.dgv_Order);
            this.panel3.Location = new System.Drawing.Point(1076, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(496, 827);
            this.panel3.TabIndex = 2;
            // 
            // btn_TaoHoaDon
            // 
            this.btn_TaoHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btn_TaoHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TaoHoaDon.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoHoaDon.ForeColor = System.Drawing.Color.White;
            this.btn_TaoHoaDon.Location = new System.Drawing.Point(19, 756);
            this.btn_TaoHoaDon.Name = "btn_TaoHoaDon";
            this.btn_TaoHoaDon.Size = new System.Drawing.Size(134, 49);
            this.btn_TaoHoaDon.TabIndex = 31;
            this.btn_TaoHoaDon.Text = "Lập hoá đơn";
            this.btn_TaoHoaDon.UseVisualStyleBackColor = false;
            this.btn_TaoHoaDon.Click += new System.EventHandler(this.button2_Click);
            // 
            // cashierOrderForm_receiptBtn
            // 
            this.cashierOrderForm_receiptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.cashierOrderForm_receiptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrderForm_receiptBtn.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_receiptBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrderForm_receiptBtn.Location = new System.Drawing.Point(342, 756);
            this.cashierOrderForm_receiptBtn.Name = "cashierOrderForm_receiptBtn";
            this.cashierOrderForm_receiptBtn.Size = new System.Drawing.Size(134, 49);
            this.cashierOrderForm_receiptBtn.TabIndex = 30;
            this.cashierOrderForm_receiptBtn.Text = "Thanh toán";
            this.cashierOrderForm_receiptBtn.UseVisualStyleBackColor = false;
            this.cashierOrderForm_receiptBtn.Click += new System.EventHandler(this.cashierOrderForm_receiptBtn_Click);
            // 
            // txt_finalTotal
            // 
            this.txt_finalTotal.AutoSize = true;
            this.txt_finalTotal.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_finalTotal.Location = new System.Drawing.Point(205, 712);
            this.txt_finalTotal.Name = "txt_finalTotal";
            this.txt_finalTotal.Size = new System.Drawing.Size(18, 19);
            this.txt_finalTotal.TabIndex = 26;
            this.txt_finalTotal.Text = "0";
            // 
            // lb_FinalTotal
            // 
            this.lb_FinalTotal.AutoSize = true;
            this.lb_FinalTotal.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FinalTotal.Location = new System.Drawing.Point(51, 712);
            this.lb_FinalTotal.Name = "lb_FinalTotal";
            this.lb_FinalTotal.Size = new System.Drawing.Size(207, 19);
            this.lb_FinalTotal.TabIndex = 25;
            this.lb_FinalTotal.Text = "Số tiền phải trả (đ) :";
            this.lb_FinalTotal.Click += new System.EventHandler(this.lb_FinalTotal_Click);
            // 
            // txt_salePercent
            // 
            this.txt_salePercent.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salePercent.Location = new System.Drawing.Point(209, 662);
            this.txt_salePercent.Name = "txt_salePercent";
            this.txt_salePercent.Size = new System.Drawing.Size(128, 33);
            this.txt_salePercent.TabIndex = 28;
            this.txt_salePercent.TextChanged += new System.EventHandler(this.txt_salePercent_TextChanged);
            this.txt_salePercent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_salePercent_KeyDown);
            // 
            // lb_SalePercent
            // 
            this.lb_SalePercent.AutoSize = true;
            this.lb_SalePercent.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SalePercent.Location = new System.Drawing.Point(50, 669);
            this.lb_SalePercent.Name = "lb_SalePercent";
            this.lb_SalePercent.Size = new System.Drawing.Size(153, 19);
            this.lb_SalePercent.TabIndex = 27;
            this.lb_SalePercent.Text = "Chiết khấu (%) :";
            // 
            // lb_totalAmount
            // 
            this.lb_totalAmount.AutoSize = true;
            this.lb_totalAmount.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalAmount.Location = new System.Drawing.Point(205, 627);
            this.lb_totalAmount.Name = "lb_totalAmount";
            this.lb_totalAmount.Size = new System.Drawing.Size(18, 19);
            this.lb_totalAmount.TabIndex = 26;
            this.lb_totalAmount.Text = "0";
            // 
            // lb_TongTien
            // 
            this.lb_TongTien.AutoSize = true;
            this.lb_TongTien.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongTien.Location = new System.Drawing.Point(51, 627);
            this.lb_TongTien.Name = "lb_TongTien";
            this.lb_TongTien.Size = new System.Drawing.Size(144, 19);
            this.lb_TongTien.TabIndex = 25;
            this.lb_TongTien.Text = "Tổng tiền (đ) :";
            // 
            // dgv_Order
            // 
            this.dgv_Order.AllowUserToAddRows = false;
            this.dgv_Order.AllowUserToDeleteRows = false;
            this.dgv_Order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Order.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgv_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Order.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgv_Order.EnableHeadersVisualStyles = false;
            this.dgv_Order.Location = new System.Drawing.Point(19, 14);
            this.dgv_Order.Name = "dgv_Order";
            this.dgv_Order.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Order.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgv_Order.RowHeadersVisible = false;
            this.dgv_Order.Size = new System.Drawing.Size(457, 570);
            this.dgv_Order.TabIndex = 4;
            // 
            // CashierOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "CashierOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo đơn hàng";
            this.Load += new System.EventHandler(this.CashierOrderForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantity)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_Product;
        private System.Windows.Forms.Label lb_ProductList;
        private System.Windows.Forms.ComboBox ccb_ProductFilter;
        private System.Windows.Forms.Label lb_ProductType;
        private System.Windows.Forms.ComboBox cbb_ProductID;
        private System.Windows.Forms.Label lb_ProductID;
        private System.Windows.Forms.Label lb_Productname;
        private System.Windows.Forms.Label cashierOrderForm_prodName;
        private System.Windows.Forms.Label lb_ProductQuantity;
        private System.Windows.Forms.NumericUpDown productQuantity;
        private System.Windows.Forms.Label cashierOrderForm_price;
        private System.Windows.Forms.Label lb_ProductPrice;
        private System.Windows.Forms.Button btn_productAdd;
        private System.Windows.Forms.Button cashierOrderForm_clearBtn;
        private System.Windows.Forms.Label lb_totalAmount;
        private System.Windows.Forms.Label lb_TongTien;
        private System.Windows.Forms.DataGridView dgv_Order;
        private System.Windows.Forms.TextBox txt_salePercent;
        private System.Windows.Forms.Label lb_SalePercent;
        private System.Windows.Forms.Label txt_finalTotal;
        private System.Windows.Forms.Label lb_FinalTotal;
        private System.Windows.Forms.Button cashierOrderForm_receiptBtn;
        private System.Windows.Forms.TextBox txt_productPrice;
        private System.Windows.Forms.TextBox txt_productName;
        private System.Windows.Forms.Button btn_TaoHoaDon;
    }
}
