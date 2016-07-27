using System;
using OpenQA.Selenium;

namespace HomeAway.POM
{
    public class BasePage
    {
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        protected IWebDriver driver { get; set; }

        public IWebElement FindElementByXpath(String xpath)
        {
            return this.driver.FindElement(By.XPath(xpath));
        }

        public String GetText(String controlName)
        {
            return FindElementByXpath(controlName).Text;
        }

        public void SetValue(String controlName, String value)
        {
            FindElementByXpath(controlName).SendKeys(value);
        }

        public void Click(String controlName)
        {
            FindElementByXpath(controlName).Click();
        }

        public bool IsVisible(String controlName)
        {
            return FindElementByXpath(controlName).Displayed;
        }
    }
}
