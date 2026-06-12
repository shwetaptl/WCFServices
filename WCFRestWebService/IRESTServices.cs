using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using WCFRestWebService.DataModels;

namespace WCFRestWebService
{
    [ServiceContract]
    public interface IRESTServices
    {
        // API call: GET {host}/RESTService.svc/restPoint/GetCustomers
        // [WebGet] enables HTTP GET access. ResponseFormat.Json overrides WCF's default (Xml),
        // ensuring the response is a JSON array the REST client can deserialize.
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        List<Customers> GetCustomers();
    }
}
