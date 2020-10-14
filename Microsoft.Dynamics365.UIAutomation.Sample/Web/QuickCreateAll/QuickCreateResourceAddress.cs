using Microsoft.Dynamics365.UIAutomation.Browser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Dynamics365.UIAutomation.Api;

namespace Microsoft.Dynamics365.UIAutomation.Sample.Web
{
    class QuickCreateResourceAddress
    {
        public Api.Browser xrmBrowser = new Api.Browser(TestSettings.Options);

        public void FillQuickCreateField(Api.Browser xrmBrowser, string fieldName)
        {
            this.xrmBrowser = xrmBrowser;
            xrmBrowser.QuickCreate.FillLookUpField(fieldName, "c");
        }

        public void QuickCreateSaveAndClose(Api.Browser xrmBrowser)
        {
            xrmBrowser.QuickCreate.SaveAndClose();
        }

    }
}
