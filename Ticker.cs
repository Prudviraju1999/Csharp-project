using System;

namespace Stocks
{
    public class Ticker : Base
    {
        public string Name { get; set; }
        public DateTime DateListed { get; set; }
        public int Cust_Id { get; set; }
    }
}