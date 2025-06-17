using Gwenchana.BussinessLogic;
using Gwenchana.DataAccess.DTO;
using Gwenchana.DataAccess.ViewModel;
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
    public partial class AssignEmployee: Form
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        private string button;


        //Constructor
        public AssignEmployee()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            UpdateComponent(LanguageClass.Language);
            tabControl1.TabPages.Remove(tabPagePetDetail);
            LoadData();
            
        }

        private void UpdateComponent(string language)
        {
            Resource.Culture = string.IsNullOrEmpty(language) ? null : new CultureInfo(language);
            lb_accountManagement.Text = Resource.lb_accountManagement;
            tabControl1.TabPages[0].Text = Resource.TabCtr_List;
            tabControl1.TabPages[1].Text = Resource.TabCtr_Details;
            lb_Search.Text = Resource.lb_Search;
            btn_Search.Text = Resource.btn_Search;
            btn_Assign.Text = Resource.btn_Assign;
            btn_Edit.Text = Resource.btn_Edit;
            btn_Delete.Text = Resource.btn_Delete;

        }

        private void LoadData()
        {
            AccountBLL accountBLL = new AccountBLL();
            //EmployeeBLL employeeBLL = new EmployeeBLL();
            DataTable dt = accountBLL.GetAllAccountsDataTable();
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            
            dataGridView.DataSource = dt;

            dataGridView.Columns[0].Visible = false; // Hide the first column (ID)
            dataGridView.Columns[1].HeaderText = Resource.lb_employeeUsername1;
            dataGridView.Columns[2].HeaderText = Resource.lb_employeePassword1;
            dataGridView.Columns[3].HeaderText = Resource.lb_employeeRole;
            dataGridView.Columns[4].HeaderText = Resource.Permission_Assignment_Status;
            dataGridView.Columns[5].HeaderText = Resource.lb_employeeName1;
            dataGridView.Columns[6].HeaderText = Resource.lb_employeeStatus;
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

            btnSave.Text = Resource.btn_Edit;


            label3.ForeColor = Color.Gray;
            txt_AccessoriesID.ForeColor = Color.Gray;
            txt_AccessoriesID.Enabled = false;

            txt_AccessoriesID.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            txt_Username.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            txt_Password.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();

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
            txt_AccessoriesID.ForeColor = Color.Gray;
            txt_AccessoriesID.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetFormState();
        }

        private void ResetFormState()
        {
            // Clear các ô nhập liệu
            txt_Password.Clear();
            txt_Username.Clear();
            txt_AccessoriesID.Clear();

            // Kích hoạt lại tất cả textbox nếu từng bị disable (Delete mode)
            txt_Username.Enabled = true;
            txt_Password.Enabled = true;
            txt_AccessoriesID.Enabled = true;
            txt_AccessoriesID.ForeColor = SystemColors.WindowText;
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
            CurrentEmployee currentEmployee = new CurrentEmployee();
            currentEmployee.GetCurrentEmployee(int.Parse(dataGridView.CurrentRow.Cells[0].Value.ToString()));
            if (currentEmployee.TrangThai == "Đang làm việc")
            {
                MessageBox.Show(Resource.Employee_Error_NotResigned, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            button = "Delete";
            tabControl1.TabPages.Add(tabPagePetDetail);
            tabControl1.TabPages.Remove(tabPagePetList);
            tabControl1.SelectedTab = tabPagePetDetail;

            label3.ForeColor = Color.Gray;
            txt_AccessoriesID.ForeColor = Color.Gray;
            txt_AccessoriesID.Enabled = false;
            txt_Username.Enabled = false;
            txt_Password.Enabled = false;

            txt_AccessoriesID.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            txt_Username.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            txt_Password.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (button == "Edit")
            {
                AccountBLL accountBLL = new AccountBLL();
                Account account = new Account
                {
                    Id = int.Parse(txt_AccessoriesID.Text),
                    Username = txt_Username.Text,
                    Password = txt_Password.Text,
                    Role = "Employee"
                };
                isSuccessful = accountBLL.UpdateAccount(account);
                if (isSuccessful)
                {
                    message = Resource.Account_Edit_Success;
                    MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    message = Resource.Account_Edit_Fail;
                    MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                btnSave.Text = Resource.btn_Delete;

                tabControl1.TabPages.Add(tabPagePetList);
                tabControl1.TabPages.Remove(tabPagePetDetail);
                tabControl1.SelectedTab = tabPagePetList;

                LoadData();
            }
            else if (button == "Delete")
            {
                AccountBLL accountBLL = new AccountBLL();
                int accountId = int.Parse(txt_AccessoriesID.Text);
                isSuccessful = accountBLL.DeleteAccount(accountId);
                

                if (isSuccessful)
                {
                    message = Resource.Account_Delete_Success;
                    MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    message = Resource.Account_Delete_Fail;
                    MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                tabControl1.TabPages.Add(tabPagePetList);
                tabControl1.TabPages.Remove(tabPagePetDetail);
                tabControl1.SelectedTab = tabPagePetList;
                LoadData();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool found = false;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (dataGridView.Rows[i].Cells[1].Value.ToString().Contains(txtSearch.Text))
                {
                    found = true;
                    dataGridView.Rows[i].Selected = true;
                    dataGridView.CurrentCell = dataGridView.Rows[i].Cells[1];
                    break;
                }
            }
            if (!found)
            {
                if (LanguageClass.Language == "ja-jp")
                {
                    MessageBox.Show(txtSearch.Text + Resource.Employee_Search_NotFoundByName, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Resource.Employee_Search_NotFoundByName + txtSearch.Text, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Assign_Click(object sender, EventArgs e)
        {
            AccountBLL accountBLL = new AccountBLL();
            int id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value.ToString());
            bool isAssigned = accountBLL.AssignEmployee(id);
            if (isAssigned)
            {
                MessageBox.Show(Resource.Permission_Assign_Success, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Resource.Permission_Assign_Fail, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadData();
        }
    }
}
