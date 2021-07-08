using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals
{
    public class RAUCheckAndSubmitPage : ElementHelper
    {
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "reviews-and-appeals-check-and-submit");
        private static string pageTitle { get; } = "Learner’s component grade status – Manage T Level results – GOV.UK";
        private static By pageHeaderElement { get; } = By.XPath("//*[@id='main-content']//h1");
        private static string  PageHeader { get; } = "Check and submit";
        private static By SubmitBtn { get; } = By.Id("submitButton");
        private static By CancelBtn { get; } = By.Id("cancelLink");
        private static By ChangeLink { get; } = By.Id("newGrade");

        private static By backLink { get; } = By.Id("backLink");
        private static By learnerDetailsElement { get; } = By.ClassName("govuk-grid-column-two-thirds");

        private static By coreCodeElement = By.ClassName("govuk-heading-m");


        public static void VerifyCheckAndSubmitPage()
        {
            Assert.AreEqual(pageUrl, WebDriver.Url);
            Assert.AreEqual(pageTitle, WebDriver.Title);
            Assert.AreEqual(PageHeader, pageHeaderElement);
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
            string CoreCode = Constants.RAACoreTitle + " " + Constants.RAACoreCode;
            Assert.IsTrue(WebDriver.FindElement(coreCodeElement).Text.Contains(CoreCode));
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

    }
}
