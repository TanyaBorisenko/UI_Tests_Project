using OpenQA.Selenium;
using UI_Tests_Project.FrameWork;

namespace UI_Tests_Project.TestProject.Pages
{
    public class ProgressBarFormPage : BaseForm
    {
        private static Label Header => new(By.XPath("//div[@class='main-header'][contains(text(),'Progress Bar')]"),
            "Progress bar page header");

        private static Button StartStopButton =>
            new(By.XPath("//div[@id='progressBar']//following::button[contains(@id,'startStopButton')]"),
                "Start and stop button");

        private static Label ProgressValue =>
            new(By.XPath("//div[@role='progressbar']"), "Progress value");

        public ProgressBarFormPage() : base(Header, "Progress bar page")
        {
        }

        public void ClickStartStopButton()
        {
            StartStopButton.MoveTo();
            StartStopButton.Click();
        }

        public bool StopProgressBar()
        {
            int counter = 0;
            while (counter <= 25)
            {
                var value = ProgressValue.FindElement().GetAttribute("aria-valuenow");
                var percentage = int.Parse(value);
                if (percentage <= 25)
                {
                    StartStopButton.Click();
                }

                counter = percentage;
            }

            return counter <= 29;
        }
    }
}