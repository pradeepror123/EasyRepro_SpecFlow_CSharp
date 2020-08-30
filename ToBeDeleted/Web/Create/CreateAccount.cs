using Microsoft.Dynamics365.UIAutomation.Browser;
using Microsoft.Dynamics365.UIAutomation.ToBeDeleted;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace TestCases.Web.Create
{
    public class CreateAccount
    {
        public Microsoft.Dynamics365.UIAutomation.Api.Browser xrmBrowser = new Microsoft.Dynamics365.UIAutomation.Api.Browser(TestSettings.Options);
        public String employerName;
        private readonly SecureString _umaUsername = (System.Configuration.ConfigurationManager.AppSettings["PowerAppsUsername"].ToString()).ToSecureString();
        private readonly SecureString _umaPassword = (System.Configuration.ConfigurationManager.AppSettings["PowerAppsPassword"].ToString()).ToSecureString();
        private Uri _umaXrmUri = new Uri(System.Configuration.ConfigurationManager.AppSettings["UMACrmUrl"].ToString());


        public Microsoft.Dynamics365.UIAutomation.Api.Browser Login()
        {
            xrmBrowser.LoginPage.Login(_umaXrmUri, _umaUsername, _umaPassword);
            xrmBrowser.GuidedHelp.CloseGuidedHelp(10000);
            return xrmBrowser;
        }

        public void NavigateToNewEmployerPage()
        {
            xrmBrowser.Navigation.NavigateToEmployersPage(500);
            xrmBrowser.Navigation.NavigateToNewForm(1000);
        }

        public string FillCADEmployerFormAndSave()
        {
            xrmBrowser.ThinkTime(1500);
            employerName = xrmBrowser.Navigation.FillCADAccountFormAndSave();
            return employerName;
        }

        public string FillPBIEmployerFormAndSave()
        {
            xrmBrowser.ThinkTime(1500);
            employerName = xrmBrowser.Navigation.FillPBIAccountFormAndSave();
            return employerName;
        }
        public void ValidateCreatedAccount()
        {
            xrmBrowser.Navigation.NavigateToEmployersPage();
            xrmBrowser.Navigation.ValidateTextFromGrid(employerName);
        }

        public void LogOutUser(Microsoft.Dynamics365.UIAutomation.Api.Browser xrmBrowser)
        {
            this.xrmBrowser = xrmBrowser;
            xrmBrowser.Navigation.SignOut(1000);
        }
    }
}
