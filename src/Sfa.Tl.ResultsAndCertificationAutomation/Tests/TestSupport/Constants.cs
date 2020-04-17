using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport
{
    public class Constants
    {
        public const string InvalidUser = "InvalidUser";
        public const string InvalidPass = "InvalidPass";
        public const string Banner = "This is a new service – your feedback will help us to improve it.";
        public const string DashBoardHeader = "Manage T Levels";
        public const string CookieHeader = "Cookies";
        public const string DfEInvalidUserName = "testuser@digital.education.gov.uk";
        public const string DfEInvalidPassword = "testing@@2020";
        private static string StartPageUrl => WebDriverFactory.Config["BaseUrl"];
        public static string TlevelDashboardUrl => string.Concat(StartPageUrl, "dashboard");
        public const string Error404 = "Page not found";
        public const string Error401 = "Access denied";
        public const string Error500 = "Sorry, there is a problem with the service";
        public const string SelectOrganisation = "Select your organisation";
        public const string TlevelAgricluture = "Agriculture, Environmental and Animal Care: Agriculture, Environmental and Animal Care";
        public const string TlevelEducation = "Education and Childcare: Education";
        public const string TlevelEngineering = "Engineering and Manufacturing: Engineering and Manufacturing";
        public const string TlevelHealth = "Health and Science: Health and Science";
        public const string TlevelLegal = "Legal, Finance and Accounting: Health and Science";
        public const string AccessibilityUrl = "https://www.gov.uk/help/accessibility-statement";
    }
}
