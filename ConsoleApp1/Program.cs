using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost bookServiceHost = null;
            try
            {
                Uri httpBaseAddress = new Uri("http://localhost:4321/StudentService");
                bookServiceHost = new ServiceHost(typeof(WcfBookService.BookService),httpBaseAddress);
                bookServiceHost.AddServiceEndpoint(typeof(WcfBookService.IBookService), new WSHttpBinding(), "");
                ServiceMetadataBehavior serviceBehavior = new ServiceMetadataBehavior();
                serviceBehavior.HttpGetEnabled = true;
                bookServiceHost.Description.Behaviors.Add(serviceBehavior);
                bookServiceHost.Open();
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                bookServiceHost = null;
            }
        }
    }
}
