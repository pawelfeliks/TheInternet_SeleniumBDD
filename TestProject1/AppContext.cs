using System.Configuration;

namespace TestProject1
{
    public class AppContext
    {
        public string Browser { get; set; }

        public AppContext()
        {
            Browser = GetAppSetting("browser");
        }

        public string GetAppSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}