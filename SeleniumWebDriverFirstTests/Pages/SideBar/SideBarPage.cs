using System;
using OpenQA.Selenium;

namespace SeleniumWebDriverFirstTests.Pages.SideBar
{
    public partial  class SideBarPage
    {
        private IWebDriver _driver;
        public SideBarPage(IWebDriver driver)
        {
            this._driver = driver;
        }
    }
}
