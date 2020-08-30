using Microsoft.Dynamics365.UIAutomation.Sample.Web;
using System;
using TechTalk.SpecFlow;

namespace Microsoft.Dynamics365.UIAutomation.Sample.UMA_CRM_Steps
{
    [Binding]
    public class LeadsSteps
    {
        readonly ScenarioContext scenarioContext;
        public CreateLead createLead = null;

        public LeadsSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [When(@"User creates a New Lead '(.*)' Pre-Existing Employer, Contact and saves")]
        public void WhenUserCreatesANewLeadPre_ExistingEmployerContactAndSaves(string info)
        {
            createLead = new CreateLead();
            Api.Browser a = scenarioContext.Get<Api.Browser>("browser");
            createLead.FillLeadFormAndSave(a, info);
        }

        [Then(@"User should be able to validate the created Lead")]
        public void ThenUserShouldBeAbleToValidateTheCreatedLead()
        {
            Api.Browser a = scenarioContext.Get<Api.Browser>("browser");
            createLead.ValidateCreatedLead(a);
        }

    }
}
