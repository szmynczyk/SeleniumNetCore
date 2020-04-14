using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace SeleniumNetCore.PageObjects
{
    class HomePage
    {
        private readonly IWebDriver driver;

        const string LoginButtonLocator = ".login-button";


        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickLoginButton()
        {
            var loginButton = driver.FindElement(By.CssSelector(LoginButtonLocator));
            loginButton.Click();
        }

        internal void GoToHomePage()
        {
            driver.Navigate().GoToUrl(@"https://vitoguide-integration.viessmann.com/home");
        }
    }
}
