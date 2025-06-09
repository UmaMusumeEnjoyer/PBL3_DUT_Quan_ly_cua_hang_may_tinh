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
using Gwenchana.DataAccess.DAL;
using Gwenchana.DataAccess.DTO;
using Gwenchana.DataAccess.ViewModel;
using Newtonsoft.Json;


namespace Gwenchana
{
    public partial class Goods_ReceiptForm : Form
    {

        public decimal totalAmount { get; set; }
        //public string choice { get; set; }
        public int Id { get; set; }
        public Goods_ReceiptForm(int id)
        {
            InitializeComponent();

            Id = id;
            txt_productName.Enabled = false;
            txt_productPrice.Enabled = false;
            dgv_Order.Columns.Clear();

            dgv_Order.Columns.Add("Product_Id", "Mã sản phẩm");
            dgv_Order.Columns["Product_Id"].Visible = false; // Ẩn cột Product_Id nếu không cần thiết
            dgv_Order.Columns.Add("productName", "Tên sản phẩm");
            //dgv_Order.Columns.Add("Price", "");
            dgv_Order.Columns.Add("Product_price", "Giá bán");
            dgv_Order.Columns.Add("quantity", "Số lượng nhập");
            dgv_Order.Columns.Add("totalPrice", "Thành tiền");
            dgv_Order.Columns.Add("Supplier_Id", "Mã nhà cung cấp");
            dgv_Order.Columns["Supplier_Id"].Visible = false; // Ẩn cột Supplier_Id nếu không cần thiết

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
            cbb_ProductID.Items.Clear();
            switch (ccb_ProductFilter.SelectedItem.ToString())
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
                    dgv_Product.Columns["Supplier_Id"].Visible = false; // Ẩn cột Supplier_Id nếu không cần thiết
                    dgv_Product.Columns["supplierName"].HeaderText = "Nhà cung cấp";
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
                    dgv_Product.Columns["Supplier_Id"].Visible = false; // Ẩn cột Supplier_Id nếu không cần thiết
                    dgv_Product.Columns["supplierName"].HeaderText = "Nhà cung cấp";
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
                    dgv_Product.Columns["Supplier_Id"].Visible = false; // Ẩn cột Supplier_Id nếu không cần thiết
                    dgv_Product.Columns["supplierName"].HeaderText = "Nhà cung cấp"; // Hiển thị tên nhà cung cấp nếu cần thiết
                    setcbb_ProductID();
                    break;

                default:
                    break;
            }
        }
        public void setcbb_ProductID()
        {
            //cbb_ProductID.Items.Clear();
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
                    int supplierId = Convert.ToInt32(selectedRow.Cells["Supplier_Id"].Value);

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
                        dgv_Order.Rows.Add(productId, productName, price, quantity, totalPrice, supplierId);
                    }
                }
            }
            // Cập nhật lại tổng tiền
            totalAmount += Convert.ToDecimal(txt_productPrice.Text) * productQuantity.Value;
            



        }

        private void CashierOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void cashierOrderForm_quantity_ValueChanged(object sender, EventArgs e)
        {

        }

        public List<ProductViewModel> GetOrderedProductList()
        {
            List<ProductViewModel> productList = new List<ProductViewModel>();

            foreach (DataGridViewRow row in dgv_Order.Rows)
            {
                if (row.IsNewRow) continue; // Bỏ qua dòng trống

                var productVM = new ProductViewModel
                {
                    Product_Id = Convert.ToInt32(row.Cells["Product_Id"].Value),
                    ProductQuantity = Convert.ToInt32(row.Cells["quantity"].Value),
                    Product_SupplierId = Convert.ToInt32(row.Cells["Supplier_Id"].Value),
                    ProductPrice = Convert.ToDecimal(row.Cells["Product_price"].Value),


                };

                productList.Add(productVM);
            }

            return productList;
        }

        private void cashierOrderForm_receiptBtn_Click(object sender, EventArgs e)
        {
            EmployeeBLL employeeBLL = new EmployeeBLL();
            Employee currentEmployee = new Employee();
            currentEmployee = employeeBLL.GetEmployeeByAccountId(Id);

            

            Goods_ReceiptBLL goods_ReceiptBLL = new Goods_ReceiptBLL();

            List<ProductViewModel> selectedProducts = new List<ProductViewModel>();
            selectedProducts = GetOrderedProductList();



            if (selectedProducts == null || selectedProducts.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào được chọn để nhập hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (currentEmployee == null)
            {
                MessageBox.Show("Không thể xác định nhân viên hiện tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isSuccess = goods_ReceiptBLL.CreateGoodsReceipt(currentEmployee, selectedProducts);
            if (isSuccess)
            {
                MessageBox.Show("Tạo hóa đơn nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Tạo hóa đơn nhập thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cashierOrderForm_removeBtn_Click(object sender, EventArgs e)
        {
            switch(ccb_ProductFilter.SelectedItem.ToString())
            {
                case "PC":
                    PCUI pCUI = new PCUI();
                    pCUI.ChangeTab();
                    pCUI.ShowDialog();
                    break;
                case "Laptop":
                    LaptopUI laptopUI = new LaptopUI();
                    laptopUI.ChangeTab();
                    laptopUI.ShowDialog();
                    break;
                case "Linh/ Phụ kiện":
                    AccessoriesUI accessoriesUI = new AccessoriesUI();
                    accessoriesUI.ChangeTab();
                    accessoriesUI.ShowDialog();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ccb_ProductFilter.SelectedItem == null || string.IsNullOrEmpty(ccb_ProductFilter.SelectedItem.ToString()))
            {
                MessageBox.Show("Vui lòng chọn danh mục sản phẩm trước khi thêm sản phẩm.");
                return;
            }
            switch (ccb_ProductFilter.SelectedItem.ToString())
            {
                case "PC":
                    AddProduct addProduct = new AddProduct("PC");
                    addProduct.ShowDialog();
                    LoadPCData(); // <-- Gọi hàm này sau khi thêm PC
                    break;
                case "Laptop":
                    AddProduct addProduct1 = new AddProduct("Laptop");
                    addProduct1.ShowDialog();
                    LoadLaptopData(); // <-- Gọi hàm này sau khi thêm Laptop
                    break;
                case "Linh/ Phụ kiện":
                    AddProduct addProduct2 = new AddProduct("Accessories");
                    addProduct2.ShowDialog();
                    LoadAccessoriesData(); // <-- Gọi hàm này sau khi thêm phụ kiện
                    break;
                default:
                    break;
            }
        }

        private void LoadPCData()
        {
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
        }

        private void LoadLaptopData()
        {
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
        }

        private void LoadAccessoriesData()
        {
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
        }

        private void dgv_Order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_Product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_productPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void cashierOrderForm_clearBtn_Click(object sender, EventArgs e)
        {
            // Xóa tất cả các hàng trong DataGridView dgv_Order
            dgv_Order.Rows.Clear();
            totalAmount = 0; // Đặt lại tổng tiền về 0
            txt_productName.Clear(); // Xóa tên sản phẩm
            txt_productPrice.Clear(); // Xóa giá sản phẩm
            productQuantity.Value = 1; // Đặt lại số lượng về 1
            cbb_ProductID.Items.Clear(); // Xóa danh sách ID sản phẩm đã chọn
            MessageBox.Show("Đã xóa giỏ hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
