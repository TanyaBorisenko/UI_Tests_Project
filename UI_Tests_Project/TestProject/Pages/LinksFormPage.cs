using OpenQA.Selenium;
using UI_Tests_Project.FrameWork;

namespace UI_Tests_Project.TestProject.Pages
{
    public class LinksFormPage : BaseForm
    {
        private static Label Header => new(By.XPath("//div[@class='main-header'][contains(text(),'Links')]"),
            "Links form page header");

        private static Button HomeLinkButton => new(By.Id("simpleLink"), "Home link");

        public LinksFormPage() : base(Header, "Links page")
        {
        }

        public void ClickHomeLinkButton()
        {
            HomeLinkButton.Click();
        }
    }
}