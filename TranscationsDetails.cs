using Stocks;
using System.Collections;
using System;

namespace StockTrading
{
    class TranscationsDetails
    {
        public ArrayList arrTransaction = new ArrayList();

        public void AddTransactionDetails(bool isBuy, int tickerId, double cost, int quantity, string DateTAndime, int cust_id)
        {
            Transactions transactionDetails = new Transactions()
            {

                Id = arrTransaction.Count,
                Type = isBuy,
                TickerId = tickerId,
                Cost = cost,
                Quantity = quantity,
                DateTAndime = Convert.ToDateTime(DateTAndime),
                cust_id = cust_id

            };            
            arrTransaction.Add(transactionDetails);

        }
    }
}