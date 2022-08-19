using Stocks;
using System;
using System.Collections;

namespace StockTrading
{
    class TickerPriceDetails
    {
        public ArrayList arrTickerPrice = new ArrayList();
        public void AddTickerPriceDetails(string tickerTime, 
                                          int tickerId)
        {
            TickerPrice tickerPrice = new TickerPrice()
            {
                Id = arrTickerPrice.Count + 1,
                TickerDateTime = Convert.ToDateTime(tickerTime),
                TickerId = tickerId,
            };
            arrTickerPrice.Add(tickerPrice);
        }

        public void UpdateTickerPrice(int id, 
                                      int tickerPriceOne, 
                                      string tickerTime, 
                                      int tickerId)
        {
            foreach (TickerPrice item in arrTickerPrice)
            {
                if (item.Id == id)
                {
                    item.Price = tickerPriceOne;
                    item.TickerDateTime = Convert.ToDateTime(tickerTime);
                    item.TickerId = tickerId;
                }
            }
        }

    }
}