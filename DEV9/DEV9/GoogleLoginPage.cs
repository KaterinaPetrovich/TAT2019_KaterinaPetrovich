using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DEV9
{
    class GoogleLoginPage
    {
        By usernameLocator = By.XPath("//input[@type='email']");
        By ButtonEnterLocator = By.XPath("//span[contains(.,'Далее')]");
        By passwordLocator = By.XPath("//input[@type='password']");
        By loginButtonLocator = By.XPath("//input[@class='o-control']");
        WebDriverWait wait;
        IWebElement element;

        private ChromeDriver driver;

        public GoogleLoginPage(ChromeDriver driver)
        {
            this.driver = driver;
            driver.Navigate().GoToUrl("https://accounts.google.com/signin/v2/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&service=mail&sacu=1&rip=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin");
            wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
        }

        public GoogleLoginPage typeUsername(String username)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(usernameLocator));
            element = wait.Until(r => driver.FindElement(usernameLocator));
            element.FindElement(usernameLocator).SendKeys(username);
            return this;
        }

        public GoogleLoginPage ClickEnter()
        {
            element = wait.Until(r => driver.FindElement(ButtonEnterLocator));
            driver.FindElement(ButtonEnterLocator).Click();
            return this;
        }


        public GoogleLoginPage typePassword(String password)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(passwordLocator));
            element = wait.Until(r => driver.FindElement(passwordLocator));
            element.FindElement(passwordLocator).SendKeys(password);
            return this;
        }

        public GoogleHomePage loginAs(String username, String password)
        {
            typeUsername(username);
            ClickEnter();
            typePassword(password);
            ClickEnter();
            return new GoogleHomePage(driver);
        }
    }
}

