using MulServiceLibrary;
using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var tcpBaseAddress = new Uri("net.tcp://localhost:63690");
            var httpBaseAddress = new Uri("http://localnost:63635");
            var host = new ServiceHost(typeof(MulService), httpBaseAddress /*, tcpBaseAddress*/);
            var tcpEndPoint = host.AddServiceEndpoint(typeof(IMulService), new NetTcpBinding(), tcpBaseAddress);
            var httpEndPoint = host.AddServiceEndpoint(typeof(IMulService), new BasicHttpBinding(), httpBaseAddress);
            var metadataBehavior = new ServiceMetadataBehavior() { HttpGetEnabled = true };
            host.Description.Behaviors.Add(metadataBehavior);
            host.Open();

            Console.WriteLine($"Service started at {host.BaseAddresses[0]}. Press \"Enter\" to stop it.");
            foreach(var ep in host.Description.Endpoints)
                Console.WriteLine($"Endpoint description: {Environment.NewLine}    Address: {ep.Address}{Environment.NewLine}    Binding: {ep.Binding.Name}{Environment.NewLine}    Contract: {ep.Contract.ContractType}");
            Console.ReadLine();
            host.Close();
            Console.WriteLine($"Stopped.");
            Console.ReadKey();
        }
    }
}
