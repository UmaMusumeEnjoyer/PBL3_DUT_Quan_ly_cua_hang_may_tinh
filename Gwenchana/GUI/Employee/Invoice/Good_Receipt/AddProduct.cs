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
            //AssociateAndRaiseViewEvents();
            
            selectedProduct = selected;
            if(selectedProduct == "Laptop")
            {
                //tabControl1.TabPages.Add(tabPageLaptop);
                //tabControl1.TabPages.Remove(tabPagePetList);
                tabControl1.TabPages.Remove(tabPagePC);
                tabControl1.TabPages.Remove(tabPageAccessories);
                tabControl1.SelectedTab = tabPageLaptop;
            }
            else if(selectedProduct == "PC")
            {
                //tabControl1.TabPages.Add(tabPagePC);
                //tabControl1.TabPages.Remove(tabPagePetList);
                tabControl1.TabPages.Remove(tabPageLaptop);
                tabControl1.TabPages.Remove(tabPageAccessories);
                tabControl1.SelectedTab = tabPagePC;
            }
            else if(selectedProduct == "Accessories") // Special tab for other purposes
            {
                //tabControl1.TabPages.Add(tabPageAccessories);
                //tabControl1.TabPages.Remove(tabPagePetList);
                tabControl1.TabPages.Remove(tabPageLaptop);
                tabControl1.TabPages.Remove(tabPagePC);
                tabControl1.SelectedTab = tabPageAccessories;
            }


            btnClose.Click += delegate { this.Close(); };
        } 


        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

       public void ChangeTab()
        {
            button = "Special";
            tabControl1.TabPages.Add(tabPageLaptop);
            //tabControl1.TabPages.Remove(tabPagePetList);
            tabControl1.SelectedTab = tabPageLaptop;
        }

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void btn_ClearFilter_Click(object sender, EventArgs e)
        {
            //cbb_LaptopSearch.SelectedIndex = -1;
            //txtSearch.Clear();
            //LoadData();
        }

        private void cbb_LaptopSearch_TextUpdate(object sender, EventArgs e)
        {
            //string a = cbb_LaptopSearch.SelectedItem.ToString();
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
    }
}
