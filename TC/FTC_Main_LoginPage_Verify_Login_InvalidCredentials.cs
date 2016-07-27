using System;
using NUnit.Framework;
using HomeAway.POM;
using HomeAway.Users;
using HomeAway.TC;

namespace HomeAway
{
    [TestFixture]
    public class FTC_Main_LoginPage_Verify_Login_InvalidCredentials : BaseTestCase
    {
        [Test]
        public void ATC_FTC_Main_LoginPage_Verify_Login_InvalidCredentials()
        {
            String expectedPageHeader = "Откройте для себя лучшие апартаменты для отдыха";
            User user = new User();
            LoginPage loginPage = new LoginPage(driver);

            loginPage
                .Login(user.email, user.password)
                .VerifyPageHeaderText(expectedPageHeader)
                .Logout()
                .VerifySigninLinkIsVisible();
        }

       
    }
}
