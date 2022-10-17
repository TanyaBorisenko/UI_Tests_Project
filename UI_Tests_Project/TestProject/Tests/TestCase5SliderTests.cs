using NUnit.Framework;
using UI_Tests_Project.TestProject.Pages;

namespace UI_Tests_Project.TestProject.Tests
{
    public class TestCase5SliderTests : BaseTest
    {
        private readonly MainPage _mainPage = new();
        private readonly SliderFormPage _sliderFormPage = new();
        private readonly ProgressBarFormPage _progressBarFormPage = new();
        private readonly MenuForm _menuForm = new();

        [Test]
        public void TestCase_5()
        {
            //Open main page
            Assert.IsTrue(_mainPage.IsPageOpened(), "Main page should open");

            //Open slider form page
            _mainPage.ClickWidgetsButton();
            _menuForm.ClickSliderButton();

            Assert.IsTrue(_sliderFormPage.IsPageOpened(), "Slider form page should open");

            //Set slider random value, compare set value and page value
            var setValue = _sliderFormPage.SetSliderValue();
            var getPageValue = _sliderFormPage.GetValueOnThePage();

            Assert.AreEqual(setValue, getPageValue, "Values must be the same");

            //Open progress bar form page
            _menuForm.ClickProgressBarButton();

            Assert.IsTrue(_progressBarFormPage.IsPageOpened(), "Progress bar page should open");

            //Click on Stop button, when value displayed on progress bar becomes equals to my age
            _progressBarFormPage.ClickStartStopButton();

            Assert.IsTrue(_progressBarFormPage.StopProgressBar(), "Value should be +-27");
        }
    }
}