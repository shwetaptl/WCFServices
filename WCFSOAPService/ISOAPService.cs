using System.Collections.Generic;
using System.ServiceModel;
using WCFSOAPWebService.DataModels;

namespace WCFSOAPWebService
{
    // No [WebGet] here — SOAP operations are invoked via XML envelope, not HTTP verbs.
    // The binding (basicHttpBinding in Web.config) controls transport and message format.
    [ServiceContract]
    public interface ISOAPService
    {
        [OperationContract]
        List<Customers> GetCustomers();
    }
}
