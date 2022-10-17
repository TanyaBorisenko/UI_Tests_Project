using OpenQA.Selenium;
using UI_Tests_Project.FrameWork;

namespace UI_Tests_Project.TestProject.Pages
{
    public class MainPage : BaseForm
    {
        private static Button ElementsButton =>
            new(By.XPath("//div[@class='card mt-4 top-card']//*[contains(text(),'Elements')]"), "Elements button");

        private static Button AlertFrameWindowsButton =>
            new(By.XPath("//div[@class='card mt-4 top-card']//*[contains(text(),'Alerts, Frame & Windows')]"),
                "AlertFrameWindows button");

        private static Button WidgetsButton =>
            new(By.XPath("//div[@class='card mt-4 top-card']//*[contains(text(),'Widgets')]"), "Widgets button");

        private static Label Banner =>
            new(By.XPath("//*[@alt='Selenium Online Training']"), "Page opened");

        public MainPage() : base(Banner, "Main Page")
        {
        }

        public void ClickAlertFrameWindowsButton()
        {
            AlertFrameWindowsButton.MoveTo();
            AlertFrameWindowsButton.Click();
        }

        public void ClickElementsButton()
        {
            ElementsButton.MoveTo();
            ElementsButton.Click();
        }

        public void ClickWidgetsButton()
        {
            WidgetsButton.MoveTo();
            WidgetsButton.Click();
        }
    }
}