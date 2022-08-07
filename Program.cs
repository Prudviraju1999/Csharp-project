using System;
using System.Collections;
using Stocks;

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

            //Read Customers
            /*
            ArrayList raju =  c.readCustomerDetails();

            foreach (Customer item in raju)
            {
                Console.WriteLine("\n"+item.Id);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.AccountNumber);
                Console.WriteLine(item.FundBalance);
                if (item.custTransactions == null)
                {
                    Console.WriteLine("Array is Empty");
                }
                else
                {
                    foreach (Transactions subItem in item.custTransactions)
                    {
                        Console.WriteLine(subItem.DateTAndime);
                    }
                }
                Console.WriteLine("_ _ _ _");
            }
            */
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

            TranscationsDetails tr = new TranscationsDetails();

            //create Transactions

            tr.AddTransactionDetails(true, 0, 200, 2, "2020-01-01 07:30",1);
            tr.AddTransactionDetails(false, 0, 300, 2, "2020-01-01 08:30",1);

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
            //Read Customers

            /*
            ArrayList raju = c.readCustomerDetails();

            foreach (Customer item in raju)
            {
                Console.WriteLine("\n" + item.Id);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.AccountNumber);
                Console.WriteLine(item.FundBalance);
                if (item.custTransactions == null)
                {
                    Console.WriteLine("Array is Empty");
                }
                else
                {
                    foreach (Transactions subItem in item.custTransactions)
                    {
                        Console.WriteLine(subItem.DateTAndime);
                    }
                }
                Console.WriteLine("_ _ _ _");
            }
            */
            Console.ReadKey();
        }
    }
}