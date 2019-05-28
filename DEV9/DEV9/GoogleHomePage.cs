using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DEV9
{
    class GoogleHomePage
    {
        By readLetterLocator = By.XPath("//div[@class='Cp']//table/tbody/tr[1]");
        By answerButtonLocator = By.XPath("//div[@class='amn']/span[contains(.,'Ответить')]");
        By newLetterTypeLocator = By.XPath("//div[@aria-label='Тело письма']");         
        By sendButtonLocator = By.XPath("//div[@class='dC']/div[1]");
        WebDriverWait wait;
        IWebElement element;
        private ChromeDriver driver;

        public GoogleHomePage(ChromeDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromMinutes(2));
        }

        public GoogleHomePage ReadLetter()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(readLetterLocator));            
            element = wait.Until(r => driver.FindElement(readLetterLocator));
            element.FindElement(readLetterLocator).Click();
            return this;
        }

        public GoogleHomePage ClickAnswerButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(answerButtonLocator));
            element = wait.Until(r => driver.FindElement(answerButtonLocator));
            element.FindElement(answerButtonLocator).Click();
            return this;

        }

        public GoogleHomePage typeNewLetter(String text)
        {
            driver.FindElement(newLetterTypeLocator);
            driver.FindElement(newLetterTypeLocator).Click();
            driver.FindElement(newLetterTypeLocator).Clear();
            driver.FindElement(newLetterTypeLocator).SendKeys(text);
            return this;
        }

        public GoogleHomePage SendLetter()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(sendButtonLocator));
            element = wait.Until(r => driver.FindElement(sendButtonLocator));
            element.FindElement(sendButtonLocator).Click();
            return this;
        }
    }
}
