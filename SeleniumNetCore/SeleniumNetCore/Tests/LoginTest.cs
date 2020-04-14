using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumNetCore.PageObjects;
using System;

namespace SeleniumNetCore.Tests
{
    [TestFixture]
    public class LoginTest
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new FirefoxDriver();
        }

        [Test]
        public void FirstFirefoxTest()
        {
            HomePage homePage = new HomePage(driver);
            homePage.GoToHomePage();
            homePage.ClickLoginButton();
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Dispose();
        }
    }
}