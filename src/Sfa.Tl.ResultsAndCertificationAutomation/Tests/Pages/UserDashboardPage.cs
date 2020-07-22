using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class UserDashboardPage : ElementHelper
    {
        public static void AdminDashboardPage()
        {
            TlevelDashboardPage.VerifyTLevelHeader();
            Assert.IsTrue(IsPresent(TlevelDashboardPage.UserAccountLink));
            Assert.IsTrue(IsPresent(TlevelDashboardPage.CentresLink));
            Assert.IsTrue(IsPresent(TlevelDashboardPage.TlevelLink));
        }

        public static void ProviderDashboardPage()
        {
            TlevelDashboardPage.VerifyTLevelHeader();
            Assert.IsTrue(IsPresent(TlevelDashboardPage.UserAccountLink));
            Assert.IsTrue(IsPresent(TlevelDashboardPage.CentresLink));
            Assert.IsTrue(IsPresent(TlevelDashboardPage.TlevelLink));
        }

        public static void ReviewerDashboardPage()
        {
            TlevelDashboardPage.VerifyTLevelHeader();
            Assert.IsTrue(IsPresent(TlevelDashboardPage.UserAccountLink));
            Assert.IsTrue(IsPresent(TlevelDashboardPage.CentresLink));
            Assert.IsTrue(IsPresent(TlevelDashboardPage.TlevelLink));
        }

        public static void NoServiceDashboardPage()
        {
            Assert.IsTrue(IsPresent(TlevelDashboardPage.UserAccountLink));
            Assert.IsFalse(IsPresent(TlevelDashboardPage.CentresLink));
            Assert.IsFalse(IsPresent(TlevelDashboardPage.TlevelLink));
        }
    }
}
