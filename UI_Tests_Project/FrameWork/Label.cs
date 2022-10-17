using OpenQA.Selenium;

namespace UI_Tests_Project.FrameWork
{
    public class Label : BaseElement
    {
        public Label(By locator, string name) : base(locator, name)
        {
        }
    }
}