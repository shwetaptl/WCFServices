using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace ConsumingServices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== REST Client (webHttpBinding) ===");
            Console.WriteLine("Endpoint: GET /RESTService.svc/restPoint/GetCustomers");
            Console.WriteLine();
            CallingRESTfunction();
            Console.ReadLine();
        }

        static void CallingRESTfunction()
        {
            // Plain HttpWebRequest — no SOAP envelope, no generated proxy required.
            // webHttpBinding makes the operation available as a standard HTTP GET.
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(
                "http://localhost:58534/RESTService.svc/restPoint/GetCustomers");

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string json = new StreamReader(response.GetResponseStream(), System.Text.Encoding.UTF8).ReadToEnd();

            // Deserialize the JSON array — property names must match the service's [DataMember] names
            List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(json);
            foreach (var c in customers)
            {
                Console.WriteLine($"ID: {c.CustomerID,-3}  Name: {c.CustomerName,-10}  City: {c.CustomerCity}");
            }
        }
    }

    // Local DTO that mirrors the service's Customers DataContract for JSON deserialization.
    // With SOAP the proxy generates this type from WSDL; with REST you define it yourself.
    class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerCity { get; set; }
    }
}
