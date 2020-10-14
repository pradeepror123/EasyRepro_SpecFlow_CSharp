using Microsoft.Dynamics365.UIAutomation.Sample.Web;
using Microsoft.Dynamics365.UIAutomation.Sample.Web.Create;
using System;
using TechTalk.SpecFlow;

namespace Microsoft.Dynamics365.UIAutomation.Sample.UMA_CRM_Steps
{
    [Binding]
    public class StudentEnrollmentsSteps
    {
        readonly ScenarioContext scenarioContext;
        CreateAccount createAccount = new CreateAccount();
        CreateLead createLead = new CreateLead();
        CreateJobOrder createJobOrder = new CreateJobOrder();
        QuickCreateResourceAddress quickCRA = new QuickCreateResourceAddress();
        CreateStudentEnrollment createStudentEnrollment = new CreateStudentEnrollment();

        public Api.Browser Browser;

        public StudentEnrollmentsSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [Then(@"validate the accessibility of fields on the form")]
        public void ThenValidateTheAccessibilityOfFieldsOnTheForm()
        {
            createStudentEnrollment.NavigateToStudentEnrollmentRecord(scenarioContext.Get<Api.Browser>("browser"));
            createStudentEnrollment.ValidateLockedFields(scenarioContext.Get<Api.Browser>("browser"));
            createStudentEnrollment.ValidateEditableFields(scenarioContext.Get<Api.Browser>("browser"));
        }

    }
}
