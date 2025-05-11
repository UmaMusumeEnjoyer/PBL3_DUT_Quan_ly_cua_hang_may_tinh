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


        //Constructor
        public LaptopUI()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            LoadData();
            tabControl1.TabPages.Remove(tabPagePetDetail);
            

            //tabControl1.TabPages.Remove(tabPagePetDetail);
            btnClose.Click += delegate { this.Close(); };
        }

        private void LoadData()
        {
            LaptopBLL laptopBLL = new LaptopBLL();
            DataTable dt = laptopBLL.GetAllLaptopsDataTable();
            dataGridView.DataSource = dt;
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.Columns["Product_Id"].Visible = false;
            dataGridView.Columns["productName"].HeaderText = "Tên sản phẩm";
            dataGridView.Columns["Manufacturer"].HeaderText = "Nhà sản xuất";
            dataGridView.Columns["specification"].HeaderText = "Thông số kỹ thuật";
            dataGridView.Columns["weight"].HeaderText = "Trọng lượng";
            dataGridView.Columns["screenSize"].HeaderText = "Kích cỡ màn hình";
            dataGridView.Columns["colour"].HeaderText = "Màu sắc";
            dataGridView.Columns["price"].HeaderText = "Giá";
            dataGridView.Columns["stockQuantity"].HeaderText = "Số lượng tồn kho";

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

       

        private void btnEdit_Click(object sender, EventArgs e)
        {
            button = "Edit";
            tabControl1.TabPages.Add(tabPagePetDetail);
            tabControl1.TabPages.Remove(tabPagePetList);
            tabControl1.SelectedTab = tabPagePetDetail;


            label3.ForeColor = Color.Gray;
            txt_LaptopID.ForeColor = Color.Gray;
            txt_LaptopID.Enabled = false;

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
            //string a = cbb_LaptopSearch.SelectedItem.ToString();

            LaptopBLL laptopBLL = new LaptopBLL();
            if (cbb_LaptopSearch.SelectedItem.ToString() == "Màu sắc")
            {
                dataGridView.DataSource = laptopBLL.GetAllLaptops().Where(l => l.Colour.Contains(searchText)).ToList();
            }
            else if(cbb_LaptopSearch.SelectedItem.ToString() == "Tên")
            {
                dataGridView.DataSource = laptopBLL.GetAllLaptops().Where(l => l.productName.Contains(searchText)).ToList();
            }
            else if(cbb_LaptopSearch.SelectedItem.ToString() == "Hãng sản xuất")
            {
                dataGridView.DataSource = laptopBLL.GetAllLaptops().Where(l => l.Manufacturer.Contains(searchText)).ToList();
            }
            else if(cbb_LaptopSearch.SelectedItem.ToString() == "Cân nặng")
            {
                dataGridView.DataSource = laptopBLL.GetAllLaptops().Where(l => l.Weight ==Convert.ToDecimal(searchText)).ToList();
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
    }
}
