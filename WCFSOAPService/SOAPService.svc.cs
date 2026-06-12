using System.Collections.Generic;
using WCFSOAPWebService.DataModels;

namespace WCFSOAPWebService
{
    public class SOAPService : ISOAPService
    {
        public List<Customers> GetCustomers()
        {
            return new List<Customers>
            {
                new Customers { CustomerID = 1, CustomerName = "Joseph",   CustomerCity = "New York"      },
                new Customers { CustomerID = 2, CustomerName = "Michelle", CustomerCity = "Los Angeles"   },
                new Customers { CustomerID = 3, CustomerName = "John",     CustomerCity = "Chicago"       },
                new Customers { CustomerID = 4, CustomerName = "Mike",     CustomerCity = "Dallas"        },
                new Customers { CustomerID = 5, CustomerName = "Rachel",   CustomerCity = "San Francisco" }
            };
        }
    }
}
