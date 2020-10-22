using Microsoft.Dynamics365.UIAutomation.Sample.Web;
using Microsoft.Dynamics365.UIAutomation.Sample.Web.Create;
using System;
using TechTalk.SpecFlow;

namespace Microsoft.Dynamics365.UIAutomation.Sample.UMA_CRM_Steps
{
    [Binding]
    public class ApplicationSteps
    {
        readonly ScenarioContext scenarioContext;
        CreateAccount createAccount = new CreateAccount();
        CreateLead createLead = new CreateLead();
        CreateJobOrder createJobOrder = new CreateJobOrder();
        CreateStudentEnrollment createStudentEnrollment = new CreateStudentEnrollment();

        public Api.Browser Browser;

        public ApplicationSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [Then(@"validate delete icon is displayed on selection of a record")]
        public void ThenValidateDeleteIconIsDisplayedOnSelectionOfARecord()
        {
            Browser = scenarioContext.Get<Api.Browser>("browser");
            Browser.Navigation.ValidateDeleteIcon();
        }
    }
}
