using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class ManageTLevel : ElementHelper
    {
        //Urls
        public static string ViewTlevel => string.Concat(StartPage.StartPageUrl, "your-tlevels");
        public static string ReviewTlevel => string.Concat(StartPage.StartPageUrl, "select-tlevel");
        public static string AreDetailsCorrect => string.Concat(StartPage.StartPageUrl, "are-details-correct");
        public static string TlevelConfirmation => string.Concat(StartPage.StartPageUrl, "tlevel-details-confirmed");
        public static string QueryTlevel => string.Concat(StartPage.StartPageUrl, "query-tlevel-details");
        public static string QueryTlevelConfirmation => string.Concat(StartPage.StartPageUrl, "tlevel-details-queried-confirmation");
        public static string VerifyTlevel => string.Concat(StartPage.StartPageUrl, "verify-tlevel");
        public static string TlevelDetails => string.Concat(StartPage.StartPageUrl, "tlevel-details");
        public static string ConfirmTlevel => string.Concat(StartPage.StartPageUrl, "confirm-tlevel");
        // Common Objects
        private readonly By ContinueBtn = By.XPath("//button[contains (text(), 'Continue')]");
        private readonly By TlevelsLink = By.XPath("//a[@href='/tlevels']");
        // Are these details correct page
        private readonly By EverythingCorrectRadioBtn = By.XPath("//input[@id='iseverythingcorrect']");
        private readonly By SomethingWrongRadoiBtn = By.XPath("//input[@id='tl-verify-no']");
        //Tlevel confirmation page
        public By PageTitle = By.TagName("h1");
        public const string TlevelConfirmantionMsg = "T Level details confirmed";
        public const string TlevelConfirmantionPageTitle = "T Level details confirmed page – Manage T Level results – GOV.UK";
        public const string TLevelViewPageTitle = "View all T Levels page";
        public const string QueryTLevelPageTitle = "Query T Level details page – Manage T Level results – GOV.UK";
        public const string QueryConfirmPageTitle = "T Level details queried confirmation page – Manage T Level results – GOV.UK";
        public const string TlevelDetailsPageHeader = "T Level details";
        public const string QueriedDetailsPageTitle = "Queried T Level Details page – Manage T Level results – GOV.UK";
        //View Tlevel details
        private readonly By SomethingNotRightLink = By.XPath("//a[contains (text(), 'Query T Level details')]");
        private readonly By ReviewAnotherLink = By.XPath("//a[contains(text(),'Review another T Level')]");
        private readonly By ViewReviedLink = By.XPath("//a[contains(text(),'View reviewed T levels')]");
        private readonly By ViewConfirmedTlevelLink = By.XPath("//a[contains(@href,'tlevel-details')]");
        public const string SelectTLevelPageTitle = "Select a T Level to review page – Manage T Level results – GOV.UK";
        public const string AreDetailsCorrectPageTitle = "Are these details correct page – Manage T Level results – GOV.UK";
        public const string VerifyTLevelPageTitle = "Your reviewed T Levels page – Manage T Level results – GOV.UK";
        public const string ConfirmedTLevelPageTitle = "Confirmed T Level Details page – Manage T Level results – GOV.UK";
        public By PageContent = By.XPath("//*[@id='main-content']");
        public const string SelectTLevelReviewPageTitle = "Select a T Level to review page – Manage T Level results – GOV.UK";
        public const string SelectTLevelReviewPageHeader = "Select a T Level to review";
        //Query Tlevel details
        private readonly By QueryDetails = By.Id("query");
        public By QuerySubmit = By.XPath("//button[contains (text(), 'Submit')]");
        private static readonly string QueryText = "Queried by Automation Tests";
        public const string TlevelQueryMsg = "T Level details queried";
        //Database Query
        private static readonly string ConnectionString = WebDriverFactory.Config["DBConnectionString"];
        private const string UpdateDBReview = "Update TqAwardingOrganisation set ReviewStatus=1 where TlAwardingOrganisatonId=1";
        public readonly By Health = By.XPath("//*[contains(text(),'T Level in Health and Science')]");
        public readonly By Legal = By.XPath("//*[contains(text(),'T Level in Legal')]");
        public readonly By Engineering = By.XPath("//*[contains(text(),'T Level in Engineering')]");
        public readonly By Agriculture = By.XPath("//*[contains(text(),'T Level in Agriculture')]");
        //Breadcrumb
        public By BcTlevelDetails = By.XPath("//a[@id='breadcrumb2']");
        public By BcYourTlevels = By.XPath("//a[@id='breadcrumb1']");

        public void DbUpdate()
        {
            SqlDatabaseConncetionHelper.ExecuteSqlCommand(UpdateDBReview, ConnectionString);
        }
        public void ClickTlevelLink()
        {
            ClickElement(TlevelsLink);
        }
        public void SelectTlevel(By by)
        {
            ClickElement(by);
        }
        public void ClickContinueBtn()
        {
            ClickElement(ContinueBtn);
        }
        public void ReviewAnotherTlevelLink()
        {
            ClickElement(ReviewAnotherLink);
        }
        public void ViewReviewedTlevelLink()
        {
            ClickElement(ViewReviedLink);
        }

        public void ClickViewConfirmedTlevel()
        {
            ClickElement(ViewConfirmedTlevelLink);
        }

        public void EverythingCorrect()
        {
            ClickElement(EverythingCorrectRadioBtn);
        }
        public void ClickSomethingNotRightLink()
        {
            ClickElement(SomethingNotRightLink);
        }

        public void SomethingWrong()
        {
            ClickElement(SomethingWrongRadoiBtn);
        }
        public void QueryTlevelText()
        {
            EnterText(QueryDetails, QueryText);
            ClickElement(QuerySubmit);
        }
    }
}
