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


namespace Gwenchana
{
    public partial class Laptop : Form
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        private string button;


        //Constructor
        public Laptop()
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
            txt_LaptopID.Text = dataGridView.CurrentRow.Cells["Supplier_Id"].Value.ToString();
            txt_LaptopName.Text = dataGridView.CurrentRow.Cells["supplierName"].Value.ToString();
            txt_SupplierPhone.Text = dataGridView.CurrentRow.Cells["phoneNumber"].Value.ToString();
            txt_SupplierAddress.Text = dataGridView.CurrentRow.Cells["address"].Value.ToString();
            txt_SupplierEmail.Text = dataGridView.CurrentRow.Cells["email"].Value.ToString();


        }

        private void txtPetId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            button = "Add";
            tabControl1.TabPages.Add(tabPagePetDetail);
            tabControl1.TabPages.Remove(tabPagePetList);
            tabControl1.SelectedTab = tabPagePetDetail;
            label3.ForeColor = Color.Gray;
            txt_LaptopID.ForeColor = Color.Gray;
            txt_LaptopID.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetFormState();
        }

        private void ResetFormState()
        {
            // Clear các ô nhập liệu
            txt_SupplierAddress.Clear();
            txt_SupplierEmail.Clear();
            txt_LaptopName.Clear();
            txt_SupplierPhone.Clear();
            txt_LaptopID.Clear();

            // Kích hoạt lại tất cả textbox nếu từng bị disable (Delete mode)
            txt_LaptopName.Enabled = true;
            txt_SupplierPhone.Enabled = true;
            txt_SupplierAddress.Enabled = true;
            txt_SupplierEmail.Enabled = true;
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

            label3.ForeColor = Color.Gray;
            txt_LaptopID.ForeColor = Color.Gray;
            txt_LaptopID.Enabled = false;
            txt_LaptopName.Enabled = false;
            txt_SupplierPhone.Enabled = false;
            txt_SupplierAddress.Enabled = false;
            txt_SupplierEmail.Enabled = false;
            txt_LaptopID.Text = dataGridView.CurrentRow.Cells["Supplier_Id"].Value.ToString();
            txt_LaptopName.Text = dataGridView.CurrentRow.Cells["supplierName"].Value.ToString();
            txt_SupplierPhone.Text = dataGridView.CurrentRow.Cells["phoneNumber"].Value.ToString();
            txt_SupplierAddress.Text = dataGridView.CurrentRow.Cells["address"].Value.ToString();
            txt_SupplierEmail.Text = dataGridView.CurrentRow.Cells["email"].Value.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(button == "Add")
            {
                // Add new supplier logic
                // Call SaveEvent or any other logic
                Supplier supplier = new Supplier
                {
                    supplierName = txt_LaptopName.Text,
                    phoneNumber = txt_SupplierPhone.Text,
                    address = txt_SupplierAddress.Text,
                    email = txt_SupplierEmail.Text
                };

                SupplierBLL supplierBLL = new SupplierBLL();
                isSuccessful = supplierBLL.AddSupplier(supplier);
                if (isSuccessful)
                {
                    message = "Thêm nhà phân phối thành công.";
                    MessageBox.Show(message);
                    LoadData();
                }
                else
                {
                    message = "Thêm nhà phân phối thất bại.";
                    MessageBox.Show(message);
                }
                tabControl1.TabPages.Add(tabPagePetList);
                tabControl1.TabPages.Remove(tabPagePetDetail);
                tabControl1.SelectedTab = tabPagePetList;

            }
            else if (button == "Edit")
            {
                // Edit supplier logic
                // Call SaveEvent or any other logic
                int supplierId = Convert.ToInt32(dataGridView.CurrentRow.Cells["Supplier_Id"].Value);
                Supplier supplier = new Supplier
                {
                    Supplier_Id = supplierId,
                    supplierName = txt_LaptopName.Text,
                    phoneNumber = txt_SupplierPhone.Text,
                    address = txt_SupplierAddress.Text,
                    email = txt_SupplierEmail.Text
                };
                SupplierBLL supplierBLL = new SupplierBLL();
                isSuccessful = supplierBLL.UpdateSupplier(supplier);
                if (isSuccessful)
                {
                    message = "Cập nhật nhà phân phối thành công.";
                    MessageBox.Show(message);
                    LoadData();
                }
                else
                {
                    message = "Cập nhật nhà phân phối thất bại.";
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
                int supplierId = Convert.ToInt32(dataGridView.CurrentRow.Cells["Supplier_Id"].Value);
                SupplierBLL supplierBLL = new SupplierBLL();
                isSuccessful = supplierBLL.DeleteSupplier(supplierId);
                if (isSuccessful)
                {
                    message = "Xoá nhà phân phối thành công.";
                    MessageBox.Show(message);
                    LoadData();
                }
                else
                {
                    message = "Xoá nhà phân phối thất bại.";
                    MessageBox.Show(message);
                }
                tabControl1.TabPages.Add(tabPagePetList);
                tabControl1.TabPages.Remove(tabPagePetDetail);
                tabControl1.SelectedTab = tabPagePetList;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (dataGridView.Rows[i].Cells[1].Value.ToString().Contains(txtSearch.Text))
                {
                    dataGridView.Rows[i].Selected = true;
                    dataGridView.CurrentCell = dataGridView.Rows[i].Cells[1];
                    break;
                }
            }
        }
    }
}
