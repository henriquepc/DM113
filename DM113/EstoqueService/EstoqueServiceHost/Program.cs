using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Estoques;


namespace EstoqueServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost estoquesServiceHost = new
            ServiceHost(typeof(EstoqueService));
            estoquesServiceHost.Open();
            Console.WriteLine("Service Running");
            Console.ReadLine();
            Console.WriteLine("Service Stopping");
            estoquesServiceHost.Close();
        }
    }
}
