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
            var httpBaseAddress = new Uri("http://localhost:6790/MyHttpEp");
            var host = new ServiceHost(typeof(MulService), httpBaseAddress);
            var httpBinding = new BasicHttpBinding()
            {
                OpenTimeout = TimeSpan.FromMinutes(10),
                CloseTimeout = TimeSpan.FromMinutes(5)
            };
            var httpEndPoint = host.AddServiceEndpoint(typeof(IMulService), httpBinding, httpBaseAddress);

            var metadataBehavior = new ServiceMetadataBehavior();
            metadataBehavior.HttpGetEnabled = true;
            host.Description.Behaviors.Add(metadataBehavior);

            host.Open();

            foreach (var ep in host.Description.Endpoints)
            {
                Console.WriteLine($"Endpoint description: {Environment.NewLine}    Address: {ep.Address}{Environment.NewLine}    Binding: {ep.Binding.Name}{Environment.NewLine}    Contract: {ep.Contract.ContractType}");
                Console.WriteLine($"    Open timeout: {ep.Binding.OpenTimeout}");
                Console.WriteLine($"    Close timeout: {ep.Binding.CloseTimeout}");
                Console.WriteLine($"    Send timeout: {ep.Binding.SendTimeout}");
                Console.WriteLine($"    Receive timeout: {ep.Binding.ReceiveTimeout}");
            }
            Console.ReadLine();
            host.Close();
            Console.WriteLine($"Stopped.");
            Console.ReadKey();
        }
    }
}
