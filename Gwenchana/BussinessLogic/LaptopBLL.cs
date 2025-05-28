using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Gwenchana.DataAccess.DTO;


namespace Gwenchana.BussinessLogic
{
    public class LaptopBLL
    {
        private readonly DataAccess.DAL.LaptopDAL _laptopDAL = new DataAccess.DAL.LaptopDAL();

        public List<Laptop> GetAllLaptops()
        {
            return _laptopDAL.GetAllLaptops();
        }

        public DataTable GetAllLaptopsDataTable()
        {
            return _laptopDAL.GetAllLaptopsDataTable();
        }
        
        public bool UpdateLaptop(Laptop laptop)
        {
            return _laptopDAL.UpdateLaptop(laptop);
        }

        public bool DeleteLaptop(int id)
        {
            return _laptopDAL.DeleteLaptop(id);
        }

        public bool AddLaptop(Laptop laptop, Product product)
        {
            return _laptopDAL.AddLaptop(laptop, product);
        }
    }
}
