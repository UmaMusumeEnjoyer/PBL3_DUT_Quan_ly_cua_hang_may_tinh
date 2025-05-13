using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gwenchana.DataAccess.DTO;
using Gwenchana.DataAccess.ViewModel;
using Gwenchana.DataAccess;
using Gwenchana.DataAccess.DBConnect;
using Gwenchana.DataAccess.ViewModel;

//using CuaHangMayTinh.UI.Authentication;

namespace Gwenchana
{
    public partial class information: Form
    {
        public int id { get; set; }
        public CurrentEmployee employee { get; set; }
        public information(int employe)
        {
            id = employe;
            employee = new CurrentEmployee();
            employee = employee.getCurrentEmployee(id);
            LoadData();
            InitializeComponent();

        }
        
        void LoadData()
        {
            txt_Name.Text = employee.employeeName;
            txt_Age.Text = employee.Age.ToString();
            //txt_Phone.Text = employee.phoneNumber;
            txt_Username.Text = employee.Username;
            txt_Password.Text = employee.Password;
            //txt_AccountId.Text = employee.Account_Id.ToString();

        }

        private void information_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ChangePass_Click(object sender, EventArgs e)
        {
        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
