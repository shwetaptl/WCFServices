using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFRestWebService.DataModels;

namespace WCFRestWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class RESTService : IRESTServices
    {
        List<Customers> lstCustomers = new List<Customers>();

        public List<Customers> GetCustomers()
        {

            lstCustomers.Add(new Customers { CustomerID = 1, CustomerName = "Josheph", CustomerCity = "New York" });
            lstCustomers.Add(new Customers { CustomerID = 2, CustomerName = "Michle", CustomerCity = "Los Angeles" });
            lstCustomers.Add(new Customers { CustomerID = 3, CustomerName = "John", CustomerCity = "Chicago" });
            lstCustomers.Add(new Customers { CustomerID = 4, CustomerName = "Mike", CustomerCity = "Dallas" });
            lstCustomers.Add(new Customers { CustomerID = 5, CustomerName = "Richel", CustomerCity = "San Francisco" });

            return lstCustomers;

        }
    }
}
