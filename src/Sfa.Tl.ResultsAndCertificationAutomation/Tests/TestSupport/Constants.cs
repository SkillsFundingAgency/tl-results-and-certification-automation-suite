using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport
{
    public class Constants
    {
        public const string InvalidUser = "InvalidUser";
        public const string InvalidPass = "InvalidPass";
        public const string Banner = "This is a new service – your feedback will help us to improve it.";
        public const string DashBoardTitle = "Home – Manage T Level results – GOV.UK";
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
        public const string TLevelsPageHeader = "Select a T Level to review";
        public const string TLevelsPageTitle = "Select a T Level to review page – Manage T Level results – GOV.UK";
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
        public const string SelectSpecialismTitle = "Add a new registration - Select the specialism page – Manage T Level results – GOV.UK";
        public const string SelectSpecialismErrorTitle = "Error: Add a new registration - Select the specialism page – Manage T Level results – GOV.UK"; public const string SelectAcademicYearTitle = "Add a new registration - Select the academic year page – Manage T Level results – GOV.UK";
        public const string ManualRegSummaryTitle = "Add a new registration - Check and submit page – Manage T Level results – GOV.UK";
        public const string ReggistrationSuccessTitle = "Add registration - Registration added confirmation page – Manage T Level results – GOV.UK";
        public const string UlnRegisteredWithSameAOTitle = "Add a new registration - ULN already registered page – Manage T Level results – GOV.UK";
        public const string UlnRegisteredWithSameAOHeader = "ULN is already registered";
        public const string UlnRegisteredWithAnotherAOTitle = "Add a new registration - ULN cannot be registered page – Manage T Level results – GOV.UK";
        public const string UlnRegisteredWithAnotherAOHeader = "ULN cannot be registered";
        //Reg Search Page
        public const string SearchRegTitle = "Search for a registration page – Manage T Level results – GOV.UK";
        public const string SearchRegHeader = "Search for a registration";
        public const string SearchNotFoundTitle = "ULN cannot be found page – Manage T Level results – GOV.UK";
        public const string SearchDetailsTitle = "Search for a registration - Registration details page – Manage T Level results – GOV.UK";
        public const string SearchDetailsHeader = "Registration details";
        public const string CancelRegTitle = "Cancel registration page – Manage T Level results – GOV.UK";
        public const string CancelRegHeader = "Are you sure you want to cancel this registration?";
        public const string CancelRegSuccessTitle = "Registration cancelled confirmation page – Manage T Level results – GOV.UK";
        public const string CancelRegSuccessHeader = "Registration cancelled successfully";
        //Registration Search Page
        public const string SearchRegistrationsPageTitle = "Search for a registration page – Manage T Level results – GOV.UK";
        public const string SearchRegistrationURLNotFoundPagePageTitle = "ULN cannot be found page – Manage T Level results – GOV.UK";
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
        public const string ManualRegULN = "9900000001";
        public const string ManualRegFirstName = "Test1";
        public const string ManualRegLastName = "Test2";
        public const string ManualRegDOBDay = "01";
        public const string ManualRegDOBMonth = "02";
        public const string ManualRegDOBYear = "2000";
        //Updated Registration Details
        public const string ManualRegUpdatedFirstName = "UpdatedFirstName";
        public const string ManualRegUpdatedLastName = "UpdatedLastName";
        public const string ManualRegUpdatedDOBDay = "12";
        public const string ManualRegUpdatedDOBMonth = "11";
        public const string ManualRegUpdatedDOBYear = "2010";
        public const string ManualRegUpdatedProvider = "Automation Test3 (99999903)";
        public const string ManualRegUpdatedProvider1 = "Automation Test4 (99999904)";
        public const string ManualRegUpdatedCore = "Engineering and Manufacturing (66666666)";
        public const string ManualRegUpdatedSpecialism = "Design, Development and Control (60000002)";
        //Registration Change DOB Page
        public const string RegistrationChangeDOBPageTitle = "Change registration - Enter the learner's date of birth page – Manage T Level results – GOV.UK";
        public const string RegistrationChangeDOBPageHeading = "Change registration";
        public const string RegistrationChangeDOBPageSubHeading = "Enter the learner's date of birth";
        public const string RegistrationChangeDOBErrorTitle = "Error: Change registration - Enter the learner's date of birth page – Manage T Level results – GOV.UK";
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
        public const string DbDOB = "01/01/2001";
        public const string DbProviderName = "Automation Test1 (99999901)";
        public const string DbCoreName = "Agriculture, Environmental and Animal Care (77777777)";
        //public const string TqProviderId = "9479";
        public const string TqProviderId = "15000";
        public const string TlSpecialismId = "209";
        public const string TqProviderId2 = "15001";
        public const string TqProviderIdForLrs = "15013";
        public const string DbProviderNameForLrs = "Barnsley College (10000536)";
        public const string DudleyProviderIdForLrs = "15014";
        public const string DdudleyProviderNameForLrs = "Dudley College of Technology (10007924)";
        //Reviews And Appeals Data
        public const string RAAName = "Db FirstName Db LastName";
        public const string RAADOB = "01 January 2001";
        public const string RAACoreTitle = "Agriculture, Environmental and Animal Care";
        public const string RAACoreCode = "(77777777)";
        public const string RAATLevelTitle = "T Level in Agriculture, Environmental and Animal Care";
        public const string RAAUKPRN = "Automation Test1";
        public const string RAAProvider = "(99999901)";
        public const string RAAExamPeriod = "Summer 2021";
        public const string RAAOriginalGrade = "A";
    }
}
