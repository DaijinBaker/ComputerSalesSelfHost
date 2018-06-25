using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace ComputerSalesSelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set up server configuration
            Uri _baseAddress = new Uri("http://localhost:12292/");
            HttpSelfHostConfiguration config = new HttpSelfHostConfiguration(_baseAddress);
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
                );

            //Create Server
            HttpSelfHostServer server = new HttpSelfHostServer(config);

            //Start Listening
            server.OpenAsync().Wait();
            Console.WriteLine("ComputerSales Web-API Self based on " + _baseAddress);
            Console.WriteLine("Hit Enter to exit...");
            Console.ReadLine();
            server.CloseAsync().Wait();

        }
    }
}
