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
using Gwenchana.DataAccess.DAL;
using Gwenchana.DataAccess.DBConnect;



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
                    MessageBox.Show("Thêm PC thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm PC thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Thêm laptop thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm laptop thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_AccessoriesSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ccb_NhaCungCap1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_pcSpecs_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
