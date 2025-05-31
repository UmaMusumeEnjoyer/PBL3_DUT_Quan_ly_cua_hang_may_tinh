using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Gwenchana.BussinessLogic;
using Gwenchana.DataAccess;
using Gwenchana.DataAccess.ViewModel;
using Gwenchana.DataAccess.DTO;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text;


namespace Gwenchana
{
    public partial class CashierOrderForm : Form
    {

        public decimal totalAmount { get; set; }
        public int id { get; set; }

        public Customer currentCustomer { get; set; }
        public Employee CurrentEmployee { get; set; }
        public CashierOrderForm(int employeeid)
        {
            InitializeComponent();

            id = employeeid;
            txt_productName.Enabled = false;
            txt_productPrice.Enabled = false;
            dgv_Order.Columns.Clear();

            dgv_Order.Columns.Add("Product_Id", "Mã sản phẩm");
            dgv_Order.Columns.Add("productName", "Tên sản phẩm");
            dgv_Order.Columns.Add("price", "Giá");
            dgv_Order.Columns.Add("quantity", "Số lượng");
            dgv_Order.Columns.Add("totalPrice", "Thành tiền");

            dgv_Order.ReadOnly = true;
            dgv_Order.AllowUserToAddRows = false;
            totalAmount = 0;
        }

        public void ClearDataGridViewData()
        {
            dgv_Product.DataSource = null;
            dgv_Product.Rows.Clear();
            dgv_Product.Refresh();
        }

        private void ccb_ProductFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_ProductID.Items.Clear();
            switch (ccb_ProductFilter.SelectedItem.ToString())
            {

                case "PC":
                    ClearDataGridViewData();
                    PCBLL pcBLL = new PCBLL();
                    DataTable dt = pcBLL.GetAllPCsDataTable();
                    dgv_Product.ReadOnly = true;
                    dgv_Product.AllowUserToAddRows = false;
                    dgv_Product.AllowUserToDeleteRows = false;
                    dgv_Product.DataSource = dt;
                    dgv_Product.Columns["Product_Id"].HeaderText = "Mã sản phẩm";
                    dgv_Product.Columns["productName"].HeaderText = "Tên sản phẩm";
                    dgv_Product.Columns["Manufacturer"].HeaderText = "Nhà sản xuất";
                    dgv_Product.Columns["specification"].HeaderText = "Thông số kỹ thuật";
                    dgv_Product.Columns["price"].HeaderText = "Giá";
                    dgv_Product.Columns["stockQuantity"].HeaderText = "Số lượng tồn kho";
                    setcbb_ProductID();
                    break;

                case "Laptop":
                    ClearDataGridViewData();
                    LaptopBLL laptopBLL = new LaptopBLL();
                    DataTable dtt = laptopBLL.GetAllLaptopsDataTable();
                    dgv_Product.DataSource = dtt;
                    dgv_Product.ReadOnly = true;
                    dgv_Product.AllowUserToAddRows = false;
                    dgv_Product.AllowUserToDeleteRows = false;
                    dgv_Product.Columns["Product_Id"].HeaderText = "Mã sản phẩm";
                    dgv_Product.Columns["productName"].HeaderText = "Tên sản phẩm";
                    dgv_Product.Columns["Manufacturer"].HeaderText = "Nhà sản xuất";
                    dgv_Product.Columns["specification"].HeaderText = "Thông số kỹ thuật";
                    dgv_Product.Columns["weight"].HeaderText = "Trọng lượng";
                    dgv_Product.Columns["screenSize"].HeaderText = "Kích cỡ màn hình";
                    dgv_Product.Columns["colour"].HeaderText = "Màu sắc";
                    dgv_Product.Columns["price"].HeaderText = "Giá";
                    dgv_Product.Columns["stockQuantity"].HeaderText = "Số lượng tồn kho";
                    setcbb_ProductID();
                    break;

                case "Linh/ Phụ kiện":
                    ClearDataGridViewData();
                    AccessoriesBLL accessoriesBLL = new AccessoriesBLL();
                    DataTable dttt = accessoriesBLL.GetAllAccessoriesDataTable();
                    dgv_Product.ReadOnly = true;
                    dgv_Product.AllowUserToAddRows = false;
                    dgv_Product.AllowUserToDeleteRows = false;
                    dgv_Product.DataSource = dttt;
                    dgv_Product.Columns["Product_Id"].HeaderText = "Mã sản phẩm";
                    dgv_Product.Columns["productName"].HeaderText = "Tên sản phẩm";
                    dgv_Product.Columns["Manufacturer"].HeaderText = "Nhà sản xuất";
                    dgv_Product.Columns["overview"].HeaderText = "Mô tả";
                    dgv_Product.Columns["type"].HeaderText = "Loại sản phẩm";
                    dgv_Product.Columns["price"].HeaderText = "Giá";
                    dgv_Product.Columns["stockQuantity"].HeaderText = "Số lượng tồn kho";
                    setcbb_ProductID();
                    break;

                default:
                    break;
            }
        }
        public void setcbb_ProductID()
        {
            cbb_ProductID.Items.Clear();
            for (int i = 0; i < dgv_Product.Rows.Count; i++)
            {
                cbb_ProductID.Items.Add(dgv_Product.Rows[i].Cells[0].Value.ToString());
            }
        }

        private void cbb_ProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedId = cbb_ProductID.SelectedItem.ToString();

            foreach (DataGridViewRow row in dgv_Product.Rows)
            {
                if (row.Cells["Product_Id"].Value != null && row.Cells["Product_Id"].Value.ToString() == selectedId)
                {
                    // Gán dữ liệu vào các TextBox
                    txt_productName.Text = row.Cells["productName"].Value.ToString();
                    txt_productPrice.Text = row.Cells["price"].Value.ToString();
                    productQuantity.Value = 1; // Đặt giá trị mặc định cho số lượng là 1
                    productQuantity.Maximum = Convert.ToInt32(row.Cells["stockQuantity"].Value); // Đặt giá trị tối đa cho số lượng là số lượng tồn kho

                    // Trỏ DataGridView tới dòng tương ứng
                    row.Selected = true;
                    dgv_Product.CurrentCell = row.Cells[0]; // hoặc chỉ định cột cụ thể khác nếu muốn
                    dgv_Product.FirstDisplayedScrollingRowIndex = row.Index;

                    break;
                }
            }
        }


        private void cashierOrderForm_addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_productName.Text) || string.IsNullOrEmpty(txt_productPrice.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trước khi thêm vào giỏ hàng.");
                return;
            }
            else
            {
                if (dgv_Product.CurrentRow != null)
                {
                    DataGridViewRow selectedRow = dgv_Product.CurrentRow;

                    string productId = selectedRow.Cells["Product_Id"].Value.ToString();
                    string productName = selectedRow.Cells["productName"].Value.ToString();
                    decimal price = Convert.ToDecimal(selectedRow.Cells["price"].Value);
                    int quantity = (int)productQuantity.Value;
                    decimal totalPrice = price * quantity;

                    // Kiểm tra nếu sản phẩm đã tồn tại trong dgv_SelectedProducts thì cộng dồn số lượng
                    bool found = false;
                    foreach (DataGridViewRow row in dgv_Order.Rows)
                    {
                        if (row.Cells["Product_Id"].Value.ToString() == productId)
                        {
                            int oldQty = Convert.ToInt32(row.Cells["quantity"].Value);
                            row.Cells["quantity"].Value = oldQty + quantity;
                            row.Cells["totalPrice"].Value = (oldQty + quantity) * price;
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        dgv_Order.Rows.Add(productId, productName, price, quantity, totalPrice);
                    }
                }
            }
            // Cập nhật lại tổng tiền
            totalAmount += Convert.ToDecimal(txt_productPrice.Text) * productQuantity.Value;
            lb_totalAmount.Text = totalAmount.ToString();



        }

        private void CashierOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void cashierOrderForm_quantity_ValueChanged(object sender, EventArgs e)
        {

        }
        private void txt_salePercent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txt_salePercent.Text))
                {
                    // Nếu không nhập gì -> giữ nguyên giá gốc
                    txt_finalTotal.Text = totalAmount.ToString();
                    return;
                }

                if (decimal.TryParse(txt_salePercent.Text, out decimal discountPercent))
                {
                    if (discountPercent < 0 || discountPercent > 100)
                    {
                        MessageBox.Show("Phần trăm giảm giá phải từ 0 đến 100.");
                        txt_salePercent.Text = "";
                        return;
                    }

                    decimal discountAmount = totalAmount * discountPercent / 100;
                    decimal finalAmount = totalAmount - discountAmount;
                    txt_finalTotal.Text = finalAmount.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số hợp lệ cho phần trăm giảm giá.");
                    txt_salePercent.Text = "";
                }

                e.SuppressKeyPress = true;
            }
        }

        private decimal GetFinalTotal()
        {
            if (decimal.TryParse(txt_finalTotal.Text, out decimal finalTotal))
                return finalTotal;
            return totalAmount;
        }

        private void cashierOrderForm_receiptBtn_Click(object sender, EventArgs e)
        {
            Customer selectedCustomer = null;
            using (var selectForm = new CustomerCashUI())
            {
                if (selectForm.ShowDialog() == DialogResult.OK)
                {
                    selectedCustomer = selectForm.currentCustomer;

                    currentCustomer = selectForm.currentCustomer;
                    MessageBox.Show("Khách hàng được chọn: " + selectedCustomer.customerName);

                    EmployeeBLL employeeBLL = new EmployeeBLL();
                    Employee currentEmployee = employeeBLL.GetEmployeeByAccountId(id);
                    CurrentEmployee = currentEmployee;

                    List<Product> selectedProducts = GetOrderedProductList();

                    decimal finalTotal = GetFinalTotal();
                    ReceiptBLL receiptBLL = new ReceiptBLL();
                    bool isSuccess = receiptBLL.createReceipt(currentEmployee, selectedCustomer, selectedProducts, finalTotal);
                    if (!isSuccess)
                    {
                        MessageBox.Show("Tạo hóa đơn thành công!");
                        //this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tạo hóa đơn thất bại!");
                    }
                }
                // Nếu người dùng bấm Cancel hoặc đóng form thì KHÔNG tạo đơn, KHÔNG hiện ra thông báo!
            }
        }

        public List<Product> GetOrderedProductList()
        {
            List<Product> productList = new List<Product>();
            ProductBLL bll = new ProductBLL(); // hoặc dùng DI nếu bạn đã có sẵn instance

            foreach (DataGridViewRow row in dgv_Order.Rows)
            {
                if (row.IsNewRow) continue; // bỏ qua dòng trống

                string productId = row.Cells["Product_Id"].Value.ToString();
                string quantity = row.Cells["quantity"].Value.ToString();
                Product product = bll.GetProduct(Convert.ToInt32(productId));

                if (product != null)
                {
                    product.quantity = Convert.ToInt32(quantity);
                    productList.Add(product);
                }
            }

            return productList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF files (*.pdf)|*.pdf";
            sfd.FileName = "HoaDon.pdf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ExportInvoiceToPDF(sfd.FileName);
                MessageBox.Show("Xuất hóa đơn ra PDF thành công!");
            }
        }

        private void ExportInvoiceToPDF(string filePath)
        {
            // Đường dẫn font Times New Roman chuẩn trên Windows
            string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "times.ttf");
            if (!File.Exists(fontPath))
            {
                MessageBox.Show("Không tìm thấy font Times New Roman (times.ttf). Vui lòng đảm bảo file này có trong thư mục C:\\Windows\\Fonts.");
                return;
            }
            BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font vietnameseFont = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font vietnameseFontBold = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD);

            // Dữ liệu hóa đơn
            string storeName = "CỬA HÀNG MÁY TÍNH BÁCH KHOA ĐÀ NẴNG";
            string storeAddress = "54 Nguyễn Lương Bằng, Hoà Khánh Bắc, Liên Chiểu, Đà Nẵng";
            string storePhone = "0123 456 789";
            DateTime invoiceDate = DateTime.Now;
            string employeeName = CurrentEmployee.employeeName;
            string customerName = (currentCustomer != null) ? currentCustomer.customerName : "";

            // Lấy danh sách sản phẩm từ DataGridView
            var products = new List<dynamic>();
            decimal tongTien = 0;
            foreach (DataGridViewRow row in dgv_Order.Rows)
            {
                if (row.IsNewRow) continue;
                decimal price = row.Cells["price"].Value != null ? Convert.ToDecimal(row.Cells["price"].Value) : 0;
                int quantity = row.Cells["quantity"].Value != null ? Convert.ToInt32(row.Cells["quantity"].Value) : 0;
                decimal total = row.Cells["totalPrice"].Value != null ? Convert.ToDecimal(row.Cells["totalPrice"].Value) : 0;
                products.Add(new
                {
                    Id = row.Cells["Product_Id"].Value?.ToString() ?? "",
                    Name = row.Cells["productName"].Value?.ToString() ?? "",
                    Price = price,
                    Quantity = quantity,
                    Total = total
                });
                tongTien += total;
            }

            // Lấy chiết khấu phần trăm từ textbox (nếu có)
            decimal chietKhau = 0;
            decimal salePercent = 0;
            decimal.TryParse(txt_salePercent?.Text, out salePercent);
            if (salePercent > 0 && salePercent <= 100)
            {
                chietKhau = tongTien * salePercent / 100;
            }

            // Tiền cần phải trả
            decimal tienCanTra = tongTien - chietKhau;

            // Bắt đầu tạo file PDF
            Document doc = new Document(PageSize.A5, 20, 20, 20, 20);
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();

            // === THÊM LOGO VÀ THÔNG TIN CỬA HÀNG CẠNH NHAU ===
            //string logoPath = Path.Combine(Application.StartupPath, "logo.png"); // Đặt file logo.png cùng thư mục exe
            string logoPath = Path.Combine(Application.StartupPath, "Pictures", "logo.png");
            PdfPTable headerTable = new PdfPTable(2);
            headerTable.WidthPercentage = 100;
            headerTable.SetWidths(new float[] { 20f, 80f }); // Cột ảnh : cột chữ

            // Cột 1: Logo
            if (File.Exists(logoPath))
            {
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
                logo.ScaleAbsolute(60f, 60f);
                PdfPCell logoCell = new PdfPCell(logo);
                logoCell.Border = 0;
                logoCell.HorizontalAlignment = Element.ALIGN_LEFT;
                logoCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                headerTable.AddCell(logoCell);
            }
            else
            {
                PdfPCell emptyCell = new PdfPCell(new Phrase(""));
                emptyCell.Border = 0;
                headerTable.AddCell(emptyCell);
            }

            // Cột 2: Các dòng chữ tiêu đề
            PdfPCell infoCell = new PdfPCell();
            infoCell.Border = 0;
            infoCell.HorizontalAlignment = Element.ALIGN_LEFT;
            infoCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            infoCell.AddElement(new Paragraph("HÓA ĐƠN BÁN HÀNG", vietnameseFontBold));
            infoCell.AddElement(new Paragraph(storeName, vietnameseFontBold));
            infoCell.AddElement(new Paragraph(storeAddress, vietnameseFont));
            infoCell.AddElement(new Paragraph("Điện thoại: " + storePhone, vietnameseFont));
            headerTable.AddCell(infoCell);

            doc.Add(headerTable);
            doc.Add(new Paragraph("--------------------------------------------------------", vietnameseFont));

            // Thông tin hóa đơn
            PdfPTable infoTable = new PdfPTable(2);
            infoTable.WidthPercentage = 100;
            infoTable.SetWidths(new float[] { 30f, 70f });
            infoTable.AddCell(new PdfPCell(new Phrase("Ngày:", vietnameseFontBold)) { Border = 0 });
            infoTable.AddCell(new PdfPCell(new Phrase(invoiceDate.ToString("dd/MM/yyyy"), vietnameseFont)) { Border = 0 });
            infoTable.AddCell(new PdfPCell(new Phrase("Nhân viên:", vietnameseFontBold)) { Border = 0 });
            infoTable.AddCell(new PdfPCell(new Phrase(employeeName, vietnameseFont)) { Border = 0 });
            if (!string.IsNullOrWhiteSpace(customerName))
            {
                infoTable.AddCell(new PdfPCell(new Phrase("Khách hàng:", vietnameseFontBold)) { Border = 0 });
                infoTable.AddCell(new PdfPCell(new Phrase(customerName, vietnameseFont)) { Border = 0 });
            }
            doc.Add(infoTable);

            doc.Add(new Paragraph("--------------------------------------------------------", vietnameseFont));

            // Bảng sản phẩm
            PdfPTable table = new PdfPTable(5);
            table.WidthPercentage = 100;
            table.SetWidths(new float[] { 15f, 35f, 15f, 10f, 25f });
            table.AddCell(new PdfPCell(new Phrase("Mã SP", vietnameseFontBold)));
            table.AddCell(new PdfPCell(new Phrase("Tên sản phẩm", vietnameseFontBold)));
            table.AddCell(new PdfPCell(new Phrase("Đơn giá", vietnameseFontBold)));
            table.AddCell(new PdfPCell(new Phrase("SL", vietnameseFontBold)));
            table.AddCell(new PdfPCell(new Phrase("Thành tiền", vietnameseFontBold)));

            foreach (var p in products)
            {
                table.AddCell(new PdfPCell(new Phrase(p.Id, vietnameseFont)));
                table.AddCell(new PdfPCell(new Phrase(p.Name, vietnameseFont)));
                table.AddCell(new PdfPCell(new Phrase(p.Price.ToString("N0"), vietnameseFont)));
                table.AddCell(new PdfPCell(new Phrase(p.Quantity.ToString(), vietnameseFont)));
                table.AddCell(new PdfPCell(new Phrase(p.Total.ToString("N0"), vietnameseFont)));
            }
            doc.Add(table);

            doc.Add(new Paragraph("--------------------------------------------------------", vietnameseFont));

            // Tổng tiền, chiết khấu, tiền phải trả
            PdfPTable totalTable = new PdfPTable(2);
            totalTable.WidthPercentage = 60;
            totalTable.HorizontalAlignment = Element.ALIGN_RIGHT;
            totalTable.SetWidths(new float[] { 50f, 50f });

            totalTable.AddCell(new PdfPCell(new Phrase("Tổng tiền:", vietnameseFontBold)) { Border = 0, HorizontalAlignment = Element.ALIGN_LEFT });
            totalTable.AddCell(new PdfPCell(new Phrase(tongTien.ToString("N0") + " VNĐ", vietnameseFont)) { Border = 0, HorizontalAlignment = Element.ALIGN_RIGHT });

            totalTable.AddCell(new PdfPCell(new Phrase("Chiết khấu (" + salePercent.ToString("N0") + "%):", vietnameseFontBold)) { Border = 0, HorizontalAlignment = Element.ALIGN_LEFT });
            totalTable.AddCell(new PdfPCell(new Phrase("-" + chietKhau.ToString("N0") + " VNĐ", vietnameseFont)) { Border = 0, HorizontalAlignment = Element.ALIGN_RIGHT });

            totalTable.AddCell(new PdfPCell(new Phrase("Tiền cần phải trả:", vietnameseFontBold)) { Border = 0, HorizontalAlignment = Element.ALIGN_LEFT });
            totalTable.AddCell(new PdfPCell(new Phrase(tienCanTra.ToString("N0") + " VNĐ", vietnameseFontBold)) { Border = 0, HorizontalAlignment = Element.ALIGN_RIGHT });

            doc.Add(totalTable);

            // Lời cảm ơn
            Paragraph thanks = new Paragraph("Cảm ơn quý khách. Hẹn gặp lại!", vietnameseFont)
            {
                Alignment = Element.ALIGN_CENTER,
                SpacingBefore = 12
            };
            doc.Add(thanks);

            doc.Close();
        }


        private void cashierOrderForm_clearBtn_Click(object sender, EventArgs e)
        {
            dgv_Order.Rows.Clear();
            totalAmount = 0;
            lb_totalAmount.Text = "0";
            txt_finalTotal.Text = "0";
            txt_salePercent.Text = "";
            txt_productName.Text = "";
            txt_productPrice.Text = "";
            cbb_ProductID.Items.Clear();
            ccb_ProductFilter.SelectedIndex = -1;
            ClearDataGridViewData();
        }


    }
}
