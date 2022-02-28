using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace JoePizzaSelenium
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\alaaa\source\repos\Phase4\Project");
            driver.Navigate().GoToUrl("https://localhost:44381/Home/PizzaSelection");
            Thread.Sleep(1000);
            //Maximizaing the chrome window
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

            //Displaying the Pizza with the id = 1.
            IWebElement order = driver.FindElement(By.Id("1"));
            order.Click();
            Thread.Sleep(5000);

            //Adding the displayed Pizza to the checkout page and confirm the order.
            IWebElement purchase = driver.FindElement(By.Id("purchase"));
            purchase.Click();
            Thread.Sleep(5000);

            //Going back to the Pizza Selection page after Confirming the order.
            IWebElement back = driver.FindElement(By.Id("back"));
            back.Click();
            Thread.Sleep(5000);

            //Quiting the chrome page.
            driver.Quit();
        }
    }
}
