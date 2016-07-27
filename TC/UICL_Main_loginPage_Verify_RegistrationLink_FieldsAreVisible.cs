using HomeAway.POM;
using HomeAway.TC;
using HomeAway.Users;
using NUnit.Framework;
using System;

namespace HomeAway
{
    public class UICL_Main_loginPage_Verify_RegistrationLink_FieldsAreVisible : BaseTestCase
    { 
        [Test]
        public void ATC_UICL_Main_loginPage_Verify_RegistrationLink_FieldsAreVisible()
        {
            String expectedLoginPageHeader = "Регистрация";
            User user = new User();
            LoginPage loginPage = new LoginPage(driver);

            loginPage
                .ClickRegistrationLink()
                .VerifyPageHeaderText(expectedLoginPageHeader)
                .VerifyFirstNameInputIsVisible()
                .VerifyLastNameInputIsVisible()
                .VerifyEmailInputIsVisible()
                .VerifyPasswordInputIsVisible()
                .VerifyRegisterButtonIsVisible();
        }
    }
}
