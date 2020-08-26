using Microsoft.Dynamics365.UIAutomation.Browser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;


namespace Microsoft.Dynamics365.UIAutomation.Api.Pages
{

    /// <summary>
    ///  The Xrm Lead page.
    ///  </summary>
    public class Lead
        : XrmPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Navigation"/> class.
        /// </summary>
        /// <param name="browser">The browser.</param>
        public Lead(InteractiveBrowser browser)
            : base(browser)
        {
            SwitchToDefault();
        }

        public String employerName;

        public String FillLeadFormWithoutPreExistingEmployerOrContactAndSave(int thinkTime = Constants.DefaultThinkTime)
        {
            string employerName = string.Empty;
            Browser.ThinkTime(thinkTime);
            Random rand = new Random();
            int num = rand.Next(10000, 100000);
            this.Execute("Leads", driver =>
            {
                Browser.ThinkTime(1000);
                // Fill form data 
                String xpath = Elements.Xpath[Reference.Entity.FormTxtField];
                employerName = "Test_LeadEmployer_" + num;
                Thread.Sleep(1000);
                driver.EnterTextAndTab(By.XPath(xpath.Replace("[NAME]", "Employer Name")), employerName, TimeSpan.FromSeconds(2));
                driver.EnterTextAndTab(By.XPath(xpath.Replace("[NAME]", "Phone")), "12312"+num, TimeSpan.FromSeconds(2));
                driver.EnterTextAndTab(By.XPath(xpath.Replace("[NAME]", "Street/P.O. Box")), "123 New St", TimeSpan.FromSeconds(2));
                driver.EnterTextAndTab(By.XPath(xpath.Replace("[NAME]", "City")), "San Antonio", TimeSpan.FromSeconds(2));
                driver.EnterTextAndTab(By.XPath(xpath.Replace("[NAME]", "State/Province")), "Texas", TimeSpan.FromSeconds(2));
                driver.EnterTextAndTab(By.XPath(xpath.Replace("[NAME]", "ZIP/Postal Code")), "78234", TimeSpan.FromSeconds(2));
                driver.EnterTextAndTab(By.XPath(xpath.Replace("[NAME]", "Job Title")), "Test Lead "+num, TimeSpan.FromSeconds(2));
                driver.WaitUntilAvailable(By.XPath(Elements.Xpath[Reference.Entity.Btn_Save]));
                driver.FindElement(By.XPath(Elements.Xpath[Reference.Entity.Btn_Save])).Click();
                Browser.ThinkTime(5000);
                return true;
            });
            return employerName;
        }

    }
}
