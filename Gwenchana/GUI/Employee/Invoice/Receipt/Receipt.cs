using Gwenchana.BussinessLogic;
using Gwenchana.DataAccess.DAL;
using Gwenchana.DataAccess.DTO;
using Gwenchana.GUI.Employee.Invoice;
using Gwenchana.LanguagePack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Gwenchana.LanguagePack;


namespace Gwenchana
{
    public partial class Receipt : Form
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        private string button;

        public int currentEmployeeID { get; set; }
        //Constructor
        public Receipt(int employeeID)
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            UpdateComponent(LanguageClass.Language);
            LoadData();
            tabControl1.TabPages.Remove(tabPagePetDetail);
            currentEmployeeID = employeeID;
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            if(currentEmployeeID == 0)
            {
                btn_CreateReceipt.Visible = false;
            }

        }

        private void LoadData()
        {
            ReceiptBLL receiptBLL = new ReceiptBLL();
            DataTable dt = receiptBLL.GetAllReceipts();
            dataGridView.DataSource = dt;
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.Columns["Receipt_Id"].Visible = false;

            dataGridView.Columns["Ngày xuất hàng"].HeaderText = Resource.Order_Creation_Date;
            dataGridView.Columns["Tên nhân viên"].HeaderText = Resource.lb_employeeName1;
            dataGridView.Columns["Trạng thái"].HeaderText = Resource.lb_employeeStatus;
            dataGridView.Columns["SĐT nhân viên"].HeaderText = Resource.lb_PhoneNumber;
            dataGridView.Columns["Tên khách hàng"].HeaderText = Resource.lb_CustomerName;
            dataGridView.Columns["SĐT khách hàng"].HeaderText = Resource.lb_PhoneNumber;
            dataGridView.Columns["Địa chỉ khách hàng"].HeaderText = Resource.lb_Address;
            dataGridView.Columns["Tổng tiền (VNĐ)"].HeaderText = Resource.lb_TotalAmount;

            dataGridView.CellFormatting += dataGridView_CellFormatting;
        }

        private void UpdateComponent(string language)
        {
            Resource.Culture = string.IsNullOrEmpty(language) ? null : new CultureInfo(language);

            lb_SalesOrder.Text = Resource.btn_exportInvoices;
            tabControl1.TabPages[0].Text = Resource.TabCtr_List;
            tabControl1.TabPages[1].Text = Resource.TabCtr_Details;
            btn_Search.Text = Resource.btn_Search;
            btn_ReceiptDetails.Text = Resource.TabCtr_Details;
            btn_CreateReceipt.Text = Resource.btn_CreateSalesInvoice;
            btn_ClearFilter.Text = Resource.btn_ClearFilter;
            lb_Search.Text = Resource.lb_Search;




            LoadTrangThaiComboBox();
        }

        private void LoadTrangThaiComboBox()
        {
            Dictionary<string, string> trangThaiDict = new Dictionary<string, string>()
            {
                { "Tên nhân viên", Resource.lb_employeeName1 },
                { "Tên khách hàng", Resource.lb_CustomerName },
                { "Thời gian", Resource.Time_Range }
            };
            cbb_ReceiptFilter.DataSource = new BindingSource(trangThaiDict, null);
            cbb_ReceiptFilter.DisplayMember = "Value";
            cbb_ReceiptFilter.ValueMember = "Key";
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Nếu cột là "price"
            if (dataGridView.Columns[e.ColumnIndex].Name == "Tổng tiền (VNĐ)" && e.Value != null && e.Value is decimal)
            {
                // Hiển thị số tiền theo chuẩn Việt Nam và thêm ký hiệu ₫
                decimal gia = (decimal)e.Value;
                e.Value = gia.ToString("N0", System.Globalization.CultureInfo.GetCultureInfo("vi-VN")) + " ₫";
                e.FormattingApplied = true;
            }
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
            txt_Spetification.Clear();
            txt_LaptopPrice.Clear();
            txt_LaptopName.Clear();
            txt_Manufacturer.Clear();
            txt_LaptopID.Clear();
            txt_LaptopWeight.Clear();
            txt_ScreenSize.Clear();
            txt_LaptopColour.Clear();
            txt_stockQuantity.Clear();
            

            // Kích hoạt lại tất cả textbox nếu từng bị disable (Delete mode)
            txt_LaptopName.Enabled = true;
            txt_Manufacturer.Enabled = true;
            txt_Spetification.Enabled = true;
            txt_LaptopPrice.Enabled = true;
            txt_LaptopID.Enabled = true;
            txt_LaptopWeight.Enabled = true;
            txt_ScreenSize.Enabled = true;
            txt_LaptopColour.Enabled = true;
            txt_stockQuantity.Enabled = true;
            
            txt_LaptopID.ForeColor = SystemColors.WindowText;
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
            CashierOrderForm cashierOrderForm = new CashierOrderForm(currentEmployeeID);
            //this.Hide();
            //employeeDashboard.ShowDialog();
            
            cashierOrderForm.ShowDialog();
            LoadData();
            //this.Show();




        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (button == "Edit")
            {
                int productID = Convert.ToInt32(dataGridView.CurrentRow.Cells["Product_Id"].Value);

                Laptop laptop = new Laptop
                {
                    Product_Id = productID,                           // Thuộc tính kế thừa từ Product
                    productName = txt_LaptopName.Text,                // Thuộc tính kế thừa từ Product
                    Manufacturer = txt_Manufacturer.Text,             // Thuộc tính kế thừa từ Product
                    price = Convert.ToDecimal(txt_LaptopPrice.Text),  // Thuộc tính kế thừa từ Product
                    stockQuantity = Convert.ToInt32(txt_stockQuantity.Text), // Thuộc tính kế thừa từ Product

                    Spectification = txt_Spetification.Text,          // Thuộc tính riêng của Laptop
                    Weight = Convert.ToDecimal(txt_LaptopWeight.Text),  // Thuộc tính riêng của Laptop
                    screenSize = txt_ScreenSize.Text, // Thuộc tính riêng của Laptop
                    Colour = txt_LaptopColour.Text                    // Thuộc tính riêng của Laptop
                };

                LaptopBLL laptopBLL = new LaptopBLL();
                isSuccessful = laptopBLL.UpdateLaptop(laptop);
                if (isSuccessful)
                {
                    message = "Cập nhật sản phẩm thành công.";
                    MessageBox.Show(message);
                    LoadData();
                }
                else
                {
                    message = "Cập nhật sản phẩm thất bại.";
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
                int productID = Convert.ToInt32(dataGridView.CurrentRow.Cells["Product_Id"].Value);
                LaptopBLL laptopBLL = new LaptopBLL();
                isSuccessful = laptopBLL.DeleteLaptop(productID);
                if (isSuccessful)
                {
                    message = "Xóa sản phẩm thành công.";
                    MessageBox.Show(message);
                    LoadData();
                }
                else
                {
                    message = "Xóa sản phẩm thất bại.";
                    MessageBox.Show(message);
                }

                tabControl1.TabPages.Add(tabPagePetList);
                tabControl1.TabPages.Remove(tabPagePetDetail);
                tabControl1.SelectedTab = tabPagePetList;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            //string a = cbb_LaptopSearch.SelectedItem.ToString();
            if (string.IsNullOrEmpty(searchText) && cbb_ReceiptFilter.SelectedIndex == -1)
            {
                MessageBox.Show(Resource.Search_Error_KeywordRequired);
                return;
            }

            var selectedKey = (cbb_ReceiptFilter.SelectedValue ?? "").ToString();


            ReceiptBLL laptopBLL = new ReceiptBLL();
            if (selectedKey == "Tên nhân viên")
            {
                dataGridView.DataSource = laptopBLL.getallreceipts().Where(l => l.EmployeeName.Contains(searchText)).ToList();
            }
            else if (selectedKey == "Tên khách hàng")
            {
                dataGridView.DataSource = laptopBLL.getallreceipts().Where(l => l.CustomerName.Contains(searchText)).ToList();
            }
            else if (selectedKey == "Thời gian")
            {
                DateTime startDate = dtpStartDate.Value.Date;
                DateTime endDate = dtpEndDate.Value.Date;
                if (startDate > endDate)
                {
                    MessageBox.Show(Resource.Start_Date_After_End_Date);
                    return;
                }
                dataGridView.DataSource = laptopBLL.getallreceipts()
                    .Where(l => {
                        DateTime parsedDate;
                        bool valid = DateTime.TryParseExact(
                            l.ReceiptDate,
                            "dd/MM/yyyy", // Đổi thành định dạng thực tế của bạn
                            System.Globalization.CultureInfo.InvariantCulture,
                            System.Globalization.DateTimeStyles.None,
                            out parsedDate
                        );
                        return valid && parsedDate >= startDate && parsedDate <= endDate;
                    })
                    .ToList();
            }
        }

        private void txt_Manufacturer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_LaptopWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_ReceiptFilter.SelectedItem != null)
            {
                var selectedKey = (cbb_ReceiptFilter.SelectedValue ?? "").ToString();

                if (selectedKey == "Thời gian")
                {
                    dtpStartDate.Enabled = true;
                    dtpEndDate.Enabled = true;
                }
            }
        }

        private void btn_ClearFilter_Click(object sender, EventArgs e)
        {
            cbb_ReceiptFilter.SelectedIndex = -1;
            txtSearch.Clear();
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            LoadData();
        }

        private void cbb_LaptopSearch_TextUpdate(object sender, EventArgs e)
        {
            string a = cbb_ReceiptFilter.SelectedItem.ToString();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ReceiptDetails_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView.CurrentRow.Cells["Receipt_Id"].Value);
            Receipt_Details details = new Receipt_Details(ID);
            details.ShowDialog();
        }
    }
}
