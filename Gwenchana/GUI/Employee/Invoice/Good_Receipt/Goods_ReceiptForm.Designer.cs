
using System.Windows.Forms;

namespace Gwenchana
{
    partial class Goods_ReceiptForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Goods_ReceiptForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_AddProduct = new System.Windows.Forms.Button();
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
            this.lb_ProductName = new System.Windows.Forms.Label();
            this.cbb_ProductID = new System.Windows.Forms.ComboBox();
            this.lb_ProductID = new System.Windows.Forms.Label();
            this.ccb_ProductFilter = new System.Windows.Forms.ComboBox();
            this.lb_ProductType = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cashierOrderForm_receiptBtn = new System.Windows.Forms.Button();
            this.dgv_Order = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
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
            this.panel1.Controls.Add(this.btn_AddProduct);
            this.panel1.Controls.Add(this.lb_ProductList);
            this.panel1.Controls.Add(this.dgv_Product);
            this.panel1.Location = new System.Drawing.Point(18, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 477);
            this.panel1.TabIndex = 0;
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btn_AddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddProduct.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddProduct.ForeColor = System.Drawing.Color.White;
            this.btn_AddProduct.Location = new System.Drawing.Point(858, 14);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(181, 36);
            this.btn_AddProduct.TabIndex = 25;
            this.btn_AddProduct.Text = "Thêm sản phẩm mới";
            this.btn_AddProduct.UseVisualStyleBackColor = false;
            this.btn_AddProduct.Click += new System.EventHandler(this.button1_Click);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Product.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Product.EnableHeadersVisualStyles = false;
            this.dgv_Product.Location = new System.Drawing.Point(16, 59);
            this.dgv_Product.Name = "dgv_Product";
            this.dgv_Product.ReadOnly = true;
            this.dgv_Product.RowHeadersVisible = false;
            this.dgv_Product.Size = new System.Drawing.Size(1023, 402);
            this.dgv_Product.TabIndex = 2;
            this.dgv_Product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Product_CellContentClick);
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
            this.panel2.Controls.Add(this.lb_ProductName);
            this.panel2.Controls.Add(this.cbb_ProductID);
            this.panel2.Controls.Add(this.lb_ProductID);
            this.panel2.Controls.Add(this.ccb_ProductFilter);
            this.panel2.Controls.Add(this.lb_ProductType);
            this.panel2.Location = new System.Drawing.Point(18, 516);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1052, 333);
            this.panel2.TabIndex = 1;
            // 
            // txt_productPrice
            // 
            this.txt_productPrice.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productPrice.Location = new System.Drawing.Point(146, 165);
            this.txt_productPrice.Name = "txt_productPrice";
            this.txt_productPrice.Size = new System.Drawing.Size(330, 33);
            this.txt_productPrice.TabIndex = 32;
            this.txt_productPrice.TextChanged += new System.EventHandler(this.txt_productPrice_TextChanged);
            // 
            // txt_productName
            // 
            this.txt_productName.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productName.Location = new System.Drawing.Point(146, 109);
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.Size = new System.Drawing.Size(306, 33);
            this.txt_productName.TabIndex = 31;
            // 
            // cashierOrderForm_clearBtn
            // 
            this.cashierOrderForm_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.cashierOrderForm_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrderForm_clearBtn.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_clearBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrderForm_clearBtn.Location = new System.Drawing.Point(661, 254);
            this.cashierOrderForm_clearBtn.Name = "cashierOrderForm_clearBtn";
            this.cashierOrderForm_clearBtn.Size = new System.Drawing.Size(194, 49);
            this.cashierOrderForm_clearBtn.TabIndex = 24;
            this.cashierOrderForm_clearBtn.Text = "Xoá toàn bộ";
            this.cashierOrderForm_clearBtn.UseVisualStyleBackColor = false;
            this.cashierOrderForm_clearBtn.Click += new System.EventHandler(this.cashierOrderForm_clearBtn_Click);
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
            this.lb_ProductPrice.Location = new System.Drawing.Point(13, 179);
            this.lb_ProductPrice.Name = "lb_ProductPrice";
            this.lb_ProductPrice.Size = new System.Drawing.Size(135, 19);
            this.lb_ProductPrice.TabIndex = 20;
            this.lb_ProductPrice.Text = "Giá nhập (đ) :";
            // 
            // lb_ProductQuantity
            // 
            this.lb_ProductQuantity.AutoSize = true;
            this.lb_ProductQuantity.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ProductQuantity.Location = new System.Drawing.Point(538, 112);
            this.lb_ProductQuantity.Name = "lb_ProductQuantity";
            this.lb_ProductQuantity.Size = new System.Drawing.Size(99, 19);
            this.lb_ProductQuantity.TabIndex = 19;
            this.lb_ProductQuantity.Text = "Số lượng :";
            // 
            // productQuantity
            // 
            this.productQuantity.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productQuantity.Location = new System.Drawing.Point(643, 106);
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
            // lb_ProductName
            // 
            this.lb_ProductName.AutoSize = true;
            this.lb_ProductName.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ProductName.Location = new System.Drawing.Point(12, 116);
            this.lb_ProductName.Name = "lb_ProductName";
            this.lb_ProductName.Size = new System.Drawing.Size(135, 19);
            this.lb_ProductName.TabIndex = 16;
            this.lb_ProductName.Text = "Tên sản phẩm :";
            // 
            // cbb_ProductID
            // 
            this.cbb_ProductID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_ProductID.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_ProductID.FormattingEnabled = true;
            this.cbb_ProductID.Location = new System.Drawing.Point(643, 38);
            this.cbb_ProductID.Name = "cbb_ProductID";
            this.cbb_ProductID.Size = new System.Drawing.Size(212, 35);
            this.cbb_ProductID.TabIndex = 15;
            this.cbb_ProductID.SelectedIndexChanged += new System.EventHandler(this.cbb_ProductID_SelectedIndexChanged);
            // 
            // lb_ProductID
            // 
            this.lb_ProductID.AutoSize = true;
            this.lb_ProductID.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ProductID.Location = new System.Drawing.Point(511, 50);
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
            this.ccb_ProductFilter.Location = new System.Drawing.Point(146, 38);
            this.ccb_ProductFilter.Name = "ccb_ProductFilter";
            this.ccb_ProductFilter.Size = new System.Drawing.Size(212, 35);
            this.ccb_ProductFilter.TabIndex = 13;
            this.ccb_ProductFilter.SelectedIndexChanged += new System.EventHandler(this.ccb_ProductFilter_SelectedIndexChanged);
            // 
            // lb_ProductType
            // 
            this.lb_ProductType.AutoSize = true;
            this.lb_ProductType.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ProductType.Location = new System.Drawing.Point(84, 50);
            this.lb_ProductType.Name = "lb_ProductType";
            this.lb_ProductType.Size = new System.Drawing.Size(63, 19);
            this.lb_ProductType.TabIndex = 12;
            this.lb_ProductType.Text = "Loại :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.cashierOrderForm_receiptBtn);
            this.panel3.Controls.Add(this.dgv_Order);
            this.panel3.Location = new System.Drawing.Point(1076, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(496, 827);
            this.panel3.TabIndex = 2;
            // 
            // cashierOrderForm_receiptBtn
            // 
            this.cashierOrderForm_receiptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.cashierOrderForm_receiptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrderForm_receiptBtn.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_receiptBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrderForm_receiptBtn.Location = new System.Drawing.Point(99, 748);
            this.cashierOrderForm_receiptBtn.Name = "cashierOrderForm_receiptBtn";
            this.cashierOrderForm_receiptBtn.Size = new System.Drawing.Size(310, 49);
            this.cashierOrderForm_receiptBtn.TabIndex = 30;
            this.cashierOrderForm_receiptBtn.Text = "Nhập hàng";
            this.cashierOrderForm_receiptBtn.UseVisualStyleBackColor = false;
            this.cashierOrderForm_receiptBtn.Click += new System.EventHandler(this.cashierOrderForm_receiptBtn_Click);
            // 
            // dgv_Order
            // 
            this.dgv_Order.AllowUserToAddRows = false;
            this.dgv_Order.AllowUserToDeleteRows = false;
            this.dgv_Order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Order.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Order.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Order.EnableHeadersVisualStyles = false;
            this.dgv_Order.Location = new System.Drawing.Point(16, 14);
            this.dgv_Order.Name = "dgv_Order";
            this.dgv_Order.ReadOnly = true;
            this.dgv_Order.RowHeadersVisible = false;
            this.dgv_Order.Size = new System.Drawing.Size(466, 597);
            this.dgv_Order.TabIndex = 4;
            this.dgv_Order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Order_CellContentClick);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Goods_ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Goods_ReceiptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo đơn nhập hàng";
            this.Load += new System.EventHandler(this.CashierOrderForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantity)).EndInit();
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.Label lb_ProductName;
        private System.Windows.Forms.Label cashierOrderForm_prodName;
        private System.Windows.Forms.Label lb_ProductQuantity;
        private System.Windows.Forms.NumericUpDown productQuantity;
        private System.Windows.Forms.Label cashierOrderForm_price;
        private System.Windows.Forms.Label lb_ProductPrice;
        private System.Windows.Forms.Button btn_productAdd;
        private System.Windows.Forms.Button cashierOrderForm_clearBtn;
        private System.Windows.Forms.DataGridView dgv_Order;
        private System.Windows.Forms.Button cashierOrderForm_receiptBtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.TextBox txt_productPrice;
        private System.Windows.Forms.TextBox txt_productName;
        private TableLayoutPanel tablePanel1;
        private FlowLayoutPanel flowPanelTop1;
        private TableLayoutPanel tablePanel3;
        private TableLayoutPanel tableLayoutMain;
    }
}
