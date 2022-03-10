using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults
{
    public class AddRommOutcomePage : ElementHelper
    {
        private static string PageUrl { get; } = "post-results-romm-outcome-known";
        private static string PageTitle { get; } = "ROMM outcome known - Post-results – Manage T Level results – GOV.UK";
        private static string PageErrorTitle { get; } = "Error: ROMM outcome known - Post-results – Manage T Level results – GOV.UK";
        private static string PageHeader { get; } = "Add a ROMM outcome";
        private static readonly By PageHeaderElement = By.XPath("//*[@id='main-content']//h1");
        private static readonly By RadioGradeChanged = By.Id("rommoutcome");
        private static readonly By RadioGradeSame = By.Id("rommoutcome-gradenotchanged");
        private static readonly By RadioNo = By.Id("appealoutcome-no");
        private static readonly By ContinueBtn = By.Id("continueButton");
        private static readonly By BackLink = By.Id("backLink");

        protected static void ClickContinueBtn() => ClickButton(ContinueBtn);
        protected static void VerifyAddRommOutcomePage()
        {
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
            Assert.AreEqual(PageHeader, WebDriver.FindElement(PageHeaderElement).Text);
        }
        protected static void VerifyAddRommOutcomeErrorPage()
        {
            Assert.AreEqual(PageErrorTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
        }

        protected static void AddRommOutcomeOptions(string optionName)
        {
            switch (optionName)
            {
                case "Yes, the grade has changed":
                    ClickElement(RadioGradeChanged);
                    ClickButton(ContinueBtn);
                    break;
                case "Yes, the grade is the same":
                    ClickElement(RadioGradeSame);
                    ClickButton(ContinueBtn);
                    break;
                case "No, grade outcome":
                    ClickElement(RadioNo);
                    ClickButton(ContinueBtn);
                    break;
            }
        }

        protected static void VerifyBackLink()
        {
            ClickElement(BackLink);
            AddRommPage.VerifyAddRommPage();
        }
    }
}
 