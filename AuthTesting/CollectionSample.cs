using System;
using System.Collections.Generic;
using System.Text;

namespace AuthTesting
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class CollectionSample
    {
        public static Customer GetCustomer(Customer[] customers, int index)
        {
            return customers[index];
        }
    }
}
