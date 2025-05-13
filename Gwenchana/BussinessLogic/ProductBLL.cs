using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Gwenchana.DataAccess.DTO;

namespace Gwenchana.BussinessLogic
{
    public class ProductBLL
    {
        private readonly DataAccess.DAL.ProductDAL _productDAL = new DataAccess.DAL.ProductDAL();
        public List<DataAccess.DTO.Product> GetAllProducts()
        {
            return _productDAL.GetAllProducts();
        }
        public Product GetProduct(int id)
        {
            return _productDAL.GetProduct(id);
        }
    }
}
