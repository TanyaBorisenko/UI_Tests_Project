using OpenQA.Selenium;
using UI_Tests_Project.FrameWork;

namespace UI_Tests_Project.TestProject.Pages
{
    public class FramesPage : BaseForm
    {
        private static Label FirstIframe => new(By.XPath("//iframe[@id='frame1']"), "First IFrame");
        private static Label SecondIframe => new(By.XPath("//iframe[@id='frame2']"), "Second IFrame");

        private static Label GetText => new(By.XPath("//body"), "Get frame text");

        private static Label Header => new(By.XPath("//div[@class='main-header'][contains(text(),'Frames')]"),
            "Frames page header");

        public FramesPage() : base(Header, "Frames page")
        {
        }

        public string GetFirstIframeText()
        {
            DriverUtil.FrameActions.SwitchToIframe(FirstIframe);
            var textFirstFrame = GetText.GetText();

            return textFirstFrame;
        }

        public string GetSecondIframeText()
        {
            DriverUtil.FrameActions.LeaveIFrame();
            DriverUtil.FrameActions.SwitchToIframe(SecondIframe);
            var textSecondFrame = GetText.GetText();

            return textSecondFrame;
        }
    }
}