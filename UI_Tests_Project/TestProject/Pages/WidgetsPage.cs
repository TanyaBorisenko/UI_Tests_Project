using OpenQA.Selenium;
using UI_Tests_Project.FrameWork;

namespace UI_Tests_Project.TestProject.Pages
{
    public class WidgetsPage : BaseForm
    {
        private static Label Header => new(By.XPath("//div[@class='main-header'][contains(text(),'Widgets')]"),
            "Widgets page header");

        public WidgetsPage() : base(Header, "Widgets page")
        {
        }
    }
}