using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;


namespace JoePizzaSpecFlow.Steps
{

    [Binding]

    public class Steps
    {
        private readonly ScenarioContext _scenarioContext;

        public Steps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        IWebDriver driver = new ChromeDriver(@"C:\Users\alaaa\source\repos\Phase4\Project");

        [Given(@"I Navigate to the page")]
        public void GivenINavigateToTheLoginPage()
        {


            driver.Navigate().GoToUrl("https://localhost:44381/Home/PizzaSelection");
            Thread.Sleep(1000);
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
            _scenarioContext.Pending();
        }
        [Then(@"Close the page")]
        public void ThenClosingthePage()
        {

            driver.Close();
            driver.Quit();
            _scenarioContext.Pending();
        }

        private string text = "Margherita";

        [Given(@"the following Data :")]

        public void GivenTheFollowingData()
        {
            var text = "Margherita";
            _scenarioContext.Pending();

        }

        [Then(@"MY BIDING SHOULD DO THAT")]
        public void ThenMYBIDINGSHOULDDOTHAT()
        {
            var actual = "Margherita";
            var expexted = "Margherita";
            if (!actual.Equals(expexted))
            {
                Assert.Fail("somthing wrong");
            }
            _scenarioContext.Pending();

        }

    }
}
