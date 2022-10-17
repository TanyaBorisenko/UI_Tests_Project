using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace UI_Tests_Project.FrameWork.Utils
{
    public sealed class WebDriverSingleton
    {
        private static IWebDriver _webDriver;

        private WebDriverSingleton()
        {
        }

        public static IWebDriver WebDriver
        {
            get
            {
                var driver = (WebDriver) _webDriver;
                if (driver?.SessionId == null)
                {
                    new DriverManager().SetUpDriver(new ChromeConfig());
                    _webDriver = GetDriver(ConfigManager.GetSettingsConfig()["BrowserName"]);
                }

                return _webDriver;
            }
        }

        private static IWebDriver GetDriver(string name)
        {
            switch (name.ToLower())
            {
                case "chrome":
                    return new ChromeDriver();
                case "ie":
                    return new InternetExplorerDriver();
                case "firefox":
                    return new FirefoxDriver();
                default:
                    throw new WebDriverException($"Please enter browser name");
            }
        }
    }
}