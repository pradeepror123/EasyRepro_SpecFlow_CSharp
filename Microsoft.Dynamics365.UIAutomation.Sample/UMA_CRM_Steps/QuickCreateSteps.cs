using Microsoft.Dynamics365.UIAutomation.Browser;
using Microsoft.Dynamics365.UIAutomation.Sample.Web;
using Microsoft.Dynamics365.UIAutomation.Sample.Web.Create;
using System;
using TechTalk.SpecFlow;

namespace Microsoft.Dynamics365.UIAutomation.Sample.UMA_CRM_Steps
{
    [Binding]
    public class CreateAddressTypeAndAddressFromQuickCreateWindowSteps
    {
        readonly ScenarioContext scenarioContext;
        CreateAccount createAccount = new CreateAccount();
        CreateLead createLead = new CreateLead();
        CreateJobOrder createJobOrder = new CreateJobOrder();

        public Api.Browser Browser;

        public CreateAddressTypeAndAddressFromQuickCreateWindowSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [Given(@"(.*) logs-in and navigates to Quick Create '(.*)' Window")]
        public void GivenCMRTest_BDRLogs_InAndNavigatesToQuickCreateWindow(string username, string windowName)
        {
            Browser = createAccount.Login(username.ToSecureString());
            Browser.Navigation.NavigateToUMAApp();
            scenarioContext.Add("browser", Browser);
            Browser.Navigation.NavigateToQuickCreate(windowName);
        }


        [Then(@"User should be able to create and save a new '(.*)'")]
        public void ThenUserShouldBeAbleToCreateAndSaveANew(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
