using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using Microsoft.Dynamics365.UIAutomation;
using Microsoft.Dynamics365.UIAutomation.ToBeDeleted;
using TestCases.Web.Create;

namespace TestCases.Steps
{
    [Binding]
    public class AccountsSteps
    {
        readonly ScenarioContext scenarioContext;

        public Microsoft.Dynamics365.UIAutomation.Api.Browser Browser;
        CreateAccount createAccount = new CreateAccount();
        CreateLead createLead = new CreateLead();
        CreateJobOrder createJobOrder = new CreateJobOrder();

        public AccountsSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [Given(@"user opened browser")]
        public void GivenUserOpenedBrowser()
        {           
            
            Browser = createAccount.Login();
            scenarioContext.Add("browser", Browser);
            Browser.Navigation.NavigateToUMAApp();
        }

        [Given(@"CSA user logs-in and navigates to '(.*)' Page")]
        public void GivenCSAUserLogs_InAndNavigatesToPage(string pageName)
        {
            Browser = createAccount.Login();
            scenarioContext.Add("browser", Browser);
            Browser.Navigation.NavigateToUMAApp();            
            if (pageName == "Employer")
                createAccount.NavigateToNewEmployerPage();
            else if (pageName == "Lead")
                createLead.NavigateToNewLeadPage(Browser);
            else if (pageName == "Job Order")
                createJobOrder.NavigateToNewJobOrderPage(Browser);
        }
    }
}
