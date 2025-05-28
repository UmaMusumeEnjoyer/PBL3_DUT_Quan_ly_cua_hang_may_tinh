using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Gwenchana.DataAccess.DTO;

namespace Gwenchana.BussinessLogic
{
    public class PCBLL
    {
        private readonly DataAccess.DAL.PCDAL _pcDAL = new DataAccess.DAL.PCDAL();
        public List<PC> GetAllPCs()
        {
            return _pcDAL.GetAllPCs();
        }

        public DataTable GetAllPCsDataTable()
        {
            return _pcDAL.GetAllPCsDataTable();
        }

        public bool UpdatePC(PC pc)
        {
            return _pcDAL.UpdatePC(pc);
        }

        public bool DeletePC(int id)
        {
            return _pcDAL.DeletePC(id);
        }


        public bool AddPC(PC pc, Product product)
        {
            return _pcDAL.AddPC(pc, product);
        }
    }
}
