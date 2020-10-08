<<<<<<< HEAD
﻿using AventStack.ExtentReports.Utils;
using Microsoft.Dynamics365.UIAutomation.Sample.Web;
using System;
using TechTalk.SpecFlow;

namespace Microsoft.Dynamics365.UIAutomation.Sample.UMA_CRM_Steps
{
    [Binding]
    public class LeadsSteps
    {
        String empName;
        String accountName;
        readonly ScenarioContext scenarioContext;
        public CreateLead createLead = null;

        public LeadsSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [When(@"User creates a New Lead '(.*)' Employer, Contact and saves")]
        public void WhenUserCreatesANewLeadEmployerContactAndSaves(string info)
        {
            createLead = new CreateLead();
            empName = (scenarioContext.Count == 1) ? "a" : scenarioContext.Get<string>("EmployerName");
            accountName = createLead.FillLeadFormAndSave(empName, scenarioContext.Get<Api.Browser>("browser"), info);
        }

        [Then(@"User should be able to validate the created Lead")]
        public void ThenUserShouldBeAbleToValidateTheCreatedLead()
        {
            createLead.ValidateCreatedLead(scenarioContext.Get<Api.Browser>("browser"), accountName);
        }

        [When(@"User fills '(.*)' and Qualifies the Lead to Job Order")]
        public void WhenUserFillsAndQualifiesTheLeadToJobOrder(string tabName)
        {
            // ScenarioContext.Current.Pending();
        }

    }
}
=======
﻿using Microsoft.Dynamics365.UIAutomation.Sample.Web;
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
>>>>>>> b4589918429bcaf5363d6c258fe7888cd78a7df2
