using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using Microsoft.Dynamics365.UIAutomation.Api;
using Microsoft.Dynamics365.UIAutomation.Sample;

namespace ToBeDeleted
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void TestMethod1()
        {
           // var option = TestSettings.Options;
            var xrmBrowser = new Microsoft.Dynamics365.UIAutomation.Api.Browser(null);
            Thread.Sleep(5000);
            xrmBrowser.Dispose();

            //var driver = new ChromeDriver();
            //    driver.Navigate().GoToUrl("https://docs.microsoft.com/en-us/");
            //    driver.Manage().Window.Maximize();
            //    Thread.Sleep(5000);
            //    driver.Quit();
            Console.WriteLine("driver opened and closed");
        }
    }
}
