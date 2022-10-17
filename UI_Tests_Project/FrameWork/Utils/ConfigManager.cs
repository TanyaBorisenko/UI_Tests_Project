using Microsoft.Extensions.Configuration;

namespace UI_Tests_Project.FrameWork.Utils
{
    public class ConfigManager
    {
        public static IConfiguration GetSettingsConfig()
        {
            var builder = new ConfigurationBuilder().AddJsonFile($"configSettings.json", true, true);
            var config = builder.Build();

            return config;
        }
    }
}