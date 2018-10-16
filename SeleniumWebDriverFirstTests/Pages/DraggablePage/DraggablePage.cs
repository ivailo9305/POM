using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWebDriverFirstTests.Pages.DraggablePage
{
    public partial class DraggablePage:BasePage
    {
        private IWebDriver _driver;

        public DraggablePage(IWebDriver driver)
            :base (driver)
        {


        }
        public string URL =>this.URL+"draggable/";
            
     

       
    }
}
 