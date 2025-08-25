using Gwenchana.BussinessLogic;
using Gwenchana.DataAccess;
using Gwenchana.DataAccess.DAL;
using Gwenchana.DataAccess.DTO;
using Gwenchana.DataAccess.ViewModel;
using Gwenchana.LanguagePack;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Windows.Forms;


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
            UpdateComponent(LanguageClass.Language);

            Id = id;
            txt_productName.Enabled = false;
            txt_productPrice.Enabled = false;
            dgv_Order.Columns.Clear();

            dgv_Order.Columns.Add("Product_Id", "ID");
            dgv_Order.Columns["Product_Id"].Visible = false; // Ẩn cột Product_Id nếu không cần thiết
            dgv_Order.Columns.Add("productName", Resource.lb_productName);
            //dgv_Order.Columns.Add("Price", "");
            dgv_Order.Columns.Add("Product_price", Resource.lb_Price);
            dgv_Order.Columns.Add("quantity", Resource.lb_Quantity);
            dgv_Order.Columns.Add("totalPrice", Resource.lb_TotalAmount);
            dgv_Order.Columns.Add("Supplier_Id", "Mã nhà cung cấp");
            dgv_Order.Columns["Supplier_Id"].Visible = false; // Ẩn cột Supplier_Id nếu không cần thiết

            dgv_Order.ReadOnly = true;
            dgv_Order.AllowUserToAddRows = false;
            totalAmount = 0;
        }
        private void UpdateComponent(string language)
        {
            Resource.Culture = string.IsNullOrEmpty(language) ? null : new CultureInfo(language);

            this.Text = Resource.btn_importInvoices;

            lb_ProductList.Text = Resource.Item_List;
            btn_AddProduct.Text = Resource.btn_AddProduct;

            lb_ProductType.Text = Resource.lb_Type;
            lb_ProductID.Text = "ID";
            lb_ProductName.Text = Resource.lb_productName;
            lb_ProductPrice.Text = Resource.lb_ImportPrice;
            lb_ProductQuantity.Text = Resource.lb_Quantity;
            btn_productAdd.Text = Resource.btn_Add;
            cashierOrderForm_clearBtn.Text = Resource.Delete_List;

            cashierOrderForm_receiptBtn.Text = Resource.btn_CreateImport;

            LoadTrangThaiComboBox();
        }

        private void LoadTrangThaiComboBox()
        {
            Dictionary<string, string> trangThaiDict = new Dictionary<string, string>()
            {
                { "Laptop", Resource.btn_Laptops },
                { "PC", Resource.btn_PCs },
                { "Linh/ Phụ kiện", Resource.btn_Accessories }
            };
            ccb_ProductFilter.DataSource = new BindingSource(trangThaiDict, null);
            ccb_ProductFilter.DisplayMember = "Value";
            ccb_ProductFilter.ValueMember = "Key";
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
            var selectedKey = (ccb_ProductFilter.SelectedValue ?? "").ToString();

            switch (selectedKey)
            {

                case "PC":
                    ClearDataGridViewData();
                    PCBLL pcBLL = new PCBLL();
                    DataTable dt = pcBLL.GetAllPCsDataTable();
                    dgv_Product.ReadOnly = true;
                    dgv_Product.AllowUserToAddRows = false;
                    dgv_Product.AllowUserToDeleteRows = false;
                    dgv_Product.DataSource = dt;
                    dgv_Product.Columns["Product_Id"].HeaderText = "ID";
                    dgv_Product.Columns["productName"].HeaderText = Resource.lb_productName;
                    dgv_Product.Columns["Manufacturer"].HeaderText = Resource.lb_manufacturerName;
                    dgv_Product.Columns["specification"].HeaderText = "Thông số kỹ thuật";
                    dgv_Product.Columns["specification"].Visible = false;
                    dgv_Product.Columns["price"].HeaderText = Resource.lb_Price;
                    dgv_Product.Columns["stockQuantity"].HeaderText = Resource.lb_StockQuantity;
                    dgv_Product.Columns["Supplier_Id"].Visible = false; // Ẩn cột Supplier_Id nếu không cần thiết
                    dgv_Product.Columns["supplierName"].HeaderText = Resource.lb_supplierName;
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
                    dgv_Product.Columns["Product_Id"].HeaderText = "ID";
                    dgv_Product.Columns["productName"].HeaderText = Resource.lb_productName;
                    dgv_Product.Columns["Manufacturer"].HeaderText = Resource.lb_manufacturerName;
                    dgv_Product.Columns["specification"].HeaderText = "Thông số kỹ thuật";
                    dgv_Product.Columns["specification"].Visible = false; // Ẩn cột specification nếu không cần thiết
                    dgv_Product.Columns["weight"].HeaderText = Resource.lb_Weight;
                    dgv_Product.Columns["screenSize"].HeaderText = Resource.lb_ScreenSize;
                    dgv_Product.Columns["colour"].HeaderText = Resource.lb_Color;
                    dgv_Product.Columns["price"].HeaderText = Resource.lb_Price;
                    dgv_Product.Columns["stockQuantity"].HeaderText = Resource.lb_StockQuantity;
                    dgv_Product.Columns["Supplier_Id"].Visible = false; // Ẩn cột Supplier_Id nếu không cần thiết
                    dgv_Product.Columns["supplierName"].HeaderText = Resource.lb_supplierName;
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
                    dgv_Product.Columns["Product_Id"].HeaderText = "ID";
                    dgv_Product.Columns["productName"].HeaderText = Resource.lb_productName;
                    dgv_Product.Columns["Manufacturer"].HeaderText = Resource.lb_manufacturerName;
                    dgv_Product.Columns["overview"].HeaderText = "Mô tả";
                    dgv_Product.Columns["overview"].Visible = false; // Ẩn cột overview nếu không cần thiết
                    dgv_Product.Columns["type"].HeaderText = Resource.lb_ProductType;
                    dgv_Product.Columns["price"].HeaderText = Resource.lb_Price;
                    dgv_Product.Columns["stockQuantity"].HeaderText = Resource.lb_StockQuantity;
                    dgv_Product.Columns["Supplier_Id"].Visible = false; // Ẩn cột Supplier_Id nếu không cần thiết
                    dgv_Product.Columns["supplierName"].HeaderText = Resource.lb_supplierName; // Hiển thị tên nhà cung cấp nếu cần thiết
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
                MessageBox.Show(Resource.Select_product_before_add_to_cart);
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
                MessageBox.Show(Resource.No_Product_Selected_For_Import, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (currentEmployee == null)
            {
                MessageBox.Show(Resource.Employee_Not_Identified, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isSuccess = goods_ReceiptBLL.CreateGoodsReceipt(currentEmployee, selectedProducts);
            if (isSuccess)
            {
                MessageBox.Show(Resource.Import_Invoice_Created_Successfully, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(Resource.Import_Invoice_Creation_Failed, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(Resource.Select_Product_Category_Before_Adding);
                return;
            }

            var selectedKey = (ccb_ProductFilter.SelectedValue ?? "").ToString();

            switch (selectedKey)
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
            dgv_Product.Columns["Product_Id"].HeaderText = "ID";
            dgv_Product.Columns["productName"].HeaderText = Resource.lb_productName;
            dgv_Product.Columns["Manufacturer"].HeaderText = Resource.lb_manufacturerName;
            dgv_Product.Columns["specification"].HeaderText = "Thông số kỹ thuật";
            dgv_Product.Columns["specification"].Visible = false;
            dgv_Product.Columns["price"].HeaderText = Resource.lb_Price;
            dgv_Product.Columns["stockQuantity"].HeaderText = Resource.lb_StockQuantity;
            dgv_Product.Columns["Supplier_Id"].Visible = false; // Ẩn cột Supplier_Id nếu không cần thiết
            dgv_Product.Columns["supplierName"].HeaderText = Resource.lb_supplierName;
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
            dgv_Product.Columns["Product_Id"].HeaderText = "ID";
            dgv_Product.Columns["productName"].HeaderText = Resource.lb_productName;
            dgv_Product.Columns["Manufacturer"].HeaderText = Resource.lb_manufacturerName;
            dgv_Product.Columns["specification"].HeaderText = "Thông số kỹ thuật";
            dgv_Product.Columns["specification"].Visible = false; // Ẩn cột specification nếu không cần thiết
            dgv_Product.Columns["weight"].HeaderText = Resource.lb_Weight;
            dgv_Product.Columns["screenSize"].HeaderText = Resource.lb_ScreenSize;
            dgv_Product.Columns["colour"].HeaderText = Resource.lb_Color;
            dgv_Product.Columns["price"].HeaderText = Resource.lb_Price;
            dgv_Product.Columns["stockQuantity"].HeaderText = Resource.lb_StockQuantity;
            dgv_Product.Columns["Supplier_Id"].Visible = false; // Ẩn cột Supplier_Id nếu không cần thiết
            dgv_Product.Columns["supplierName"].HeaderText = Resource.lb_supplierName;
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
            dgv_Product.Columns["Product_Id"].HeaderText = "ID";
            dgv_Product.Columns["productName"].HeaderText = Resource.lb_productName;
            dgv_Product.Columns["Manufacturer"].HeaderText = Resource.lb_manufacturerName;
            dgv_Product.Columns["overview"].HeaderText = "Mô tả";
            dgv_Product.Columns["overview"].Visible = false; // Ẩn cột overview nếu không cần thiết
            dgv_Product.Columns["type"].HeaderText = Resource.lb_ProductType;
            dgv_Product.Columns["price"].HeaderText = Resource.lb_Price;
            dgv_Product.Columns["stockQuantity"].HeaderText = Resource.lb_StockQuantity;
            dgv_Product.Columns["Supplier_Id"].Visible = false; // Ẩn cột Supplier_Id nếu không cần thiết
            dgv_Product.Columns["supplierName"].HeaderText = Resource.lb_supplierName; // Hiển thị tên nhà cung cấp nếu cần thiết
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
            //cbb_ProductID.Items.Clear(); // Xóa danh sách ID sản phẩm đã chọn
            MessageBox.Show(Resource.Cart_Cleared, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
