using HomeAway.POM;
using HomeAway.TC;
using HomeAway.Users;
using NUnit.Framework;
using System;

namespace HomeAway
{
    public class FTC_Main_LoginPage_Verify_Login_ValidCredentials : BaseTestCase
    {
        [Test]
        public void ATC_FTC_Main_LoginPage_Verify_Login_ValidCredentials()
        {
            String expectedLoginPageHeader = "Войти";
            String expectedAlertText = "Неверный адрес электронной почты или пароль. Попробуйте еще раз.";
            User user = new User();
            LoginPage loginPage = new LoginPage(driver);

            loginPage
                .LoginWithIncorrectCredentials(user.incorrectEmail, user.password)
                .VerifyPageHeaderText(expectedLoginPageHeader)
                .VerifyIncorrectLoginAlertText(expectedAlertText)
                .VerifySigninLinkIsVisible();
        }
    }
}
