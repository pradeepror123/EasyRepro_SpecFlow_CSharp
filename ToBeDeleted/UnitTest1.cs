using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;

namespace ToBeDeleted
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://docs.microsoft.com/en-us/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
            driver.Quit();
            Console.WriteLine("driver opened and closed");
        }
    }
}
