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
            LoadData();
            tabControl1.TabPages.Remove(tabPagePetDetail);

            //tabControl1.TabPages.Remove(tabPagePetDetail);
            //btnClose.Click += delegate { this.Close(); };
        }

        private void LoadData()
        {
            AccountBLL accountBLL = new AccountBLL();
            DataTable dt = accountBLL.GetAllAccountsDataTable();
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            
            dataGridView.DataSource = dt;

            dataGridView.Columns[0].Visible = false; // Hide the first column (ID)
            dataGridView.Columns[1].HeaderText = "Tên tài khoản";
            dataGridView.Columns[2].HeaderText = "Mật khẩu";
            dataGridView.Columns[3].HeaderText = "Vai trò";
            //dataGridView.Columns[4].HeaderText = "Trạng thái";
            dataGridView.Columns[4].HeaderText = "Trạng thái gán quyền";



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
                    message = "Cập nhật tài khoản thành công!";
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    message = "Cập nhật tài khoản thất bại!";
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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
                    message = "Xóa tài khoản thành công!";
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    message = "Xóa tài khoản thất bại!";
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
                MessageBox.Show("Không tìm thấy tài khoản nào với tên chứa: " + txtSearch.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Gán quyền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Gán quyền thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadData();
        }
    }
}
