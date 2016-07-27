using HomeAway.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace HomeAway.TC
{
    public class BaseTestCase
    {
        protected IWebDriver driver;
        String url = "https://www.homeaway.ru/login";

        [SetUp]
        public void SetUp()
        {
            driver = WebDriverUtil.GetDriver();
            WebDriverUtil.LoadPage(url);
        }

        [TearDown]
        public void TearDown()
        {
            WebDriverUtil.DeleteDriver();
        }
    }
}
