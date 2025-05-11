using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gwenchana.BussinessLogic
{
    public class SupplierBLL
    {
        private readonly DataAccess.DAL.SupplierDAL _supplierDAL = new DataAccess.DAL.SupplierDAL();

        public List<DataAccess.DTO.Supplier> GetAllSuppliers()
        {
            return _supplierDAL.GetAllSuppliers();
        }

        public DataAccess.DTO.Supplier GetSupplierById(int id)
        {
            return _supplierDAL.GetSupplierById(id);
        }

        public DataTable GetAllSuppliersDataTable()
        {
            return _supplierDAL.GetAllSuppliersDataTable();
        }

        public bool AddSupplier(DataAccess.DTO.Supplier supplier)
        {
            return _supplierDAL.AddSupplier(supplier);
        }

        public bool DeleteSupplier(int id)
        {
            return _supplierDAL.DeleteSupplier(id);
        }

        public bool UpdateSupplier(DataAccess.DTO.Supplier supplier)
        {
            return _supplierDAL.UpdateSupplier(supplier);
        }

    }
}
