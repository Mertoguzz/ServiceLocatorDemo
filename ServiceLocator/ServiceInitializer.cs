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

        public static void RegisterLazy()
        {
            InitializeLazy<IProductService, Product>();
        }

        private static void InitializeLazy<T, C>()
        {
            try
            {
                ServiceLocator.RegisterLazy<T, C>();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
