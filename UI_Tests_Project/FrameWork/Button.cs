using OpenQA.Selenium;

namespace UI_Tests_Project.FrameWork
{
    public class Button : BaseElement
    {
        public Button(By locator, string name) : base(locator, name)
        {
        }
    }
}