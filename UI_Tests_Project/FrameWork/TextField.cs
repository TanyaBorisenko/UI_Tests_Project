using OpenQA.Selenium;

namespace UI_Tests_Project.FrameWork
{
    public class TextField : BaseElement
    {
        public TextField(By locator, string locatorName) : base(locator, locatorName)
        {
        }

        public void SendKeys(string text)
        {
            FindElement().SendKeys(text);
        }
    }
}