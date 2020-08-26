﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Dynamics365.UIAutomation.Api;
using Microsoft.Dynamics365.UIAutomation.Browser;
using System;
using System.Security;

namespace Microsoft.Dynamics365.UIAutomation.Sample.Web
{
    [TestClass]
    public class CreateAccount
    {
        public Api.Browser xrmBrowser;
        public String employerName;
        private readonly SecureString _username = System.Configuration.ConfigurationManager.AppSettings["OnlineUsername"].ToSecureString();
        private readonly SecureString _password = System.Configuration.ConfigurationManager.AppSettings["OnlinePassword"].ToSecureString();
        private readonly Uri _xrmUri = new Uri(System.Configuration.ConfigurationManager.AppSettings["OnlineCrmUrl"].ToString());

        //[TestMethod]
        public Api.Browser LoginAndNavigateToNewEmployerPage()
        {
           xrmBrowser = new Api.Browser(TestSettings.Options);
            xrmBrowser.LoginPage.Login(_xrmUri, _username, _password);
            xrmBrowser.GuidedHelp.CloseGuidedHelp();
            xrmBrowser.Dialogs.CloseWarningDialog();
            xrmBrowser.ThinkTime(500);
            xrmBrowser.Navigation.NavigateToEmployersPage(1000);
            xrmBrowser.Navigation.NavigateToNewForm(1000);
            return xrmBrowser;
        }

        //[TestMethod]
        public void FillCADEmployerFormAndSave()
        {
            xrmBrowser.ThinkTime(1500);
            employerName = xrmBrowser.Navigation.FillCADAccountFormAndSave();
        }

        //[Test Method]
        public void ValidateCreatedCADAccount()
        {
            xrmBrowser.Navigation.NavigateToEmployersPage();
            xrmBrowser.Navigation.ValidateTextFromGrid(employerName);
        }

        //[TestMethod]
        public void LogOutUser()
        {
            xrmBrowser.Navigation.SignOut(1000);
        }


    }
}