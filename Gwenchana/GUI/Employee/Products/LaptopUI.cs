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
            LoadData();
            tabControl1.TabPages.Remove(tabPagePetDetail);
            
            button2.Visible = false; // Ẩn nút button1 nếu không cần thiết
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
            dataGridView.Columns["productName"].HeaderText = "Tên sản phẩm";
            dataGridView.Columns["Manufacturer"].HeaderText = "Nhà sản xuất";
            dataGridView.Columns["specification"].HeaderText = "Thông số kỹ thuật";
            dataGridView.Columns["weight"].HeaderText = "Trọng lượng";
            dataGridView.Columns["screenSize"].HeaderText = "Kích cỡ màn hình";
            dataGridView.Columns["colour"].HeaderText = "Màu sắc";
            dataGridView.Columns["price"].HeaderText = "Giá";
            dataGridView.Columns["stockQuantity"].HeaderText = "Số lượng tồn kho";
            dataGridView.Columns["Supplier_Id"].Visible = false; // Ẩn cột Supplier_Id nếu không cần thiết
            dataGridView.Columns["supplierName"].HeaderText = "Nhà cung cấp"; // Hiển thị tên nhà cung cấp nếu cần

        }



        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
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


            btnSave.Text = "Cập nhật";
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
            int stockQuantity = Convert.ToInt32(dataGridView.CurrentRow.Cells["stockQuantity"].Value);
            if (stockQuantity > 0)
            {
                MessageBox.Show("Không thể xoá vì còn hàng tồn kho", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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

            btnSave.Text = "Xoá sản phẩm";

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
            else if(button =="Special")
            {
                txt_LaptopID.ForeColor = Color.Gray;
                txt_LaptopID.Enabled = false;
            }
            else
            {

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (laptopData == null) LoadData();

            string filter = "";
            if (cbb_LaptopSearch.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tiêu chí tìm kiếm hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Vui lòng chọn tiêu chí tìm kiếm hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            btnSave.Visible = false;
            btnCancel.Visible = false;
            button2.Visible = true;

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
            btnSave.Visible = true;
            btnCancel.Visible = true;
            button2.Visible = false;

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
    }
}
