using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport
{
    public static class Constants
    {
        public const string DashBoardTitle = "Home – Manage T Level results – GOV.UK";
        public const string DashBoardHeader = "Manage T Level results";
        public const string CookieHeader = "Cookies";
        private static string StartPageUrl => WebDriverFactory.Config["BaseUrl"];
        public static string TlevelDashboardUrl => string.Concat(StartPageUrl, "dashboard");
        public const string Error404 = "Page not found";
        public const string Error401 = "Access denied";
        public const string Error500 = "Sorry, there is a problem with the service";
        public const string TlevelTitleAgricluture = "T Level in Agriculture, Environmental and Animal Care";
        public const string TlevelTitleEducation = "T Level in Education and Childcare";
        public const string AccessibilityUrl = "https://www.gov.uk/help/accessibility-statement";
        public const string ProviderPageHeader = "Which provider do you want to manage?";
        public const string ProviderPageTitle = "Manage providers – Manage T Level results – GOV.UK";
        public const string PrivacyPageTitle = "Privacy policy page – Manage T Level results – GOV.UK";
        public const string UserGuideTitle = "User guide page – Manage T Level results – GOV.UK";
        //Reviewer Error Page Titles
        public const string ErrorSelectTlevelReview = "Error: Select a T Level to review page – Manage T Level results – GOV.UK";
        public const string ErrorAreTheseDetailsCorrect = "Error: Are these details correct page – Manage T Level results – GOV.UK";
        public const string ErrorQueryTlevel = "Error: Query T Level details page – Manage T Level results – GOV.UK";
        //Provider Error Page Titles
        public const string ErrorFindProvider = "Error: Manage providers – Manage T Level results – GOV.UK";
        public const string ErrorSelectProviderTlevel = "Error: Select provider’s T Levels page – Manage T Level results – GOV.UK";
        public const string ErrorAreYouSureRemove = "Error: Are you sure you want to remove this T Level page – Manage T Level results – GOV.UK";
        public const string ErrorAddTlevel = "Error: Add T Levels page – Manage T Level results – GOV.UK";
        //Registration Page
        public const string RegistrationsPageTitle = "Registrations – Manage T Level results – GOV.UK";
        public const string RegistationPageHeader = "Registrations";
        public const string UploadRegPageTitle = "Upload multiple registrations – Manage T Level results – GOV.UK";
        public const string UploadRegPageHeader = "Upload multiple registrations";
        public const string UploadRegPageErrorTitle = "Error: Upload multiple registrations – Manage T Level results – GOV.UK";
        public const string RegistrationUploadSuccessTitle = "Registrations upload success – Manage T Level results – GOV.UK";
        public const string RegistrationSuccessHeader = "Registrations uploaded successfully";
        public const string RegistrationUploadUnSuccessTitle = "Registrations upload error – Manage T Level results – GOV.UK";
        public const string RegistrationUnSuccessHeader = "There is a problem";
        public const string UlnPageTitle = "Add a new registration - Enter Unique Learner Number page – Manage T Level results – GOV.UK";
        public const string UlnPageErrorTitle = "Error: Add a new registration - Enter Unique Learner Number page – Manage T Level results – GOV.UK";
        public const string LearnerPageTitle = "Add a new registration - Enter the learner’s name page – Manage T Level results – GOV.UK";
        public const string LearnerPageErrorTitle = "Error: Add a new registration - Enter the learner’s name page – Manage T Level results – GOV.UK";
        public const string DobPageTitle = "Add a new registration - Enter the learner’s date of birth page – Manage T Level results – GOV.UK";
        public const string DobPageErrorTitle = "Error: Add a new registration - Enter the learner’s date of birth page – Manage T Level results – GOV.UK";
        public const string SelectProviderTitle = "Add a new registration - Select the provider page – Manage T Level results – GOV.UK";
        public const string SelectProviderErrorTitle = "Error: Add a new registration - Select the provider page – Manage T Level results – GOV.UK";
        public const string SelectCoreTitle = "Add a new registration - Select the core page – Manage T Level results – GOV.UK";
        public const string SelectCoreErrorTitle = "Error: Add a new registration - Select the core page – Manage T Level results – GOV.UK";
        public const string SpecialismDecideTitle = "Add a new registration - Has the learner decided on the specialism page – Manage T Level results – GOV.UK";
        public const string SpecialismDecideErrorTitle = "Error: Add a new registration - Has the learner decided on the specialism page – Manage T Level results – GOV.UK";
        public const string SelectSpecialismTitle = "Add a new registration - Select the specialism – Manage T Level results – GOV.UK";
        public const string SelectSpecialismErrorTitle = "Error: Add a new registration - Select the specialism – Manage T Level results – GOV.UK"; public const string SelectAcademicYearTitle = "Add a new registration - Select the academic year page – Manage T Level results – GOV.UK";
        public const string ManualRegSummaryTitle = "Add a new registration - Check and submit page – Manage T Level results – GOV.UK";
        public const string ReggistrationSuccessTitle = "Add registration - Registration added confirmation page – Manage T Level results – GOV.UK";
        public const string UlnRegisteredWithSameAoTitle = "Add a new registration - ULN already registered page – Manage T Level results – GOV.UK";
        public const string UlnRegisteredWithSameAoHeader = "ULN is already registered";
        public const string UlnRegisteredWithAnotherAoTitle = "Add a new registration - ULN cannot be registered page – Manage T Level results – GOV.UK";
        public const string UlnRegisteredWithAnotherAoHeader = "ULN cannot be registered";
        //Reg Search Page
        public const string SearchDetailsTitle = "Search for a registration - Registration details page – Manage T Level results – GOV.UK";
        public const string SearchDetailsHeader = "Registration details";
        //Registration Search Page
        public const string SearchRegistrationsPageTitle = "Search for a registration page – Manage T Level results – GOV.UK";
        public const string SearchRegistrationUrlNotFoundPagePageTitle = "ULN cannot be found page – Manage T Level results – GOV.UK";
        //Registration ChangeName Page
        public const string RegistrationChangeNamePageTitle = "Change registration - Enter the learner's name page – Manage T Level results – GOV.UK";
        public const string RegistrationChangeNamePageHeading = "Change registration";
        public const string RegistrationChangeNamePageSubHeading = "Enter the learner's name";
        public const string RegistrationChangeNameErrorTitle = "Error: Change registration - Enter the learner's name page – Manage T Level results – GOV.UK";
        //Page Not Found Page
        public const string PageNotFoundPageTitle = "Page not found – Manage T Level results – GOV.UK";
        //Registration Change Success Page
        public const string RegistrationChangeSuccessPageTitle = "Registration details change confirmation page – Manage T Level results – GOV.UK";
        public const string RegistrationChangeSuccessPageHeader = "Change successful";
        //Manual Registration Details
        public const string ManualRegUln = "9900000001";
        public const string ManualRegFirstName = "Test1";
        public const string ManualRegLastName = "Test2";
        public const string ManualRegDobDay = "01";
        public const string ManualRegDobMonth = "02";
        public const string ManualRegDobYear = "2000";
        //Updated Registration Details
        public const string ManualRegUpdatedProvider = "Automation Test3 (99999903)";
        public const string ManualRegUpdatedProvider1 = "Automation Test4 (99999904)";
        public const string ManualRegUpdatedCore = "Engineering and Manufacturing (66666666)";
        public const string ManualRegUpdatedSpecialism = "Design, Development and Control (60000002)";
        //Registration Change DOB Page
        public const string RegistrationChangeDobPageTitle = "Change registration - Enter the learner's date of birth page – Manage T Level results – GOV.UK";
        public const string RegistrationChangeDobPageHeading = "Change registration";
        public const string RegistrationChangeDobPageSubHeading = "Enter the learner's date of birth";
        public const string RegistrationChangeDobErrorTitle = "Error: Change registration - Enter the learner's date of birth page – Manage T Level results – GOV.UK";
        //Registration Amend Active Registration Page
        public const string AmendActiveRegistrationPageTitle = "What would you like to do with this active registration page – Manage T Level results – GOV.UK";
        public const string AmendActiveRegistrationPageHeading = "What would you like to do with this active registration?";
        public const string RegistrationsActiveOptionsPageErrorTitle = "Error: What would you like to do with this active registration page – Manage T Level results – GOV.UK";
        //Registration Withdraw Registration Page
        public const string WithdrawRegistrationPageTitle = "Withdraw registration page – Manage T Level results – GOV.UK";
        public const string WithdrawRegistrationPageHeading = "Are you sure you want to withdraw this registration?";
        public const string WithdrawRegistrationPageErrorTitle = "Error: Withdraw registration page – Manage T Level results – GOV.UK";
        //Registration Withdrawn Registration Options Page
        public const string WithdrawnRegOptionsPageTitle = "What would you like to do with this withdrawn registration page – Manage T Level results – GOV.UK";
        public const string WithdrawnRegOptionsPageHeading = "What would you like to do with this withdrawn registration?";
        public const string WithdrawnRegOptionsPageErrorTitle = "Error: What would you like to do with this withdrawn registration page – Manage T Level results – GOV.UK";
        //Registration data in DB
        public const string DbFirstName = "Db FirstName";
        public const string DbLastName = "Db LastName";
        public const string DbDob = "01/01/2001";
        public const string DbProviderName = "Automation Test1 (99999901)";
        public const string DbCoreName = "Agriculture, Environmental and Animal Care (77777777)";
        //public const string TqProviderId = "9479";
        public const string TqProviderId = "15166";
        public const string TlSpecialismId = "42";
        public const string TlAssessmentSeriesId = "7";
        public const string TqProviderId2 = "15167";
        public const string TqProviderIdForLrs = "15179";
        public const string DbProviderNameForLrs = "Barnsley College (10000536)";
        public const string DudleyProviderIdForLrs = "15181";
        public const string DdudleyProviderNameForLrs = "Dudley College of Technology (10007924)";
        //Reviews And Appeals Data
        public const string RaaName = "Db FirstName Db LastName";
        public const string Raadob = "01 January 2001";
        public const string RaaCoreTitle = "Agriculture, Environmental and Animal Care";
        public const string RaaCoreCode = "(77777777)";
        public const string RaatLevelTitle = "T Level in Agriculture, Environmental and Animal Care";
        public const string Raaukprn = "Automation Test1";
        public const string RaaProvider = "(99999901)";
        public const string RaaExamPeriod = "Summer 2021";
        public const string RaaOriginalGrade = "A";
        // City and Guillds
        public const string CityAndGuildsProviderId = "15399";
        public const string HeatingSpecialismId = "11";
        public const string VentilationSpecialismId = "16";
        public const string PathwayAssessmentSeriesId = "2";
        public const string GasEngineeringId = "12";
    }
}
