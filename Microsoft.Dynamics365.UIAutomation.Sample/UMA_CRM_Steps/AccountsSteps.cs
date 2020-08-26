using Microsoft.Dynamics365.UIAutomation.Sample.Web;
using System;
using TechTalk.SpecFlow;

namespace Microsoft.Dynamics365.UIAutomation.Sample.Steps
{
    [Binding]
    public class CreationUpdationAndDeletionOfEmployerAccountsSteps
    {
       readonly  ScenarioContext scenarioContext;
        public CreationUpdationAndDeletionOfEmployerAccountsSteps(ScenarioContext scenarioContext) {
            this.scenarioContext = scenarioContext;
        }

        public CreateAccount createAccount = new CreateAccount();

        [Given(@"CSA user logs-in and navigates to Employer Account Page")]
        public void GivenCSAUserLogs_InAndNavigatesToEmployerAccountPage()
        {
            var Browser  = createAccount.LoginAndNavigateToNewEmployerPage();
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
            createAccount.LogOutUser();
        }

    }
}
