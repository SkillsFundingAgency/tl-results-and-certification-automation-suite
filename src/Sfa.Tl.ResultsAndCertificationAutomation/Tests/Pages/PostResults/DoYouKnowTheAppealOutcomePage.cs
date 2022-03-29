using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults
{
    public class DoYouKnowTheAppealOutcomePage : ElementHelper
    {
        private static string PageUrl { get; } = "post-results-appeal-outcome-known";
        private static string PageTitle { get; } = "Appeal outcome known - Post-results – Manage T Level results – GOV.UK";
        private static string PageErrorTitle { get; } = "Error: Appeal outcome known - Post-results – Manage T Level results – GOV.UK";
        private static string PageHeader { get; } = "Do you know the appeal outcome?";
        private static readonly By PageHeaderElement = By.XPath("//*[@id='main-content']//h1");
        private static readonly By LearnerDetailsElement = By.XPath("//*[@id='main-content']/div[1]");
        private static readonly By RadioNoOutcome = By.Id("appealoutcome");
        private static readonly By RadioSameGrade = By.Id("appealoutcome-gradenotchanged");
        private static readonly By RadioGradeChanged = By.Id("appealoutcome-gradechanged");
        private static readonly By ContinueBtn = By.Id("continueButton");
        private static readonly By BackLink = By.Id("backLink");

        protected static void VerifyDoYouKnowTheAppealOutcomePage()
        {
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.AreEqual(PageHeader, WebDriver.FindElement(PageHeaderElement).Text);
        }
        protected static void VerifyDoYouKnowTheAppealOutcomeErrorPage()
        {
            Assert.AreEqual(PageErrorTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
        }
        public static void DoYouKnowAppealOutcomeOptions(string optionName)
        {
            switch (optionName)
            {
                case "No outcome":
                    ClickElement(RadioNoOutcome);
                    ClickButton(ContinueBtn);
                    break;
                case "The grade is the same":
                    ClickElement(RadioSameGrade);
                    ClickButton(ContinueBtn);
                    break;
                case "Grade has changed":
                    ClickElement(RadioGradeChanged);
                    ClickButton(ContinueBtn);
                    break;
            }
        }
        protected static void VerifyBackLink()
        {
            ClickElement(BackLink);
            AddAppealPage.VerifyAddAppealPage();
        }
        protected static void VerifyLearnerCoreDoYouKnowAppealOutcomePage()
        {
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbFirstName + " " + Constants.DbLastName));
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbDateOfBirth));
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbTlevel));
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbCoreComponent));
        }
    }
}
