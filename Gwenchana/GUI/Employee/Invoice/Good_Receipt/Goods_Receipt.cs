﻿using Gwenchana.BussinessLogic;
using Gwenchana.DataAccess.DAL;
using Gwenchana.DataAccess.DTO;
using Gwenchana.DataAccess.ViewModel;
using Gwenchana.GUI.Employee.Invoice;
using Gwenchana.LanguagePack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Gwenchana
{
    public partial class Goods_Receipt : Form
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        private string button;
        public int  currentEmployeeID { get; set; }


        //Constructor
        public Goods_Receipt(int cei)
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            LoadTrangThaiComboBox();
            UpdateComponent(LanguageClass.Language);
            LoadData();
            tabControl1.TabPages.Remove(tabPagePetDetail);

            currentEmployeeID = cei;
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;

            if(currentEmployeeID == 0)
            {
                btn_CreateImport.Visible = false; // Ẩn nút Thêm đơn nhập hàng nếu không có nhân viên đăng nhập
            }

            //tabControl1.TabPages.Remove(tabPagePetDetail);
            //btnClose.Click += delegate { this.Close(); };
        }

        private void LoadData()
        {
            Goods_ReceiptBLL goodsReceiptBLL = new Goods_ReceiptBLL();
            DataTable dt = goodsReceiptBLL.GetAllGoodsReceipt();
            dataGridView.DataSource = dt;
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;

            dataGridView.Columns["Mã đơn nhập hàng"].Visible = false; // Ẩn cột Mã đơn nhập hàng
            dataGridView.Columns["Ngày nhập hàng"].HeaderText = Resource.lb_ImportDate;
            dataGridView.Columns["Tên nhân viên"].HeaderText = Resource.lb_employeeName1;
            //dataGridView.Columns["Tên sản phẩm"].HeaderText = "Tên sản phẩm";
            //dataGridView.Columns["Hãng sản xuất"].HeaderText = "Hãng sản xuất";
            dataGridView.Columns["Tên nhà phân phối"].HeaderText = Resource.lb_supplierName;
            //dataGridView.Columns["Số lượng"].HeaderText = "Số lượng nhập";
            //dataGridView.Columns["Giá nhập (VNĐ)"].HeaderText = "Giá nhập";
            dataGridView.Columns["Thành tiền (VNĐ)"].HeaderText = Resource.lb_TotalAmount;

            dataGridView.CellFormatting += dataGridView_CellFormatting; // Đăng ký sự kiện CellFormatting để định dạng ô giá tiền

        }

        private void UpdateComponent(string language)
        {
            Resource.Culture = string.IsNullOrEmpty(language) ? null : new CultureInfo(language);

            lb_ImportInvoice.Text = Resource.btn_importInvoices;
            tabControl1.TabPages[0].Text = Resource.TabCtr_List;
            tabControl1.TabPages[1].Text = Resource.TabCtr_Details;

            lb_Search.Text = Resource.lb_Search;
            btn_Search.Text = Resource.btn_Search;
            btn_ClearFilter.Text = Resource.btn_ClearFilter;
            lb_SearchFilters.Text = Resource.lb_Filters;
            btn_Details.Text = Resource.TabCtr_Details;
            btn_CreateImport.Text = Resource.btn_CreateImport; // Nút Thêm đơn nhập hàng



            LoadTrangThaiComboBox();
        }

        private void LoadTrangThaiComboBox()
        {
            Dictionary<string, string> trangThaiDict = new Dictionary<string, string>()
            {
                { "Tên nhân viên", Resource.lb_employeeName1 },
                { "Tên nhà cung cấp", Resource.lb_supplierName},
                { "Thời gian", Resource.Time_Range }
            };
            cbb_Goods_Receipt_Search.DataSource = new BindingSource(trangThaiDict, null);
            cbb_Goods_Receipt_Search.DisplayMember = "Value";
            cbb_Goods_Receipt_Search.ValueMember = "Key";
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Nếu cột là "price"
            if (dataGridView.Columns[e.ColumnIndex].Name == "Thành tiền (VNĐ)" && e.Value != null && e.Value is decimal)
            {
                // Hiển thị số tiền theo chuẩn Việt Nam và thêm ký hiệu ₫
                decimal gia = (decimal)e.Value;
                e.Value = gia.ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("vi-VN")) + " ₫";
                e.FormattingApplied = true;
            }
        }


        private void AssociateAndRaiseViewEvents()
        {
            btn_Search.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
              {
                  if (e.KeyCode == Keys.Enter)
                      SearchEvent?.Invoke(this, EventArgs.Empty);
              };
            //Others
        }

 


        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

       

        private void btnEdit_Click(object sender, EventArgs e)
        {
            button = "Edit";
            tabControl1.TabPages.Add(tabPagePetDetail);
            tabControl1.TabPages.Remove(tabPagePetList);
            tabControl1.SelectedTab = tabPagePetDetail;


            label3.ForeColor = Color.Gray;
            txt_LaptopID.ForeColor = Color.Gray;
            txt_LaptopID.Enabled = false;
            txt_stockQuantity.Enabled = false;

            txt_LaptopID.Text = dataGridView.CurrentRow.Cells["Product_Id"].Value.ToString();
            txt_LaptopName.Text = dataGridView.CurrentRow.Cells["productName"].Value.ToString();
            txt_Manufacturer.Text = dataGridView.CurrentRow.Cells["Manufacturer"].Value.ToString();
            txt_Spetification.Text = dataGridView.CurrentRow.Cells["specification"].Value.ToString();
            txt_LaptopWeight.Text = dataGridView.CurrentRow.Cells["weight"].Value.ToString();
            txt_ScreenSize.Text = dataGridView.CurrentRow.Cells["screenSize"].Value.ToString();
            txt_LaptopColour.Text = dataGridView.CurrentRow.Cells["colour"].Value.ToString();
            txt_LaptopPrice.Text = dataGridView.CurrentRow.Cells["price"].Value.ToString();
            txt_stockQuantity.Text = dataGridView.CurrentRow.Cells["stockQuantity"].Value.ToString();

        }

        private void txtPetId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetFormState();
        }

        private void ResetFormState()
        {
            // Clear các ô nhập liệu
            txt_Spetification.Clear();
            txt_LaptopPrice.Clear();
            txt_LaptopName.Clear();
            txt_Manufacturer.Clear();
            txt_LaptopID.Clear();
            txt_LaptopWeight.Clear();
            txt_ScreenSize.Clear();
            txt_LaptopColour.Clear();
            txt_stockQuantity.Clear();
            

            // Kích hoạt lại tất cả textbox nếu từng bị disable (Delete mode)
            txt_LaptopName.Enabled = true;
            txt_Manufacturer.Enabled = true;
            txt_Spetification.Enabled = true;
            txt_LaptopPrice.Enabled = true;
            txt_LaptopID.Enabled = true;
            txt_LaptopWeight.Enabled = true;
            txt_ScreenSize.Enabled = true;
            txt_LaptopColour.Enabled = true;
            txt_stockQuantity.Enabled = true;
            
            txt_LaptopID.ForeColor = SystemColors.WindowText;
            label3.ForeColor = SystemColors.ControlText;

            // Chuyển về trang danh sách
            if (!tabControl1.TabPages.Contains(tabPagePetList))
                tabControl1.TabPages.Add(tabPagePetList);
            if (tabControl1.TabPages.Contains(tabPagePetDetail))
                tabControl1.TabPages.Remove(tabPagePetDetail);
            tabControl1.SelectedTab = tabPagePetList;

            // Reset trạng thái logic
            button = null;
            isEdit = false;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            button = "Delete";
            tabControl1.TabPages.Add(tabPagePetDetail);
            tabControl1.TabPages.Remove(tabPagePetList);
            tabControl1.SelectedTab = tabPagePetDetail;

            label3.ForeColor = Color.Gray;
            txt_LaptopID.ForeColor = Color.Gray;
            txt_LaptopID.Enabled = false;
            txt_LaptopName.Enabled = false;
            txt_Manufacturer.Enabled = false;
            txt_Spetification.Enabled = false;
            txt_LaptopPrice.Enabled = false;
            txt_LaptopWeight.Enabled = false;
            txt_ScreenSize.Enabled = false;
            txt_LaptopColour.Enabled = false;
            txt_stockQuantity.Enabled = false;


            txt_LaptopID.Text = dataGridView.CurrentRow.Cells["Product_Id"].Value.ToString();
            txt_LaptopName.Text = dataGridView.CurrentRow.Cells["productName"].Value.ToString();
            txt_Manufacturer.Text = dataGridView.CurrentRow.Cells["Manufacturer"].Value.ToString();
            txt_Spetification.Text = dataGridView.CurrentRow.Cells["specification"].Value.ToString();
            txt_LaptopWeight.Text = dataGridView.CurrentRow.Cells["weight"].Value.ToString();
            txt_ScreenSize.Text = dataGridView.CurrentRow.Cells["screenSize"].Value.ToString();
            txt_LaptopColour.Text = dataGridView.CurrentRow.Cells["colour"].Value.ToString();
            txt_LaptopPrice.Text = dataGridView.CurrentRow.Cells["price"].Value.ToString();
            txt_stockQuantity.Text = dataGridView.CurrentRow.Cells["stockQuantity"].Value.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (button == "Edit")
            {
                int productID = Convert.ToInt32(dataGridView.CurrentRow.Cells["Product_Id"].Value);

                Laptop laptop = new Laptop
                {
                    Product_Id = productID,                           // Thuộc tính kế thừa từ Product
                    productName = txt_LaptopName.Text,                // Thuộc tính kế thừa từ Product
                    Manufacturer = txt_Manufacturer.Text,             // Thuộc tính kế thừa từ Product
                    price = Convert.ToDecimal(txt_LaptopPrice.Text),  // Thuộc tính kế thừa từ Product
                    stockQuantity = Convert.ToInt32(txt_stockQuantity.Text), // Thuộc tính kế thừa từ Product

                    Spectification = txt_Spetification.Text,          // Thuộc tính riêng của Laptop
                    Weight = Convert.ToDecimal(txt_LaptopWeight.Text),  // Thuộc tính riêng của Laptop
                    screenSize = txt_ScreenSize.Text, // Thuộc tính riêng của Laptop
                    Colour = txt_LaptopColour.Text                    // Thuộc tính riêng của Laptop
                };

                LaptopBLL laptopBLL = new LaptopBLL();
                isSuccessful = laptopBLL.UpdateLaptop(laptop);
                if (isSuccessful)
                {
                    message = "Cập nhật sản phẩm thành công.";
                    MessageBox.Show(message);
                    LoadData();
                }
                else
                {
                    message = "Cập nhật sản phẩm thất bại.";
                    MessageBox.Show(message);
                }

                tabControl1.TabPages.Add(tabPagePetList);
                tabControl1.TabPages.Remove(tabPagePetDetail);
                tabControl1.SelectedTab = tabPagePetList;
            }
            else if (button == "Delete")
            {
                // Delete supplier logic
                // Call SaveEvent or any other logic
                int productID = Convert.ToInt32(dataGridView.CurrentRow.Cells["Product_Id"].Value);
                LaptopBLL laptopBLL = new LaptopBLL();
                isSuccessful = laptopBLL.DeleteLaptop(productID);
                if (isSuccessful)
                {
                    message = "Xóa sản phẩm thành công.";
                    MessageBox.Show(message);
                    LoadData();
                }
                else
                {
                    message = "Xóa sản phẩm thất bại.";
                    MessageBox.Show(message);
                }

                tabControl1.TabPages.Add(tabPagePetList);
                tabControl1.TabPages.Remove(tabPagePetDetail);
                tabControl1.SelectedTab = tabPagePetList;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            string employeeName = "";
            string supplierName = "";

            if (cbb_Goods_Receipt_Search.SelectedItem != null)
            {
                employeeName = cbb_Goods_Receipt_Search.SelectedItem.ToString();
            }


            Goods_ReceiptBLL goodsReceiptBLL = new Goods_ReceiptBLL();

            var selectedKey = (cbb_Goods_Receipt_Search.SelectedValue ?? "").ToString();

            if (selectedKey != null)
            {
                if (selectedKey == "Tên nhân viên")
                {
                    dataGridView.DataSource = goodsReceiptBLL.GetAllGoodsReceiptDetails().Where(l => l.EmployeeName.Contains(searchText)).ToList();
                }
                else if (selectedKey == "Tên nhà cung cấp")
                {
                    dataGridView.DataSource = goodsReceiptBLL.GetAllGoodsReceiptDetails().Where(l => l.SupplierName.Contains(searchText)).ToList();
                }
                else if (selectedKey == "Thời gian")
                {
                    DateTime startDate = dtpStartDate.Value.Date;
                    DateTime endDate = dtpEndDate.Value.Date;
                    dataGridView.DataSource = goodsReceiptBLL.GetAllGoodsReceiptDetails()
                        .Where(l => l.GoodsReceiptDate >= startDate && l.GoodsReceiptDate <= endDate).ToList();
                }
            }

        }

        private void txt_Manufacturer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_LaptopWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_Goods_Receipt_Search.SelectedItem != null)
            {
                if (cbb_Goods_Receipt_Search.SelectedItem.ToString() == "Thời gian")
                {
                    dtpStartDate.Enabled = true;
                    dtpEndDate.Enabled = true;
                }
            }
        }

        private void btn_ClearFilter_Click(object sender, EventArgs e)
        {
            cbb_Goods_Receipt_Search.SelectedIndex = -1;
            txtSearch.Clear();
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            LoadData();
        }

        private void cbb_LaptopSearch_TextUpdate(object sender, EventArgs e)
        {
            string a = cbb_Goods_Receipt_Search.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Goods_ReceiptForm goodsReceiptForm = new Goods_ReceiptForm(currentEmployeeID);
            goodsReceiptForm.ShowDialog();
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView.CurrentRow.Cells["Mã đơn nhập hàng"].Value);
            Goods_Receipt_Details details = new Goods_Receipt_Details(ID);
            details.ShowDialog();
        }
    }
}
