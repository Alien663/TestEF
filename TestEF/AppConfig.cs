using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace TestEF
{
    public class AppConfig
    {
        public static IConfigurationRoot Config => LazyConfig.Value;

        private static readonly Lazy<IConfigurationRoot> LazyConfig = new Lazy<IConfigurationRoot>(() => new ConfigurationBuilder()
            .SetBasePath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!)
            .AddJsonFile("appsettings.json")
            .Build());
    }
}
