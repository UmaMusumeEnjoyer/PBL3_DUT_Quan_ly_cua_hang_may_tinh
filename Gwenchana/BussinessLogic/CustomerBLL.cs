using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Gwenchana.BussinessLogic
{
    public class CustomerBLL
    {
        private readonly DataAccess.DAL.CustomerDAL _customerDAL = new DataAccess.DAL.CustomerDAL();
        public List<DataAccess.DTO.Customer> GetAllCustomers()
        {
            return _customerDAL.GetAllCustomers();
        }
        public DataTable GetAllCustomersDataTable()
        {
            return _customerDAL.GetAllCustomersDataTable();
        }
        public bool AddCustomer(DataAccess.DTO.Customer customer)
        {
            return _customerDAL.AddCustomer(customer);
        }
    }
}
