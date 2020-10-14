using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Dynamics365.UIAutomation.Sample.Web.Create
{
    class CreateStudentEnrollment
    {
        public Api.Browser xrmBrowser = null;

        public void ValidateLockedFields(Api.Browser xrmBrowser)
        {
            this.xrmBrowser = xrmBrowser;
            xrmBrowser.StudentEnrollment.ValdiateAllLockedFields();
        }

        public void NavigateToStudentEnrollmentRecord(Api.Browser xrmBrowser)
        {
            this.xrmBrowser = xrmBrowser;
            xrmBrowser.StudentEnrollment.NavigateToEnrollmentRecord();
        }

        public void ValidateEditableFields(Api.Browser xrmBrowser)
        {
            this.xrmBrowser = xrmBrowser;
            xrmBrowser.StudentEnrollment.ValidateAllEditableFields();
        }
    }
}
