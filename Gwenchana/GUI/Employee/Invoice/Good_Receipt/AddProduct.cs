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



            }
            else if(selectedProduct == "PC")
            {
                tabControl1.TabPages.Remove(tabPageLaptop);
                tabControl1.TabPages.Remove(tabPageAccessories);


                ccb_NhaCungCap2.DataSource = cbbData;
                ccb_NhaCungCap2.DisplayMember = "supplierName";
            }
            else if(selectedProduct == "Accessories") 
            {
                tabControl1.TabPages.Remove(tabPageLaptop);
                tabControl1.TabPages.Remove(tabPagePC);


                ccb_NhaCungCap3.DataSource = cbbData;
                ccb_NhaCungCap3.DisplayMember = "supplierName";
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




            this.Close();
        }

        private void btn_LaptopSave_Click(object sender, EventArgs e)
        {






            this.Close();
        }

        private void btn_AccessoriesSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ccb_NhaCungCap1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
