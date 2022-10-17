using OpenQA.Selenium;

namespace UI_Tests_Project.FrameWork.Utils
{
    public class FrameActions
    {
        private IWebDriver Driver => WebDriverSingleton.WebDriver;

        public void SwitchToIframe(BaseElement element)
        {
            IWebElement webElement = element.FindElement();
            Driver.SwitchTo().Frame(webElement);
        }

        public void SwitchToInnerIframe()
        {
            Driver.SwitchTo().Frame(0);
        }

        public void LeaveIFrame()
        {
            Driver.SwitchTo().DefaultContent();
        }
    }
}