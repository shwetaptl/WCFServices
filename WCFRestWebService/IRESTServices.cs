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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IRESTServices
    {
        //API CALL : {{URL}}/RESTService.svc/restPoint/GetCustomer
        //You have to define method type other things are optionals.
        [OperationContract]
        [WebGet]
        //[WebGet(UriTemplate = "/GetCustomers", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Customers> GetCustomers();
    }

}
