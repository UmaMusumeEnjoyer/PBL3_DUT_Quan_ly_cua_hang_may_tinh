﻿using Gwenchana.BussinessLogic;
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

            

            //dataGridView1.Columns["Mã đơn xuất hàng"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AllowUserToAddRows = false; // ẩn dòng trống cuối
            


            dataGridView1.ReadOnly = true; // nếu không cần chỉnh sửa


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
