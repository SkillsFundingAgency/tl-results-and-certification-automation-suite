using System;
using System.Configuration;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Hooks;
using Sfa.Tl.ResultsAndCertificationAutomation.ObjectRepository;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport
{
    public class Constants
    {
        public const string InvalidUser = "InvalidUser";
        public const string InvalidPass = "InvalidPass";
        public const string Banner = "This is a new service – your feedback will help us to improve it.";
        public const string DashBoardHeader = "Manage T Levels";
        public const string CookieHeader = "Cookies";
        public const string Browser = "Chrome";
        public const string BaseUrl = "https://s126t01-resac-as.azurewebsites.net/";
        public const string DfESignInUrl = "https://s126t01-resac-as.azurewebsites.net/Account/SignIn";
        public const string DfEUserName = "rajesh.gaddam@digital.education.gov.uk";
        public const string DfEPassword = "testing@2020";
        public const string DfEInvalidUserName = "testuser@digital.education.gov.uk";
        public const string DfEInvalidPassword = "testing@@2020";
        public const string TLevelHomePageUrl = "https://s126t01-resac-as.azurewebsites.net/TlevelHome";
        public const string TlevelDashboardUrl = "https://s126t01-resac-as.azurewebsites.net/Dashboard";
    }
}
