using Stocks;
using System;
using System.Collections;

namespace StockTrading
{
    class TickerDetails
    {
        public ArrayList arrTickers = new ArrayList();
        public void AddTickerDetails(string name, string listedDate, int customerId)
        {
            Ticker tickerDetails = new Ticker()
            {
                Id = arrTickers.Count,
                Name = name,
                DateListed = Convert.ToDateTime(listedDate),
                Cust_Id = customerId
            };
            arrTickers.Add(tickerDetails);
        }

        public ArrayList readTickerDetails()
        {
            return arrTickers;
        }

        public void UpdateTicker(int id, string name, string dateListed, int cust_Id )
        {
            foreach (Ticker item in arrTickers)
            {
                if (item.Id == id)
                {
                    item.Name = name;
                    item.DateListed = Convert.ToDateTime(dateListed);
                    item.Cust_Id = cust_Id;
                }
            }
        }

        public void deleteTicker(int id)
        {
            int idx = -1;
            foreach (Ticker item in arrTickers)
            {
                if (item.Id == id)
                {
                    idx = arrTickers.IndexOf(item);
                }
            }
            if (idx != -1)
            {
                arrTickers.RemoveAt(idx);
            }

        }
    }
}