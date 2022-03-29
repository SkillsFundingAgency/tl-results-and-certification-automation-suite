using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults
{
    public class DoYouKnowTheRommOutcomePage : ElementHelper
    {
        private static string PageUrl { get; } = "post-results-add-romm-outcome";
        private static string PageTitle { get; } = "ROMM outcome - Post-results – Manage T Level results – GOV.UK";
        private static string PageErrorTitle { get; } = "Error: ROMM outcome - Post-results – Manage T Level results – GOV.UK";
        private static string PageHeader { get; } = "Do you know the ROMM outcome?";
        private static readonly By PageHeaderElement = By.XPath("//*[@id='main-content']//h1");
        private static readonly By LearnerDetailsElement = By.XPath("//*[@id='main-content']/div[1]");
        private static readonly By RadioNoGradeChanged = By.Id("rommoutcome");
        private static readonly By RadioGradeChanged = By.Id("rommoutcome-gradechanged");
        private static readonly By RadioGradeWithdrawn = By.Id("appealoutcome-withdraw");
        private static readonly By ContinueBtn = By.Id("continueButton");

        protected static void VerifyDoYouKnowTheRommOutcomePage()
        {
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.AreEqual(PageHeader, WebDriver.FindElement(PageHeaderElement).Text);
        }
        protected static void VerifyDoYouKnowTheRommOutcomeErrorPage()
        {
            Assert.AreEqual(PageErrorTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
        }

        public static void DoYouKnowRommOutcomeOptions(string optionName)
        {
            switch (optionName)
            {
                case "No change to grade":
                    ClickElement(RadioNoGradeChanged);
                    ClickButton(ContinueBtn);
                    break;
                case "The grade has changed":
                    ClickElement(RadioGradeChanged);
                    ClickButton(ContinueBtn);
                    break;
                case "ROMM withdrawn":
                    ClickElement(RadioGradeWithdrawn);
                    ClickButton(ContinueBtn);
                    break;
            }
        }

        protected static void ClickContinue() => ClickButton(ContinueBtn);
        protected static void VerifyLearnerOs1DoYouKnowRommOutcomePage()
        {
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbFirstName + " " + Constants.DbLastName));
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbDateOfBirth));
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbTlevel));
            Assert.IsTrue(WebDriver.FindElement(LearnerDetailsElement).Text.Contains(Constants.DbOs1Component));
        }
    }
}
