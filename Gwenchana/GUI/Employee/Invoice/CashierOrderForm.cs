using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Gwenchana.BussinessLogic;
using Gwenchana.DataAccess;
using Gwenchana.DataAccess.ViewModel;


namespace Gwenchana
{
    public partial class CashierOrderForm : Form
    {

        public CashierOrderForm()
        {
            InitializeComponent();

            txt_productName.Enabled = false;
            txt_productPrice.Enabled = false;

        }

        public void ClearDataGridViewData()
        {
            dgv_Product.DataSource = null;
            dgv_Product.Rows.Clear();
            dgv_Product.Refresh();
        }   

        private void ccb_ProductFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(ccb_ProductFilter.SelectedItem.ToString())
            {

                case "PC":
                    ClearDataGridViewData();
                    PCBLL pcBLL = new PCBLL();
                    DataTable dt = pcBLL.GetAllPCsDataTable();
                    dgv_Product.ReadOnly = true;
                    dgv_Product.AllowUserToAddRows = false;
                    dgv_Product.AllowUserToDeleteRows = false;
                    dgv_Product.DataSource = dt;
                    dgv_Product.Columns["Product_Id"].HeaderText = "Mã sản phẩm";
                    dgv_Product.Columns["productName"].HeaderText = "Tên sản phẩm";
                    dgv_Product.Columns["Manufacturer"].HeaderText = "Nhà sản xuất";
                    dgv_Product.Columns["specification"].HeaderText = "Thông số kỹ thuật";
                    dgv_Product.Columns["price"].HeaderText = "Giá";
                    dgv_Product.Columns["stockQuantity"].HeaderText = "Số lượng tồn kho";
                    setcbb_ProductID();
                    break;

                case "Laptop":
                    ClearDataGridViewData();
                    LaptopBLL laptopBLL = new LaptopBLL();
                    DataTable dtt = laptopBLL.GetAllLaptopsDataTable();
                    dgv_Product.DataSource = dtt;
                    dgv_Product.ReadOnly = true;
                    dgv_Product.AllowUserToAddRows = false;
                    dgv_Product.AllowUserToDeleteRows = false;
                    dgv_Product.Columns["Product_Id"].HeaderText = "Mã sản phẩm";
                    dgv_Product.Columns["productName"].HeaderText = "Tên sản phẩm";
                    dgv_Product.Columns["Manufacturer"].HeaderText = "Nhà sản xuất";
                    dgv_Product.Columns["specification"].HeaderText = "Thông số kỹ thuật";
                    dgv_Product.Columns["weight"].HeaderText = "Trọng lượng";
                    dgv_Product.Columns["screenSize"].HeaderText = "Kích cỡ màn hình";
                    dgv_Product.Columns["colour"].HeaderText = "Màu sắc";
                    dgv_Product.Columns["price"].HeaderText = "Giá";
                    dgv_Product.Columns["stockQuantity"].HeaderText = "Số lượng tồn kho";
                    setcbb_ProductID();
                    break;

                case "Linh/ Phụ kiện":
                    ClearDataGridViewData();
                    AccessoriesBLL accessoriesBLL = new AccessoriesBLL();
                    DataTable dttt = accessoriesBLL.GetAllAccessoriesDataTable();
                    dgv_Product.ReadOnly = true;
                    dgv_Product.AllowUserToAddRows = false;
                    dgv_Product.AllowUserToDeleteRows = false;
                    dgv_Product.DataSource = dttt;
                    dgv_Product.Columns["Product_Id"].HeaderText = "Mã sản phẩm";
                    dgv_Product.Columns["productName"].HeaderText = "Tên sản phẩm";
                    dgv_Product.Columns["Manufacturer"].HeaderText = "Nhà sản xuất";
                    dgv_Product.Columns["overview"].HeaderText = "Mô tả";
                    dgv_Product.Columns["type"].HeaderText = "Loại sản phẩm";
                    dgv_Product.Columns["price"].HeaderText = "Giá";
                    dgv_Product.Columns["stockQuantity"].HeaderText = "Số lượng tồn kho";
                    setcbb_ProductID();
                    break;

                default:
                    break;
            }
        }
        public void setcbb_ProductID()
        {
            cbb_ProductID.Items.Clear();
            for (int i = 0; i < dgv_Product.Rows.Count; i++)
            {
                cbb_ProductID.Items.Add(dgv_Product.Rows[i].Cells[0].Value.ToString());
            }
        }

        private void cbb_ProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedId = cbb_ProductID.SelectedItem.ToString();

            foreach (DataGridViewRow row in dgv_Product.Rows)
            {
                if (row.Cells["Product_Id"].Value != null && row.Cells["Product_Id"].Value.ToString() == selectedId)
                {
                    // Gán dữ liệu vào các TextBox
                    txt_productName.Text = row.Cells["productName"].Value.ToString();
                    txt_productPrice.Text = row.Cells["price"].Value.ToString();

                    // Trỏ DataGridView tới dòng tương ứng
                    row.Selected = true;
                    dgv_Product.CurrentCell = row.Cells[0]; // hoặc chỉ định cột cụ thể khác nếu muốn
                    dgv_Product.FirstDisplayedScrollingRowIndex = row.Index;

                    break;
                }
            }
        }


        private void cashierOrderForm_addBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_productName.Text) || string.IsNullOrEmpty(txt_productPrice.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trước khi thêm vào giỏ hàng.");
                return;
            }
        }

        private void CashierOrderForm_Load(object sender, EventArgs e)
        {

        }
    }
}
