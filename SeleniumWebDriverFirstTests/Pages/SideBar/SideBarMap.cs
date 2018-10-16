using System;
using OpenQA.Selenium;

namespace SeleniumWebDriverFirstTests.Pages.SideBar
{
    public partial class SideBarPage
    {

        public IWebElement RegistrationButton => _driver.FindElement(By.Id("dragable button"));



    }
}
