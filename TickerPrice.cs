using System;

namespace Stocks
{
    public class TickerPrice : Base
    {

        public int Price { get; set; }
        public DateTime TickerDateTime { get; set; }
        public int TickerId { get; set; }
    }
}