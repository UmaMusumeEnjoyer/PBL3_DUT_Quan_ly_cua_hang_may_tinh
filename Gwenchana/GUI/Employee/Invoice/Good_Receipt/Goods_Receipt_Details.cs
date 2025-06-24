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
    public partial class Goods_Receipt_Details : Form
    {
        public int Receipt_ID { get; set; }
        public Goods_Receipt_Details(int receipt_ID)
        {

            InitializeComponent();
            Receipt_ID = receipt_ID;
            LoadData();

        }

        private void LoadData()
        {
            Goods_ReceiptBLL receiptBLL = new Goods_ReceiptBLL();
            DataTable dt = receiptBLL.GetAllGoodsReceiptsByID(Receipt_ID);
            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            //dataGridView.Columns["Mã đơn xuất hàng"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AllowUserToAddRows = false; // ẩn dòng trống cuối
            dataGridView1.ReadOnly = true; // nếu không cần chỉnh sửa


            Resource.Culture = string.IsNullOrEmpty(LanguageClass.Language) ? null : new CultureInfo(LanguageClass.Language);

            dataGridView1.Columns["Mã đơn nhập hàng"].HeaderText = "ID";
            dataGridView1.Columns["Ngày nhập hàng"].HeaderText = Resource.lb_ImportDate;
            dataGridView1.Columns["Tên nhân viên"].HeaderText = Resource.lb_employeeName1;
            dataGridView1.Columns["Trạng thái"].HeaderText = Resource.lb_employeeStatus;
            dataGridView1.Columns["Tên nhà phân phối"].HeaderText = Resource.lb_supplierName;
            dataGridView1.Columns["Tên sản phẩm"].HeaderText = Resource.lb_productName;
            dataGridView1.Columns["Hãng sản xuất"].HeaderText = Resource.lb_manufacturerName;
            dataGridView1.Columns["Số lượng"].HeaderText = Resource.lb_Quantity;
            dataGridView1.Columns["Giá nhập (VNĐ)"].HeaderText = Resource.lb_ImportPrice;
            dataGridView1.Columns["Thành tiền (VNĐ)"].HeaderText = Resource.lb_TotalAmount;

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
