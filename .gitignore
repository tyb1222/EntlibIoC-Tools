using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace Police.Service.Infrastructure
{
    public sealed class ServiceLocator : IServiceProvider
    {
        private static readonly ServiceLocator _instance = new ServiceLocator();

        public static ServiceLocator Instance { get { return _instance; } }

        private static IUnityContainer _container;

        private ServiceLocator()
        {
            _container = new UnityContainer();
            UnityConfigurationSection configurationSection = UnityConfiguration.GetConfigurationFromFile();
            configurationSection.Configure(_container);           
        }

        public object GetService(Type serviceType)
        {
            return _container.Resolve(serviceType);
        }

        public T GetService<T>()
        {
            return _container.Resolve<T>();
        }

        public T GetInstance<T>(string key)
        {
            UnityConfigurationSection configurationSection = UnityConfiguration.GetConfigurationFromFile();
            using (IUnityContainer container = new UnityContainer().LoadConfiguration(configurationSection,key))
            {
                return container.Resolve<T>();
            }
        }
    }
}
