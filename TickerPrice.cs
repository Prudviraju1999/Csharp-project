using System;
using System.Timers;

namespace Stocks
{
    public class TickerPrice : Base
    {
        

        public TickerPrice()
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Elapsed += new ElapsedEventHandler(UpdateTickerPrice);
            timer.Start();
        }

        private void UpdateTickerPrice(object sender, ElapsedEventArgs e)
        {
            double[] names = new double[] { 101.01, 102.53, 103.56, 104.76, 105.24};
            Random rnd = new Random();
            int index = rnd.Next(names.Length);
            this.Price = names[index];
            Console.Write( "\rPrice : {0}",Price);

        }

        public double Price { get; set; }
        public DateTime TickerDateTime { get; set; }
        public int TickerId { get; set; }
    }
}