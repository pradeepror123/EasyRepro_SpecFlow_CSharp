using Microsoft.Dynamics365.UIAutomation.Api.Pages;
using Microsoft.Dynamics365.UIAutomation.Browser;
using Microsoft.Dynamics365.UIAutomation.Sample.Web.Create;
using System;
using System.Security;
using TechTalk.SpecFlow;

namespace Microsoft.Dynamics365.UIAutomation.Sample.UMA_CRM_Steps
{
    [Binding]
    public class PowerAppsRunsSteps
    {
        readonly ScenarioContext scenarioContext;
        PowerAppsFlows powerApps = new PowerAppsFlows();
        UMAPowerApps umaPowerApps;
        public Api.Browser Browser;

        public PowerAppsRunsSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [Given(@"User logs-in and navigates to UMA Power Automate Flows page")]
        public void GivenCSAUserLogs_InAndNavigatesToUMAPowerAutomateFlowsPage()
        {
            Browser = powerApps.LoginPowerApps();
            scenarioContext.Add("browser", Browser);
            powerApps.NavigateToPowerApps();
        }

        [Then(@"loop through all the Flows and run them")]
        public void ThenLoopThroughAllTheFlowsAndRunThem()
        {
            umaPowerApps = new UMAPowerApps(scenarioContext.Get<Api.Browser>("browser"));
            umaPowerApps.LoopThorughAllFLowsAndRun();
        }

    }
}
