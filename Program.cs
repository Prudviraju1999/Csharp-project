using System;
using System.Collections;
using Stocks;
using System.Collections.Generic;

namespace StockTrading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer *****************************************************************
            //Func Check [CRUD]

            CustumerDetails c = new CustumerDetails();
            
            //create Customers
            c.AddCustomer("karli", 100, 101);
            c.AddCustomer("raju", 101, 102);

            // Add Customer Transactions
            c.AddCustomerTransaction(1,true, 0, 200, 2, Convert.ToDateTime("2020-01-01 02:30"));
            c.AddCustomerTransaction(1, false, 0, 200, 2, Convert.ToDateTime("2022-01-01 02:45"));
            c.AddCustomerTransaction(2, false, 0, 200, 2, Convert.ToDateTime("2022-01-01 03:30"));
            c.AddCustomerTransaction(2, false, 0, 200, 2, Convert.ToDateTime("2022-01-01 03:40"));
            c.AddCustomerTransaction(2, false, 0, 200, 2, Convert.ToDateTime("2022-01-01 03:50"));

            
            /*
            //Update Customers
            c.UpdateCustomer(2, "Raju", 1000);

            //Delete Customers
            c.deleteCust(1);


    */

            //Ticker   *****************************************************************************
            //Func Check [CRUD]

            TickerDetails t = new TickerDetails();

            /*

            //create Tickers
            t.AddTickerDetails("Reliance", "2020-01-01", 101);
            t.AddTickerDetails("ITC", "2021-01-01", 102);

            //Read Tickers

            ArrayList raj = t.arrTickers;

            foreach (Ticker item in raj)
            {
                Console.WriteLine("\n" + item.Id);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.DateListed);
                Console.WriteLine(item.Cust_Id);
                Console.WriteLine("_ _ _ _");
            }

            //Update Tickers
            t.UpdateTicker(1, "JIO", "1999-01-01", 101);

            //Delete Tickers
            t.deleteTicker(0);

    */

            // Ticker Price  *******************************************************************
            // Create, Update test

            TickerPriceDetails tp = new TickerPriceDetails();

            /*

            //create TickerPrice

            tp.AddTickerPriceDetails(100,"2020-01-01 07:30",1);
            tp.AddTickerPriceDetails(200, "2020-01-01 08:30", 2);

            //Read TickerPrice

            ArrayList rajtp = tp.arrTickerPrice;

            foreach (TickerPrice item in rajtp)
            {
                Console.WriteLine("\n" + item.Id);
                Console.WriteLine(item.Price);
                Console.WriteLine(item.TickerDateTime);
                Console.WriteLine(item.TickerId);
                Console.WriteLine("_ _ _ _");
            }

            //Update TickerPrice
            tp.UpdateTickerPrice(1, 220, "2020-01-01 08:30", 2);

    */


            // Transactions  *******************************************************************
            // Create, Read test

            TransactionsDetails tr = new TransactionsDetails();

            //Read Transactions

            /*
            ArrayList rajtr = tr.arrTransaction;

            foreach (Transactions item in rajtr)
            {
                Console.WriteLine("\n" + item.Id);
                Console.WriteLine(item.Type);
                Console.WriteLine(item.Cost);
                Console.WriteLine(item.DateTAndime);
                Console.WriteLine(item.Quantity);
                Console.WriteLine(item.TickerId);
                Console.WriteLine(item.cust_id);
                Console.WriteLine("_ _ _ _");
            }
            */


            //Read Customers with transactions

            List<Customer> raju = c.ReadCustomerDetails();

            foreach (Customer item in raju)
            {
                Console.WriteLine("\n" + item.Id);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.AccountNumber);
                Console.WriteLine(item.FundBalance);
               
                if (item.Transactions == null)
                {
                    Console.WriteLine("Array is Empty");
                }
                else
                {
                    foreach (Transactions subItem in item.Transactions)
                    {
                        Console.WriteLine(subItem.DateTAndime);
                    }
                }
                Console.WriteLine("_ _ _ _");
            }
            
            Console.ReadKey();
        }
    }
}