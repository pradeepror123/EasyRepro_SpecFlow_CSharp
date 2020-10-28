using Microsoft.Dynamics365.UIAutomation.Sample.Web;
using Microsoft.Dynamics365.UIAutomation.Sample.Web.Create;
using System;
using TechTalk.SpecFlow;

namespace Microsoft.Dynamics365.UIAutomation.Sample.UMA_CRM_Steps
{
    [Binding]
    public class ResourcesAddressesSteps
    {
        readonly ScenarioContext scenarioContext;
        CreateAccount createAccount = new CreateAccount();
        CreateLead createLead = new CreateLead();
        CreateJobOrder createJobOrder = new CreateJobOrder();
        QuickCreateResourceAddress quickCRA = new QuickCreateResourceAddress();
        CreateStudentEnrollment createStudentEnrollment = new CreateStudentEnrollment();


        public Api.Browser Browser;

        public ResourcesAddressesSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [Then(@"User should be able to create '(.*)' with '(.*)' Address and Address Type")]
        public void ThenUserShouldBeAbleToCreateWithAddressAndAddressType(string newFormName, string type)
        {
            Browser = scenarioContext.Get<Api.Browser>("browser");
            if (newFormName == "Resource Address" & type == "pre-existing")
            {
                quickCRA.FillQuickCreateField(Browser, "Address Type", "a");
                quickCRA.FillQuickCreateField(Browser, "Address", "m");
                quickCRA.QuickCreateSaveAndClose(Browser);
            } else if (newFormName == "Resource Address" & type == "new")
            {
                quickCRA.CreateNewAndSaveQCForm(Browser, "Address Type");
                quickCRA.CreateNewAndSaveQCForm(Browser, "Address");
                quickCRA.QuickCreateSaveAndClose(Browser);
            }
        }
    }
}
