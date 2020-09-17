// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Dynamics365.UIAutomation.Api;
using Microsoft.Dynamics365.UIAutomation.Browser;
using System;
using System.Collections.Generic;
using System.Security;
using OpenQA.Selenium.Interactions;

namespace Microsoft.Dynamics365.UIAutomation.Sample.Web
{
    [TestClass]
    public class CreateLead
    {
        public Api.Browser xrmBrowser = null;
        public String employerName;
        private readonly SecureString _username = System.Configuration.ConfigurationManager.AppSettings["OnlineUsername"].ToSecureString();
        private readonly SecureString _password = System.Configuration.ConfigurationManager.AppSettings["OnlinePassword"].ToSecureString();
        private readonly Uri _xrmUri = new Uri(System.Configuration.ConfigurationManager.AppSettings["OnlineCrmUrl"].ToString());

        public String FillLeadFormAndSave(String employerName, Api.Browser xrmBrowser, String info)
        {
            this.xrmBrowser = xrmBrowser;
            xrmBrowser.ThinkTime(1000);
            xrmBrowser.Navigation.NavigateToNewForm(1000);
            this.employerName = xrmBrowser.LeadPage.FillLeadFormAndSave(employerName, info, 1000);
            return this.employerName;

        }

        //[TestMethod]
        public Api.Browser LoginAndNavigateToNewLeadPage()
        {
            xrmBrowser = new Api.Browser(TestSettings.Options);
            xrmBrowser.LoginPage.Login(_xrmUri, _username, _password);
            xrmBrowser.GuidedHelp.CloseGuidedHelp();
            // xrmBrowser.Dialogs.CloseWarningDialog();
            // xrmBrowser.ThinkTime(500);
            xrmBrowser.Navigation.NavigateToUMAApp(500);
            xrmBrowser.Navigation.NavigateToLeadsPage(500);
            xrmBrowser.Navigation.NavigateToNewForm(1000);
            return xrmBrowser;
        }

        public void ValidateCreatedLead(Api.Browser xrmBrowser, String employerName)
        {
            this.xrmBrowser = xrmBrowser;
            xrmBrowser.Navigation.NavigateToLeadsPage(1000);
            xrmBrowser.Navigation.ValidateTextFromGrid(employerName);
        }
    }
}