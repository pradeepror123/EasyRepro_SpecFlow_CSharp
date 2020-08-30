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

        public String FillLeadFormAndSave(String employerName, Api.Browser xrmBrowser, String info)
        {
            this.xrmBrowser = xrmBrowser;
            xrmBrowser.ThinkTime(1000);
            xrmBrowser.Navigation.NavigateToNewForm(1000);
            this.employerName = xrmBrowser.LeadPage.FillLeadFormAndSave(employerName, info, 1000);
            return this.employerName;

        }

        //[TestMethod]
        public void NavigateToNewLeadPage(Api.Browser xrmBrowser)
        {
            this.xrmBrowser = xrmBrowser;

            xrmBrowser.Navigation.NavigateToLeadsPage(500);
            xrmBrowser.Navigation.NavigateToNewForm(1000);
        }

        public void ValidateCreatedLead(Api.Browser xrmBrowser, String employerName)
        {
            this.xrmBrowser = xrmBrowser;
            xrmBrowser.Navigation.NavigateToLeadsPage(1000);
            xrmBrowser.Navigation.ValidateTextFromGrid(employerName);
        }
    }
}