using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Stocks
{
    public class Customer : Base
    {
        public Customer()
        {
            this.Transactions = new List<Transactions>();
        }

        public string Name { get; set; }
        public int AccountNumber { get; set; }
        public double FundBalance { get; set; }

        public List<Transactions> Transactions { get; set; }
    }

}