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
using Gwenchana.LanguagePack;
using System.Globalization;


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
            
            UpdateComponent(LanguageClass.Language);

            id = employeeid;
            txt_productName.Enabled = false;
            txt_productPrice.Enabled = false;
            dgv_Order.Columns.Clear();

            dgv_Order.Columns.Add("Product_Id", "ID");
            dgv_Order.Columns.Add("productName", Resource.lb_productName);
            dgv_Order.Columns.Add("price", Resource.lb_Price);
            dgv_Order.Columns.Add("quantity", Resource.lb_Quantity);
            dgv_Order.Columns.Add("totalPrice", Resource.lb_TotalAmount);

            dgv_Order.ReadOnly = true;
            dgv_Order.AllowUserToAddRows = false;
            totalAmount = 0;
            btn_TaoHoaDon.Enabled = false; // Disable the export button initially
        }

        public void ClearDataGridViewData()
        {
            dgv_Product.DataSource = null;
            dgv_Product.Rows.Clear();
            dgv_Product.Refresh();
        }


        private void UpdateComponent(string language)
        {
            Resource.Culture = string.IsNullOrEmpty(language) ? null : new CultureInfo(language);
            Resource1.Culture = string.IsNullOrEmpty(language) ? null : new CultureInfo(language);

            this.Text = Resource.btn_exportInvoices;
            lb_ProductList.Text = Resource.Item_List;

            lb_ProductType.Text = Resource.lb_Type;
            lb_ProductID.Text = "ID";
            lb_Productname.Text = Resource.lb_productName;
            lb_ProductPrice.Text = Resource.lb_Price;
            lb_ProductQuantity.Text = Resource.lb_Quantity;
            btn_productAdd.Text = Resource.btn_Add;
            cashierOrderForm_clearBtn.Text = Resource.Delete_List;

            lb_TongTien.Text = Resource.lb_TotalAmount;
            lb_SalePercent.Text = Resource.lb_DiscountPercent;
            lb_FinalTotal.Text = Resource.lb_FinalTotal;

            cashierOrderForm_receiptBtn.Text = Resource.btn_CreateReceipt;
            btn_TaoHoaDon.Text = Resource.btn_ExportPDF;




            LoadTrangThaiComboBox();
        }

        private void LoadTrangThaiComboBox()
        {
            Dictionary<string, string> trangThaiDict = new Dictionary<string, string>()
            {
                { "Laptop", Resource.btn_Laptops },
                { "PC", Resource.btn_PCs },
                { "Linh/ Phụ kiện", Resource.btn_Accessories }
            };
            ccb_ProductFilter.DataSource = new BindingSource(trangThaiDict, null);
            ccb_ProductFilter.DisplayMember = "Value";
            ccb_ProductFilter.ValueMember = "Key";
        }
        private void ccb_ProductFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_ProductID.Items.Clear();
            var selectedKey = (ccb_ProductFilter.SelectedValue ?? "").ToString();

            switch (selectedKey)
            {

                case "PC":
                    ClearDataGridViewData();
                    PCBLL pcBLL = new PCBLL();
                    DataTable dt = pcBLL.GetAllPCsDataTable();
                    dgv_Product.ReadOnly = true;
                    dgv_Product.AllowUserToAddRows = false;
                    dgv_Product.AllowUserToDeleteRows = false;
                    dgv_Product.DataSource = dt;
                    dgv_Product.Columns["Product_Id"].HeaderText = "ID";
                    dgv_Product.Columns["productName"].HeaderText = Resource.lb_productName;
                    dgv_Product.Columns["Manufacturer"].HeaderText = Resource.lb_manufacturerName;
                    dgv_Product.Columns["specification"].HeaderText = "Thông số kỹ thuật";
                    dgv_Product.Columns["specification"].Visible = false;

                    dgv_Product.Columns["price"].HeaderText = Resource.lb_Price;
                    dgv_Product.Columns["stockQuantity"].HeaderText = Resource.lb_StockQuantity;
                    dgv_Product.Columns["Supplier_Id"].Visible = false; // Ẩn cột Supplier_Id nếu không cần thiết
                    dgv_Product.Columns["supplierName"].HeaderText = Resource.lb_supplierName;
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
                    dgv_Product.Columns["Product_Id"].HeaderText = "ID";
                    dgv_Product.Columns["productName"].HeaderText = Resource.lb_productName;
                    dgv_Product.Columns["Manufacturer"].HeaderText = Resource.lb_manufacturerName;
                    dgv_Product.Columns["specification"].HeaderText = "Thông số kỹ thuật";
                    dgv_Product.Columns["specification"].Visible = false;
                    dgv_Product.Columns["weight"].HeaderText = "Trọng lượng";
                    dgv_Product.Columns["weight"].Visible = false;

                    dgv_Product.Columns["screenSize"].HeaderText = "Kích cỡ màn hình";
                    dgv_Product.Columns["screenSize"].Visible = false;
                    dgv_Product.Columns["colour"].HeaderText = "Màu sắc";
                    dgv_Product.Columns["colour"].Visible = false;
                    dgv_Product.Columns["price"].HeaderText = Resource.lb_Price;
                    dgv_Product.Columns["stockQuantity"].HeaderText = Resource.lb_StockQuantity;
                    dgv_Product.Columns["Supplier_Id"].Visible = false;
                    dgv_Product.Columns["supplierName"].HeaderText = Resource.lb_supplierName;
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
                    dgv_Product.Columns["Product_Id"].HeaderText = "ID";
                    dgv_Product.Columns["productName"].HeaderText = Resource.lb_productName;
                    dgv_Product.Columns["Manufacturer"].HeaderText = Resource.lb_manufacturerName;
                    dgv_Product.Columns["overview"].HeaderText = "Mô tả";
                    dgv_Product.Columns["overview"].Visible = false;
                    dgv_Product.Columns["type"].HeaderText = Resource.lb_ProductType;
                    dgv_Product.Columns["price"].HeaderText = Resource.lb_Price;
                    dgv_Product.Columns["stockQuantity"].HeaderText = Resource.lb_StockQuantity;
                    dgv_Product.Columns["Supplier_Id"].Visible = false;
                    dgv_Product.Columns["supplierName"].HeaderText = Resource.lb_supplierName;
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
                MessageBox.Show(Resource.Select_product_before_add_to_cart);
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
                        MessageBox.Show(Resource.Discount_percent_out_of_range);
                        txt_salePercent.Text = "";
                        return;
                    }

                    decimal discountAmount = totalAmount * discountPercent / 100;
                    decimal finalAmount = totalAmount - discountAmount;
                    txt_finalTotal.Text = finalAmount.ToString();
                }
                else
                {
                    MessageBox.Show(Resource.Invalid_discount_percent_input);
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
                    MessageBox.Show(Resource.Selected_customer + selectedCustomer.customerName);

                    EmployeeBLL employeeBLL = new EmployeeBLL();
                    Employee currentEmployee = employeeBLL.GetEmployeeByAccountId(id);
                    CurrentEmployee = currentEmployee;

                    List<Product> selectedProducts = GetOrderedProductList();

                    decimal finalTotal = GetFinalTotal();
                    ReceiptBLL receiptBLL = new ReceiptBLL();
                    bool isSuccess = receiptBLL.createReceipt(currentEmployee, selectedCustomer, selectedProducts, finalTotal);
                    if (!isSuccess)
                    {
                        MessageBox.Show(Resource.Invoice_Create_Success);
                        //this.Close();
                        // In hóa đơn
                        btn_TaoHoaDon.Enabled = true; // Kích hoạt nút xuất PDF
                    }
                    else
                    {
                        MessageBox.Show(Resource.Invoice_Create_Fail);
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
                MessageBox.Show(Resource.Invoice_ExportPDF_Success);
            }
            this.Close(); 
        }

        private void ExportInvoiceToPDF(string filePath)
        {
            string fontPath = Path.Combine(Application.StartupPath, "Fonts", "NotoSansCJKjp-Regular.otf");
            if (!File.Exists(fontPath))
            {
                MessageBox.Show("Không tìm thấy font hỗ trợ tiếng Nhật.");
                return;
            }
            BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font multiLangFont = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font multiLangFontBold = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD);

            // Dữ liệu hóa đơn
            string storeName = Resource1.ShopName;
            string storeAddress = Resource1.ShopAddress;
            string storePhone = "0123 456 789";
            DateTime invoiceDate = DateTime.Now;
            string employeeName = CurrentEmployee.employeeName;
            string customerName = (currentCustomer != null) ? currentCustomer.customerName : "";

           
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
            infoCell.AddElement(new Paragraph(Resource1.SalesInvoice, multiLangFontBold));
            infoCell.AddElement(new Paragraph(storeName, multiLangFontBold));
            infoCell.AddElement(new Paragraph(storeAddress, multiLangFont));
            infoCell.AddElement(new Paragraph(Resource1.ShopPhone + storePhone, multiLangFont));
            headerTable.AddCell(infoCell);

            doc.Add(headerTable);
            doc.Add(new Paragraph("--------------------------------------------------------", multiLangFont));

            // Thông tin hóa đơn
            PdfPTable infoTable = new PdfPTable(2);
            infoTable.WidthPercentage = 100;
            infoTable.SetWidths(new float[] { 30f, 70f });
            infoTable.AddCell(new PdfPCell(new Phrase(Resource1.Date, multiLangFontBold)) { Border = 0 });
            infoTable.AddCell(new PdfPCell(new Phrase(invoiceDate.ToString("dd/MM/yyyy"), multiLangFont)) { Border = 0 });
            infoTable.AddCell(new PdfPCell(new Phrase(Resource1.SalerName, multiLangFontBold)) { Border = 0 });
            infoTable.AddCell(new PdfPCell(new Phrase(employeeName, multiLangFont)) { Border = 0 });
            if (!string.IsNullOrWhiteSpace(customerName))
            {
                infoTable.AddCell(new PdfPCell(new Phrase(Resource1.Customer, multiLangFontBold)) { Border = 0 });
                infoTable.AddCell(new PdfPCell(new Phrase(customerName, multiLangFont)) { Border = 0 });
            }
            doc.Add(infoTable);

            doc.Add(new Paragraph("--------------------------------------------------------", multiLangFont));

            // Bảng sản phẩm
            PdfPTable table = new PdfPTable(5);
            table.WidthPercentage = 100;
            table.SetWidths(new float[] { 15f, 35f, 15f, 10f, 25f });
            table.AddCell(new PdfPCell(new Phrase(Resource1.ProductID, multiLangFontBold)));
            table.AddCell(new PdfPCell(new Phrase(Resource1.ProductName, multiLangFontBold)));
            table.AddCell(new PdfPCell(new Phrase(Resource1.UnitPrice, multiLangFontBold)));
            table.AddCell(new PdfPCell(new Phrase(Resource1.Quantity, multiLangFontBold)));
            table.AddCell(new PdfPCell(new Phrase(Resource1.TotalPrice, multiLangFontBold)));

            foreach (var p in products)
            {
                table.AddCell(new PdfPCell(new Phrase(p.Id, multiLangFont)));
                table.AddCell(new PdfPCell(new Phrase(p.Name, multiLangFont)));
                table.AddCell(new PdfPCell(new Phrase(p.Price.ToString("N0"), multiLangFont)));
                table.AddCell(new PdfPCell(new Phrase(p.Quantity.ToString(), multiLangFont)));
                table.AddCell(new PdfPCell(new Phrase(p.Total.ToString("N0"), multiLangFont)));
            }
            doc.Add(table);

            doc.Add(new Paragraph("--------------------------------------------------------", multiLangFont));

            // Tổng tiền, chiết khấu, tiền phải trả
            PdfPTable totalTable = new PdfPTable(2);
            totalTable.WidthPercentage = 60;
            totalTable.HorizontalAlignment = Element.ALIGN_RIGHT;
            totalTable.SetWidths(new float[] { 50f, 50f });

            totalTable.AddCell(new PdfPCell(new Phrase(Resource1.TotalAmount, multiLangFontBold)) { Border = 0, HorizontalAlignment = Element.ALIGN_LEFT });
            totalTable.AddCell(new PdfPCell(new Phrase(tongTien.ToString("N0") + " VNĐ", multiLangFont)) { Border = 0, HorizontalAlignment = Element.ALIGN_RIGHT });

            totalTable.AddCell(new PdfPCell(new Phrase(Resource1.Discount + salePercent.ToString("N0") + "%):", multiLangFontBold)) { Border = 0, HorizontalAlignment = Element.ALIGN_LEFT });
            totalTable.AddCell(new PdfPCell(new Phrase("-" + chietKhau.ToString("N0") + " VNĐ", multiLangFont)) { Border = 0, HorizontalAlignment = Element.ALIGN_RIGHT });

            totalTable.AddCell(new PdfPCell(new Phrase(Resource1.AmountPayable, multiLangFontBold)) { Border = 0, HorizontalAlignment = Element.ALIGN_LEFT });
            totalTable.AddCell(new PdfPCell(new Phrase(tienCanTra.ToString("N0") + " VNĐ", multiLangFontBold)) { Border = 0, HorizontalAlignment = Element.ALIGN_RIGHT });

            doc.Add(totalTable);

            // Lời cảm ơn
            Paragraph thanks = new Paragraph(Resource1.ThankYou, multiLangFont)
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

        private void cashierOrderForm_clearBtn_Click_1(object sender, EventArgs e)
        {
            // Xóa tất cả các hàng trong DataGridView dgv_Order
            dgv_Order.Rows.Clear();
            totalAmount = 0; // Đặt lại tổng tiền về 0
            txt_productName.Clear(); // Xóa tên sản phẩm
            txt_productPrice.Clear(); // Xóa giá sản phẩm
            productQuantity.Value = 1; // Đặt lại số lượng về 1
            //cbb_ProductID.Items.Clear(); // Xóa danh sách ID sản phẩm đã chọn
            MessageBox.Show(Resource.Cart_Cleared, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txt_salePercent_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_FinalTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
