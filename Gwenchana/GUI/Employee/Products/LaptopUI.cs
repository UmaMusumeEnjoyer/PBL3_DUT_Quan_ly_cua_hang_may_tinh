using Gwenchana.BussinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gwenchana.DataAccess.DTO;
using Gwenchana.DataAccess.DAL;
using Gwenchana.LanguagePack; // Assuming you have a LanguagePack class for localization
using System.Globalization; // For CultureInfo



namespace Gwenchana
{
    public partial class LaptopUI : Form
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        private string button;

        private DataTable laptopData;
        //Constructor
        public LaptopUI()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            UpdateComponent(LanguageClass.Language);
            LoadData();
            tabControl1.TabPages.Remove(tabPagePetDetail);
            
            btn_Back.Visible = false; // Ẩn nút button1 nếu không cần thiết
        }
        
        private void UpdateComponent(string language)
        {
            Resource.Culture = string.IsNullOrEmpty(language) ? null : new CultureInfo(language);
            lb_laptopManagement.Text = Resource.btn_Laptops;
            tabControl1.TabPages[0].Text = Resource.TabCtr_List;
            tabControl1.TabPages[1].Text = Resource.TabCtr_Details;
            lb_Search.Text = Resource.lb_Search;
            btn_Search.Text = Resource.btn_Search;
            btn_ClearFilter.Text = Resource.btn_ClearFilter;
            btn_Add.Text = Resource.btn_Add;
            btn_Edit.Text = Resource.btn_Edit;
            btn_Delete.Text = Resource.btn_Delete;
            btn_Details.Text = Resource.TabCtr_Details;

            btn_Save.Text = Resource.btn_Edit;
            btn_Cancel.Text = Resource.btn_Cancel;
            btn_Back.Text = Resource.btn_Back;

            lb_ID.Text = "ID";
            lb_ProductName.Text = Resource.lb_productName;
            lb_Colour.Text = Resource.lb_Color;
            lb_Manufacturer.Text = Resource.lb_manufacturerName;
            lb_Weight.Text = Resource.lb_Weight;
            lb_ScreenSize.Text = Resource.lb_ScreenSize;
            lb_Spetifications.Text = Resource.lb_Specifications;
            lb_StockQuantity.Text = Resource.lb_StockQuantity;
            lb_Price.Text = Resource.lb_Price;



        }


        private void LoadData()
        {
            LaptopBLL laptopBLL = new LaptopBLL();
            laptopData = laptopBLL.GetAllLaptopsDataTable();
            
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.DataSource = laptopData;

            dataGridView.Columns["Product_Id"].Visible = false;
            dataGridView.Columns["productName"].HeaderText = Resource.lb_productName;
            dataGridView.Columns["Manufacturer"].HeaderText = Resource.lb_manufacturerName;
            dataGridView.Columns["specification"].HeaderText = Resource.lb_Specifications;
            dataGridView.Columns["weight"].HeaderText = Resource.lb_Weight;
            dataGridView.Columns["screenSize"].HeaderText = Resource.lb_ScreenSize;
            dataGridView.Columns["colour"].HeaderText = Resource.lb_Color;
            dataGridView.Columns["price"].HeaderText = Resource.lb_Price;
            dataGridView.Columns["stockQuantity"].HeaderText = Resource.lb_StockQuantity;
            dataGridView.Columns["Supplier_Id"].Visible = false; 
            dataGridView.Columns["supplierName"].HeaderText = Resource.lb_supplierName; 

            dataGridView.CellFormatting += dataGridView_CellFormatting;
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Nếu cột là "price"
            if (dataGridView.Columns[e.ColumnIndex].Name == "price" && e.Value != null && e.Value is decimal)
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

       public void ChangeTab()
        {
            button = "Special";
            tabControl1.TabPages.Add(tabPagePetDetail);
            tabControl1.TabPages.Remove(tabPagePetList);
            tabControl1.SelectedTab = tabPagePetDetail;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            button = "Edit";
            tabControl1.TabPages.Add(tabPagePetDetail);
            tabControl1.TabPages.Remove(tabPagePetList);
            tabControl1.SelectedTab = tabPagePetDetail;


            lb_ID.ForeColor = Color.Gray;
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


            btn_Save.Text = Resource.btn_Edit;
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
            lb_ID.ForeColor = SystemColors.ControlText;

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
            int stockQuantity = Convert.ToInt32(dataGridView.CurrentRow.Cells["stockQuantity"].Value);
            if (stockQuantity > 0)
            {
                MessageBox.Show(Resource.Delete_Fail_StockRemaining, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            button = "Delete";
            tabControl1.TabPages.Add(tabPagePetDetail);
            tabControl1.TabPages.Remove(tabPagePetList);
            tabControl1.SelectedTab = tabPagePetDetail;

            lb_ID.ForeColor = Color.Gray;
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

            btn_Save.Text = Resource.btn_Delete;

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
                    message = Resource.Laptop_Update_Success;
                    MessageBox.Show(message);
                    LoadData();
                }
                else
                {
                    message = Resource.Laptop_Update_Fail;
                    MessageBox.Show(message);
                }

                tabControl1.TabPages.Add(tabPagePetList);
                tabControl1.TabPages.Remove(tabPagePetDetail);
                tabControl1.SelectedTab = tabPagePetList;
            }
            else if (button == "Delete")
            {
                int productID = Convert.ToInt32(dataGridView.CurrentRow.Cells["Product_Id"].Value);
                LaptopBLL laptopBLL = new LaptopBLL();
                isSuccessful = laptopBLL.DeleteLaptop(productID);
                if (isSuccessful)
                {
                    message = Resource.Laptop_Delete_Success;
                    MessageBox.Show(message);
                    LoadData();
                }
                else
                {
                    message = Resource.Laptop_Delete_Fail;
                    MessageBox.Show(message);
                }

                tabControl1.TabPages.Add(tabPagePetList);
                tabControl1.TabPages.Remove(tabPagePetDetail);
                tabControl1.SelectedTab = tabPagePetList;
            }
            else if(button =="Special")
            {
                txt_LaptopID.ForeColor = Color.Gray;
                txt_LaptopID.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show(Resource.Search_Error_KeywordRequired, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (laptopData == null) LoadData();

            string filter = "";
            if (cbb_LaptopSearch.SelectedItem == null)
            {
                MessageBox.Show(Resource.Search_Error_InvalidCriteria, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            switch (cbb_LaptopSearch.SelectedItem.ToString())
            {
                case "Màu sắc":
                    filter = $"colour LIKE '%{searchText.Replace("'", "''")}%'";
                    break;
                case "Tên":
                    filter = $"productName LIKE '%{searchText.Replace("'", "''")}%'";
                    break;
                case "Hãng sản xuất":
                    filter = $"Manufacturer LIKE '%{searchText.Replace("'", "''")}%'";
                    break;
                case "Cân nặng":
                    filter = $"CONVERT(Weight, 'System.String') LIKE '%{searchText.Replace("'", "''")}%'";
                    break;
                default:
                    MessageBox.Show(Resource.Search_Error_InvalidCriteria, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            DataView dv = new DataView(laptopData);
            dv.RowFilter = filter;
            dataGridView.DataSource = dv;
        }

        private void txt_Manufacturer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_LaptopWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void btn_ClearFilter_Click(object sender, EventArgs e)
        {
            cbb_LaptopSearch.SelectedIndex = -1;
            txtSearch.Clear();
            LoadData();
        }

        private void cbb_LaptopSearch_TextUpdate(object sender, EventArgs e)
        {
            string a = cbb_LaptopSearch.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Thực hiện tương tự AccessoriesUI
            tabControl1.TabPages.Add(tabPagePetDetail);
            tabControl1.TabPages.Remove(tabPagePetList);
            tabControl1.SelectedTab = tabPagePetDetail;

            btn_Save.Visible = false;
            btn_Cancel.Visible = false;
            btn_Back.Visible = true;

            txt_LaptopID.Text = dataGridView.CurrentRow.Cells["Product_Id"].Value.ToString();
            txt_LaptopID.Enabled = false;
            txt_LaptopID.ForeColor = Color.Gray;

            txt_LaptopName.Text = dataGridView.CurrentRow.Cells["productName"].Value.ToString();
            txt_LaptopName.Enabled = false;
            txt_LaptopName.ForeColor = Color.Gray;

            txt_Manufacturer.Text = dataGridView.CurrentRow.Cells["Manufacturer"].Value.ToString();
            txt_Manufacturer.Enabled = false;
            txt_Manufacturer.ForeColor = Color.Gray;

            txt_Spetification.Text = dataGridView.CurrentRow.Cells["specification"].Value.ToString();
            txt_Spetification.Enabled = false;
            txt_Spetification.ForeColor = Color.Gray;

            txt_LaptopWeight.Text = dataGridView.CurrentRow.Cells["weight"].Value.ToString();
            txt_LaptopWeight.Enabled = false;
            txt_LaptopWeight.ForeColor = Color.Gray;

            txt_ScreenSize.Text = dataGridView.CurrentRow.Cells["screenSize"].Value.ToString();
            txt_ScreenSize.Enabled = false;
            txt_ScreenSize.ForeColor = Color.Gray;

            txt_LaptopColour.Text = dataGridView.CurrentRow.Cells["colour"].Value.ToString();
            txt_LaptopColour.Enabled = false;
            txt_LaptopColour.ForeColor = Color.Gray;

            txt_LaptopPrice.Text = dataGridView.CurrentRow.Cells["price"].Value.ToString();
            txt_LaptopPrice.Enabled = false;
            txt_LaptopPrice.ForeColor = Color.Gray;

            txt_stockQuantity.Text = dataGridView.CurrentRow.Cells["stockQuantity"].Value.ToString();
            txt_stockQuantity.Enabled = false;
            txt_stockQuantity.ForeColor = Color.Gray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(tabPagePetList))
                tabControl1.TabPages.Add(tabPagePetList);
            if (tabControl1.TabPages.Contains(tabPagePetDetail))
                tabControl1.TabPages.Remove(tabPagePetDetail);
            tabControl1.SelectedTab = tabPagePetList;

            // Reset trạng thái logic
            btn_Save.Visible = true;
            btn_Cancel.Visible = true;
            btn_Back.Visible = false;

            txt_LaptopID.Clear();
            txt_LaptopName.Clear();
            txt_Manufacturer.Clear();
            txt_Spetification.Clear();
            txt_LaptopWeight.Clear();
            txt_ScreenSize.Clear();
            txt_LaptopColour.Clear();
            txt_LaptopPrice.Clear();
            txt_stockQuantity.Clear();

            txt_LaptopID.ForeColor = SystemColors.WindowText;
            txt_LaptopName.ForeColor = SystemColors.WindowText; 
            txt_Manufacturer.ForeColor = SystemColors.WindowText;
            txt_Spetification.ForeColor = SystemColors.WindowText;
            txt_LaptopWeight.ForeColor = SystemColors.WindowText;
            txt_ScreenSize.ForeColor = SystemColors.WindowText;
            txt_LaptopColour.ForeColor = SystemColors.WindowText;
            txt_LaptopPrice.ForeColor = SystemColors.WindowText;
            txt_stockQuantity.ForeColor = SystemColors.WindowText;

            txt_LaptopID.Enabled = true;
            txt_LaptopName.Enabled = true;
            txt_Manufacturer.Enabled = true;
            txt_Spetification.Enabled = true;
            txt_LaptopWeight.Enabled = true;
            txt_ScreenSize.Enabled = true;
            txt_LaptopColour.Enabled = true;
            txt_LaptopPrice.Enabled = true;
            txt_stockQuantity.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddProduct addProductForm = new AddProduct("Laptop");
            addProductForm.ShowDialog();
            LoadData();
        }

        private void txt_LaptopWeight_Validating(object sender, CancelEventArgs e)
        {
            double canNang;
            if (!double.TryParse(txt_LaptopWeight.Text, out canNang) || canNang < 0)
            {
                MessageBox.Show(Resource.Validation_Error_InvalidWeight, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_LaptopWeight.Focus();
                txt_LaptopWeight.SelectAll();
            }
        }

        private void txt_LaptopPrice_Validating(object sender, CancelEventArgs e)
        {
            double canNang;
            if (!double.TryParse(txt_LaptopPrice.Text, out canNang) || canNang < 0)
            {
                MessageBox.Show(Resource.Validation_Error_InvalidPrice, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_LaptopPrice.Focus();
                txt_LaptopPrice.SelectAll();
            }
        }

        private void lb_Manufacturer_Click(object sender, EventArgs e)
        {

        }
    }
}
