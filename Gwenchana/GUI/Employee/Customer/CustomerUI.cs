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
    public partial class CustomerUI : Form
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        private string button;


        //Constructor
        public CustomerUI()
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
            CustomerBLL customerBLL = new CustomerBLL();
            DataTable dt = customerBLL.GetAllCustomersDataTable();

            dataGridView.DataSource = dt;
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;

            dataGridView.Columns["Customer_Id"].Visible = false;
            dataGridView.Columns["SoDonDaThucHien"].HeaderText = "Số đơn đã thực hiện";
            dataGridView.Columns["customerName"].HeaderText = "Tên khách hàng";
            dataGridView.Columns["phoneNumber"].HeaderText = "Số điện thoại";
            dataGridView.Columns["address"].HeaderText = "Địa chỉ";
            dataGridView.Columns["email"].HeaderText = "Email";


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
            txt_phoneNumber.Clear();
            btn_Address.Clear();
            txt_LaptopName.Clear();

            txt_LaptopID.Clear();

            

            // Kích hoạt lại tất cả textbox nếu từng bị disable (Delete mode)
            txt_LaptopName.Enabled = true;

            txt_phoneNumber.Enabled = true;
            btn_Address.Enabled = true;
            txt_LaptopID.Enabled = true;

            
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






        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (button == "Add")
            {
                CustomerBLL customerBLL = new CustomerBLL();
                Customer customer = new Customer
                {
                    customerName = txt_LaptopName.Text,
                    phoneNumber = txt_phoneNumber.Text,
                    address = btn_Address.Text,
                    email = txt_Email.Text,
                    //SoDonDaThucHien = Convert.ToInt32(txt_sodondathuchien.Text)
                };
                isSuccessful = customerBLL.AddCustomer(customer);
                if (isSuccessful)
                {
                    message = "Thêm khách hàng thành công!";
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    message = "Thêm khách hàng thất bại!";
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                tabControl1.TabPages.Add(tabPagePetList);
                tabControl1.TabPages.Remove(tabPagePetDetail);
                tabControl1.SelectedTab = tabPagePetList;
            }
            else if (button == "Delete")
            {
                int productID = Convert.ToInt32(dataGridView.CurrentRow.Cells["Product_Id"].Value);


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

        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            button = "Add";
            tabControl1.TabPages.Add(tabPagePetDetail);
            tabControl1.TabPages.Remove(tabPagePetList);
            tabControl1.SelectedTab = tabPagePetDetail;
            label3.ForeColor = Color.Gray;
            txt_LaptopID.ForeColor = Color.Gray;
            txt_LaptopID.Enabled = false;
            txt_sodondathuchien.Enabled = false;

        }
    }
}
