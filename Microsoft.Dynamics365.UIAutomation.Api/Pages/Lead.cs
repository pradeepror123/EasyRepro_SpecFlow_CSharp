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

        public String FillLeadFormAndSave(string info, int thinkTime = Constants.DefaultThinkTime)
        {
            string employerName = string.Empty;
            Browser.ThinkTime(thinkTime);
            Random rand = new Random();
            int num = rand.Next(10000, 100000);
            String xpath = Elements.Xpath[Reference.Entity.FormTxtField];
            this.Execute("Leads", driver =>
            {
                Browser.ThinkTime(1000);
                if(info == "with")
                {
                    FillLookUpField("New or Existing Employer?", "a", driver);
                    FillLookUpField("New or Existing Contact?", "a", driver);
                    employerName = driver.FindElement(By.XPath(xpath.Replace("[NAME]", "Account Name"))).GetAttribute("value");
                    driver.WaitUntilAvailable(By.XPath(Elements.Xpath[Reference.Entity.Btn_Save]));
                    driver.FindElement(By.XPath(Elements.Xpath[Reference.Entity.Btn_Save])).Click();
                    Browser.ThinkTime(2000);
                    return true;
                }
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

        public void FillLookUpField(string fieldLabel, string fieldValue, IWebDriver driver)
        {
            driver.FindElement(By.XPath($"//input[contains(@aria-label,'{fieldLabel}')]")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath($"//input[contains(@aria-label,'{fieldLabel}')]")).SendKeys(fieldValue, true);
            Thread.Sleep(1000);
            driver.Inivisibility(By.XPath("//label[text()='Loading...']"), 30);
            driver.Click(driver.FindElement(By.XPath("(//ul[contains(@aria-label,'Lookup Search Results')]/li)[1]")));
            Thread.Sleep(500);
        }

    }
}
