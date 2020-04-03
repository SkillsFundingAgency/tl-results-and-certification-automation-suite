using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class ManageTLevel : ElementHelper
    {
        //Urls
        private static string ViewTlevel => string.Concat(StartPage.StartPageUrl, "view-all-tlevels");
        private static string ReviewTlevel => string.Concat(StartPage.StartPageUrl, "tlevel-select");
        private static string QueryTlevel => string.Concat(StartPage.StartPageUrl, "report-tlevel-issue");
        // Common Objects
        private By ContinueBtn = By.XPath("//button[contains (text(), 'Continue')]");
        private By ServiceBanner = By.XPath("//a[@href='/dashboard']");
        private By TlevelsLink = By.XPath("//a[@href='/tlevels']");
        // Are these details correct page
        private By EverythingCorrectRadioBtn = By.XPath("//input[@id='tl-verify-yes']");
        private By SomethingWrongRadoiBtn = By.XPath("//input[@id='tl-verify-no']");
        //Tlevel confirmation page
        private By ViewYourTlevelBtn = By.XPath("//button[contains (text(), 'View your T Levels')]");
        private By PageTitle = By.TagName("h1");
        private const string TlevelConfirmantionMsg = "T Level details confirmed";
        //View Tlevel details
        private By HomeBtn = By.XPath("//a[contains (text(), 'Home')]");
        private By SomethingNotRightLink = By.XPath("//a[contains (text(), 'Something is not right')]");
        //Query Tlevel details
        private By QueryDetails = By.Id("more-detail");
        private By QuerySubmit = By.XPath("//button[contains (text(), 'Submit')]");
        //Database Query
        private static string ConnectionString = WebDriverFactory.Config["DBConnectionString"];
        private const string SQLUpdatetHealth = "Update TqAwardingOrganisation set ReviewStatus=1 where TlRouteId=9";
        private const string SQLUpdatetLegal = "Update TqAwardingOrganisation set ReviewStatus=1 where TlRouteId=10";
        private const string SQLUpdatetEngineering = "Update TqAwardingOrganisation set ReviewStatus=1 where TlRouteId=11";
        private const string SQLUpdatetAgriculture = "Update TqAwardingOrganisation set ReviewStatus=1 where TlRouteId=12";
        private readonly By Health = By.XPath("//*[contains(text(),'Health and Science')]");
        private readonly By Legal = By.XPath("//*[contains(text(),'Legal')]");
        private readonly By Engineering = By.XPath("//*[contains(text(),'Engineering')]");
        private readonly By Agriculture = By.XPath("//*[contains(text(),'Agriculture')]");


        public void ConfirmTlevelsingle(By by)
        {
            ClickElement(TlevelsLink);
            Assert.AreEqual(WebDriver.Url, ReviewTlevel);
            ClickElement(by);
            ClickElement(ContinueBtn);
        }

        public void EverythingCorrect()
        {
            ClickElement(EverythingCorrectRadioBtn);
            ClickElement(ContinueBtn);
        }

        public void SomethingWrong()
        {
            ClickElement(SomethingWrongRadoiBtn);
            ClickElement(ContinueBtn);
        }

        public void UpdatetHealth()
        {
            SqlDatabaseConncetionHelper.UpdateSqlCommand(SQLUpdatetHealth, ConnectionString);
        }

        public void ReviewTLevel()
        {
            ConfirmTlevelsingle(Health);
            EverythingCorrect();
            Assert.IsTrue(WebDriver.FindElement(PageTitle).Text.Contains(TlevelConfirmantionMsg));
        }
    }
}
