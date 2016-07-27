using System;
using OpenQA.Selenium;
using NUnit.Framework;

namespace HomeAway.POM
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public String pageHeader = "//h2";
        public String userPanel = "//span[@class='hi']";
        public String logoutLink = "//li/a[@href='/logout']";

        public HomePage VerifyPageHeaderText(String expectedHeaderText)
        {
            String actualHeaderText = this.GetText(this.pageHeader);
            Assert.AreEqual(expectedHeaderText, actualHeaderText);
            return new HomePage(driver);
        }

        public LoginPage Logout()
        {
            this.Click(this.userPanel);
            this.Click(this.logoutLink);
            return new LoginPage(driver);
        }
    }
}
