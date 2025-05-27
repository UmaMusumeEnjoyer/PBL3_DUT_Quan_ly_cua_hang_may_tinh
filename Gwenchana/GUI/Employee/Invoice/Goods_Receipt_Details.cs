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
            ReceiptBLL receiptBLL = new ReceiptBLL();
            DataTable dt = receiptBLL.GetAllReceiptsByID(Receipt_ID);
            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            //dataGridView.Columns["Mã đơn xuất hàng"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AllowUserToAddRows = false; // ẩn dòng trống cuối
            dataGridView1.ReadOnly = true; // nếu không cần chỉnh sửa



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
