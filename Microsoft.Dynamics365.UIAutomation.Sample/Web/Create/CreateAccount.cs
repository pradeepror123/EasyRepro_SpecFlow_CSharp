﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Dynamics365.UIAutomation.Api;
using Microsoft.Dynamics365.UIAutomation.Browser;
using System;
using System.Security;

namespace Microsoft.Dynamics365.UIAutomation.Sample.Web
{
    //[TestClass]
    public class CreateAccount
    {                    
        public Api.Browser xrmBrowser = new Api.Browser(TestSettings.Options);
        public String employerName;
        private readonly SecureString _umaUsername = (System.Configuration.ConfigurationManager.AppSettings["PowerAppsUsername"].ToString()).ToSecureString();
        private readonly SecureString _umaPassword =(System.Configuration.ConfigurationManager.AppSettings["PowerAppsPassword"].ToString()).ToSecureString();
        private Uri _umaXrmUri = new Uri(System.Configuration.ConfigurationManager.AppSettings["UMACrmUrl"].ToString());

        //[TestMethod]
        public Api.Browser Login()
        {
            xrmBrowser.LoginPage.Login(_umaXrmUri, _umaUsername, _umaPassword);
            xrmBrowser.GuidedHelp.CloseGuidedHelp();
            return xrmBrowser;
        }

        //[TestMethod]
        public void NavigateToNewEmployerPage()
        {
            xrmBrowser.Navigation.NavigateToEmployersPage(500);
            xrmBrowser.Navigation.NavigateToNewForm(1000);
        }

        //[TestMethod]
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

        //[Test Method]
        public void ValidateCreatedAccount()
        {
            xrmBrowser.Navigation.NavigateToEmployersPage();
            xrmBrowser.Navigation.ValidateTextFromGrid(employerName);
        }

        //[TestMethod]
        public void LogOutUser(Api.Browser xrmBrowser)
        {
            this.xrmBrowser = xrmBrowser;
            xrmBrowser.Navigation.SignOut(1000);
        }


    }
}
