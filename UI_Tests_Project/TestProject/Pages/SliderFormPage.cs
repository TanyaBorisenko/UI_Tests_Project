using OpenQA.Selenium;
using UI_Tests_Project.FrameWork;
using UI_Tests_Project.FrameWork.Utils;

namespace UI_Tests_Project.TestProject.Pages
{
    public class SliderFormPage : BaseForm
    {
        private static Label Header => new(By.XPath("//div[@class='main-header'][contains(text(),'Slider')]"),
            "Slider form page header");

        private static Label Slider =>
            new(By.XPath("//div[@id='sliderContainer']//span[@class='range-slider__wrap']//*[contains(@type,'range')]"),
                "Slider");

        private static Label GetPageSliderValue => new(By.Id("sliderValue"), "Slider value on the page");

        public SliderFormPage() : base(Header, "Slider form page")
        {
        }

        public string SetSliderValue()
        {
            var slider = Slider.FindElement();
            var getMaxValue = int.Parse(slider.GetAttribute("max"));

            var pixelsToMove = DriverUtil.GetPixelsToMove
                (slider, TestDataGenerated.GenerateSomeNumber(0, getMaxValue), getMaxValue, 0);

            DriverUtil.Action.ClickAndHold(slider).MoveByOffset(pixelsToMove, 0).Release().Perform();

            return slider.GetAttribute("value");
        }

        public string GetValueOnThePage()
        {
            return GetPageSliderValue.FindElement().GetAttribute("value");
        }
    }
}