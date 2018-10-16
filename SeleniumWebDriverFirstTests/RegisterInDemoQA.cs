namespace SeleniumWebDriverFirstTests
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Support.UI;
    using SeleniumWebDriverFirstTests.Pages;
    using SeleniumWebDriverFirstTests.Pages.DraggablePage;
    using SeleniumWebDriverFirstTests.Pages.RegistrationPage;
    using SeleniumWebDriverFirstTests.Pages.SideBar;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    [TestFixture]
    public class RegisterInDemoQA
    {
        private IWebDriver _driver;
        private SideBarPage _sidebarPage;
        private RegistrationPage _regPage;
        private DraggablePage _draggablePage;

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _driver.Url = "http://www.demoqa.com";
            _draggablePage = new DraggablePage(_driver);
            _sidebarPage = new SideBarPage(_driver);
            _sidebarPage.RegistrationButton.Click();

             


        }
        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }


        [Test]
        public void NavigateToRegistrationPage()
        {
            _regPage.NavigateTo();
            _sidebarPage.RegistrationButton.Click();

            Assert.IsTrue(_regPage.HeaderMessage.Displayed);
            StringAssert.Contains("Registration",_regPage.HeaderMessage.Text);
          
        }

        [Test]
        public void RegistrateWithValidData()
        {

        
            _sidebarPage.RegistrationButton.Click();
         


 
            Assert.IsTrue(_regPage.RegistrationMessage.Displayed);
            StringAssert.Contains("Registration",_regPage.RegPageValidation.Text);            
        }


        [Test]
        public void RegistrateWithoutName()
        {
            _sidebarPage.RegistrationButton.Click();
            _regPage.FillRegistrationForm();

           
             //invalid Xpath
            IWebElement nameError = _driver.FindElement(By.XPath("fvdsgdfbdf"));
            Assert.IsTrue(_regPage.NameErrorMessage.Displayed);
            Assert.AreEqual("This field is required", nameError.Text);
          
        }


        [Test]
        public void RegistrationWithoutPhonenumber()
        {
           
            _sidebarPage.RegistrationButton.Click();
            _regPage.FillRegistrationForm();

            //invalid Xpath
        

            Assert.IsTrue(_regPage.PhoneErrorMessage.Displayed);
            Assert.AreEqual("This field is required", _regPage.PhoneErrorMessage.Text);

        }


        [Test]
        public void DragableTest()
        {
 
        }

      
    }
}
