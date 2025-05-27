using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gwenchana.DataAccess.ViewModel
{
    public class ProductViewModel
    {
        public int Product_Id { get; set; }
        public int ProductQuantity { get; set; }
        public Decimal ProductPrice { get; set; }
        public int Product_SupplierId { get; set; }

    }
}
