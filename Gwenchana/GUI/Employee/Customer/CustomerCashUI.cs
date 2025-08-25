﻿using Gwenchana.BussinessLogic;
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
using System.Globalization;
using Gwenchana.LanguagePack;



namespace Gwenchana
{
    public partial class CustomerCashUI : Form
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        private string button;
        public Customer currentCustomer { get; set; }
        private DataTable customerData;


        //Constructor
        public CustomerCashUI()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            LoadTrangThaiComboBox();
            UpdateComponent(LanguageClass.Language);
            LoadData();
            tabControl1.TabPages.Remove(tabPagePetDetail);
            
        }

        private void UpdateComponent(string language)
        {
            Resource.Culture = string.IsNullOrEmpty(language) ? null : new CultureInfo(language);

            lb_CustomerManagement.Text = Resource.btn_Customers;
            this.Text = Resource.btn_Customers;

            tabControl1.TabPages[0].Text = Resource.TabCtr_List;
            tabControl1.TabPages[1].Text = Resource.TabCtr_Details;

            lb_Search.Text = Resource.lb_Search;
            lb_SearchFilters.Text = Resource.lb_Filters;

            btn_Search.Text = Resource.btn_Search;
            btn_ClearFilter.Text = Resource.btn_ClearFilter;
            btn_Add.Text = Resource.btn_Add;
            btn_Edit.Text = Resource.btn_Edit;
            btn_CreateOrder.Text = Resource.btn_CreateOrder;

            lb_ID.Text = "ID";
            lb_CustomerName.Text = Resource.lb_CustomerName;
            lb_CreatedOrders.Text = Resource.lb_CompletedOrders;
            lb_PhoneNumber.Text = Resource.lb_PhoneNumber;
            lb_Address.Text = Resource.lb_Address;
            lb_Email.Text = Resource.lb_Email;

            btn_Save.Text = Resource.btn_Save;
            btn_Cancel.Text = Resource.btn_Cancel;
            

            LoadTrangThaiComboBox();
        }

        private void LoadTrangThaiComboBox()
        {
            Dictionary<string, string> trangThaiDict = new Dictionary<string, string>()
            {
                { "Tên", Resource.lb_CustomerName},
                { "Số điện thoại", Resource.lb_PhoneNumber }
            };
            cbb_LaptopSearch.DataSource = new BindingSource(trangThaiDict, null);
            cbb_LaptopSearch.DisplayMember = "Value";
            cbb_LaptopSearch.ValueMember = "Key";
        }

        private void LoadData()
        {
            CustomerBLL customerBLL = new CustomerBLL();
            customerData = customerBLL.GetAllCustomersDataTable();

            dataGridView.DataSource = customerData;
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;

            dataGridView.Columns["Customer_Id"].Visible = false;
            dataGridView.Columns["SoDonDaThucHien"].HeaderText = Resource.lb_CompletedOrders;
            dataGridView.Columns["customerName"].HeaderText = Resource.lb_CustomerName;
            dataGridView.Columns["phoneNumber"].HeaderText = Resource.lb_PhoneNumber;
            dataGridView.Columns["address"].HeaderText = Resource.lb_Address;
            dataGridView.Columns["email"].HeaderText = Resource.lb_Email;
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

            lb_ID.ForeColor = Color.Gray;
            txt_LaptopID.ForeColor = Color.Gray;
            txt_LaptopID.Enabled = false;
            txt_sodondathuchien.Enabled = false;

            txt_LaptopName.Text = dataGridView.CurrentRow.Cells["customerName"].Value.ToString();
            txt_phoneNumber.Text = dataGridView.CurrentRow.Cells["phoneNumber"].Value.ToString();
            btn_Address.Text = dataGridView.CurrentRow.Cells["address"].Value.ToString();
            txt_Email.Text = dataGridView.CurrentRow.Cells["email"].Value.ToString();
            txt_LaptopID.Text = dataGridView.CurrentRow.Cells["Customer_Id"].Value.ToString();
            txt_sodondathuchien.Text = dataGridView.CurrentRow.Cells["SoDonDaThucHien"].Value.ToString();
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

            txt_Email.Clear();

            // Kích hoạt lại tất cả textbox nếu từng bị disable (Delete mode)
            txt_LaptopName.Enabled = true;

            txt_phoneNumber.Enabled = true;
            btn_Address.Enabled = true;
            txt_LaptopID.Enabled = true;

            
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
                };
                isSuccessful = customerBLL.AddCustomer(customer);
                if (isSuccessful)
                {
                    message = Resource.Customer_Create_Success;
                    MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    message = Resource.Customer_Create_Fail;
                    MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
                tabControl1.TabPages.Add(tabPagePetList);
                tabControl1.TabPages.Remove(tabPagePetDetail);
                tabControl1.SelectedTab = tabPagePetList;
            }
            else if (button == "Edit")
            {
                int productID = Convert.ToInt32(dataGridView.CurrentRow.Cells["Customer_Id"].Value);
                CustomerBLL customerBLL = new CustomerBLL();
                Customer customer = new Customer
                {
                    Customer_Id = productID,
                    customerName = txt_LaptopName.Text,
                    phoneNumber = txt_phoneNumber.Text,
                    address = btn_Address.Text,
                    email = txt_Email.Text,
                    //SoDonDaThucHien = Convert.ToInt32(txt_sodondathuchien.Text)
                };
                isSuccessful = customerBLL.UpdateCustomer(customer);
                if (isSuccessful)
                {
                    message = Resource.Customer_Update_Success;
                    MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); 
                }
                else
                {
                    message = Resource.Customer_Update_Fail;
                    MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                tabControl1.TabPages.Add(tabPagePetList);
                tabControl1.TabPages.Remove(tabPagePetDetail);
                tabControl1.SelectedTab = tabPagePetList;
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

            if (customerData == null) LoadData();

            string filter = "";
            if (cbb_LaptopSearch.SelectedItem == null)
            {
                MessageBox.Show(Resource.Search_Error_InvalidCriteria, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var selectedKey = (cbb_LaptopSearch.SelectedValue ?? "").ToString();

            switch (selectedKey)
            {
                case "Tên":
                    filter = $"customerName LIKE '%{searchText.Replace("'", "''")}%'";
                    break;
                case "Số điện thoại":
                    filter = $"phoneNumber LIKE '%{searchText.Replace("'", "''")}%'";
                    break;
                default:
                    MessageBox.Show(Resource.Search_Error_InvalidCriteria, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            DataView dv = new DataView(customerData);
            dv.RowFilter = filter;
            dataGridView.DataSource = dv;
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
            lb_ID.ForeColor = Color.Gray;
            txt_LaptopID.ForeColor = Color.Gray;
            txt_LaptopID.Enabled = false;
            txt_sodondathuchien.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPagePetDetail);
            txt_LaptopName.Text = dataGridView.CurrentRow.Cells["customerName"].Value.ToString();
            txt_phoneNumber.Text = dataGridView.CurrentRow.Cells["phoneNumber"].Value.ToString();
            btn_Address.Text = dataGridView.CurrentRow.Cells["address"].Value.ToString();
            txt_Email.Text = dataGridView.CurrentRow.Cells["email"].Value.ToString();
            txt_LaptopID.Text = dataGridView.CurrentRow.Cells["Customer_Id"].Value.ToString();
            currentCustomer = new Customer
            {
                Customer_Id = Convert.ToInt32(txt_LaptopID.Text),
                customerName = txt_LaptopName.Text,
                phoneNumber = txt_phoneNumber.Text,
                address = btn_Address.Text,
                email = txt_Email.Text,
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }


    }
}
