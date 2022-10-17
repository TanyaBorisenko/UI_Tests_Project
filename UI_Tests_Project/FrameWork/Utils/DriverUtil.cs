using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace UI_Tests_Project.FrameWork.Utils
{
    public class DriverUtil
    {
        private IWebDriver Driver => WebDriverSingleton.WebDriver;
        public Actions Action => new(Driver);
        public AlertActions AlertActions => new();
        public TabsActions TabsActions => new();
        public FrameActions FrameActions => new();

        public int GetPixelsToMove(IWebElement slider, decimal amount, decimal sliderMax, decimal sliderMin)
        {
            int pixels = 0;
            decimal tempPixels = slider.Size.Width;
            tempPixels = tempPixels / (sliderMax - sliderMin);
            tempPixels = tempPixels * (amount - sliderMin);
            pixels = Convert.ToInt32(tempPixels);
            return pixels;
        }
    }
}