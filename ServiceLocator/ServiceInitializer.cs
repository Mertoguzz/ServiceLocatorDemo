using Core;
using System;

namespace ServiceLocator
{
    public class ServiceInitializer
    {
        public static void Register()
        {
            Initialize<IProductService>(new Product());
        }


        private static void Initialize<T>(T instance)
        {
            try
            {
                ServiceLocator.Register<T>(instance);
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
