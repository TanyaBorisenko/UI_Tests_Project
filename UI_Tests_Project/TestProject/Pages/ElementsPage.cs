using OpenQA.Selenium;
using UI_Tests_Project.FrameWork;

namespace UI_Tests_Project.TestProject.Pages
{
    public class ElementsPage : BaseForm
    {
        private static Label Header => new(By.XPath("//div[@class='main-header'][contains(text(),'Elements')]"),
            "Elements page header");

        public ElementsPage() : base(Header, "Elements page")
        {
        }
    }
}