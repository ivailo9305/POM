

namespace SeleniumWebDriverFirstTests.Pages.RegistrationPage
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    public partial class RegistrationPage:BasePage
    {

        private IWebDriver _driver;

        public RegistrationPage(IWebDriver driver){
            this._driver = driver;
        }
        public string URL => "www.ggbbg.gom";
            
        public WebDriverWait Wait => new WebDriverWait(_driver, TimeSpan.FromSeconds(3));

       
 
        public void FillRegistrationForm()
        {
            Type(FirstName, "Ventsislav");
            Type(LastName, "Ivanov");
            this.MatrialStatus.Click();
            this.Hobbies[0].Click();
            this.Hobbies[1].Click();
            CountryOption.SelectByText("Bulgaria");
            MonthOption.SelectByValue("3");
            DayOption.SelectByText("3");
            YearOption.SelectByValue("1989");
            Type(Phone, "359999999999");
            Type(UserName, "BatmanForever");
            Type(Email, "Ivanov8@abv.bg");
            UploadPicButton.Click();
            _driver.SwitchTo().ActiveElement().SendKeys(Path.GetFullPath(@"..\..\..\logo.jpg"));
            Wait.
            Type(Description, "I think I'm Ready with this test!");
            Type(Password, "123456789");
            Type(ConfirmPassword, "123456789");
            SubmitButton.Click();
        }

           

        private void Type(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }
    }
}
