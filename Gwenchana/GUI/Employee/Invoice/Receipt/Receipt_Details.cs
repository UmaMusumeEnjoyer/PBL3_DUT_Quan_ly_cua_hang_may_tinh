using Gwenchana.BussinessLogic;
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

namespace Gwenchana.GUI.Employee.Invoice
{
    public partial class Receipt_Details : Form
    {
        public int Receipt_ID { get; set; }
        public Receipt_Details(int receipt_ID)
        {

            InitializeComponent();
            Receipt_ID = receipt_ID;
            LoadData();

        }

        private void LoadData()
        {
            ReceiptBLL receiptBLL = new ReceiptBLL();
            DataTable dt = receiptBLL.GetAllReceiptsByID(Receipt_ID);
            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            Resource.Culture = string.IsNullOrEmpty(LanguageClass.Language) ? null : new CultureInfo(LanguageClass.Language);

            dataGridView1.Columns["Mã đơn hàng"].HeaderText = "ID";
            dataGridView1.Columns["Ngày xuất hàng"].HeaderText = Resource.Order_Creation_Date;
            dataGridView1.Columns["Tên nhân viên"].HeaderText = Resource.lb_employeeName1;
            dataGridView1.Columns["Trạng thái"].HeaderText = Resource.lb_employeeStatus;
            dataGridView1.Columns["Tên khách hàng"].HeaderText = Resource.lb_CustomerName;
            dataGridView1.Columns["Tên sản phẩm"].HeaderText = Resource.lb_productName;
            dataGridView1.Columns["Hãng sản xuất"].HeaderText = Resource.lb_manufacturerName;
            dataGridView1.Columns["Số lượng"].HeaderText = Resource.lb_Quantity;
            dataGridView1.Columns["Giá bán (VNĐ)"].HeaderText = Resource.lb_Price;
            dataGridView1.Columns["Thành tiền (VNĐ)"].HeaderText = Resource.lb_TotalAmount;




           
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AllowUserToAddRows = false; 
            


            dataGridView1.ReadOnly = true; 


            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Áp dụng cho cột có index 8 và 9
            if (e.ColumnIndex == 8 || e.ColumnIndex == 9)
            {
                if (e.Value != null && decimal.TryParse(e.Value.ToString(), out decimal value))
                {
                    e.Value = value.ToString("N0"); // Định dạng số với dấu phẩy
                    e.FormattingApplied = true;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
