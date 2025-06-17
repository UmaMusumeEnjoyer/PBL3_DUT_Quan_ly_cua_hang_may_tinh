using Gwenchana.BussinessLogic;
using Gwenchana.DataAccess.DTO;
using Gwenchana.LanguagePack; // Assuming you have a LanguagePack class for localization
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization; // For CultureInfo

namespace Gwenchana
{
    public partial class Employees: Form
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        private string button;


        //Constructor
        public Employees()
        {
            InitializeComponent();
            LoadTrangThaiComboBox();
            AssociateAndRaiseViewEvents();
            UpdateComponent(LanguageClass.Language);
            LoadData();
            tabControl1.TabPages.Remove(tabPagePetDetail);
        }

        private void UpdateComponent(string language)
        {
            Resource.Culture = string.IsNullOrEmpty(language) ? null : new CultureInfo(language);
            lb_employeeManagement.Text = Resource.lb_employeeManagement;
            tabControl1.TabPages[0].Text = Resource.TabCtr_List;
            tabControl1.TabPages[1].Text = Resource.TabCtr_Details;
            lb_Search.Text = Resource.lb_Search;
            btn_Search.Text = Resource.btn_Search;
            btn_Edit.Text = Resource.btn_Edit;
            lb_employeeID.Text = "ID";
            lb_employeeName.Text = Resource.lb_employeeName;
            lb_employeeAge.Text = Resource.lb_employeeAge;
            lb_employeePhonenumber.Text = Resource.lb_employeePhonenumber;
            lb_employeeStatus.Text = Resource.lb_employeeStatus;
            LoadTrangThaiComboBox();

        }


        private void LoadData()
        {
            EmployeeBLL employeeBLL = new EmployeeBLL();
            DataTable dt = employeeBLL.GetAllEmployeesDataTable();
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            
            dataGridView.DataSource = dt;

            dataGridView.Columns[0].Visible = false; // Hide the first column (ID)

            dataGridView.Columns[1].HeaderText = Resource.lb_employeeName1;
            dataGridView.Columns[2].HeaderText = Resource.lb_Age;
            dataGridView.Columns[3].HeaderText = Resource.lb_Phonenumber;
            dataGridView.Columns[4].HeaderText = "Account ID";
            dataGridView.Columns[4].Visible = false; // Hide the Account ID column
            dataGridView.Columns[5].HeaderText = Resource.lb_employeeStatus; 


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

            lb_employeeID.ForeColor = Color.Gray;
            txt_AccessoriesID.ForeColor = Color.Gray;
            txt_AccessoriesID.Enabled = false;

            txt_AccessoriesID.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            txt_EmployeeName.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            txt_PhoneNumber.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            txt_Age.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();

            cbb_TrangThai.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();

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
            lb_employeeID.ForeColor = Color.Gray;
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
            txt_PhoneNumber.Clear();
            txt_EmployeeName.Clear();
            txt_AccessoriesID.Clear();

            // Kích hoạt lại tất cả textbox nếu từng bị disable (Delete mode)
            txt_EmployeeName.Enabled = true;
            txt_PhoneNumber.Enabled = true;
            txt_AccessoriesID.Enabled = true;
            txt_AccessoriesID.ForeColor = SystemColors.WindowText;
            lb_employeeID.ForeColor = SystemColors.ControlText;

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


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (button == "Edit")
            {
                EmployeeBLL employeeBLL = new EmployeeBLL();
                Employee employee = new Employee
                {
                    Empolyee_Id = int.Parse(txt_AccessoriesID.Text),

                    employeeName = txt_EmployeeName.Text,
                    phoneNumber = txt_PhoneNumber.Text,
                    Age = int.Parse(txt_Age.Text),
                    TrangThai = ((KeyValuePair<string, string>)cbb_TrangThai.SelectedItem).Key
                };
                isSuccessful = employeeBLL.UpdateEmployee(employee);
                if (isSuccessful)
                {
                    message = Resource.Account_Update_Success;
                    MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                tabControl1.TabPages.Add(tabPagePetList);
                tabControl1.TabPages.Remove(tabPagePetDetail);
                tabControl1.SelectedTab = tabPagePetList;

                LoadData();
            }
        }

        private void LoadTrangThaiComboBox()
        {
            Dictionary<string, string> trangThaiDict = new Dictionary<string, string>()
            {
                { "Đang làm việc", Resource.Status_Working }, 
                { "Nghỉ việc",     Resource.Status_Stopped }
            };
            cbb_TrangThai.DataSource = new BindingSource(trangThaiDict, null);
            cbb_TrangThai.DisplayMember = "Value";
            cbb_TrangThai.ValueMember = "Key";
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
                if(LanguageClass.Language == "ja-jp")
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

        private void cbb_TrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
