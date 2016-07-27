using System;
using OpenQA.Selenium;
using NUnit.Framework;

namespace HomeAway.POM
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
            this.driver = base.driver;
        }

        public String pageHeader = "//h4";
        public String emailInput = "//input[@id='email']";
        public String passwordInput = "//input[@id='password']";
        public String loginButton = "//button[@data-tkey='Sign In']";
        public String alert = "//div[@role='alert']";
        public String signInLink = "//a[@id='signin']";
        public String signUpLink = "//a[@id='signin-signup']";

        public HomePage Login(String login, String pass)
        {
            this.SetValue(this.emailInput, login);
            this.SetValue(this.passwordInput, pass);
            this.Click(this.loginButton);
            return new HomePage(driver);
        }

        public LoginPage LoginWithIncorrectCredentials(String login, String pass)
        {
            this.SetValue(this.emailInput, login);
            this.SetValue(this.passwordInput, pass);
            this.Click(this.loginButton);
            return new LoginPage(driver);
        }

        public RegistrationPage ClickRegistrationLink()
        {
            this.Click(this.signUpLink);
            return new RegistrationPage(driver);
        }

        public LoginPage VerifyPageHeaderText(String expectedHeaderText)
        {
            String actualHeaderText = this.GetText(this.pageHeader);
            Assert.AreEqual(expectedHeaderText, actualHeaderText);
            return new LoginPage(driver);
        }

        public LoginPage VerifyIncorrectLoginAlertText(String expectedAlertText)
        {
            String actualAlertText = this.GetText(this.alert);
            Assert.AreEqual(expectedAlertText, actualAlertText);
            return new LoginPage(driver);
        }

        public LoginPage VerifySigninLinkIsVisible(bool expectedResult = true)
        {
            bool actualResult = this.IsVisible(this.signInLink);
            Assert.IsTrue(expectedResult.Equals(actualResult));
            return new LoginPage(driver);
        }
    }
}
