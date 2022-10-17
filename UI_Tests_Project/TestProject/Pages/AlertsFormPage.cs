using NLog;
using OpenQA.Selenium;
using UI_Tests_Project.FrameWork;
using UI_Tests_Project.FrameWork.Utils;

namespace UI_Tests_Project.TestProject.Pages
{
    public class AlertsFormPage : BaseForm
    {
        private static Label Header => new(By.XPath("//div[@class='main-header'][contains(text(),'Alerts')]"),
            "Alerts form page header");

        private static Label ConfirmResult => new(By.Id("confirmResult"), "Confirm result");
        private static Label PromptResult => new(By.Id("promptResult"), "Prompt result");

        private static Button PromptBoxButton =>
            new(By.XPath("//div[@class='col']//*[contains(@id,'promtButton')]"), "Prompt button");

        private static Button ConfirmBoxButton =>
            new(By.XPath("//div[@class='col']//*[contains(@id,'confirmButton')]"), "Confirm button");

        private static Button SeeAlertButton =>
            new(By.XPath("//div[@class='col']//*[contains(@id,'alertButton')]"), "Alert button");

        private static Logger _logger = LogManager.GetCurrentClassLogger();

        public AlertsFormPage() : base(Header, "Alerts form page")
        {
        }

        public void ClickSeeAlertButton()
        {
            SeeAlertButton.Click();
        }

        public void ClickConfirmBoxButton()
        {
            ConfirmBoxButton.Click();
        }

        public string GetConfirmResultText()
        {
            var resultText = ConfirmResult.GetText();

            return resultText;
        }

        public void ClickPromptBoxButton()
        {
            PromptBoxButton.Click();
        }

        public string EnterGeneratedName()
        {
            var output = TestDataGenerated.GenerateSomeName();

            _logger.Info($"Person name {output}");

            return output;
        }

        public string GetPromptResultText()
        {
            var resultText = PromptResult.GetText();

            return resultText;
        }
    }
}