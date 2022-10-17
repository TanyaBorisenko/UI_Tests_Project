using NUnit.Framework;
using UI_Tests_Project.FrameWork.Utils;
using UI_Tests_Project.TestProject.Pages;

namespace UI_Tests_Project.TestProject.Tests
{
    public class TestCase1AlertsTests : BaseTest
    {
        private readonly MainPage _mainPage = new();
        private readonly AlertsFormPage _alertsFormPage = new();
        private readonly DriverUtil _driverUtil = new();
        private readonly MenuForm _menuForm = new();

        [Test]
        public void TestCase_1()
        {
            //Open main page
            Assert.IsTrue(_mainPage.IsPageOpened(), "Main page should open");

            //Alerts form has appeared on page 
            _mainPage.ClickAlertFrameWindowsButton();
            _menuForm.ClickAlertsButton();

            Assert.IsTrue(_alertsFormPage.IsPageOpened(), "Alerts form should open");

            //Open alert with text "You clicked a button"
            _alertsFormPage.ClickSeeAlertButton();
            var alertSeeButtonText = _driverUtil.AlertActions.AlertGetText();

            Assert.AreEqual(alertSeeButtonText, "You clicked a button", "Text should be the same");

            //Close alert
            _driverUtil.AlertActions.AcceptAlert();

            Assert.False(_driverUtil.AlertActions.IsAlertDisplayed(), "Alert should be closed");

            //Open alert with text "Do you confirm action?"
            _alertsFormPage.ClickConfirmBoxButton();
            var alertConfirmButtonText = _driverUtil.AlertActions.AlertGetText();

            Assert.AreEqual(alertConfirmButtonText, "Do you confirm action?", "Text should be the same");

            //Close alert, compare text
            _driverUtil.AlertActions.AcceptAlert();

            Assert.AreEqual(_alertsFormPage.GetConfirmResultText(), "You selected Ok", "Text should be the same");

            //Open alert with text "Please enter your name"
            _alertsFormPage.ClickPromptBoxButton();
            var alertPromptButtonText = _driverUtil.AlertActions.AlertGetText();

            Assert.AreEqual(alertPromptButtonText, "Please enter your name", "Text should be the same");

            //Enter text, close alert, compare text
            var randomText = _alertsFormPage.EnterGeneratedName();
            _driverUtil.AlertActions.SendKeys(randomText);
            _driverUtil.AlertActions.AcceptAlert();

            Assert.AreEqual(_alertsFormPage.GetPromptResultText(), $"You entered {randomText}",
                "Text should be the same");
        }
    }
}