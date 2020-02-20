using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class UserDashboardPage : ElementHelper
    {
        public static void AOAppDashboardPage()
        {
            Assert.IsTrue(IsPresent(TlevelDashboardPage.UserAccountLink));
            Assert.IsTrue(IsPresent(TlevelDashboardPage.CentresLink));
            Assert.IsTrue(IsPresent(TlevelDashboardPage.TlevelLink));
        }

        public static void AOCentreDashboardPage()
        {
            Assert.IsTrue(IsPresent(TlevelDashboardPage.UserAccountLink));
            Assert.IsTrue(IsPresent(TlevelDashboardPage.CentresLink));
            Assert.IsFalse(IsPresent(TlevelDashboardPage.TlevelLink));
        }

        public static void NoUserDashboardPage()
        {
            Assert.IsTrue(IsPresent(TlevelDashboardPage.UserAccountLink));
            Assert.IsFalse(IsPresent(TlevelDashboardPage.CentresLink));
            Assert.IsFalse(IsPresent(TlevelDashboardPage.TlevelLink));
        }
    }
}
