using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals
{
    public class ReviewAndAppealsLearnerWithdrawnByExamBoardPage : ElementHelper
    {
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "reviews-and-appeals-learner-withdrawn");
        private static string pageTitle { get; } = "Learner has been withdrawn – Manage T Level results – GOV.UK";
        private static string pageHeader { get; } = "Learner has been withdrawn by the exam board";
        private static readonly By pageHeaderElement = By.XPath("//*[@id='main-content']//h1");
        private static By BackToHomeBtn { get; } = By.Id("backButton");
        private static By RegistrationDetailsElement  = By.ClassName("govuk-grid-column-three-quarters");
        private static By BackLink { get; } = By.ClassName("govuk-back-link");

        public static void VerifyLearnerWithdrawnByExamBoardPage()
        {
            Assert.AreEqual(pageUrl, WebDriver.Url);
            Assert.AreEqual(pageTitle, WebDriver.Title);
            Assert.AreEqual(pageHeader, WebDriver.FindElement(pageHeaderElement).Text);
        }


        public static void VerifyLearnerDetails(string ULN)
        {
            Assert.IsTrue(WebDriver.FindElement(RegistrationDetailsElement).Text.Contains(ULN));
            Assert.IsTrue(WebDriver.FindElement(RegistrationDetailsElement).Text.Contains("Db FirstName Db LastName"));
            Assert.IsTrue(WebDriver.FindElement(RegistrationDetailsElement).Text.Contains("01 January 2001"));
            Assert.IsTrue(WebDriver.FindElement(RegistrationDetailsElement).Text.Contains("Barnsley College"));
            Assert.IsTrue(WebDriver.FindElement(RegistrationDetailsElement).Text.Contains("(10000536)"));
            Assert.IsTrue(WebDriver.FindElement(RegistrationDetailsElement).Text.Contains("T Level in Agriculture, Environmental and Animal Care"));
        }


        public static void ClickBackLink()
        {
            ClickElement(BackLink);
        }

        public static void ClickBackToHomeBtn()
        {
            ClickElement(BackToHomeBtn);
        }

    }
}
