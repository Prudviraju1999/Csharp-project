using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocks
{
    public class Transactions: Base
    {
        public bool Type { get; set; }
        public int TickerId { get; set; }
        public double Cost { get; set; }
        public int Quantity { get; set; }
        public DateTime DateTAndime { get; set; }
        public int cust_id { get; set; }
    }
}