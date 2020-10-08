using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api = Microsoft.Dynamics365.UIAutomation.Api;

namespace TestCases.Web.Create
{
    public class CreateJobOrder
    {
        public Api.Browser xrmBrowser = null;
        String employerName;

        internal void FillJobOrderFormAndSave(Api.Browser xrmBrowser, String employerName, String info)
        {
            this.xrmBrowser = xrmBrowser;
            xrmBrowser.ThinkTime(1500);
            this.employerName = employerName;
            employerName = xrmBrowser.JobOrder.FillJobOrderFormAndSave(employerName, info, 2000);
        }

        //[TestMethod]
        public void NavigateToNewJobOrderPage(Api.Browser xrmBrowser)
        {
            this.xrmBrowser = xrmBrowser;
            xrmBrowser.Navigation.NavigateToJobOrdersPage(500);
            xrmBrowser.Navigation.NavigateToNewForm(1000);
        }

        public void ValidateCreatedJobOrder(Api.Browser xrmBrowser)
        {
            this.xrmBrowser = xrmBrowser;
            xrmBrowser.Navigation.NavigateToJobOrdersPage(1000);
            xrmBrowser.Navigation.ValidateTextFromGrid(employerName);
        }
    }
}
