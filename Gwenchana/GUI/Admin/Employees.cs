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
            AssociateAndRaiseViewEvents();
            LoadData();
            tabControl1.TabPages.Remove(tabPagePetDetail);

            //tabControl1.TabPages.Remove(tabPagePetDetail);
            btnClose.Click += delegate { this.Close(); };
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

            dataGridView.Columns[1].HeaderText = "Họ và tên";
            dataGridView.Columns[2].HeaderText = "Tuổi";
            dataGridView.Columns[3].HeaderText = "Số điện thoại";


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
            txt_AccessoriesID.ForeColor = Color.Gray;
            txt_AccessoriesID.Enabled = false;

            txt_AccessoriesID.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            txt_EmployeeName.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            txt_PhoneNumber.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            txt_Age.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();

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
            txt_PhoneNumber.Clear();
            txt_EmployeeName.Clear();
            txt_AccessoriesID.Clear();

            // Kích hoạt lại tất cả textbox nếu từng bị disable (Delete mode)
            txt_EmployeeName.Enabled = true;
            txt_PhoneNumber.Enabled = true;
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
            button = "Delete";
            tabControl1.TabPages.Add(tabPagePetDetail);
            tabControl1.TabPages.Remove(tabPagePetList);
            tabControl1.SelectedTab = tabPagePetDetail;

            label3.ForeColor = Color.Gray;
            txt_AccessoriesID.ForeColor = Color.Gray;
            txt_AccessoriesID.Enabled = false;
            txt_EmployeeName.Enabled = false;
            txt_PhoneNumber.Enabled = false;
            txt_Age.Enabled = false;


            txt_AccessoriesID.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            txt_EmployeeName.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            txt_PhoneNumber.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            txt_Age.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();





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

                };
                isSuccessful = employeeBLL.UpdateEmployee(employee);
                if (isSuccessful)
                {
                    message = "Cập nhật tài khoản thành công!";
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                tabControl1.TabPages.Add(tabPagePetList);
                tabControl1.TabPages.Remove(tabPagePetDetail);
                tabControl1.SelectedTab = tabPagePetList;

                LoadData();
            }
            else if (button == "Delete")
            {
                MessageBox.Show("Nếu xoá nhân viên thì sẽ xoá tài khoản của nhân viên đó", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EmployeeBLL employeeBLL = new EmployeeBLL();

                int employeeId = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
                isSuccessful = employeeBLL.DeleteEmployee(employeeId);
                if (isSuccessful) 
                {
                    message = "Xoá tài khoản thành công!";
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    message = "Xoá tài khoản thất bại!";
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




                tabControl1.TabPages.Add(tabPagePetList);
                tabControl1.TabPages.Remove(tabPagePetDetail);
                tabControl1.SelectedTab = tabPagePetList;
                LoadData();
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

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
