using Microsoft.Dynamics365.UIAutomation.Api;
using Microsoft.Dynamics365.UIAutomation.Browser;
using Microsoft.Dynamics365.UIAutomation.Sample.Web;
using Microsoft.Dynamics365.UIAutomation.Sample.Web.Create;
using OpenQA.Selenium.Chrome;
using System;
using System.Security;
using System.Threading;
using TechTalk.SpecFlow;

namespace Microsoft.Dynamics365.UIAutomation.Sample.Steps
{
    [Binding]
    public class CreationUpdationAndDeletionOfEmployerAccountsSteps
    {
        readonly ScenarioContext scenarioContext;
        CreateAccount createAccount = new CreateAccount();
        CreateLead createLead = new CreateLead();
        CreateJobOrder createJobOrder = new CreateJobOrder();
        CreateStudentEnrollment createStudentEnrollment = new CreateStudentEnrollment();

        public Api.Browser Browser;

        public CreationUpdationAndDeletionOfEmployerAccountsSteps(ScenarioContext scenarioContext) {
            this.scenarioContext = scenarioContext;
        }

        [Given(@"Sample Step")]
        public void SampleStep()
        {
            //var driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://docs.microsoft.com/en-us/");
            //driver.Manage().Window.Maximize();
            //Thread.Sleep(5000);
            //driver.Quit();
            //Console.WriteLine("driver opened and closed");
        }

        [Given(@"(.*) logs-in and navigates to '(.*)' Page")]
        public void GivenUserLogs_InAndNavigatesToPage(string username, string pageName)
        {
            Browser = (username == "User") ? createAccount.Login() : createAccount.Login(username.ToSecureString());
            scenarioContext.Add("user", username);
            scenarioContext.Add("browser", Browser);
            Browser.Navigation.NavigateToUMAApp();
            switch (pageName)
            {
                case "Employer":
                    createAccount.NavigateToNewEmployerPage();
                    break;
                case "Lead":
                    createLead.NavigateToNewLeadPage(Browser);
                    break;
                case "Job Order":
                    createJobOrder.NavigateToNewJobOrderPage(Browser);
                    break;
                case "Student Enrollment":
                    Browser.Navigation.NavigateToStudentEnrollment();
                    break;
                case "New Resource Address":
                    Browser.Navigation.NavigateToStudentEnrollment();
                    createStudentEnrollment.NavigateToStudentEnrollmentRecord(Browser);
                    Browser.Navigation.NavigateToResourceRequests();
                    createStudentEnrollment.NavigateToResourceUMARecord(Browser);
                    createStudentEnrollment.NavigateToNewResourceAddress(Browser);
                    break;
            }
        }

        [When(@"User creates a New Employer '(.*)' Account and saves")]
        public void WhenUserCreatesANewEmployerAccountFormAndSaves(string formName)
        {
            string empName;
            if (formName == "PBI")
                empName = createAccount.FillPBIEmployerFormAndSave();
            else
                empName = createAccount.FillCADEmployerFormAndSave();
            scenarioContext.Add("EmployerName", empName);
        }


        [Then(@"User should be able to validate the created Account")]
        public void ThenUserShouldBeAbleToValidateTheCreatedAccount()
        {
            createAccount.ValidateCreatedAccount();
        }

        [Then(@"User should log-out of the Application")]
        public void ThenUserShouldLog_OutOfTheApplication()
        {
            Api.Browser a = scenarioContext.Get<Api.Browser>("browser");
            createAccount.LogOutUser(a);
        }

    }
}
