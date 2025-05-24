using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Gwenchana.DataAccess.DTO;
using Gwenchana.DataAccess.DAL;
using System.Data.SqlClient;

namespace Gwenchana.BussinessLogic
{
    public class AccessoriesBLL
    {
        private readonly AccessoriesDAL _accessoriesDAL = new AccessoriesDAL();
        //public List<Accessories> GetAllAccessories()
        //{
        //    return _accessoriesDAL.GetAllAccessories();
        //}
        //public DTO.Accessories GetAccessoriesById(int id)
        //{
        //    return _accessoriesDAL.GetAccessoriesById(id);
        //}
        public DataTable GetAllAccessoriesDataTable()
        {
            return _accessoriesDAL.GetAllAccessoriesDataTable();
        }
        //public bool AddAccessories(DTO.Accessories accessories)
        //{
        //    return _accessoriesDAL.AddAccessories(accessories);
        //}

        public bool DeleteAccessories(int id)
        {
            return _accessoriesDAL.DeleteAccessories(id);
        }

        public bool UpdateAccessories(Accessories accessories)
        {
            return _accessoriesDAL.UpdateAccessories(accessories);
        }

        public List<Accessories> GetAllAccessoriesList()
        {
            return _accessoriesDAL.GetAllAccessories();
        }
    }
}
