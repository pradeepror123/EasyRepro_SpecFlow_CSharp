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

        [Given(@"User logs-in with (.*) and (.*) and navigates to '(.*)' Page")]
        public void GivenCSAUserLogs_InAndNavigatesToPage(String usrname, String pswd, string pageName)
        {
            Browser = createAccount.Login();
            Browser.Navigation.NavigateToUMAApp();
            scenarioContext.Add("browser", Browser);
            if (pageName == "Employer")
                createAccount.NavigateToNewEmployerPage();
            else if (pageName == "Lead")
                createLead.NavigateToNewLeadPage(Browser);
            else if (pageName == "Job Order")
                createJobOrder.NavigateToNewJobOrderPage(Browser);
        }

        [Given(@"Sample Step")]
        public void GivenSampleStep()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"CSA user logs-in and navigates to '(.*)' Page")]
        public void GivenCSAUserLogs_InAndNavigatesToPage(string pageName)
        {
            Browser = createAccount.Login();
            Browser.Navigation.NavigateToUMAApp();
            scenarioContext.Add("browser", Browser);
            if (pageName == "Employer")
                createAccount.NavigateToNewEmployerPage();
            else if (pageName == "Lead")
                createLead.NavigateToNewLeadPage(Browser);
            else if (pageName == "Job Order")
                createJobOrder.NavigateToNewJobOrderPage(Browser);
        }

        [When(@"User creates a New Employer '(.*)' Account and saves")]
        public void WhenUserCreatesANewEmployerAccountFormAndSaves(string formName)
        {
            string empName = "";
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
