using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFRestWebService.DataModels
{
    [DataContract]
    public class Customers
    {
        private int customerId;
        private string customerName;
        private string customerCity;

        [DataMember]
        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        [DataMember]
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        [DataMember]
        public string CustomerCity
        {
            get { return customerCity; }
            set { customerCity = value; }
        }

    }
}