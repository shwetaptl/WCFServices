using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsumingServices
{
    class Program
    {
        static void Main(string[] args)
        {
            CallingRESTfunction();

            Console.ReadLine();
        }

        static void CallingRESTfunction()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:58534/RESTService.svc/restPoint/GetCustomers");

            //Get the Web Response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();

            //Seting Up the Stream Reader
            StreamReader readerStream = new StreamReader(responseStream, System.Text.Encoding.GetEncoding("utf-8"));

            string json = readerStream.ReadToEnd();
            
            Console.WriteLine(json);            

            Console.ReadLine();

        }

    }
}
