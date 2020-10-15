using Microsoft.Dynamics365.UIAutomation.Browser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class StudentEnrollment
        : XrmPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Navigation"/> class.
        /// </summary>
        /// <param name="browser">The browser.</param>
        public StudentEnrollment(InteractiveBrowser browser)
            : base(browser)
        {
            SwitchToDefault();
        }

        public void ValdiateAllLockedFields()
        {
            // Field not found on page: Status Reason
            // Field already has value and is editable: "Academic Period"
            string[] fieldLabels = { "Student", "Program", "Campus", "Enroll Date", "Exp Start Date", "Grad Date", 
                "Cum GPA", "School Status", "Continuing Education Eligibility", "ISP Status", "Pending Waiver Status", 
                "Placement Status", "In-Motion", "Recommended PopType", "WFHTier", "CR Packaged Date", 
                "LS Forecast Change Date", "CR Packaged Deadline", "Student Profile Completed Date", "Student Risk Bucket", 
                "Mock Interview Score", "Mock Interview Completed Date", "Resume Fluency Score", 
                "Do Not Transfer", "Enrollment Number", "Cohort", "Lock Assignment", "Farthest Application", "Candidate Status" };
            foreach (string fieldName in fieldLabels)
                ValidateIfFieldLocked(fieldName);
        }

        public void ValidateIfFieldLocked(String fieldName)
        {
            this.Execute("LockedFields", driver =>
            {
                Thread.Sleep(500);
                driver.ScrollElement(By.XPath($"//*[contains(@aria, '{fieldName}')]"));
                String inputField = $"//section//input[contains(@aria-label, '{fieldName}')]";
                String selectField = $"//section//select[contains(@aria-label, '{fieldName}')]";
                String inputIDField = $"//input[contains(@id, '{fieldName.ToLower().Replace(" ", String.Empty)}')]";
                // @aria-readonly / disabled
                if (driver.FindElements(By.XPath(inputField)).Count > 0)    {
                    ScrollAndValidateReadonly(inputField, driver);
                } else if (driver.FindElements(By.XPath(selectField)).Count > 0)    {
                    ScrollAndValidateReadonly(selectField, driver);
                } else if (driver.FindElements(By.XPath(inputIDField)).Count > 0) {
                    ScrollAndValidateReadonly(inputIDField, driver); 
                }
                return true;
            });
            
        }

        public void ScrollAndValidateReadonly(String field, IWebDriver driver)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", driver.FindElement(By.XPath(field)));
            driver.FindElement(By.XPath(field)).Click();
            if (driver.FindElement(By.XPath(field)).GetAttribute("aria-readonly") == null)
                Assert.IsNotNull(driver.FindElement(By.XPath(field)).GetAttribute("disabled"), $"{field} does not have disabled as true");
            else
                Assert.IsNotNull(driver.FindElement(By.XPath(field)).GetAttribute("aria-readonly"), $"{field} does not have aria-readonly as true");
        }

        public void NavigateToEnrollmentRecord()
        {
            this.Execute("LockedFields", driver =>
            {
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//a[contains(text(),'Advanced')]")).Click();
                Thread.Sleep(3000);
                Assert.IsTrue(driver.IsVisible(By.XPath("//h1[contains(text(), 'Advanced Elementary')]")), "Cannot navigate to Advanced Elementary Student Enrollment Record");
                return true;
            });
        }

        public void ValidateAllEditableFields()
        {
            this.Execute("EditableFields", driver =>
            {

                return true;
            });
        }
    }
}

