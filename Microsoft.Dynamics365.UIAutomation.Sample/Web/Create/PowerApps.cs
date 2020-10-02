using Microsoft.Dynamics365.UIAutomation.Browser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Dynamics365.UIAutomation.Sample.Web.Create
{
    class PowerApps
    {
        public String employerName;
        public Api.Browser xrmBrowser = new Api.Browser(TestSettings.Options);
        private readonly SecureString _pwUsername = (System.Configuration.ConfigurationManager.AppSettings["PowerAppsUsername"].ToString()).ToSecureString();
        private readonly SecureString _pwPassword = (System.Configuration.ConfigurationManager.AppSettings["PowerAppsPassword"].ToString()).ToSecureString();
        private Uri _pwXrmUri = new Uri(System.Configuration.ConfigurationManager.AppSettings["PowerAppsCrmUrl"].ToString());
        // SecureString _pwXrmUri = "eyed--5T&tZ".ToString().ToSecureString();

        public Api.Browser LoginPowerApps()
        {
            xrmBrowser.LoginPage.Login(_pwXrmUri, _pwUsername, _pwPassword);
            return xrmBrowser;
        }

        public void NavigateToPowerApps()
        {
            xrmBrowser.Navigation.NavigateToPowerAutomateFlows(500);
        }

        public void CheckStatus()
        {
            
        }

    }
}
