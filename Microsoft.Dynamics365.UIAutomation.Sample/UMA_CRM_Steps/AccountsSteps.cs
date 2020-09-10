using Microsoft.Dynamics365.UIAutomation.Sample.Web;
using Microsoft.Dynamics365.UIAutomation.Sample.Web.Create;
using System;
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

        [Given(@"CSA user logs-in and navigates to '(.*)' Page")]
        public void GivenCSAUserLogs_InAndNavigatesToPage(string pageName)
        {
            if (pageName == "Employer")
                Browser = createAccount.LoginAndNavigateToNewEmployerPage();
            else if (pageName == "Lead")
                Browser = createLead.LoginAndNavigateToNewLeadPage();
            else if (pageName == "Job Order")
                Browser = createJobOrder.LoginAndNavigateToJobOrderPage();
            scenarioContext.Add("browser", Browser);
        }

        [When(@"User creates a New Employer '(.*)' Account and saves")]
        public void WhenUserCreatesANewEmployerAccountFormAndSaves(string formName)
        {
            if (formName == "PBI")
                createAccount.FillPBIEmployerFormAndSave();
            else
                createAccount.FillCADEmployerFormAndSave();
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

        //#@LeadToJobOrder_PBI
        //# Scenario: Create and Qualify a Lead to convert to Job Order with Pre-Existing PBI Employer & Contact
        //# Given CSA user logs-in and navigates to 'Lead' Page
        //# When User creates a New Lead 'with' Pre-Existing Employer, Contact and saves
        //# Then User should be able to validate the created Lead
        //# And User should log-out of the Application
        //#
        //#@LeadToJobOrder_CAD
        //# Scenario: Create and Qualify a Lead to convert to Job Order with Pre-Existing CAD Employer & Contact
        //# Given CSA user logs-in and navigates to 'Lead' Page
        //# When User creates a New Lead 'with' Pre-Existing Employer, Contact and saves
        //# Then User should be able to validate the created Lead
        //# And User should log-out of the Application
        //#
        //#@LeadCreation_PBI
        //# Scenario: Create Lead with Pre-Existing PBI Employer & Contact
        //# Given CSA user logs-in and navigates to 'Employer' Page
        //# When User creates a New Employer 'PBI' Account and saves
        //# Then User should be able to validate the created Account 
        //# And CSA user navigates to 'Lead' Page
        //# When User creates a New Lead 'with' Pre-Existing Employer, Contact and saves
        //# Then User should be able to validate the created Lead
        //# And User should log-out of the Application
        //#
        //#@LeadCreation_CAD
        //# Scenario: Create Lead with Pre-Existing CAD Employer & Contact
        //# Given CSA user logs-in and navigates to 'Employer' Page
        //# When User creates a New Employer 'CAD' Account and saves
        //# Then User should be able to validate the created Account
        //# And CSA user navigates to 'Lead' Page
        //# When User creates a New Lead 'with' Pre-Existing Employer, Contact and saves
        //# Then User should be able to validate the created Lead
        //# And User should log-out of the Application

    }
}
