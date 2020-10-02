using Microsoft.Dynamics365.UIAutomation.Browser;
using OpenQA.Selenium;
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
                var allFlows = driver.FindElements(By.XPath("//div[@data-automation-key='status']"));
                foreach (var flow in allFlows)
                {
                    if (flow.Text.ToLower().Contains("off"))
                        NavigateToFlowAndRun(driver, flow);
                }
                return true;
            });
            return true;
        }

        public void NavigateToFlowAndRun(IWebDriver driver, IWebElement flow)
        {
            flow.FindElement(By.XPath("//parent::div//div[@data-automation-key='displayName']//a")).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Thread.Sleep(5000);
        }
    }
}
