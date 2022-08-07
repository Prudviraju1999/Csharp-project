using Stocks;
using System.Collections;
using System;

namespace StockTrading
{
    public class CustumerDetails
    {
        public ArrayList arrCustomers = new ArrayList();

        
        public void AddCustomer(string name, int accountNumber, double fundBalance)
        {
            
            Customer customer = new Customer
            {
                Id = arrCustomers.Count,
                Name = name,
                AccountNumber = accountNumber,
                FundBalance = fundBalance
            };
            arrCustomers.Add(customer);
        }
        public ArrayList readCustomerDetails()
        {
            return arrCustomers;
        }

        public void UpdateCustomer(int id, string name, double fundBalance)
        {
            foreach (Customer item in arrCustomers)
            {
                if (item.Id == id)
                {
                    item.Name = name;
                    item.FundBalance = fundBalance;
                }
            }
        }

        public void deleteCust(int id)
        {
            int idx = -1;
            foreach (Customer item in arrCustomers)
            {
                if (item.Id == id)
                {
                    idx = arrCustomers.IndexOf(item);
                }
            }
            if (idx != -1)
            {
                arrCustomers.RemoveAt(idx);
            }
            
        }

    }
}