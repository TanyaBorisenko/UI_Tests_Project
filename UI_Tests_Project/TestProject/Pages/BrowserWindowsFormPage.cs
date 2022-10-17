using OpenQA.Selenium;
using UI_Tests_Project.FrameWork;

namespace UI_Tests_Project.TestProject.Pages
{
    public class BrowserWindowsFormPage : BaseForm
    {
        private static Label Header => new(By.XPath("//div[@class='main-header'][contains(text(),'Browser Windows')]"),
            "Browser windows page header");

        private static Button NewTabButton => new(By.XPath("//button[@id='tabButton']"), "New tab button");

        public BrowserWindowsFormPage() : base(Header, "Browser windows")
        {
        }

        public void ClickNewTabButton()
        {
            NewTabButton.Click();
        }
    }
}