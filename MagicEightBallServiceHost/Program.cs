using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Description;
using MagicEightBallServiceLib;

namespace MagicEightBallServiceHost
{
    class Program
    {   //wlj:add some comment
        static void Main(string[] args)
        {
            Console.WriteLine("**** Console Base WCF host");
            using (ServiceHost serviceHost = new ServiceHost(typeof(MagicEightBallService)))
            {
                serviceHost.Open();
                Console.WriteLine("The Service is ready");
                Console.WriteLine("Press the enter key to terminate service");
                DisplayHostInfo(serviceHost);

                Console.ReadLine();
            }
            Console.ReadLine();
        }
        public static void DisplayHostInfo(ServiceHost host) 
        {
            Console.WriteLine();
            Console.WriteLine("***** Host Info ****");
            foreach(System.ServiceModel.Description.ServiceEndpoint se
                in host.Description.Endpoints)
            {
                Console.WriteLine("Address:{0}",se.Address);
                Console.WriteLine("Binding:{0}",se.Binding.Name);
                Console.WriteLine("Contract:{0}",se.Contract);
                Console.WriteLine();
            }
            Console.WriteLine("**************************");
        }
    }
}
