using Core;
using ServiceLocator;
using System;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceInitializer.Register();
            string name = ServiceLocator.ServiceLocator.Create<IProductService>().GetProductName(5);
            Console.WriteLine(name);
            Console.ReadKey();
        }
    }
}
