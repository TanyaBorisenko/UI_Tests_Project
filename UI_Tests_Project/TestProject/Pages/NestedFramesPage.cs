using OpenQA.Selenium;
using UI_Tests_Project.FrameWork;

namespace UI_Tests_Project.TestProject.Pages
{
    public class NestedFramesPage : BaseForm
    {
        private static Label Header => new(By.XPath("//div[@class='main-header'][contains(text(),'Nested Frames')]"),
            "Nested frames page header");

        private static Label ParentIframe => new(By.Id("frame1"), "IFrame");
        private static Label GetParentText => new(By.XPath("//body"), "Parent frame text");
        private static Label GetChildText => new(By.XPath("//body"), "Child frame text");

        public NestedFramesPage() : base(Header, "Nested frames")
        {
        }

        public string GetParentIframeText()
        {
            DriverUtil.FrameActions.SwitchToIframe(ParentIframe);
            var textParentFrame = GetParentText.GetText();

            return textParentFrame;
        }

        public string GetChildIframeText()
        {
            DriverUtil.FrameActions.SwitchToInnerIframe();
            var textChildFrame = GetChildText.GetText();
            DriverUtil.FrameActions.LeaveIFrame();

            return textChildFrame;
        }
    }
}