using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gwenchana.DataAccess.DTO
{
    public class Laptop : Product
    {
        public int Weight { get; set; }
        public decimal screenSize { get; set; }
        public string Spectification { get; set; }
        public string Colour { get; set; }
        //public string manufacturer { get; set; }

    }
}
