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
using Gwenchana.DataAccess.DTO;


namespace Gwenchana
{
    public partial class CashierOrderForm : Form
    {

        public decimal totalAmount { get; set; }
        public CashierOrderForm()
        {
            InitializeComponent();

            txt_productName.Enabled = false;
            txt_productPrice.Enabled = false;
            dgv_Order.Columns.Clear();

            dgv_Order.Columns.Add("Product_Id", "Mã sản phẩm");
            dgv_Order.Columns.Add("productName", "Tên sản phẩm");
            dgv_Order.Columns.Add("price", "Giá");
            dgv_Order.Columns.Add("quantity", "Số lượng");
            dgv_Order.Columns.Add("totalPrice", "Thành tiền");

            dgv_Order.ReadOnly = true;
            dgv_Order.AllowUserToAddRows = false;
            totalAmount = 0;
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
                    productQuantity.Value = 1; // Đặt giá trị mặc định cho số lượng là 1
                    productQuantity.Maximum = Convert.ToInt32(row.Cells["stockQuantity"].Value); // Đặt giá trị tối đa cho số lượng là số lượng tồn kho

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
            else
            {
                if (dgv_Product.CurrentRow != null)
                {
                    DataGridViewRow selectedRow = dgv_Product.CurrentRow;

                    string productId = selectedRow.Cells["Product_Id"].Value.ToString();
                    string productName = selectedRow.Cells["productName"].Value.ToString();
                    decimal price = Convert.ToDecimal(selectedRow.Cells["price"].Value);
                    int quantity = (int)productQuantity.Value;
                    decimal totalPrice = price * quantity;

                    // Kiểm tra nếu sản phẩm đã tồn tại trong dgv_SelectedProducts thì cộng dồn số lượng
                    bool found = false;
                    foreach (DataGridViewRow row in dgv_Order.Rows)
                    {
                        if (row.Cells["Product_Id"].Value.ToString() == productId)
                        {
                            int oldQty = Convert.ToInt32(row.Cells["quantity"].Value);
                            row.Cells["quantity"].Value = oldQty + quantity;
                            row.Cells["totalPrice"].Value = (oldQty + quantity) * price;
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        dgv_Order.Rows.Add(productId, productName, price, quantity, totalPrice);
                    }
                }
            }
            // Cập nhật lại tổng tiền
            totalAmount += Convert.ToDecimal(txt_productPrice.Text) * productQuantity.Value;
            lb_totalAmount.Text = totalAmount.ToString();



        }

        private void CashierOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void cashierOrderForm_quantity_ValueChanged(object sender, EventArgs e)
        {

        }
        private void txt_salePercent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txt_salePercent.Text))
                {
                    // Nếu không nhập gì -> giữ nguyên giá gốc
                    txt_finalTotal.Text = totalAmount.ToString();
                    return;
                }

                if (decimal.TryParse(txt_salePercent.Text, out decimal discountPercent))
                {
                    if (discountPercent < 0 || discountPercent > 100)
                    {
                        MessageBox.Show("Phần trăm giảm giá phải từ 0 đến 100.");
                        txt_salePercent.Text = "";
                        return;
                    }

                    decimal discountAmount = totalAmount * discountPercent / 100;
                    decimal finalAmount = totalAmount - discountAmount;
                    txt_finalTotal.Text = finalAmount.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số hợp lệ cho phần trăm giảm giá.");
                    txt_salePercent.Text = "";
                }

                e.SuppressKeyPress = true;
            }
        }

        private void cashierOrderForm_receiptBtn_Click(object sender, EventArgs e)
        {
            using (var selectForm = new CustomerCashUI())
            {
                if (selectForm.ShowDialog() == DialogResult.OK)
                {
                    Customer selectedCustomer = selectForm.currentCustomer;
                 
                    MessageBox.Show("Khách hàng được chọn: " + selectedCustomer.customerName);
                }
            }







        }



    }
}
