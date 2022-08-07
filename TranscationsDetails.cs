using System;
using System.Collections;
using Stocks;

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


            CustumerDetails tr = new CustumerDetails();
            
            foreach (Customer cust in tr.arrCustomers)
            {
                if (cust_id == cust.Id)
                {
                    cust.custTransactions.Add(transactionDetails);
                }
            }
            
        }
    }
}