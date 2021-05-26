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
            var baseAddress = new Uri("http://localhost:63635");
            var host = new ServiceHost(typeof(MulService), baseAddress);
            var endPoint = host.AddServiceEndpoint(typeof(IMulService), new BasicHttpBinding(), baseAddress);
            var metadataBehavior = new ServiceMetadataBehavior() { HttpGetEnabled = true };
            host.Description.Behaviors.Add(metadataBehavior);
            host.Open();

            Console.WriteLine($"Service started at {baseAddress.AbsoluteUri}. Press \"Enter\" to stop it.");
            Console.ReadLine();
            host.Close();
            Console.WriteLine($"Stopped.");
            Console.ReadKey();
        }
    }
}
