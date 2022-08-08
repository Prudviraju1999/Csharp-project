using System;
using System.Collections;
using Stocks;

namespace StockTrading
{
    public class TransactionsDetails : CustumerDetails
    {
        public Transactions GetTransactionsObject(bool isBuy, int tickerId, double cost, int quantity, DateTime DateTAndime)
        {
            Transactions transactions = new Transactions()
            {
                Type = isBuy,
                TickerId = tickerId,
                Cost = cost,
                Quantity = quantity,
                DateTAndime = DateTAndime
            };
            return transactions;
        }
    }
}