using NUnit.Framework;
using UI_Tests_Project.TestProject.Pages;

namespace UI_Tests_Project.TestProject.Tests
{
    public class TestCase2IframeTests : BaseTest
    {
        private readonly MainPage _mainPage = new();
        private readonly NestedFramesPage _nestedFramesPage = new();
        private readonly FramesPage _framesPage = new();
        private readonly MenuForm _menuForm = new();

        [Test]
        public void TestCase_2()
        {
            //Open main page
            Assert.IsTrue(_mainPage.IsPageOpened(), "Main page should open");

            //Open nested frames page, messages are present
            _mainPage.ClickAlertFrameWindowsButton();
            _menuForm.ClickNestedFramesButton();
            _nestedFramesPage.IsPageOpened();

            var parentText = _nestedFramesPage.GetParentIframeText();
            Assert.AreEqual(parentText, "Parent frame", "Text should be the same");

            var childText = _nestedFramesPage.GetChildIframeText();
            Assert.AreEqual(childText, "Child Iframe", "Text should be the same");

            //Open frames page,compare text
            _menuForm.ClickFramesButton();
            _framesPage.IsPageOpened();
            var firstFrameText = _framesPage.GetFirstIframeText();
            var secondFrameText = _framesPage.GetSecondIframeText();

            Assert.AreEqual(firstFrameText, secondFrameText, "Text should be the same");
        }
    }
}