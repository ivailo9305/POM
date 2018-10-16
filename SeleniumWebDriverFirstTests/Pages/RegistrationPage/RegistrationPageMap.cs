using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWebDriverFirstTests.Pages.RegistrationPage
{
    public partial class RegistrationPage
    {

        public IWebElement HeaderMessage => this._driver.FindElement(By.ClassName("entry-title"));

        public IWebElement FirstName => this._driver.FindElement(By.Id("name_3_firstname"));

        public IWebElement LastName => this._driver.FindElement(By.Id("name_3_lastname"));

        public IWebElement MatrialStatus => this._driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[2]/div/div/input[1]"));

        public List<IWebElement> Hobbies => this._driver.FindElements(By.Name("checkbox_5[]")).ToList();

        public IWebElement Country => this._driver.FindElement(By.Id("dropdown_9"));

        public SelectElement CountryOption => new SelectElement(this.Country);

        public IWebElement Month => this._driver.FindElement(By.Id("mm_date_8"));

        public SelectElement MonthOption => new SelectElement(this.Month);

        public IWebElement Day => this._driver.FindElement(By.Id("dd_date_8"));

        public SelectElement DayOption => new SelectElement(this.Day);

        public IWebElement Year => this._driver.FindElement(By.Id("yy_date_8"));

        public SelectElement YearOption => new SelectElement(this.Year);

        public IWebElement Phone => this._driver.FindElement(By.Id("phone_9"));

        public IWebElement UserName => this._driver.FindElement(By.Id("username"));

        public IWebElement Email => this._driver.FindElement(By.Id("email_1"));

        public IWebElement UploadPicButton => this._driver.FindElement(By.Id("profile_pic_10"));

        public IWebElement Description => Wait.Until(d => d.FindElement(By.Id("description")));

        public IWebElement Password => this._driver.FindElement(By.Id("password_2"));

        public IWebElement ConfirmPassword => this._driver.FindElement(By.Id("confirm_password_password_2"));

        public IWebElement SubmitButton => this._driver.FindElement(By.Name("pie_submit"));

        public IWebElement RegistrationMessage => this._driver.FindElement(By.ClassName("piereg_message"));

        public IWebElement NameErrorMessage => this._driver.FindElement(By.XPath(@"//*[@id=""pie_register""]/li[1]/div[1]/div[2]/span"));

        public IWebElement PhoneErrorMessage => this._driver.FindElement(By.XPath(@"//*[@i"));

        public IWebElement RegPageValidation => this._driver.FindElement(By.Id("gdfs"));
    }
}
