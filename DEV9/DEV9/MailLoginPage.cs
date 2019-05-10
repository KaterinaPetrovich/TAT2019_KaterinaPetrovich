using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Globalization;
using System.Threading.Tasks;


namespace DEV9
{
    public class MailLoginPage
    {
        By usernameLocator = By.XPath("//input[@id='mailbox:login']");
        By passwordLocator = By.XPath("//input[@id='mailbox:password']");
        By loginButtonLocator = By.XPath("//input[@class='o-control']");
        WebDriverWait wait;
        IWebElement element;

        private ChromeDriver driver;

        public MailLoginPage(ChromeDriver driver)
        {
            this.driver = driver;
            driver.Navigate().GoToUrl("https://mail.ru/");
            wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));           
        }

        public MailLoginPage typeUsername(String username)
        {
            element = wait.Until(r => driver.FindElement(usernameLocator));
            element.FindElement(usernameLocator).SendKeys(username);                     
            return this;
        }

        public MailLoginPage typePassword(String password)
        {
            element = wait.Until(r => driver.FindElement(passwordLocator));
            element.FindElement(passwordLocator).SendKeys(password);
            return this;
        }

        public HomePage Enter()
        {
            element = wait.Until(r => driver.FindElement(loginButtonLocator));
            driver.FindElement(loginButtonLocator).Submit();
            return new HomePage(driver);
        }

        public HomePage loginAs(String username, String password)
        {
            typeUsername(username);
            typePassword(password);
            return Enter();
        }
    }
}
