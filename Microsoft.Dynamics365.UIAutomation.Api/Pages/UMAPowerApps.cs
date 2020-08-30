using Microsoft.Dynamics365.UIAutomation.Browser;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Dynamics365.UIAutomation.Api.Pages
{
    /// <summary>
    ///  The Xrm Lead page.
    ///  </summary>
    public class UMAPowerApps
        : XrmPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Navigation"/> class.
        /// </summary>
        /// <param name="browser">The browser.</param>
        public UMAPowerApps(InteractiveBrowser browser)
            : base(browser)
        {
            SwitchToDefault();
        }

        public Boolean LoopThorughAllFLowsAndRun()
        {
            this.Execute("JobOrders", driver =>
            {
                Thread.Sleep(3000);
                int count = driver.FindElements(By.XPath("//div[normalize-space(text())='Off']/../..//a")).Count();
                for (int i = 0; i < count; i++)
                {
                    var ele = driver.FindAvailable(By.XPath($"(//div[normalize-space(text())='Off']/../..//a)[{i + 1}]"));
                    var popup = new PopupWindowFinder(driver);
                    string session = popup.Click(ele);
                    driver.SwitchTo().Window(session);
                    string result = TurnOn() == true ? "is turned On" : "is not turned On";
                    Console.WriteLine(ele.Text + " => " + result);
                    driver.Close();
                }
                return true;
            });
            return true;
        }

        public bool TurnOn()
        {
            bool condition = false;
            // do turn on
            //verification

            return condition;
        }
    }
}
