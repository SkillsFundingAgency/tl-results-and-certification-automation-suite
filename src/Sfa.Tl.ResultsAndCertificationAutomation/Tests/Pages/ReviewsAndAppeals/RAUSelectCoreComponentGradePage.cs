using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals
{
    public class RAUSelectCoreComponentGradePage : ElementHelper
    {
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "reviews-and-appeals-appeal-update-grade");
        private static string pageTitle { get; } = "Select core component grade – Manage T Level results – GOV.UK";
        private static By pageHeaderElement { get; } = By.XPath("//*[@id='main-content']//h1");
        private static string  PageHeader { get; } = "Select the core component grade";
        private static By continueBtn { get; } = By.Id("continueButton");
        private static By learnerDetailsElement { get; } = By.ClassName("govuk-grid-column-two-thirds");
        private static By backLink = By.Id("backLink");



        public static void VerifySelectTheCoreComponentGradePage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            Assert.AreEqual(pageTitle, WebDriver.Title);
            Assert.AreEqual(PageHeader, pageHeaderElement);
        }

        public static void VerifyRAULearnerDetails(string ULN)
        {
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(ULN));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains("Db FirstName Db LastName"));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains("01 January 2001"));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains("Summer 2021"));
            //add check for core code
            //add check for old grade
        }

        public static void ClickBackLink()
        {
            ClickButton(backLink);
        }

        public static void VerifyPreviousGradeRadioBtnPrepopulated()
        {
           //insert code here
           
        }




    }
}
