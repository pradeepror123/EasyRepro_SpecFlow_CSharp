using Microsoft.Dynamics365.UIAutomation.Sample.Web;
using Microsoft.Dynamics365.UIAutomation.Sample.Web.Create;
using System;
using TechTalk.SpecFlow;

namespace Microsoft.Dynamics365.UIAutomation.Sample.UMA_CRM_Steps
{
    [Binding]
    public class CreationUpdationAndDeletionOfJobOrdersSteps
    {
        readonly ScenarioContext scenarioContext;
        CreateAccount createAccount = new CreateAccount();
        CreateLead createLead = new CreateLead();
        CreateJobOrder createJobOrder = new CreateJobOrder();

        public Api.Browser Browser;

        public CreationUpdationAndDeletionOfJobOrdersSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [When(@"User creates a New Job Order with created Account")]
        public void WhenUserCreatesANewJobOrderWithCreatedAccount()
        {
            createJobOrder.FillJobOrderFormAndSave(Browser, "sample");
        }
        
        [Then(@"CSA user navigates to '(.*)' Page")]
        public void ThenCSAUserNavigatesToPage(string pageName)
        {
            Browser = scenarioContext.Get<Api.Browser>("browser");

            Browser.Navigation.NavigateToJobOrdersPage(500);
            Browser.Navigation.NavigateToNewForm(1000);
        }
        
        [Then(@"User should be able to validate the created Job Order")]
        public void ThenUserShouldBeAbleToValidateTheCreatedJobOrder()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
