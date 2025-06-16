using Gwenchana.DataAccess.DTO;
using Gwenchana.DataAccess.ViewModel;
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

namespace Gwenchana
{
    public partial class EmployeeMenu1 : Form
    {
        //public CurrentEmployee currentEmployee { get; set; }
        public int currentEmployeeID { get; set; }

        public EmployeeMenu1()
        {
            //string username = Login.username;
            
            InitializeComponent();

            CurrentEmployee employee = new CurrentEmployee();


            hideSubMenu();
            UpdateComponent(LanguageClass.Language);
        }

        private void UpdateComponent(string language)
        {
            Resource.Culture = string.IsNullOrEmpty(language) ? null : new CultureInfo(language);
            btn_Products.Text = Resource.btn_Products;
            btn_Laptops.Text = Resource.btn_Laptops;
            btn_PCs.Text = Resource.btn_PCs;
            btn_Accessories.Text = Resource.btn_Accessories;
            btn_Suppliers.Text = Resource.btn_Suppliers;
            btn_Invoices.Text = Resource.btn_Invoices;
            btn_importInvoices.Text = Resource.btn_importInvoices;
            btn_exportInvoices.Text = Resource.btn_exportInvoices;
            btn_Customers.Text = Resource.btn_Customers;
            btn_Statistics.Text = Resource.btn_Statistics;
            btn_Employees.Text = Resource.btn_Employees;
            btn_Accounts.Text = Resource.btn_Accounts;
            btn_Exit.Text = Resource.btn_Exit;
        }


        private void hideSubMenu()
        {
            panelMediaSubMenu.Visible = false;
            //panelPlaylistSubMenu.Visible = false;
            //panelToolsSubMenu.Visible = false;
            panel1.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }

        #region MediaSubMenu
        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new LaptopUI());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new PCUI());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new AccessoriesUI());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            //showSubMenu(panelPlaylistSubMenu);
        }

        #region PlayListManagemetSubMenu
        private void button8_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnTools_Click(object sender, EventArgs e)
        {
            //showSubMenu(panelToolsSubMenu);
            openChildForm(new PetView());

        }
        #region ToolsSubMenu
        private void button13_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            //openChildForm(new Form3());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                Resource.Prompt_ConfirmReturnToLogin,
                Resource.Confirm_Exit,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close(); // Close the current form
            }
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void HoaDon_Click(object sender, EventArgs e)
        {
            showSubMenu(panel1);
        }


        private void HoaDonNhap_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_ThongTinCaNhan_Click(object sender, EventArgs e)
        {
            openChildForm(new information(currentEmployeeID));
        }

        private void button5_Click_2(object sender, EventArgs e)
        {

        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_HoaDonNhap_Click(object sender, EventArgs e)
        {
            openChildForm(new Goods_Receipt(currentEmployeeID));
        }

        private void btn_HoaDonXuat_Click(object sender, EventArgs e)
        {
            openChildForm(new Receipt(currentEmployeeID));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new CustomerUI());
        }

        private void button5_Click_3(object sender, EventArgs e)
        {
            openChildForm(new Dashboard());
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            openChildForm(new AssignEmployee());
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Employees()); 
        }
    }
}
