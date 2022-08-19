using Stocks;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StockTrading
{
    public class CustumerDetails
    {
        public List<Customer> Customers = new List<Customer>();
        
        public void AddCustomer(string name, 
                                int accountNumber, 
                                double fundBalance)
        {            
            Customer customer = new Customer
            {
                Id = Customers.Count + 1,
                Name = name,
                AccountNumber = accountNumber,
                FundBalance = fundBalance
            };
            Customers.Add(customer);
        }

        public List<Customer> ReadCustomerDetails()
        {
            return Customers;
        }

        public void UpdateCustomer(int id, string name, double fundBalance)
        {
            foreach (Customer item in Customers)
            {
                if (item.Id == id)
                {
                    item.Name = name;
                    item.FundBalance = fundBalance;
                }
            }
        }

        public void DeleteCustomer(int id)
        {
            int idx = -1;

            //Customer c = Customers.Where(m => m.Id == id).FirstOrDefault();
            //Customers.Remove(c);

            foreach (Customer item in Customers)
            {
                if (item.Id == id)
                {
                    idx = Customers.IndexOf(item);
                }
            }
            if (idx != -1)
            {
                Customers.RemoveAt(idx);
            }
            
        }

        public bool AddCustomerTransaction(int customerId, 
                                            bool isBuy, 
                                            int tickerId, 
                                            double cost, 
                                            int quantity, 
                                            DateTime dateAndTime)
        {
            bool isSuccessful = true;

            foreach (Customer c in Customers)
            {
                if (c.Id == customerId)
                {
                    try
                    {
                        c.Transactions.Add(new TransactionsDetails().GetTransactionsObject(isBuy,
                                                                                            tickerId,
                                                                                            cost,
                                                                                            quantity,
                                                                                            dateAndTime));
                    }
                    catch
                    {
                        isSuccessful = false;
                    }
                    break;
                }
            }
            return isSuccessful;
        }

    }
}