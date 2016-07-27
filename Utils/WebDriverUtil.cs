using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace HomeAway.Utils
{
    public class WebDriverUtil
    {
        private static IWebDriver driver;
        private static long implicitlyWaitTimeout = 2;
        private WebDriverUtil() { }

        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(GetImplicitlyWaitTimeout()));
                driver.Manage().Window.Maximize();
            }
            return driver;
        }

        public static void DeleteDriver()
        {
            if (driver != null)
            {
                driver.Quit();
            }
            driver = null;
        }

        public static long GetImplicitlyWaitTimeout()
        {
            return implicitlyWaitTimeout;
        }

        public static void LoadPage(String path)
        {
            GetDriver().Navigate().GoToUrl(path);
        }
    }
}
