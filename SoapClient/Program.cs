using SoapClient.SOAPService;
using System;

namespace SoapClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SOAP Client (basicHttpBinding) ===");
            Console.WriteLine("Endpoint: SOAPService.svc/soap  (SOAP envelope via generated proxy)");
            Console.WriteLine();
            CallingSOAPService();
            Console.ReadLine();
        }

        static void CallingSOAPService()
        {
            // SOAPServiceClient is the auto-generated proxy from "Add Service Reference".
            // It wraps the SOAP/XML envelope — callers work with plain C# objects, never raw XML.
            // The endpoint address and binding are resolved from App.config.
            SOAPServiceClient proxy = new SOAPServiceClient();

            Customers[] customers = proxy.GetCustomers();
            foreach (var c in customers)
            {
                Console.WriteLine($"ID: {c.CustomerID,-3}  Name: {c.CustomerName,-10}  City: {c.CustomerCity}");
            }
        }
    }
}
