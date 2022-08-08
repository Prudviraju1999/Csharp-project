using System;
using System.Timers;

namespace Stocks
{
    public class TickerPrice : Base
    {
        private Timer timer = new Timer();

        public TickerPrice()
        {
            timer.Interval = 20000;
            timer.Elapsed += UpdateTickerPrice;
            timer.Start();
        }

        private void UpdateTickerPrice(object sender, ElapsedEventArgs e)
        {
            this.Price = Convert.ToInt32(new Random().NextDouble());
        }

        public int Price { get; set; }
        public DateTime TickerDateTime { get; set; }
        public int TickerId { get; set; }
    }
}