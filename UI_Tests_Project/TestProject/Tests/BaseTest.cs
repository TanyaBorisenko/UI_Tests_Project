using NUnit.Framework;
using OpenQA.Selenium;
using UI_Tests_Project.FrameWork.Utils;

namespace UI_Tests_Project.TestProject.Tests
{
    public class BaseTest
    {
        private IWebDriver Driver => WebDriverSingleton.WebDriver;
        private readonly string _url = ConfigManager.GetSettingsConfig()["Url"];

        [SetUp]
        public void BeforeTest()
        {
            Driver.Navigate().GoToUrl(_url);
            Driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}