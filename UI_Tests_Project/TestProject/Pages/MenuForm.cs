using OpenQA.Selenium;
using UI_Tests_Project.FrameWork;

namespace UI_Tests_Project.TestProject.Pages
{
    public class MenuForm : BaseForm
    {
        public static Label LeftPanel => new(By.XPath("//div[@class='left-pannel']"), "Left panel");

        private static Button AlertsButton =>
            new(By.XPath("//div[@class='element-list collapse show']//*[contains(@id,'item-1')]"), "Alerts button");

        private static Button NestedFramesButton =>
            new(By.XPath("//div[@class='element-list collapse show']//*[contains(@id,'item-3')]"),
                "Nested frames button");

        private static Button BrowserWindowsButton =>
            new(By.XPath("//div[@class='element-list collapse show']//*[contains(@id,'item-0')]"),
                "Browser windows button");

        private static Button WebTablesButton =>
            new(By.XPath("//div[@class='element-list collapse show']//*[contains(@id,'item-3')]"), "Web tables button");

        private static Button SliderButton =>
            new(By.XPath("//div[@class='element-list collapse show']//*[contains(@id,'item-3')]"), "Slider button");

        private static Button ProgressBarButton =>
            new(By.XPath("//div[@class='element-list collapse show']//*[contains(@id,'item-4')]"),
                "Progress bar button");

        private static Button FramesButton =>
            new(By.XPath("//div[@class='element-list collapse show']//*[contains(@id,'item-2')]"), "Frames button");

        private static Button ElementsButton =>
            new(By.XPath("//div[@class='element-group']//*[contains(text(),'Elements')]"), "Elements button");

        private static Button LinksButton =>
            new(By.XPath("//ul[@class='menu-list']//*[contains(@id,'item-5')]"), "Links button");

        public MenuForm() : base(LeftPanel, "Left panel")
        {
        }

        public void ClickLinksButton()
        {
            LinksButton.MoveTo();
            LinksButton.Click();
        }

        public void ClickElementsButton()
        {
            ElementsButton.Click();
        }

        public void ClickFramesButton()
        {
            FramesButton.MoveTo();
            FramesButton.Click();
        }

        public void ClickProgressBarButton()
        {
            ProgressBarButton.MoveTo();
            ProgressBarButton.Click();
        }

        public void ClickSliderButton()
        {
            SliderButton.MoveTo();
            SliderButton.Click();
        }

        public void ClickWebTablesButton()
        {
            WebTablesButton.MoveTo();
            WebTablesButton.Click();
        }

        public void ClickAlertsButton()
        {
            AlertsButton.MoveTo();
            AlertsButton.Click();
        }

        public void ClickNestedFramesButton()
        {
            NestedFramesButton.MoveTo();
            NestedFramesButton.Click();
        }

        public void ClickBrowserWindowsButton()
        {
            BrowserWindowsButton.MoveTo();
            BrowserWindowsButton.Click();
        }
    }
}