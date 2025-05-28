
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
            this.tttt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePetList = new System.Windows.Forms.TabPage();
            this.btn_addCustomer = new System.Windows.Forms.Button();
            this.btn_ClearFilter = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbb_LaptopSearch = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabPagePetDetail = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sodondathuchien = new System.Windows.Forms.TextBox();
            this.lb_Email = new System.Windows.Forms.Label();
            this.btn_Address = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lb6 = new System.Windows.Forms.Label();
            this.txt_phoneNumber = new System.Windows.Forms.TextBox();
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
            // tttt
            // 
            this.tttt.AutoSize = true;
            this.tttt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tttt.Location = new System.Drawing.Point(53, 17);
            this.tttt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tttt.Name = "tttt";
            this.tttt.Size = new System.Drawing.Size(201, 25);
            this.tttt.TabIndex = 0;
            this.tttt.Text = "Thông tin khách hàng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.tttt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 56);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(825, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 30);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePetList);
            this.tabControl1.Controls.Add(this.tabPagePetDetail);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(866, 411);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPagePetList
            // 
            this.tabPagePetList.Controls.Add(this.btn_addCustomer);
            this.tabPagePetList.Controls.Add(this.btn_ClearFilter);
            this.tabPagePetList.Controls.Add(this.label7);
            this.tabPagePetList.Controls.Add(this.cbb_LaptopSearch);
            this.tabPagePetList.Controls.Add(this.dataGridView);
            this.tabPagePetList.Controls.Add(this.label2);
            this.tabPagePetList.Controls.Add(this.btnEdit);
            this.tabPagePetList.Controls.Add(this.btnSearch);
            this.tabPagePetList.Controls.Add(this.txtSearch);
            this.tabPagePetList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagePetList.Location = new System.Drawing.Point(4, 29);
            this.tabPagePetList.Name = "tabPagePetList";
            this.tabPagePetList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePetList.Size = new System.Drawing.Size(858, 378);
            this.tabPagePetList.TabIndex = 0;
            this.tabPagePetList.Text = "Danh sách";
            this.tabPagePetList.UseVisualStyleBackColor = true;
            // 
            // btn_addCustomer
            // 
            this.btn_addCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addCustomer.Location = new System.Drawing.Point(741, 134);
            this.btn_addCustomer.Name = "btn_addCustomer";
            this.btn_addCustomer.Size = new System.Drawing.Size(99, 30);
            this.btn_addCustomer.TabIndex = 11;
            this.btn_addCustomer.Text = "Thêm";
            this.btn_addCustomer.UseVisualStyleBackColor = true;
            this.btn_addCustomer.Click += new System.EventHandler(this.btn_addCustomer_Click);
            // 
            // btn_ClearFilter
            // 
            this.btn_ClearFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ClearFilter.Location = new System.Drawing.Point(747, 6);
            this.btn_ClearFilter.Name = "btn_ClearFilter";
            this.btn_ClearFilter.Size = new System.Drawing.Size(74, 28);
            this.btn_ClearFilter.TabIndex = 10;
            this.btn_ClearFilter.Text = "Xoá";
            this.btn_ClearFilter.UseVisualStyleBackColor = true;
            this.btn_ClearFilter.Click += new System.EventHandler(this.btn_ClearFilter_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(512, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tiêu chí :";
            // 
            // cbb_LaptopSearch
            // 
            this.cbb_LaptopSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_LaptopSearch.FormattingEnabled = true;
            this.cbb_LaptopSearch.Items.AddRange(new object[] {
            "Tên",
            "Hãng sản xuất",
            "Cân nặng",
            "Màu sắc"});
            this.cbb_LaptopSearch.Location = new System.Drawing.Point(601, 6);
            this.cbb_LaptopSearch.Name = "cbb_LaptopSearch";
            this.cbb_LaptopSearch.Size = new System.Drawing.Size(140, 28);
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
            this.dataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(24, 73);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(711, 297);
            this.dataGridView.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tìm kiếm : ";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(741, 98);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(99, 30);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(642, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(24, 41);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(612, 26);
            this.txtSearch.TabIndex = 0;
            // 
            // tabPagePetDetail
            // 
            this.tabPagePetDetail.Controls.Add(this.label5);
            this.tabPagePetDetail.Controls.Add(this.txt_Email);
            this.tabPagePetDetail.Controls.Add(this.label1);
            this.tabPagePetDetail.Controls.Add(this.txt_sodondathuchien);
            this.tabPagePetDetail.Controls.Add(this.lb_Email);
            this.tabPagePetDetail.Controls.Add(this.btn_Address);
            this.tabPagePetDetail.Controls.Add(this.btnCancel);
            this.tabPagePetDetail.Controls.Add(this.btnSave);
            this.tabPagePetDetail.Controls.Add(this.lb6);
            this.tabPagePetDetail.Controls.Add(this.txt_phoneNumber);
            this.tabPagePetDetail.Controls.Add(this.label4);
            this.tabPagePetDetail.Controls.Add(this.txt_LaptopName);
            this.tabPagePetDetail.Controls.Add(this.label3);
            this.tabPagePetDetail.Controls.Add(this.txt_LaptopID);
            this.tabPagePetDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagePetDetail.Location = new System.Drawing.Point(4, 29);
            this.tabPagePetDetail.Name = "tabPagePetDetail";
            this.tabPagePetDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePetDetail.Size = new System.Drawing.Size(858, 378);
            this.tabPagePetDetail.TabIndex = 1;
            this.tabPagePetDetail.Text = "Thông tin chi tiết";
            this.tabPagePetDetail.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(312, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Email :";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(316, 198);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(307, 29);
            this.txt_Email.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Số đơn đã thực hiện :";
            // 
            // txt_sodondathuchien
            // 
            this.txt_sodondathuchien.Location = new System.Drawing.Point(316, 120);
            this.txt_sodondathuchien.Name = "txt_sodondathuchien";
            this.txt_sodondathuchien.Size = new System.Drawing.Size(183, 29);
            this.txt_sodondathuchien.TabIndex = 18;
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email.Location = new System.Drawing.Point(59, 240);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(65, 20);
            this.lb_Email.TabIndex = 17;
            this.lb_Email.Text = "Địa chỉ :";
            // 
            // btn_Address
            // 
            this.btn_Address.Location = new System.Drawing.Point(63, 263);
            this.btn_Address.Name = "btn_Address";
            this.btn_Address.Size = new System.Drawing.Size(380, 29);
            this.btn_Address.TabIndex = 16;
            // 
            // btnCancel
            // 
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
            this.lb6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb6.Location = new System.Drawing.Point(59, 175);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(110, 20);
            this.lb6.TabIndex = 13;
            this.lb6.Text = "Số điện thoại :";
            // 
            // txt_phoneNumber
            // 
            this.txt_phoneNumber.Location = new System.Drawing.Point(63, 198);
            this.txt_phoneNumber.Name = "txt_phoneNumber";
            this.txt_phoneNumber.Size = new System.Drawing.Size(227, 29);
            this.txt_phoneNumber.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tên khách hàng :";
            // 
            // txt_LaptopName
            // 
            this.txt_LaptopName.Location = new System.Drawing.Point(63, 120);
            this.txt_LaptopName.Name = "txt_LaptopName";
            this.txt_LaptopName.Size = new System.Drawing.Size(183, 29);
            this.txt_LaptopName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
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
            // CustomerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 467);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustomerUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PetView";
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

        private System.Windows.Forms.Label tttt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePetList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TabPage tabPagePetDetail;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.TextBox txt_phoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_LaptopName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_LaptopID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.TextBox btn_Address;
        private System.Windows.Forms.ComboBox cbb_LaptopSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_ClearFilter;
        private System.Windows.Forms.Button btn_addCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sodondathuchien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Email;
    }
}