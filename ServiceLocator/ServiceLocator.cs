using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocator
{
    public delegate object ServiceProvider();
    public class ServiceLocator
    {
        protected static readonly IDictionary<Type, ServiceProvider> Providers = new Dictionary<Type, ServiceProvider>();
        public static T Create<T>()
        {
            Type t = typeof(T);
            ServiceProvider serviceProvider = Providers[t];
            return (T)serviceProvider();
        }
        public static bool IsRegistered(Type T)
        {
            return Providers.ContainsKey(T);
        }

        public static void Register<T>(ServiceProvider serviceProvider)
        {
            Providers[typeof(T)] = serviceProvider;
        }

        public static void Register<T>(object instance)
        {
            Providers[typeof(T)] = () => instance;
        }

        public static void RegisterLazy<T, C>()
        {
            Providers[typeof(T)] = () => Activator.CreateInstance<C>();
        }

        private static void Clear()
        {
            Providers.Clear();
        }
        public static ServiceProvider GetServiceProvider<T>() { return Providers[typeof(T)]; }  
    }
}
