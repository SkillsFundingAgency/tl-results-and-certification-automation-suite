using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Results
{
    public class LearnerWithdrawnPage : ElementHelper
    {
        private static string PageUrl { get; } = "results-learner-withdrawn";
        private static string PageTitle { get; } = "Learner withdrawn - Results – Manage T Level results – GOV.UK";
        private static By PageHeadElement { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By PageContent { get; } = By.XPath("//*[@id='main-content']");
        private const string PageHeader = "Db FirstName Db LastName is withdrawn";
        private const string PageInlineText = "This learner’s registration has been withdrawn. You cannot change or add a result. Please speak to your organisation’s registrations editor to change this learner’s status.";
        private static By BackLink { get; } = By.Id("backLink");
        private static By SearchAgainBtn { get; } = By.Id("searchAgainButton");
        private static By BackHomeBtn { get; } = By.Id("backToHomeButton");
        private static By SearchBtn { get; } = By.Id("searchButton");

        protected static void VerifyLearnerWithdrawnPage()
        {
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.AreEqual(PageHeader, WebDriver.FindElement(PageHeadElement).Text);
            Assert.IsTrue(WebDriver.FindElement(PageContent).Text.Contains(PageInlineText));
        }

        protected static void VerifyBackLink(string uln)
        {
            ClickElement(BackLink);
            ResultsSearchForALearnerPage.VerifyResultsSearchLearnerPage();
            ResultsSearchForALearnerPage.VerifySearchFieldIsPrePopulated(uln);
        }

        protected static void VerifyBackToHome()
        {
            ClickButton(BackHomeBtn);
            TlevelDashboardPage.VerifyDashboardpage();
        }

        protected static void VerifySearchAgain()
        {
            ClickButton(SearchAgainBtn);
            ResultsSearchForALearnerPage.VerifyResultsSearchLearnerPage();
            ResultsSearchForALearnerPage.VerifySearchFieldIsEmpty();
        }

        protected static void ClickSearchBtn()
        {
            ClickButton(SearchBtn);
        }
    }
}
