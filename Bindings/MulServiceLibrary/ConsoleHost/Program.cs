using MulServiceLibrary;
using System;
using System.ServiceModel;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var httpBaseAddress = new Uri("http://localnost:63635/MyHttpEp");
            var host = new ServiceHost(typeof(MulService), httpBaseAddress /*, tcpBaseAddress*/);
            var httpEndPoint = host.AddServiceEndpoint(typeof(IMulService), new BasicHttpBinding(), httpBaseAddress);

            host.Open();

            foreach(var ep in host.Description.Endpoints)
                Console.WriteLine($"Endpoint description: {Environment.NewLine}    Address: {ep.Address}{Environment.NewLine}    Binding: {ep.Binding.Name}{Environment.NewLine}    Contract: {ep.Contract.ContractType}");
            Console.ReadLine();
            host.Close();
            Console.WriteLine($"Stopped.");
            Console.ReadKey();
        }
    }
}
