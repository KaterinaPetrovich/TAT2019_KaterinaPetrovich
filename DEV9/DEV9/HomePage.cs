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
    public class HomePage
    {
        By newLetterButtonLocator = By.XPath("//span[contains(.,'Написать письмо')]");
        By adressLocator = By.XPath("//textarea[@tabindex='4']");
        By newLetterTypeLocator = By.XPath(".//tr[@class='mceFirst mceLast']//iframe");
        By sendButtonLocator = By.XPath("//span[contains(.,'Отправить')]");
        WebDriverWait wait;
        IWebElement element;
        private ChromeDriver driver;

        public HomePage(ChromeDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromMinutes(2));
        }

        public HomePage ClickNewLetterButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(newLetterButtonLocator));
            element = wait.Until(r => driver.FindElement(newLetterButtonLocator));
            element.FindElement(newLetterButtonLocator).Click();
            return this;
        }

        public HomePage typeAdress(String adress)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(adressLocator));
            element = wait.Until(r => driver.FindElement(adressLocator));
            element.FindElement(adressLocator).SendKeys(adress);
            return this;
        }

        public HomePage typeNewLetter(String text)
        {
            driver.SwitchTo().Frame(driver.FindElement(newLetterTypeLocator));
            driver.FindElement(By.Id("tinymce")).Click();
            driver.FindElement(By.Id("tinymce")).Clear();
            driver.FindElement(By.Id("tinymce")).SendKeys(text);
            driver.SwitchTo().DefaultContent();
            return this;
        }

        public HomePage Send()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(sendButtonLocator));
            element = wait.Until(r => driver.FindElement(sendButtonLocator));
            element.FindElement(sendButtonLocator).Click();
            return this;
        }
        public HomePage SendMessage(String adress, String text)
        {
            ClickNewLetterButton();
            typeAdress(adress);
            typeNewLetter(text);
            return Send();
        }

    }
}