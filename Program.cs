using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Flipkart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.flipkart.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[@class='_2KpZ6l _2doB4z']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@name='q']")).SendKeys("IPad");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("(//li[@class='Y5N33s'])[1]")).Click();
            Thread.Sleep(10000);
            driver.FindElement(By.XPath("(//div[@class='_2kHMtA'])[1]")).Click();
            Thread.Sleep(2000);
            var NewWindow=driver.WindowHandles[1];
            driver.SwitchTo().Window(NewWindow);
            driver.FindElement(By.XPath("//button[@class='_2KpZ6l _2U9uOA _3v1-ww']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//span[text()='Cart']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("(//span[text()='Place Order'])/ancestor::button")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@class='_2IX_2- _17N0em']")).SendKeys("123456789");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[text()='CONTINUE']")).Click();
        }
    }
}