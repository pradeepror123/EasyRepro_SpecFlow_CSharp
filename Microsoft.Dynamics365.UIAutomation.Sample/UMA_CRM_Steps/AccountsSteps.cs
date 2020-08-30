using Microsoft.Dynamics365.UIAutomation.Sample.Web;
using System;
using TechTalk.SpecFlow;

namespace Microsoft.Dynamics365.UIAutomation.Sample.Steps
{
    [Binding]
    public class CreationUpdationAndDeletionOfEmployerAccountsSteps
    {
        readonly  ScenarioContext scenarioContext;
        public CreateAccount createAccount = new CreateAccount();
        public CreateLead createLead = new CreateLead();
        public Api.Browser Browser;

        public CreationUpdationAndDeletionOfEmployerAccountsSteps(ScenarioContext scenarioContext) {
            this.scenarioContext = scenarioContext;
        }

        [Given(@"CSA user logs-in and navigates to '(.*)' Page")]
        public void GivenCSAUserLogs_InAndNavigatesToPage(string pageName)
        {
            if (pageName == "Employer")
            {
                Browser = createAccount.LoginAndNavigateToNewEmployerPage();
            } else if (pageName == "Lead")
                Browser = createLead.LoginAndNavigateToNewLeadPage();
            scenarioContext.Add("browser", Browser);
        }

        [When(@"User creates a New Employer CAD Account Form and saves")]
        public void WhenUserCreatesANewEmployerCADAccountFormAndSaves()
        {
            createAccount.FillCADEmployerFormAndSave(); 
         }

        [Then(@"User should be able to validate the created CAD Account")]
        public void ThenUserShouldBeAbleToValidateTheCreatedCADAccount()
        {
            createAccount.ValidateCreatedCADAccount();
        }

        [Then(@"User should log-out of the Application")]
        public void ThenUserShouldLog_OutOfTheApplication()
        {
            Api.Browser a = scenarioContext.Get<Api.Browser>("browser");
            createAccount.LogOutUser(a);
        }

    }
}
