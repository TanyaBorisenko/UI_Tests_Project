using NLog;
using OpenQA.Selenium;

namespace UI_Tests_Project.FrameWork.Utils
{
    public class AlertActions
    {
        private IWebDriver Driver => WebDriverSingleton.WebDriver;
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        public bool IsAlertDisplayed()
        {
            try
            {
                Driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException ex)
            {
                _logger.Error("Alert is null");
                return false;
            }
        }

        public string AlertGetText()
        {
            var alertText = Driver.SwitchTo().Alert().Text;

            return alertText;
        }

        public void AcceptAlert()
        {
            Driver.SwitchTo().Alert().Accept();
        }

        public void SendKeys(string text)
        {
            Driver.SwitchTo().Alert().SendKeys(text);
        }
    }
}