
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Goods_ReceiptForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Product = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_productPrice = new System.Windows.Forms.TextBox();
            this.txt_productName = new System.Windows.Forms.TextBox();
            this.cashierOrderForm_clearBtn = new System.Windows.Forms.Button();
            this.btn_productAdd = new System.Windows.Forms.Button();
            this.cashierOrderForm_price = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.productQuantity = new System.Windows.Forms.NumericUpDown();
            this.cashierOrderForm_prodName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_ProductID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ccb_ProductFilter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgv_Product);
            this.panel1.Location = new System.Drawing.Point(18, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 345);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(643, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 36);
            this.button1.TabIndex = 25;
            this.button1.Text = "Thêm sản phẩm mới";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh sách mặt hàng :";
            // 
            // dgv_Product
            // 
            this.dgv_Product.AllowUserToAddRows = false;
            this.dgv_Product.AllowUserToDeleteRows = false;
            this.dgv_Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product.EnableHeadersVisualStyles = false;
            this.dgv_Product.Location = new System.Drawing.Point(16, 59);
            this.dgv_Product.Name = "dgv_Product";
            this.dgv_Product.ReadOnly = true;
            this.dgv_Product.RowHeadersVisible = false;
            this.dgv_Product.Size = new System.Drawing.Size(777, 265);
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
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.productQuantity);
            this.panel2.Controls.Add(this.cashierOrderForm_prodName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbb_ProductID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ccb_ProductFilter);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(18, 388);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 333);
            this.panel2.TabIndex = 1;
            // 
            // txt_productPrice
            // 
            this.txt_productPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productPrice.Location = new System.Drawing.Point(131, 165);
            this.txt_productPrice.Name = "txt_productPrice";
            this.txt_productPrice.Size = new System.Drawing.Size(330, 26);
            this.txt_productPrice.TabIndex = 32;
            // 
            // txt_productName
            // 
            this.txt_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productName.Location = new System.Drawing.Point(131, 108);
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.Size = new System.Drawing.Size(306, 26);
            this.txt_productName.TabIndex = 31;
            // 
            // cashierOrderForm_clearBtn
            // 
            this.cashierOrderForm_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.cashierOrderForm_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrderForm_clearBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_clearBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrderForm_clearBtn.Location = new System.Drawing.Point(588, 254);
            this.cashierOrderForm_clearBtn.Name = "cashierOrderForm_clearBtn";
            this.cashierOrderForm_clearBtn.Size = new System.Drawing.Size(194, 49);
            this.cashierOrderForm_clearBtn.TabIndex = 24;
            this.cashierOrderForm_clearBtn.Text = "Xoá toàn bộ";
            this.cashierOrderForm_clearBtn.UseVisualStyleBackColor = false;
            // 
            // btn_productAdd
            // 
            this.btn_productAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btn_productAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_productAdd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Giá nhập (đ) :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(443, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Số lượng :";
            // 
            // productQuantity
            // 
            this.productQuantity.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productQuantity.Location = new System.Drawing.Point(523, 106);
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.Size = new System.Drawing.Size(212, 29);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tên sản phẩm :";
            // 
            // cbb_ProductID
            // 
            this.cbb_ProductID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_ProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_ProductID.FormattingEnabled = true;
            this.cbb_ProductID.Location = new System.Drawing.Point(523, 38);
            this.cbb_ProductID.Name = "cbb_ProductID";
            this.cbb_ProductID.Size = new System.Drawing.Size(212, 32);
            this.cbb_ProductID.TabIndex = 15;
            this.cbb_ProductID.SelectedIndexChanged += new System.EventHandler(this.cbb_ProductID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(413, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã sản phẩm :";
            // 
            // ccb_ProductFilter
            // 
            this.ccb_ProductFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccb_ProductFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccb_ProductFilter.FormattingEnabled = true;
            this.ccb_ProductFilter.Items.AddRange(new object[] {
            "Laptop",
            "PC",
            "Linh/ Phụ kiện"});
            this.ccb_ProductFilter.Location = new System.Drawing.Point(143, 38);
            this.ccb_ProductFilter.Name = "ccb_ProductFilter";
            this.ccb_ProductFilter.Size = new System.Drawing.Size(212, 32);
            this.ccb_ProductFilter.TabIndex = 13;
            this.ccb_ProductFilter.SelectedIndexChanged += new System.EventHandler(this.ccb_ProductFilter_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Loại :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.cashierOrderForm_receiptBtn);
            this.panel3.Controls.Add(this.dgv_Order);
            this.panel3.Location = new System.Drawing.Point(848, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 695);
            this.panel3.TabIndex = 2;
            // 
            // cashierOrderForm_receiptBtn
            // 
            this.cashierOrderForm_receiptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.cashierOrderForm_receiptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrderForm_receiptBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_receiptBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrderForm_receiptBtn.Location = new System.Drawing.Point(56, 616);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Order.EnableHeadersVisualStyles = false;
            this.dgv_Order.Location = new System.Drawing.Point(19, 33);
            this.dgv_Order.Name = "dgv_Order";
            this.dgv_Order.ReadOnly = true;
            this.dgv_Order.RowHeadersVisible = false;
            this.dgv_Order.Size = new System.Drawing.Size(379, 426);
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
            this.ClientSize = new System.Drawing.Size(1269, 729);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ccb_ProductFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_ProductID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cashierOrderForm_prodName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown productQuantity;
        private System.Windows.Forms.Label cashierOrderForm_price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_productAdd;
        private System.Windows.Forms.Button cashierOrderForm_clearBtn;
        private System.Windows.Forms.DataGridView dgv_Order;
        private System.Windows.Forms.Button cashierOrderForm_receiptBtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_productPrice;
        private System.Windows.Forms.TextBox txt_productName;
    }
}
