using System.ServiceProcess;
using MulServiceLibrary;
using System.ServiceModel;
using System;

namespace MyWindowsServiceHost
{
    public partial class MyWcfService : ServiceBase
    {
        private ServiceHost host;

        public MyWcfService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            host = new ServiceHost(typeof(MulService), new Uri("net.tcp://localhost:9001/MyService"));
            host.Open();
        }

        protected override void OnStop()
        {
            host?.Close();
            host = null;
        }
    }
}
