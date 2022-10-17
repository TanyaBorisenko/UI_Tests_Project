using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace UI_Tests_Project.FrameWork.Utils
{
    public class TabsActions
    {
        private IWebDriver Driver => WebDriverSingleton.WebDriver;

        public string GetNewTabUrl()
        {
            return Driver.Url;
        }

        public void CloseTab()
        {
            Driver.Close();
        }

        public IReadOnlyCollection<string> GetTabs()
        {
            return Driver.WindowHandles;
            ;
        }

        private void CloseAndSwitch(string name, bool closeCurrent)
        {
            if (closeCurrent)
            {
                CloseTab();
            }

            Driver.SwitchTo().Window(name);
        }

        public void SwitchToTab(int index, bool closeCurrent = false)
        {
            var tabNames = GetTabs();
            if (index < 0 || tabNames.Count <= index)
            {
                throw new ArgumentOutOfRangeException
                    ($"Index of browser tab '{index}' you provided is out of range {0}..{tabNames.Count}");
            }

            var newTab = tabNames.ElementAt(index);
            CloseAndSwitch(newTab, closeCurrent);
        }
    }
}