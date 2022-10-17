using System;
using System.Collections.ObjectModel;
using NLog;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using UI_Tests_Project.FrameWork.Utils;

namespace UI_Tests_Project.FrameWork
{
    public abstract class BaseElement
    {
        private readonly By _locator;
        private readonly string _name;
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private static IWebDriver Driver => WebDriverSingleton.WebDriver;

        private static WebDriverWait Wait => new WebDriverWait(Driver,
            TimeSpan.FromSeconds(Convert.ToDouble(ConfigManager.GetSettingsConfig()["TimeOut"])));

        public BaseElement(By locator, string name)
        {
            _locator = locator;
            _name = name;
        }

        public void Click()
        {
            Logger.Info($"Click by element '{_name}'");
            FindElement().Click();
        }

        public string GetText()
        {
            Logger.Info("Text:");
            return FindElement().Text;
        }

        public void MoveTo()
        {
            Driver.ExecuteJavaScript("scroll(0,600)");
        }

        public bool IsDisplayed()
        {
            Logger.Info($"Element '{_name}' is displayed");
            return FindElement().Displayed;
        }

        public WebElement FindElement()
        {
            return (WebElement) Wait.Until(d => d.FindElement(_locator));
        }

        public ReadOnlyCollection<IWebElement> FindElements()
        {
            return Wait.Until(d => d.FindElements(_locator));
        }
    }
}