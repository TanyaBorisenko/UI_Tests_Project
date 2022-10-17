using NUnit.Framework;
using UI_Tests_Project.FrameWork.Utils;
using UI_Tests_Project.TestProject.Pages;

namespace UI_Tests_Project.TestProject.Tests
{
    public class TestCase4HandlesTests : BaseTest
    {
        private readonly MainPage _mainPage = new();
        private readonly BrowserWindowsFormPage _browserWindowsFormPage = new();
        private readonly DriverUtil _driverUtil = new();
        private readonly LinksFormPage _linksFormPage = new();
        private readonly MenuForm _menuForm = new();

        [Test]
        public void TestCase_4()
        {
            //Open main page
            Assert.IsTrue(_mainPage.IsPageOpened(), "Main page should open");

            //Open browser windows form
            _mainPage.ClickAlertFrameWindowsButton();
            _menuForm.ClickBrowserWindowsButton();

            Assert.IsTrue(_browserWindowsFormPage.IsPageOpened(), "Browser windows page should open");

            //Open new tap
            _browserWindowsFormPage.ClickNewTabButton();
            _driverUtil.TabsActions.SwitchToTab(1);

            Assert.AreEqual(_driverUtil.TabsActions.GetNewTabUrl(), "https://demoqa.com/sample",
                "Url should be the same");

            //Close tab
            _driverUtil.TabsActions.CloseTab();
            _driverUtil.TabsActions.SwitchToTab(0);

            Assert.IsTrue(_browserWindowsFormPage.IsPageOpened(), "Page should open");

            //Open page with links form
            _menuForm.ClickElementsButton();
            _menuForm.ClickLinksButton();

            Assert.IsTrue(_linksFormPage.IsPageOpened(), "Links form page should open");

            //Open new tab with main page
            _linksFormPage.ClickHomeLinkButton();
            _driverUtil.TabsActions.SwitchToTab(1);

            Assert.IsTrue(_mainPage.IsPageOpened(), "Main page should open");

            //Resume to previous tab, page with links form open
            _driverUtil.TabsActions.SwitchToTab(0);

            Assert.IsTrue(_linksFormPage.IsPageOpened(), "Links form page should open");
        }
    }
}