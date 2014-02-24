using System;
using System.Configuration;
using System.IO;
using Microsoft.Practices.Unity.Configuration;

namespace Police.Service.Infrastructure
{
    public class UnityConfiguration
    {
        public static UnityConfigurationSection GetConfigurationFromFile()
        {            
            string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "unity.config");
            var fileMap = new ExeConfigurationFileMap {ExeConfigFilename = fileName};
            Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap,
                                                                                          ConfigurationUserLevel.None);
            const string configSection = "unity";
            return configuration.GetSection(configSection) as UnityConfigurationSection;
        }

      
    }
}
