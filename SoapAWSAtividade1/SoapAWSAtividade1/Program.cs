using System;
using System.Threading.Tasks;

namespace SoapAWSAtividade1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ServiceReference1.SOAPDemoSoapClient client = new ServiceReference1.SOAPDemoSoapClient();

            var response = await client.LookupCityAsync("84119");

            Console.WriteLine($"{response.City}");

            var intResponse = await client.AddIntegerAsync(25, 20);

            Console.WriteLine($"{intResponse.ToString()}");

            var personResponse = await client.FindPersonAsync("1");

            Console.WriteLine($"{personResponse.Name}");
        }
    }
}
