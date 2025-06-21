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
using Gwenchana.LanguagePack; // Assuming you have a LanguagePack class for localization
using System.Globalization; // For CultureInfo

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
            LoadTrangThaiComboBox();
            UpdateComponent(LanguageClass.Language);
            LoadData();
            tabControl1.TabPages.Remove(tabPagePetDetail);
            btn_Back.Visible = false;

        }
        private DataTable accessoriesData;

        private void UpdateComponent(string language)
        {
            Resource.Culture = string.IsNullOrEmpty(language) ? null : new CultureInfo(language);

            lb_Accessories.Text = Resource.btn_Accessories;
            tabControl1.TabPages[0].Text = Resource.TabCtr_List;
            tabControl1.TabPages[1].Text = Resource.TabCtr_Details;

            lb_Search.Text = Resource.lb_Search;
            lb_SearchFilters.Text = Resource.lb_Filters;
            
            btn_Search.Text = Resource.btn_Search;
            btn_ClearFilter.Text = Resource.btn_ClearFilter;
            btn_Add.Text = Resource.btn_Add;
            btn_Edit.Text = Resource.btn_Edit;
            btn_Delete.Text = Resource.btn_Delete;
            
            lb_ID.Text = "ID";
            lb_ProductType.Text = Resource.lb_ProductType;
            lb_ProductName.Text = Resource.lb_productName;
            lb_StockQuantity.Text = Resource.lb_StockQuantity;
            lb_Manufacturer.Text = Resource.lb_manufacturerName;
            lb_Overview.Text = Resource.lb_Overview;
            lb_Price.Text = Resource.lb_Price;

            btn_Back.Text = Resource.btn_Back;
            btn_Cancel.Text = Resource.btn_Cancel;

            LoadTrangThaiComboBox();
        }

        private void LoadTrangThaiComboBox()
        {
            Dictionary<string, string> trangThaiDict = new Dictionary<string, string>()
            {
                { "Tên", Resource.lb_productName},
                { "Hãng sản xuất", Resource.lb_manufacturerName },
                { "Loại", Resource.lb_ProductType  },
            };
            cbb_LaptopSearch.DataSource = new BindingSource(trangThaiDict, null);
            cbb_LaptopSearch.DisplayMember = "Value";
            cbb_LaptopSearch.ValueMember = "Key";
        }

        private void LoadData()
        {
            AccessoriesBLL accessoriesBLL = new AccessoriesBLL();
            accessoriesData = accessoriesBLL.GetAllAccessoriesDataTable(); 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;

            dataGridView.DataSource = accessoriesData; 

           
            dataGridView.Columns["Product_Id"].Visible = false;
            dataGridView.Columns["productName"].HeaderText = Resource.lb_productName;
            dataGridView.Columns["Manufacturer"].HeaderText = Resource.lb_manufacturerName;
            dataGridView.Columns["overview"].HeaderText = Resource.lb_Overview;
            dataGridView.Columns["type"].HeaderText = Resource.lb_ProductType;
            dataGridView.Columns["price"].HeaderText = Resource.lb_Price;
            dataGridView.Columns["stockQuantity"].HeaderText = Resource.lb_StockQuantity;
            //dataGridView.Columns["Supplier_Id"].HeaderText = "Nhà cung cấp";
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
        }


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

            btn_Save.Text = Resource.btn_Edit;

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
            lb_ID.ForeColor = Color.Gray;
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

            txt_AccessoriesName.Enabled = true;
            txt_AccessoriesManufacturer.Enabled = true;
            txt_AccessoriesOverview.Enabled = true;
            txt_AccessoriesPrice.Enabled = true;
            txt_AccessoriesID.Enabled = true;
            txt_AccessoriesID.ForeColor = SystemColors.WindowText;
            lb_ID.ForeColor = SystemColors.ControlText;
            txt_AccessoriesType.Enabled = true;
            txt_AccessoriesType.ForeColor = SystemColors.WindowText;

            
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
                MessageBox.Show(Resource.Delete_Fail_StockRemaining ,"", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            button = "Delete";
            tabControl1.TabPages.Add(tabPagePetDetail);
            tabControl1.TabPages.Remove(tabPagePetList);
            tabControl1.SelectedTab = tabPagePetDetail;

            lb_ID.ForeColor = Color.Gray;
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

            btn_Save.Text = Resource.btn_Delete;
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
                    MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    message = "Cập nhật không thành công!";
                    MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    message = "Xóa không thành công!";
                    MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show(Resource.Search_Error_KeywordRequired, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (accessoriesData == null)
            {
                LoadData(); 
            }

            string filter = "";
            if (cbb_LaptopSearch.SelectedItem == null)
            {
                MessageBox.Show(Resource.Validation_Error_InvalidPrice, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedKey = (cbb_LaptopSearch.SelectedValue ?? "").ToString();


            if (selectedKey == "Tên")
            {
                filter = $"productName LIKE '%{searchText.Replace("'", "''")}%'";
            }
            else if (selectedKey == "Hãng sản xuất")
            {
                filter = $"Manufacturer LIKE '%{searchText.Replace("'", "''")}%'";
            }
            else if (selectedKey == "Loại")
            {
                filter = $"type LIKE '%{searchText.Replace("'", "''")}%'";
            }
            else
            {
                MessageBox.Show(Resource.Search_Error_InvalidCriteria, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataView dv = new DataView(accessoriesData);
            dv.RowFilter = filter;
            dataGridView.DataSource = dv;
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

            btn_Save.Visible = false;
            btn_Cancel.Visible = false;
            btn_Back.Visible = true;


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


     
            btn_Save.Visible = true;
            btn_Cancel.Visible = true;
            btn_Back.Visible = false; 
            txt_AccessoriesID.Clear();
            txt_AccessoriesName.Clear();
            txt_AccessoriesManufacturer.Clear();
            txt_AccessoriesOverview.Clear();
            txt_AccessoriesType.Clear();
            txt_AccessoriesPrice.Clear();
            txt_AccessoriesstockQuantity.Clear();
            txt_AccessoriesID.ForeColor = SystemColors.WindowText;
            txt_AccessoriesID.Enabled = true;
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

        private void txt_AccessoriesPrice_Validating(object sender, CancelEventArgs e)
        {
            double canNang;
            if (!double.TryParse(txt_AccessoriesPrice.Text, out canNang) || canNang < 0)
            {
                MessageBox.Show(Resource.Validation_Error_InvalidPrice, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_AccessoriesPrice.Focus();
                txt_AccessoriesPrice.SelectAll();
            }
        }
    }
}
