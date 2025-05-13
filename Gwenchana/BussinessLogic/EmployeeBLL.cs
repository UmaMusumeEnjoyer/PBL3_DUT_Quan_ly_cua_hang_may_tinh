using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gwenchana.BussinessLogic
{
    public class EmployeeBLL
    {
        private readonly DataAccess.DAL.EmployeeDAL _employeeDAL = new DataAccess.DAL.EmployeeDAL();
        public List<DataAccess.DTO.Employee> GetAllEmployees()
        {
            return _employeeDAL.GetAllEmployees();
        }
        public bool AddEmployee(DataAccess.DTO.Employee employee)
        {
            // Implement the logic to add an employee
            return true;
        }
        public bool UpdateEmployee(DataAccess.DTO.Employee employee)
        {
            return _employeeDAL.UpdateEmployee(employee);
        }
        public bool DeleteEmployee(int employeeId)
        {
            return _employeeDAL.DeleteEmployee(employeeId);
        }
        public DataTable GetAllEmployeesDataTable()
        {
            return _employeeDAL.GetAllEmployeesDataTable();
        }
    }
}
