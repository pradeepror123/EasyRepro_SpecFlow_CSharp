using Microsoft.Dynamics365.UIAutomation.Browser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Dynamics365.UIAutomation.Sample.Web
{
    class QuickCreateResourceAddress
    {
        public Api.Browser xrmBrowser = new Api.Browser(TestSettings.Options);

        public void FillQuickCreateField(Api.Browser xrmBrowser, string windowName, IWebDriver driver)
        {
            this.xrmBrowser = xrmBrowser;
            if (windowName == "Resource Address")
            {
                FillLookUpField("Address", "a", driver);
                FillLookUpField("Address Type", "a", driver);
            }
        }

        public void FillLookUpField(String field, String text, IWebDriver driver)
        {
            Thread.Sleep(1000);
            driver.FindAvailable(By.XPath($"//input[@aria-label='{field}, Lookup']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath($"//input[@aria-label='{field}, Lookup']")).SendKeys(text, true);
            Thread.Sleep(1000);
            if (driver.FindElement(By.XPath("//div[contains(@aria-label, 'Lookup results')]//label[contains(text(), 'Insufficient Permissions')]")).IsVisible())
                Assert.Fail($"User has Insufficient Permissions on {field} field");
        }
    }
}
