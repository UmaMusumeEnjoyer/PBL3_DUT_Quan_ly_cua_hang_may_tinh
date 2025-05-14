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
    public partial class PCUI : Form
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        private string button;


        //Constructor
        public PCUI()
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
            PCBLL pcBLL = new PCBLL();
            //List<Supplier> suppliers = supplierBLL.GetAllSuppliers();
            DataTable dt = pcBLL.GetAllPCsDataTable();
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            
            dataGridView.DataSource = dt;

            dataGridView.Columns["Product_Id"].Visible = false;
            dataGridView.Columns["productName"].HeaderText = "Tên sản phẩm";
            dataGridView.Columns["Manufacturer"].HeaderText = "Nhà sản xuất";
            dataGridView.Columns["specification"].HeaderText = "Thông số kỹ thuật";
            //dataGridView.Columns["weight"].HeaderText = "Trọng lượng";
            dataGridView.Columns["price"].HeaderText = "Giá";

            dataGridView.Columns["stockQuantity"].HeaderText = "Số lượng tồn kho";

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
            txt_ProductID.ForeColor = Color.Gray;
            txt_ProductID.Enabled = false;
            txt_stockQuantity.Enabled = false;

            txt_ProductID.Text = dataGridView.CurrentRow.Cells["Product_Id"].Value.ToString();
            txt_pcName.Text = dataGridView.CurrentRow.Cells["productName"].Value.ToString();
            txt_pcSupplier.Text = dataGridView.CurrentRow.Cells["Manufacturer"].Value.ToString();
            txt_pcSpecs.Text = dataGridView.CurrentRow.Cells["specification"].Value.ToString();
            //txt_pcSpecs.Text = dataGridView.CurrentRow.Cells["weight"].Value.ToString();
            txt_pcPrice.Text = dataGridView.CurrentRow.Cells["price"].Value.ToString();
            txt_stockQuantity.Text = dataGridView.CurrentRow.Cells["stockQuantity"].Value.ToString();



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
            txt_ProductID.ForeColor = Color.Gray;
            txt_ProductID.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetFormState();
        }

        private void ResetFormState()
        {
            // Clear các ô nhập liệu
            txt_pcSpecs.Clear();
            txt_pcPrice.Clear();
            txt_pcName.Clear();
            txt_pcSupplier.Clear();
            txt_ProductID.Clear();

            // Kích hoạt lại tất cả textbox nếu từng bị disable (Delete mode)
            txt_pcName.Enabled = true;
            txt_pcSupplier.Enabled = true;
            txt_pcSpecs.Enabled = true;
            txt_pcPrice.Enabled = true;
            txt_ProductID.Enabled = true;
            txt_ProductID.ForeColor = SystemColors.WindowText;
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
            txt_ProductID.ForeColor = Color.Gray;
            txt_ProductID.Enabled = false;

            txt_pcName.Enabled = false;
            txt_pcSupplier.Enabled = false;
            txt_pcSpecs.Enabled = false;
            txt_pcPrice.Enabled = false;
            txt_pcSpecs.Enabled = false;
            txt_stockQuantity.Enabled = false;

            txt_ProductID.Text = dataGridView.CurrentRow.Cells["Product_Id"].Value.ToString();
            txt_pcName.Text = dataGridView.CurrentRow.Cells["productName"].Value.ToString();
            txt_pcSupplier.Text = dataGridView.CurrentRow.Cells["Manufacturer"].Value.ToString();
            txt_pcSpecs.Text = dataGridView.CurrentRow.Cells["specification"].Value.ToString();
            txt_pcPrice.Text = dataGridView.CurrentRow.Cells["price"].Value.ToString();
            //txt_pcSpecs.Text = dataGridView.CurrentRow.Cells["weight"].Value.ToString();
            txt_stockQuantity.Text = dataGridView.CurrentRow.Cells["stockQuantity"].Value.ToString();



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (button == "Edit")
            {
                // Edit supplier logic
                // Call SaveEvent or any other logic
                int supplierId = Convert.ToInt32(dataGridView.CurrentRow.Cells["Product_Id"].Value);
                PCBLL pcBLL = new PCBLL();
                PC pc = new PC
                {
                    Product_Id = supplierId,
                    productName = txt_pcName.Text,
                    Manufacturer = txt_pcSupplier.Text,
                    Spetification = txt_pcSpecs.Text,
                    price = Convert.ToDecimal(txt_pcPrice.Text),
                    stockQuantity = Convert.ToInt32(txt_stockQuantity.Text)
                };
                isSuccessful = pcBLL.UpdatePC(pc);
                if (isSuccessful)
                {
                    message = "Cập nhật PC thành công.";
                    MessageBox.Show(message);
                    LoadData();
                }
                else
                {
                    message = "Cập nhật PC thất bại.";
                    MessageBox.Show(message);
                }

                tabControl1.TabPages.Add(tabPagePetList);
                tabControl1.TabPages.Remove(tabPagePetDetail);
                tabControl1.SelectedTab = tabPagePetList;
            }
            else if (button == "Delete")
            {
                int supplierId = Convert.ToInt32(dataGridView.CurrentRow.Cells["Product_Id"].Value);
                PCBLL pCBLL = new PCBLL();
                isSuccessful = pCBLL.DeletePC(supplierId);
                if (isSuccessful)
                {
                    message = "Xóa PC thành công.";
                    MessageBox.Show(message);
                    LoadData();
                }
                else
                {
                    message = "Xóa PC thất bại.";
                    MessageBox.Show(message);
                }
                tabControl1.TabPages.Add(tabPagePetList);
                tabControl1.TabPages.Remove(tabPagePetDetail);
                tabControl1.SelectedTab = tabPagePetList;
            }
            else if(button =="Special")
            {
                txt_ProductID.ForeColor = Color.Gray;
                txt_ProductID.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            //string a = cbb_LaptopSearch.SelectedItem.ToString();

            PCBLL laptopBLL = new PCBLL();
            if (cbb_PcSearch.SelectedItem.ToString() == "Tên")
            {
                dataGridView.DataSource = laptopBLL.GetAllPCs().Where(l => l.productName.Contains(searchText)).ToList();
            }
            else if (cbb_PcSearch.SelectedItem.ToString() == "Nhà sản xuất")
            {
                dataGridView.DataSource = laptopBLL.GetAllPCs().Where(l => l.Manufacturer.Contains(searchText)).ToList();
            }
            else if (cbb_PcSearch.SelectedItem.ToString() == "Cấu hình")
            {
                dataGridView.DataSource = laptopBLL.GetAllPCs().Where(l => l.Spetification.Contains(searchText)).ToList();
            }
        }

        private void txt_SupplierPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbb_LaptopSearch_TextUpdate(object sender, EventArgs e)
        {

        }

        private void btn_ClearFilter_Click(object sender, EventArgs e)
        {
            cbb_PcSearch.SelectedIndex = -1;
            txtSearch.Clear();
            LoadData();
        }
    }
}
