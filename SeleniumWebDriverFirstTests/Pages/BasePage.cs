using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWebDriverFirstTests.Pages
{
    public class BasePage
    {
        //new commit
        private IWebDriver _driver;

        public BasePage(IWebDriver driver){
            this._driver = driver;
        }
        private string URL => "www.ggbbg.gom";
            
        public WebDriverWait Wait => new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
        public IWebDriver Driver => this._driver;
       
        public void NavigateTo(){
            this.Driver.Url = this.URL;
        }

    }
}
