using System;
using OpenQA.Selenium;
using NUnit.Framework;

namespace HomeAway.POM
{
    public class RegistrationPage : BasePage
    {
        public RegistrationPage(IWebDriver driver) : base(driver)
        {
        }

        public String pageHeader = "//h4";
        public String firstNameInput = "//input[@name='user[first_name]']";
        public String lastNameInput = "//input[@name='user[last_name]']";
        public String emailInput = "//input[@name='user[email]']";
        public String passwordInput = "//input[@name='user[password]']";
        public String registerButton = "//input[@data-tkey='Sign Up']";

        public RegistrationPage VerifyPageHeaderText(String expectedHeaderText)
        {
            String actualHeaderText = this.GetText(this.pageHeader);
            Assert.AreEqual(expectedHeaderText, actualHeaderText);
            return new RegistrationPage(driver);
        }

        public RegistrationPage VerifyFirstNameInputIsVisible(bool expectedResult = true)
        {
            bool actualResult = this.IsVisible(this.firstNameInput);
            Assert.IsTrue(expectedResult.Equals(actualResult));
            return new RegistrationPage(driver);
        }

        public RegistrationPage VerifyLastNameInputIsVisible(bool expectedResult = true)
        {
            bool actualResult = this.IsVisible(this.lastNameInput);
            Assert.IsTrue(expectedResult.Equals(actualResult));
            return new RegistrationPage(driver);
        }

        public RegistrationPage VerifyEmailInputIsVisible(bool expectedResult = true)
        {
            bool actualResult = this.IsVisible(this.emailInput);
            Assert.IsTrue(expectedResult.Equals(actualResult));
            return new RegistrationPage(driver);
        }
        public RegistrationPage VerifyPasswordInputIsVisible(bool expectedResult = true)
        {
            bool actualResult = this.IsVisible(this.passwordInput);
            Assert.IsTrue(expectedResult.Equals(actualResult));
            return new RegistrationPage(driver);
        }

        public RegistrationPage VerifyRegisterButtonIsVisible(bool expectedResult = true)
        {
            bool actualResult = this.IsVisible(this.registerButton);
            Assert.IsTrue(expectedResult.Equals(actualResult));
            return new RegistrationPage(driver);
        }
    }
}
