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
using Gwenchana.LanguagePack;
using System.Globalization; // For CultureInfo

namespace Gwenchana
{
    public partial class PCUI : Form
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        private string button;

        private DataTable pcData;


        //Constructor
        public PCUI()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            LoadTrangThaiComboBox();
            UpdateComponent(LanguageClass.Language);
            
            LoadData();
            tabControl1.TabPages.Remove(tabPagePetDetail);

            button2.Visible = false; 
        }

        private void UpdateComponent(string language)
        {
            Resource.Culture = string.IsNullOrEmpty(language) ? null : new CultureInfo(language);
            tabControl1.TabPages[0].Text = Resource.TabCtr_List;
            tabControl1.TabPages[1].Text = Resource.TabCtr_Details;
            lb_pcManagement.Text = Resource.lb_pcManagement;
            lb_Filters.Text = Resource.lb_Filters;
            btn_ClearFilter.Text = Resource.btn_ClearFilter;
            lb_Search.Text = Resource.lb_Search;
            btn_Search.Text = Resource.btn_Search;
            btn_Details.Text = Resource.TabCtr_Details;
            btn_Add.Text = Resource.btn_Add;
            btn_Edit.Text = Resource.btn_Edit;
            btn_Delete.Text = Resource.btn_Delete;
            LoadTrangThaiComboBox();

        }

        private void LoadTrangThaiComboBox()
        {
            Dictionary<string, string> trangThaiDict = new Dictionary<string, string>()
            {
                { "Tên", Resource.lb_productName},
                { "Nhà sản xuất", Resource.lb_manufacturerName },
                { "Cấu hình", Resource.lb_Specifications  }
            };
            cbb_PcSearch.DataSource = new BindingSource(trangThaiDict, null);
            cbb_PcSearch.DisplayMember = "Value";
            cbb_PcSearch.ValueMember = "Key";
        }

        private void LoadData()
        {
            PCBLL pcBLL = new PCBLL();
            pcData = pcBLL.GetAllPCsDataTable();
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;

            dataGridView.DataSource = pcData;

            dataGridView.Columns["Product_Id"].Visible = false;
            dataGridView.Columns["productName"].HeaderText = Resource.lb_productName;
            dataGridView.Columns["Manufacturer"].HeaderText = Resource.lb_manufacturerName;
            dataGridView.Columns["specification"].HeaderText = Resource.lb_Specifications;
            
            dataGridView.Columns["price"].HeaderText = Resource.lb_Price;

            dataGridView.Columns["stockQuantity"].HeaderText = Resource.lb_StockQuantity;
            //dataGridView.Columns["Supplier_Id"].HeaderText = "Mã nhà cung cấp";
            dataGridView.Columns["Supplier_Id"].Visible = false;
            dataGridView.Columns["supplierName"].HeaderText = Resource.lb_supplierName;

            dataGridView.CellFormatting += dataGridView_CellFormatting;

        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Nếu cột là "price"
            if (dataGridView.Columns[e.ColumnIndex].Name == "price" && e.Value != null && e.Value is decimal)
            {
                // Hiển thị số tiền theo chuẩn Việt Nam và thêm ký hiệu ₫
                decimal gia = (decimal)e.Value;
                e.Value = gia.ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("vi-VN")) + " ₫";
                e.FormattingApplied = true;
            }
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

            btnSave.Text = Resource.btn_Edit;

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
            int stockQuantity = Convert.ToInt32(dataGridView.CurrentRow.Cells["stockQuantity"].Value);
            if (stockQuantity > 0)
            {
                MessageBox.Show("Không thể xoá vì còn hàng tồn kho", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            button = "Delete";
            tabControl1.TabPages.Add(tabPagePetDetail);
            tabControl1.TabPages.Remove(tabPagePetList);
            tabControl1.SelectedTab = tabPagePetDetail;

            lb_Id.ForeColor = Color.Gray;
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

            btnSave.Text = Resource.btn_Delete;

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

            if (pcData == null) LoadData();

            string filter = "";
            if (cbb_PcSearch.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tiêu chí tìm kiếm hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var selectedKey = (cbb_PcSearch.SelectedValue ?? "").ToString();
            if (selectedKey == "Tên")
                filter = $"productName LIKE '%{searchText.Replace("'", "''")}%'";
            else if (selectedKey == "Nhà sản xuất")
                filter = $"Manufacturer LIKE '%{searchText.Replace("'", "''")}%'";
            else if (selectedKey == "Cấu hình")
                filter = $"specification LIKE '%{searchText.Replace("'", "''")}%'";
            else
            {
                MessageBox.Show("Vui lòng chọn tiêu chí tìm kiếm hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataView dv = new DataView(pcData);
            dv.RowFilter = filter;
            dataGridView.DataSource = dv;
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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPagePetDetail);
            tabControl1.TabPages.Remove(tabPagePetList);
            tabControl1.SelectedTab = tabPagePetDetail;

            btnSave.Visible = false;
            btnCancel.Visible = false;
            button2.Visible = true;

            txt_ProductID.Text = dataGridView.CurrentRow.Cells["Product_Id"].Value.ToString();
            txt_ProductID.Enabled = false;
            txt_ProductID.ForeColor = Color.Gray;

            txt_pcName.Text = dataGridView.CurrentRow.Cells["productName"].Value.ToString();
            txt_pcName.Enabled = false;
            txt_pcName.ForeColor = Color.Gray;

            txt_pcSupplier.Text = dataGridView.CurrentRow.Cells["Manufacturer"].Value.ToString();
            txt_pcSupplier.Enabled = false;
            txt_pcSupplier.ForeColor = Color.Gray;

            txt_pcSpecs.Text = dataGridView.CurrentRow.Cells["specification"].Value.ToString();
            txt_pcSpecs.Enabled = false;
            txt_pcSpecs.ForeColor = Color.Gray;

            txt_pcPrice.Text = dataGridView.CurrentRow.Cells["price"].Value.ToString();
            txt_pcPrice.Enabled = false;
            txt_pcPrice.ForeColor = Color.Gray;

            txt_stockQuantity.Text = dataGridView.CurrentRow.Cells["stockQuantity"].Value.ToString();
            txt_stockQuantity.Enabled = false;
            txt_stockQuantity.ForeColor = Color.Gray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(tabPagePetList))
                tabControl1.TabPages.Add(tabPagePetList);
            if (tabControl1.TabPages.Contains(tabPagePetDetail))
                tabControl1.TabPages.Remove(tabPagePetDetail);
            tabControl1.SelectedTab = tabPagePetList;

            btnSave.Visible = true;
            btnCancel.Visible = true;
            button2.Visible = false;

            txt_ProductID.Clear();
            txt_pcName.Clear();
            txt_pcSupplier.Clear();
            txt_pcSpecs.Clear();
            txt_pcPrice.Clear();
            txt_stockQuantity.Clear();

            txt_ProductID.Enabled = true;
            txt_ProductID.ForeColor = SystemColors.WindowText;

            txt_pcName.Enabled = true;
            txt_pcName.ForeColor = SystemColors.WindowText;

            txt_pcSupplier.Enabled = true;
            txt_pcSupplier.ForeColor = SystemColors.WindowText;

            txt_stockQuantity.Enabled = true;
            txt_stockQuantity.ForeColor = SystemColors.WindowText;

            txt_pcSpecs.Enabled = true;
            txt_pcSpecs.ForeColor = SystemColors.WindowText;

            txt_pcPrice.Enabled = true;
            txt_pcPrice.ForeColor = SystemColors.WindowText;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddProduct addProductForm = new AddProduct("PC");
            addProductForm.ShowDialog();
            LoadData();
        }

        private void txt_pcPrice_Validating(object sender, CancelEventArgs e)
        {
            double canNang;
            if (!double.TryParse(txt_pcPrice.Text, out canNang) || canNang < 0)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho cân nặng (không âm)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_pcPrice.Focus();
                txt_pcPrice.SelectAll();
            }
        }
    }
}
