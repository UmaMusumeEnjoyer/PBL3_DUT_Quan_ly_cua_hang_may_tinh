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

namespace Gwenchana
{
    public partial class PetView : Form
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        //Constructor
        public PetView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            LoadData();
            tabControl1.TabPages.Remove(tabPagePetDetail);

            //tabControl1.TabPages.Remove(tabPagePetDetail);
            btnClose.Click += delegate { this.Close(); };
        }

        private void LoadData()
        {
            SupplierBLL supplierBLL = new SupplierBLL();
            //List<Supplier> suppliers = supplierBLL.GetAllSuppliers();
            DataTable dt = supplierBLL.GetAllSuppliersDataTable();
            dataGridView.ReadOnly = true;
            dataGridView.DataSource = dt;

        }



        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
              {
                  if (e.KeyCode == Keys.Enter)
                      SearchEvent?.Invoke(this, EventArgs.Empty);
              };
            //Others
        }

 


        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

       

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void txtPetId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPagePetDetail);
            tabControl1.TabPages.Remove(tabPagePetList);
            tabControl1.SelectedTab = tabPagePetDetail;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPagePetList);
            tabControl1.TabPages.Remove(tabPagePetDetail);
            tabControl1.SelectedTab = tabPagePetList;
        }
    }
}
