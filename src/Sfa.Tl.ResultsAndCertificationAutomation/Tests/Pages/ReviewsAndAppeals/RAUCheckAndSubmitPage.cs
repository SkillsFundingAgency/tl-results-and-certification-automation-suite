using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals
{
    public class RAUCheckAndSubmitPage : ElementHelper
    {
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "reviews-and-appeals-check-and-submit");
        private static string pageTitle { get; } = "Check and submit outcome of core appeal – Manage T Level results – GOV.UK";
        private static By pageHeaderElement { get; } = By.XPath("//*[@id='main-content']//h1");
        private static string  PageHeader { get; } = "Check and submit";
        private static By SubmitBtn { get; } = By.Id("submitButton");
        private static By CancelBtn { get; } = By.Id("cancelLink");
        private static By ChangeLink { get; } = By.Id("newGrade");
        private static By backLink { get; } = By.Id("backLink");
        private static By learnerDetailsElement { get; } = By.XPath("//*[@id='main-content']/div/div/form");
        private static By newGradeElement = By.XPath("//*[@id='main-content']//form/dl[2]/div[2]/dd[1]");
        private static By oldGradeElement = By.XPath("//*[@id='main-content']//form/dl[2]/div[1]/dd[1]");
        private static By helpTextElement = By.ClassName("govuk-inset-text");

        public static void VerifyCheckAndSubmitPage()
        {
            Assert.AreEqual(pageUrl, WebDriver.Url);
            Assert.AreEqual(pageTitle, WebDriver.Title);
            Assert.AreEqual(PageHeader, WebDriver.FindElement(pageHeaderElement).Text);
        }

        public static void VerifyRAULearnerDetails(string ULN)
        {
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(ULN));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RAAName));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RAADOB));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RAAProvider));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RAAUKPRN));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RAATLevelTitle));
        }

        public static void VerifyCoreDetails()
        {
            string CoreCode = "Core (code): " + Constants.RAACoreTitle + " " + Constants.RAACoreCode;
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(CoreCode));
        }

        public static void VerifyGradeDetailsWhenGradeIsSame(string ULN)
        {
            //Get current grade from TqPathwayResult table and compare against old and new grade on screen
            string OldGrade = SqlQueries.RetrieveLatestGrade(ULN);
            Assert.IsTrue(WebDriver.FindElement(newGradeElement).Text.Contains(OldGrade));
            Assert.IsTrue(WebDriver.FindElement(oldGradeElement).Text.Contains(OldGrade));
        }

        public static void VerifyGradeDetailsWhenNewGradeSelected(string ULN)
        {
            //Get current grade from TqPathwayResult table and compare against old and new grade on screen
            string OldGrade = SqlQueries.RetrieveLatestGrade(ULN);
            Assert.IsTrue(WebDriver.FindElement(newGradeElement).Text.Contains("B"));
            Assert.IsTrue(WebDriver.FindElement(oldGradeElement).Text.Contains(OldGrade));
        }


        public static void ClickBackLink()
        {
            ClickButton(backLink);
        }

        public static void ClickSubmitBtn()
        {
            ClickButton(SubmitBtn);
        }

        public static void ClickCancelBtn()
        {
            ClickButton(CancelBtn);
        }

        public static void ClickChangeLink()
        {
            ClickButton(ChangeLink);
        }

        public static void VerifyHelpText()
        {
            Assert.IsTrue(WebDriver.FindElement(helpTextElement).Text.Contains("Selecting 'Submit' will update the grade and mean the grade is no longer being appealed")); 
        }

    }
}
