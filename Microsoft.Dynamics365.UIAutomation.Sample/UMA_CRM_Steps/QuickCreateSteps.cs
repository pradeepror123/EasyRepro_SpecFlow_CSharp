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
        QuickCreateResourceAddress quickCRA = new QuickCreateResourceAddress();


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

        [Then(@"User should be able to create '(.*)' with pre-existing data")]
        public void ThenUserShouldBeAbleToCreateWithPre_ExistingData(string quickCreateFormName)
        {
            if (quickCreateFormName == "Resource Address")
            {
                Browser = scenarioContext.Get<Api.Browser>("browser");
                quickCRA.FillQuickCreateField(Browser, "Address Type");
                quickCRA.FillQuickCreateField(Browser, "Address");
                quickCRA.QuickCreateSaveAndClose(Browser);
            }
        }

    }
}
