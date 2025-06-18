using Gwenchana.BussinessLogic;
using Gwenchana.DataAccess.DTO;
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
    public partial class PetView : Form
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        private string button;


        //Constructor
        public PetView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            UpdateComponent(LanguageClass.Language);
            LoadData();
            tabControl1.TabPages.Remove(tabPagePetDetail);
           

        }

        private void UpdateComponent(string language)
        {
            Resource.Culture = string.IsNullOrEmpty(language) ? null : new CultureInfo(language);
            lb_supplierManagement.Text = Resource.btn_Suppliers;
            tabControl1.TabPages[0].Text = Resource.TabCtr_List;
            tabControl1.TabPages[1].Text = Resource.TabCtr_Details;
            lb_supplierSearch.Text = Resource.lb_supplierSearch;
            btn_Search.Text = Resource.btn_Search;
            btn_Add.Text = Resource.btn_Add;
            btn_Edit.Text = Resource.btn_Edit;
            lb_Id.Text = "ID";
            lb_Name.Text = Resource.lb_Name;
            lb_PhoneNumber.Text = Resource.lb_employeePhonenumber;
            lb_Address.Text = Resource.lb_Address;
            lb_Email.Text = Resource.lb_Email;
        }

        private void LoadData()
        {
            SupplierBLL supplierBLL = new SupplierBLL();
            //List<Supplier> suppliers = supplierBLL.GetAllSuppliers();
            DataTable dt = supplierBLL.GetAllSuppliersDataTable();
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            
            dataGridView.DataSource = dt;
            dataGridView.Columns["Supplier_Id"].Visible = false;
            dataGridView.Columns["supplierName"].HeaderText = "Tên";
            dataGridView.Columns["phoneNumber"].HeaderText = "Số điện thoại";
            dataGridView.Columns["address"].HeaderText = "Địa chỉ";
            dataGridView.Columns["email"].HeaderText = "Email";

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

            lb_Id.ForeColor = Color.Gray;
            txtPetId.ForeColor = Color.Gray;
            txtPetId.Enabled = false;
            txtPetId.Text = dataGridView.CurrentRow.Cells["Supplier_Id"].Value.ToString();
            txt_SupplierName.Text = dataGridView.CurrentRow.Cells["supplierName"].Value.ToString();
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
            lb_Id.ForeColor = Color.Gray;
            txtPetId.ForeColor = Color.Gray;
            txtPetId.Enabled = false;
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
            txt_SupplierName.Clear();
            txt_SupplierPhone.Clear();
            txtPetId.Clear();

            // Kích hoạt lại tất cả textbox nếu từng bị disable (Delete mode)
            txt_SupplierName.Enabled = true;
            txt_SupplierPhone.Enabled = true;
            txt_SupplierAddress.Enabled = true;
            txt_SupplierEmail.Enabled = true;
            txtPetId.Enabled = true;
            txtPetId.ForeColor = SystemColors.WindowText;
            lb_Id.ForeColor = SystemColors.ControlText;

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

            lb_Id.ForeColor = Color.Gray;
            txtPetId.ForeColor = Color.Gray;
            txtPetId.Enabled = false;
            txt_SupplierName.Enabled = false;
            txt_SupplierPhone.Enabled = false;
            txt_SupplierAddress.Enabled = false;
            txt_SupplierEmail.Enabled = false;
            txtPetId.Text = dataGridView.CurrentRow.Cells["Supplier_Id"].Value.ToString();
            txt_SupplierName.Text = dataGridView.CurrentRow.Cells["supplierName"].Value.ToString();
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
                    supplierName = txt_SupplierName.Text,
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
                    supplierName = txt_SupplierName.Text,
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
                    message = "Xoá nhà phân phối thất bại, hãy xoá những sản phẩm của nhà phân phối này.";
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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
