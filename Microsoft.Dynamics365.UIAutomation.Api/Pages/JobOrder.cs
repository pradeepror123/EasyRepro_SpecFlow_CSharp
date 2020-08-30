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
    public class JobOrder
        : XrmPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Navigation"/> class.
        /// </summary>
        /// <param name="browser">The browser.</param>
        public JobOrder(InteractiveBrowser browser)
            : base(browser)
        {
            SwitchToDefault();
        }

        public String FillJobOrderFormAndSave(string empName, string info, int thinkTime = Constants.DefaultThinkTime)
        {
            Browser.ThinkTime(thinkTime);
            Random rand = new Random();
            int num = rand.Next(10000, 100000);
            String jobTitleText = "Test_JobOrder_" + num;
            String xpath = Elements.Xpath[Reference.Entity.FormTxtField];
            var time = TimeSpan.FromSeconds(2);
            this.Execute("JobOrders", driver =>
            {
                Browser.ThinkTime(1000);
                if (info == "with")
                {
                    var jobTitle = By.XPath(Elements.Xpath["InputIDContains"].Replace("arg", "jobtitle"));
                    driver.EnterTextAndTab(jobTitle, jobTitleText, time);
                    FillLookUpField("Employer", empName, driver);
                    driver.Actions().MoveToElement(driver.FindElement(jobTitle)). SendKeys(Keys.PageDown).SendKeys(Keys.PageDown).Build().Perform();
                    driver.ScrollUntilElementVisible(By.XPath(Elements.Xpath["InputIDContains"].Replace("arg", "DatePicker") + "[@aria-label='Job Start Date']"));
                    string currentDate = DateTime.Now.ToString(@"M/dd/yyyy");
                    var datePicker = By.XPath(Elements.Xpath["InputIDContains"].Replace("arg", "DatePicker") + "[@aria-label='Job Start Date']");
                    Browser.ThinkTime(1000);
                    driver.Actions().MoveToElement(driver.FindElement(datePicker)).DoubleClick().SendKeys(currentDate).SendKeys(Keys.Tab).Build().Perform();
                    //driver.EnterTextAndTab(By.XPath(Elements.Xpath["InputIDContains"].Replace("arg", "DatePicker") + "[@aria-label='Job Start Date']"), currentDate, time);
                }
                driver.WaitUntilAvailable(By.XPath(Elements.Xpath[Reference.Entity.Btn_Save]));
                driver.FindElement(By.XPath(Elements.Xpath[Reference.Entity.Btn_Save])).Click();
                Browser.ThinkTime(5000);
                return true;
            });
            return jobTitleText;
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
