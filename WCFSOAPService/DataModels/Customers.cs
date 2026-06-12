using System.Runtime.Serialization;

namespace WCFSOAPWebService.DataModels
{
    [DataContract]
    public class Customers
    {
        private int customerId;
        private string customerName;
        private string customerCity;

        [DataMember]
        public int CustomerID
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
