using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCases.Web.Create
{
    public class CreateLead
    {
        public Microsoft.Dynamics365.UIAutomation.Api.Browser xrmBrowser = null;
        public String employerName;

        public String FillLeadFormAndSave(String employerName, Microsoft.Dynamics365.UIAutomation.Api.Browser xrmBrowser, String info)
        {
            this.xrmBrowser = xrmBrowser;
            xrmBrowser.ThinkTime(1000);
            xrmBrowser.Navigation.NavigateToNewForm(1000);
            this.employerName = xrmBrowser.LeadPage.FillLeadFormAndSave(employerName, info, 1000);
            return this.employerName;

        }
        public void NavigateToNewLeadPage(Microsoft.Dynamics365.UIAutomation.Api.Browser xrmBrowser)
        {
            this.xrmBrowser = xrmBrowser;

            xrmBrowser.Navigation.NavigateToLeadsPage(500);
            xrmBrowser.Navigation.NavigateToNewForm(1000);
        }

        public void ValidateCreatedLead(Microsoft.Dynamics365.UIAutomation.Api.Browser xrmBrowser, String employerName)
        {
            this.xrmBrowser = xrmBrowser;
            xrmBrowser.Navigation.NavigateToLeadsPage(1000);
            xrmBrowser.Navigation.ValidateTextFromGrid(employerName);
        }
    }
}
