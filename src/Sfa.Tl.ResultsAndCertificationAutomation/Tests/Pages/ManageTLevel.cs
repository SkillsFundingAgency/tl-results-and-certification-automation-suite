using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class ManageTLevel : ElementHelper
    {
        //Urls
        public static string ViewTlevel => string.Concat(StartPage.StartPageUrl, "view-all-tlevels");
        public static string ReviewTlevel => string.Concat(StartPage.StartPageUrl, "tlevel-select");
        private static string QueryTlevel => string.Concat(StartPage.StartPageUrl, "report-tlevel-issue");
        // Common Objects
        private By ContinueBtn = By.XPath("//button[contains (text(), 'Continue')]");
        private By ServiceBanner = By.XPath("//a[@href='/dashboard']");
        private By TlevelsLink = By.XPath("//a[@href='/tlevels']");
        // Are these details correct page
        private By EverythingCorrectRadioBtn = By.XPath("//input[@id='iseverythingcorrect']");
        private By SomethingWrongRadoiBtn = By.XPath("//input[@id='tl-verify-no']");
        //Tlevel confirmation page
        private By ViewYourTlevelBtn = By.XPath("//button[contains (text(), 'View your T Levels')]");
        public By PageTitle = By.TagName("h1");
        public const string TlevelConfirmantionMsg = "T Level details confirmed";
        //View Tlevel details
        private By HomeBtn = By.XPath("//a[contains (text(), 'Home')]");
        private By SomethingNotRightLink = By.XPath("//a[contains (text(), 'Something is not right')]");
        private By ReviewAnotherLink = By.XPath("//a[contains(text(),'Review another T Level')]");
        private By ViewReviedLink = By.XPath("//a[contains(text(),'View reviewed T levels')]");
        private By ViewConfirmedTlevelLink = By.XPath("//a[contains(@href,'tlevel-details')]");
        //Query Tlevel details
        private By QueryDetails = By.Id("query");
        private By QuerySubmit = By.XPath("//button[contains (text(), 'Submit')]");
        private static string QueryText = "Queried by Automation Tests";
        public const string TlevelQueryMsg = "T Level details queried";
        //Database Query
        private static string ConnectionString = WebDriverFactory.Config["DBConnectionString"];
        private const string UpdateDBReview = "Update TqAwardingOrganisation set ReviewStatus=1 where TlAwardingOrganisatonId=1";
        public readonly By Health = By.XPath("//*[contains(text(),'Health and Science')]");
        public readonly By Legal = By.XPath("//*[contains(text(),'Legal')]");
        public readonly By Engineering = By.XPath("//*[contains(text(),'Engineering')]");
        public readonly By Agriculture = By.XPath("//*[contains(text(),'Agriculture')]");

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
