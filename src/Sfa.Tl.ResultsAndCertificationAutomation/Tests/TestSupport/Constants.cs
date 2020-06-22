using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport
{
    public class Constants
    {
        public const string InvalidUser = "InvalidUser";
        public const string InvalidPass = "InvalidPass";
        public const string Banner = "This is a new service – your feedback will help us to improve it.";
        public const string DashBoardTitle = "Home page – Manage T Level results – GOV.UK";
        public const string DashBoardHeader = "Manage T Level results";
        public const string CookieHeader = "Cookies";
        public const string DfEInvalidUserName = "testuser@digital.education.gov.uk";
        public const string DfEInvalidPassword = "testing@@2020";
        private static string StartPageUrl => WebDriverFactory.Config["BaseUrl"];
        public static string TlevelDashboardUrl => string.Concat(StartPageUrl, "dashboard");
        public const string Error404 = "Page not found";
        public const string Error401 = "Access denied";
        public const string Error500 = "Sorry, there is a problem with the service";
        public const string SelectOrganisation = "Select your organisation";
        public const string TlevelTitleAgricluture = "T Level in Agriculture, Environmental and Animal Care";
        public const string TlevelTitleEducation = "T Level in Education and Childcare";
        public const string TlevelTitleEngineering = "T Level in Engineering and Manufacturing";
        public const string TlevelTitleHealth = "T Level in Health and Science";
        public const string TlevelTitleLegal = "T Level in Legal, Finance and Accounting";
        public const string TlevelAgricluture = "Agriculture, Environmental and Animal Care: Agriculture, Environmental and Animal Care";
        public const string TlevelEducation = "Education and Childcare: Education";
        public const string TlevelEngineering = "Engineering and Manufacturing: Engineering and Manufacturing";
        public const string TlevelHealth = "Health and Science: Health and Science";
        public const string TlevelLegal = "Legal, Finance and Accounting: Health and Science";
        public const string AccessibilityUrl = "https://www.gov.uk/help/accessibility-statement";
        //Reviewer Error Page Titles
        public const string ErrorSelectTlevelReview = "Error: Select a T Level to review page – Manage T Level results – GOV.UK";
        public const string ErrorAreTheseDetailsCorrect = "Error: Are these details correct page – Manage T Level results – GOV.UK";
        public const string ErrorQueryTlevel = "Error: Query T Level details page – Manage T Level results – GOV.UK";
        //Provider Error Page Titles
        public const string ErrorFindProvider = "Error: Find a provider page – Manage T Level results – GOV.UK";
        public const string ErrorSelectProviderTlevel = "Error: Select provider’s T Levels page – Manage T Level results – GOV.UK";
        public const string ErrorAreYouSureRemove = "Error: Are you sure you want to remove this T Level page – Manage T Level results – GOV.UK";
        public const string ErrorAddTlevel = "Error: Add T Levels page – Manage T Level results – GOV.UK";
        //Registration Page
        public const string RegistrationsPageTitle = "Registrations page – Manage T Level results – GOV.UK";
        public const string RegistationPageHeader = "Registrations";
        public const string UploadRegPageTitle = "Upload registrations file page – Manage T Level results – GOV.UK";
        public const string UploadRegPageHeader = "Upload registrations file";
        public const string RegistrationUploadSuccessTitle = "Registrations upload successful page – Manage T Level results – GOV.UK";
        public const string RegistrationSuccessHeader = "Registrations upload successful";
        public const string RegistrationUploadUnSuccessTitle = "Registrations upload unsuccessful page – Manage T Level results – GOV.UK";
        public const string RegistrationUnSuccessHeader = "Registrations upload unsuccessful";
        //Csv Errors
        public const string LineNo = "Line";
        public const string UlnNo = "ULN";
        public const string ErrorMsg = "Error";
    }
}
