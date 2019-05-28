using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace DEV9
{
    class Program
    {
        static void Main(string[] args)
        {
            ChromeDriver chromeDriver = new ChromeDriver();
            MailLoginPage mailLoginPage = new MailLoginPage(chromeDriver);
            HomePage homePage = mailLoginPage.loginAs("kofevm", "AcdE*123nnn");
            homePage.SendMessage("chaineskuchai@gmail.com", "hello!");
            GoogleLoginPage googleLoginPage = new GoogleLoginPage(chromeDriver);            
            GoogleHomePage googlehomePage = googleLoginPage.loginAs("chaineskuchai@gmail.com", "AcdE*123");
            googlehomePage.ReadLetter();
            googlehomePage.ClickAnswerButton();
            googlehomePage.typeNewLetter("text");
            googlehomePage.SendLetter();

        }
    }
}
