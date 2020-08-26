using Microsoft.Dynamics365.UIAutomation.Sample.Web;
using System;
using TechTalk.SpecFlow;

namespace Microsoft.Dynamics365.UIAutomation.Sample.UMA_CRM_Steps
{
    [Binding]
    public class LeadsSteps
    {
        readonly ScenarioContext scenarioContext;

        public LeadsSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        public CreateLead createLead = new CreateLead();

        [Given(@"CSA user logs-in and navigates to Lead Page")]
        public void GivenCSAUserLogs_InAndNavigatesToLeadPage()
        {
            var Browser = createLead.LoginAndNavigateToNewLeadPage();
            scenarioContext.Add("browser", Browser);
        }

        [When(@"User creates a New Lead without Pre-Existing Employer, Contact and saves")]
        public void WhenUserCreatesANewLeadWithoutPre_ExistingEmployerContactAndSaves()
        {
            createLead.FillLeadFormWithoutEmployerOrContactAndSave();
        }

        [Then(@"User should be able to validate the created Lead")]
        public void ThenUserShouldBeAbleToValidateTheCreatedLead()
        {
            createLead.ValidateCreatedLead();
        }

    }
}
