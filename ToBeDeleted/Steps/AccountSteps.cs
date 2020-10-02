using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace ToBeDeleted.Steps
{
    [Binding]
    public class AccountsSteps
    {
        [Given(@"user opened browser")]
        public void GivenUserOpenedBrowser()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://docs.microsoft.com/en-us/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
            driver.Quit();
        }
    }
}
