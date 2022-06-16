using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arvatonet
{
    public class Order
    {
        public string Code {get ; set;}
        public string ProductCode { get; set; }
        public Personal Personal{ get; set; }
        public double TotalAmount { get; set; }
        public int TotalPiece { get; set; }
        public double ProductPrice { get; set; }
    }
}
