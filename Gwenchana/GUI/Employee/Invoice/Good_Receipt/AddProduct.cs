using Gwenchana.BussinessLogic;
using Gwenchana.DataAccess.DAL;
using Gwenchana.DataAccess.DBConnect;
using Gwenchana.DataAccess.DTO;
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
using System.Globalization;




namespace Gwenchana
{
    public partial class AddProduct : Form
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        private string button;

        public string selectedProduct { get; set; }

        //Constructor
        public AddProduct(string selected)
        {
            InitializeComponent();
            UpdateComponent(LanguageClass.Language);
            SupplierBLL supplierBLL = new SupplierBLL();
            DataTable cbbData = new DataTable();
            cbbData = supplierBLL.GetAllSuppliersDataTable();

            selectedProduct = selected;
            if(selectedProduct == "Laptop")
            {
                tabControl1.TabPages.Remove(tabPagePC);
                tabControl1.TabPages.Remove(tabPageAccessories);
                tabControl1.SelectedTab = tabPageLaptop;
                


                ccb_NhaCungCap1.DataSource = cbbData;
                ccb_NhaCungCap1.DisplayMember = "supplierName";
                ccb_NhaCungCap1.ValueMember = "Supplier_Id";


            }
            else if(selectedProduct == "PC")
            {
                tabControl1.TabPages.Remove(tabPageLaptop);
                tabControl1.TabPages.Remove(tabPageAccessories);


                ccb_NhaCungCap2.DataSource = cbbData;
                ccb_NhaCungCap2.DisplayMember = "supplierName";
                ccb_NhaCungCap2.ValueMember = "Supplier_Id";
            }
            else if(selectedProduct == "Accessories") 
            {
                tabControl1.TabPages.Remove(tabPageLaptop);
                tabControl1.TabPages.Remove(tabPagePC);


                ccb_NhaCungCap3.DataSource = cbbData;
                ccb_NhaCungCap3.DisplayMember = "supplierName";
                ccb_NhaCungCap3.ValueMember = "Supplier_Id";
            }

        }

        private void UpdateComponent(string language)
        {
            Resource.Culture = string.IsNullOrEmpty(language) ? null : new CultureInfo(language);

            tabControl1.TabPages[0].Text = Resource.btn_Laptops;
            tabControl1.TabPages[1].Text = Resource.btn_PCs;
            tabControl1.TabPages[2].Text = Resource.btn_Accessories;

            lb_LaptopName.Text = Resource.lb_productName;
            lb_ManufacturerLaptop.Text = Resource.lb_manufacturerName;
            lb_LaptopWeight.Text = Resource.lb_Weight;
            lb_LaptopScreenSize.Text = Resource.lb_ScreenSize;
            lb_LaptopSpecs.Text = Resource.lb_Specifications;
            lb_LaptopColor.Text = Resource.lb_Color;
            lb_LaptopPrice.Text = Resource.lb_Price;
            btn_LaptopSave.Text = Resource.btn_Save;
            lb_LaptopSupplierName.Text = Resource.lb_SupplierCounter;
            btn_Cancel.Text = Resource.btn_Cancel;

            lb_PcName.Text = Resource.lb_productName;
            lb_PcManufacturer.Text = Resource.lb_manufacturerName;
            lb_PcSpecs.Text = Resource.lb_Specifications;
            lb_PcPrice.Text = Resource.lb_Price;
            lb_PcSupplierName.Text = Resource.lb_SupplierCounter;
            btn_SavePC.Text = Resource.btn_Save;
            btn_Cancel.Text = Resource.btn_Cancel;

            lb_AccessoriesName.Text = Resource.lb_productName;
            lb_ManufacturerAcc.Text = Resource.lb_manufacturerName;
            lb_AccessoryType.Text = Resource.lb_Type;
            lb_AccOverview.Text = Resource.lb_Overview;
            lb_AccessoriesPrice.Text = Resource.lb_Price;
            lb_AccessorySupplierName.Text = Resource.lb_SupplierCounter;
            btn_AccessoriesSave.Text = Resource.btn_Save;
            btn_Cancel.Text = Resource.btn_Cancel;

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
            this.Close();
        }

        private void txt_Manufacturer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_LaptopWeight_TextChanged(object sender, EventArgs e)
        {

        }


        private void btn_SavePC_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Lấy dữ liệu từ các control trên form
                var product = new Product
                {
                    Supplier_Id = Convert.ToInt32(ccb_NhaCungCap2.SelectedValue),
                    productName = txt_pcName.Text.Trim(),
                    price = decimal.Parse(txt_pcPrice.Text),
                    //stockQuantity = int.Parse(.Text),
                    Manufacturer = txt_pcManufacturer.Text.Trim()
                };

                var laptop = new PC
                {
                    Spetification = txt_pcSpecs.Text.Trim(),
                };

                // 2. Thêm vào database qua DAL
                var pcbll = new PCBLL();
                bool result = pcbll.AddPC(laptop, product);

                // 3. Thông báo kết quả cho người dùng
                if (result)
                {
                    MessageBox.Show("Thêm PC thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm PC thất bại!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_LaptopSave_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Lấy dữ liệu từ các control trên form
                var product = new Product
                {
                    Supplier_Id = Convert.ToInt32(ccb_NhaCungCap1.SelectedValue),
                    productName = txt_LaptopName.Text.Trim(),
                    price = decimal.Parse(txt_LaptopPrice.Text),
                    //stockQuantity = int.Parse(.Text),
                    Manufacturer = txt_Manufacturer.Text.Trim()
                };

                var laptop = new Laptop
                {
                    Weight = decimal.Parse(txt_LaptopWeight.Text),
                    screenSize = txt_ScreenSize.Text.Trim(),
                    Spectification = txt_Spetification.Text.Trim(),
                    Colour = txt_LaptopColour.Text.Trim()
                };

                // 2. Thêm vào database qua DAL
                var laptopDAL = new LaptopDAL();
                bool result = laptopDAL.AddLaptop(laptop, product);

                // 3. Thông báo kết quả cho người dùng
                if (result)
                {
                    MessageBox.Show("Thêm laptop thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm laptop thất bại!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_AccessoriesSave_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Lấy dữ liệu từ các control trên form
                var product = new Product
                {
                    Supplier_Id = Convert.ToInt32(ccb_NhaCungCap3.SelectedValue),
                    productName = txt_AccessoriesName.Text.Trim(),
                    price = decimal.Parse(txt_AccessoriesPrice.Text),
                    //stockQuantity = int.Parse(.Text),
                    Manufacturer = txt_AccessoriesManufacturer.Text.Trim()
                };
                var accessories = new Accessories
                {
                    Type = txt_AccessoriesType.Text.Trim(),
                    Overview = txt_AccessoriesOverview.Text.Trim()

                };
                // 2. Thêm vào database qua DAL
                var accessoriesDAL = new AccessoriesDAL();
                bool result = accessoriesDAL.AddAccessories(accessories, product);
                // 3. Thông báo kết quả cho người dùng
                if (result)
                {
                    MessageBox.Show("Thêm phụ kiện thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm phụ kiện thất bại!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void ccb_NhaCungCap1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_pcSpecs_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_LaptopWeight_Validating(object sender, CancelEventArgs e)
        {
            decimal canNang;
            if (!decimal.TryParse(txt_LaptopWeight.Text, out canNang) || canNang < 0)
            {
                MessageBox.Show(Resource.Validation_Error_InvalidWeight, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_LaptopWeight.Focus();
                txt_LaptopWeight.SelectAll();
            }
        }

        private void txt_LaptopPrice_Validating(object sender, CancelEventArgs e)
        {
            decimal canNang;
            if (!decimal.TryParse(txt_LaptopPrice.Text, out canNang) || canNang < 0)
            {
                MessageBox.Show(Resource.Validation_Error_InvalidPrice, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_LaptopPrice.Focus();
                txt_LaptopPrice.SelectAll();
            }
        }

        private void txt_pcPrice_Validating(object sender, CancelEventArgs e)
        {
            decimal canNang;
            if (!decimal.TryParse(txt_pcPrice.Text, out canNang) || canNang < 0)
            {
                MessageBox.Show(Resource.Validation_Error_InvalidPrice, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_pcPrice.Focus();
                txt_pcPrice.SelectAll();
            }
        }

        private void txt_AccessoriesPrice_Validating(object sender, CancelEventArgs e)
        {
            decimal canNang;
            if (!decimal.TryParse(txt_AccessoriesPrice.Text, out canNang) || canNang < 0)
            {
                MessageBox.Show(Resource.Validation_Error_InvalidPrice, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_AccessoriesPrice.Focus();
                txt_AccessoriesPrice.SelectAll();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
