using Gwenchana.BussinessLogic;
using Gwenchana.DataAccess.DAL;
using Gwenchana.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gwenchana
{
    public partial class AccessoriesUI: Form
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        private string button;


        //Constructor
        public AccessoriesUI()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            LoadData();
            tabControl1.TabPages.Remove(tabPagePetDetail);
            button2.Visible = false; // Ẩn nút "Thêm mới" trong tab PetList

        }
        private DataTable accessoriesData;
        private void LoadData()
        {
            //dataGridView.Columns["supplierName"].HeaderText = "Tên nhà cung cấp";
            AccessoriesBLL accessoriesBLL = new AccessoriesBLL();
            accessoriesData = accessoriesBLL.GetAllAccessoriesDataTable(); // Lưu lại DataTable gốc
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;

            dataGridView.DataSource = accessoriesData; // Gán DataTable gốc

            // Định dạng lại cột như ban đầu
            dataGridView.Columns["Product_Id"].Visible = false;
            dataGridView.Columns["productName"].HeaderText = "Tên sản phẩm";
            dataGridView.Columns["Manufacturer"].HeaderText = "Nhà sản xuất";
            dataGridView.Columns["overview"].HeaderText = "Mô tả";
            dataGridView.Columns["type"].HeaderText = "Loại sản phẩm";
            dataGridView.Columns["price"].HeaderText = "Giá";
            dataGridView.Columns["stockQuantity"].HeaderText = "Số lượng tồn kho";
            dataGridView.Columns["Supplier_Id"].HeaderText = "Nhà cung cấp";
            dataGridView.Columns["Supplier_Id"].Visible = false; // Ẩn cột Supplier_Id
            //dataGridView.Columns["supplierName"].Visible = false;
            dataGridView.Columns["supplierName"].HeaderText = "Tên nhà cung cấp";

        }

        public void ChangeTab()
        {
            button = "Special";
            tabControl1.TabPages.Add(tabPagePetDetail);
            tabControl1.TabPages.Remove(tabPagePetList);
            tabControl1.SelectedTab = tabPagePetDetail;
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
            txt_AccessoriesstockQuantity.Enabled = false;

            txt_AccessoriesID.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            txt_AccessoriesName.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            txt_AccessoriesManufacturer.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            txt_AccessoriesOverview.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            txt_AccessoriesType.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            txt_AccessoriesPrice.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
            txt_AccessoriesstockQuantity.Text = dataGridView.CurrentRow.Cells[6].Value.ToString();

            // Đặt lại trạng thái của các ô nhập liệu
            btnSave.Text = "Cập nhật";

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
            txt_AccessoriesOverview.Clear();
            txt_AccessoriesPrice.Clear();
            txt_AccessoriesName.Clear();
            txt_AccessoriesManufacturer.Clear();
            txt_AccessoriesID.Clear();

            // Kích hoạt lại tất cả textbox nếu từng bị disable (Delete mode)
            txt_AccessoriesName.Enabled = true;
            txt_AccessoriesManufacturer.Enabled = true;
            txt_AccessoriesOverview.Enabled = true;
            txt_AccessoriesPrice.Enabled = true;
            txt_AccessoriesID.Enabled = true;
            txt_AccessoriesID.ForeColor = SystemColors.WindowText;
            label3.ForeColor = SystemColors.ControlText;
            txt_AccessoriesType.Enabled = true;
            txt_AccessoriesType.ForeColor = SystemColors.WindowText;

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
            txt_AccessoriesID.ForeColor = Color.Gray;
            txt_AccessoriesID.Enabled = false;
            txt_AccessoriesName.Enabled = false;
            txt_AccessoriesManufacturer.Enabled = false;
            txt_AccessoriesOverview.Enabled = false;
            txt_AccessoriesPrice.Enabled = false;
            txt_AccessoriesType.Enabled = false;
            txt_AccessoriesstockQuantity.Enabled = false;

            txt_AccessoriesID.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            txt_AccessoriesName.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            txt_AccessoriesManufacturer.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            txt_AccessoriesOverview.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            txt_AccessoriesType.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            txt_AccessoriesPrice.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
            txt_AccessoriesstockQuantity.Text = dataGridView.CurrentRow.Cells[6].Value.ToString();

            btnSave.Text = "Xóa";





        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (button == "Edit")
            {
                int id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value.ToString());
                Accessories accessoriesDTO = new Accessories
                {
                    Product_Id = id,
                    productName = txt_AccessoriesName.Text,
                    Manufacturer = txt_AccessoriesManufacturer.Text,
                    Overview = txt_AccessoriesOverview.Text,
                    Type = txt_AccessoriesType.Text,
                    price = Convert.ToDecimal(txt_AccessoriesPrice.Text),
                    stockQuantity = Convert.ToInt32(txt_AccessoriesstockQuantity.Text)
                };
                AccessoriesBLL accessoriesBLL = new AccessoriesBLL();
                isSuccessful = accessoriesBLL.UpdateAccessories(accessoriesDTO);
                if (isSuccessful)
                {
                    message = "Cập nhật thành công!";
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    message = "Cập nhật không thành công!";
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                tabControl1.TabPages.Add(tabPagePetList);
                tabControl1.TabPages.Remove(tabPagePetDetail);
                tabControl1.SelectedTab = tabPagePetList;

                LoadData();
            }
            else if (button == "Delete")
            {
                AccessoriesBLL accessoriesBLL = new AccessoriesBLL();
                int id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value.ToString());
                isSuccessful = accessoriesBLL.DeleteAccessories(id);
                if (isSuccessful)
                {
                    message = "Xóa thành công!";
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    message = "Xóa không thành công!";
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LoadData();


                tabControl1.TabPages.Add(tabPagePetList);
                tabControl1.TabPages.Remove(tabPagePetDetail);
                tabControl1.SelectedTab = tabPagePetList;
            }
            else if(button == "Special")
            {
                txt_AccessoriesID.ForeColor = Color.Gray;
                txt_AccessoriesID.Enabled = false;
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

            // Sử dụng DataView để filter trên DataTable gốc
            if (accessoriesData == null)
            {
                LoadData(); // Đảm bảo DataTable đã có dữ liệu
            }

            string filter = "";
            if (cbb_LaptopSearch.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tiêu chí tìm kiếm hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbb_LaptopSearch.SelectedItem.ToString() == "Tên")
            {
                filter = $"productName LIKE '%{searchText.Replace("'", "''")}%'";
            }
            else if (cbb_LaptopSearch.SelectedItem.ToString() == "Hãng sản xuất")
            {
                filter = $"Manufacturer LIKE '%{searchText.Replace("'", "''")}%'";
            }
            else if (cbb_LaptopSearch.SelectedItem.ToString() == "Loại")
            {
                filter = $"type LIKE '%{searchText.Replace("'", "''")}%'";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tiêu chí tìm kiếm hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataView dv = new DataView(accessoriesData);
            dv.RowFilter = filter;
            dataGridView.DataSource = dv;

            // Các định dạng cột vẫn giữ nguyên vì DataTable/DataView không thay đổi cấu trúc cột
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ClearFilter_Click(object sender, EventArgs e)
        {
            cbb_LaptopSearch.SelectedIndex = -1;
            txtSearch.Clear();
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPagePetDetail);
            tabControl1.TabPages.Remove(tabPagePetList);
            tabControl1.SelectedTab = tabPagePetDetail;

            btnSave.Visible = false;
            btnCancel.Visible = false;
            button2.Visible = true;


            txt_AccessoriesID.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            txt_AccessoriesID.ForeColor = Color.Gray;
            txt_AccessoriesID.Enabled = false;

            txt_AccessoriesName.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            txt_AccessoriesName.ForeColor = Color.Gray;
            txt_AccessoriesName.Enabled = false;
            
            txt_AccessoriesManufacturer.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            txt_AccessoriesManufacturer.ForeColor = Color.Gray;
            txt_AccessoriesManufacturer.Enabled = false;

            txt_AccessoriesOverview.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            txt_AccessoriesOverview.ForeColor = Color.Gray;
            txt_AccessoriesOverview.Enabled = false;

            txt_AccessoriesType.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            txt_AccessoriesType.ForeColor = Color.Gray;
            txt_AccessoriesType.Enabled = false;

            txt_AccessoriesPrice.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
            txt_AccessoriesPrice.ForeColor = Color.Gray;
            txt_AccessoriesPrice.Enabled = false;

            txt_AccessoriesstockQuantity.Text = dataGridView.CurrentRow.Cells[6].Value.ToString();
            txt_AccessoriesstockQuantity.ForeColor = Color.Gray;
            txt_AccessoriesstockQuantity.Enabled = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(tabPagePetList))
                tabControl1.TabPages.Add(tabPagePetList);
            if (tabControl1.TabPages.Contains(tabPagePetDetail))
                tabControl1.TabPages.Remove(tabPagePetDetail);
            tabControl1.SelectedTab = tabPagePetList;


            // Hiển thị lại các nút Save và Cancel
            btnSave.Visible = true;
            btnCancel.Visible = true;
            button2.Visible = false; // Ẩn nút "Xem chi tiết" sau khi đã xem xong
            // Đặt lại trạng thái của các ô nhập liệu về mặc định
            txt_AccessoriesID.Clear();
            txt_AccessoriesName.Clear();
            txt_AccessoriesManufacturer.Clear();
            txt_AccessoriesOverview.Clear();
            txt_AccessoriesType.Clear();
            txt_AccessoriesPrice.Clear();
            txt_AccessoriesstockQuantity.Clear();
            // Đặt lại màu sắc và trạng thái của các ô nhập liệu
            txt_AccessoriesID.ForeColor = SystemColors.WindowText;
            txt_AccessoriesID.Enabled = true;
            //label3.ForeColor = SystemColors.ControlText;
            txt_AccessoriesName.ForeColor = SystemColors.WindowText;
            txt_AccessoriesName.Enabled = true;
            txt_AccessoriesManufacturer.ForeColor = SystemColors.WindowText;
            txt_AccessoriesManufacturer.Enabled = true;
            txt_AccessoriesOverview.ForeColor = SystemColors.WindowText;
            txt_AccessoriesOverview.Enabled = true;
            txt_AccessoriesType.ForeColor = SystemColors.WindowText;
            txt_AccessoriesType.Enabled = true;
            txt_AccessoriesPrice.ForeColor = SystemColors.WindowText;
            txt_AccessoriesPrice.Enabled = true;
            txt_AccessoriesstockQuantity.ForeColor = SystemColors.WindowText;
            txt_AccessoriesstockQuantity.Enabled = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct("Accessories");
            addProduct.ShowDialog();
            LoadData(); // Tải lại dữ liệu sau khi thêm mới sản phẩm
        }
    }
}
