using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals
{
    public class RAUAddOutcomeOfAppealPage : ElementHelper
    {
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "reviews-and-appeals-uln-not-found");
        private static string pageTitle { get; } = "Add outcome of core appeal – Manage T Level results – GOV.UK";
        private static By pageHeaderElement { get; } = By.XPath("//*[@id='main-content']//h1");
        private static string  PageHeader { get; } = "Add outcome of appeal";
        private static By continueBtn { get; } = By.Id("buttonSearchAgain");
        private static By backLink { get; } = By.Id("");
        private static By theGradeIsTheSameRadioBtn = By.Id("appealoutcome");
        private static By iNeedToUpdateTheGradeRadioBtn = By.Id("appealoutcome-updategrade");
        private static By learnerDetailsElement = By.ClassName("govuk-grid-column-two-thirds");
        private static By originalGrade = By.XPath("//*[@id='main-content']//div[6]");


        public static void VerifyRAULearnersComponentGradesStatusPage()
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
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RAACoreTitle));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RAACoreCode));
            Assert.IsTrue(WebDriver.FindElement(learnerDetailsElement).Text.Contains(Constants.RAAExamPeriod));
            Assert.IsTrue(WebDriver.FindElement(originalGrade).Text.Contains(Constants.RAAOriginalGrade));
        }


        public static void ClickBackLink()
        {
            ClickButton(backLink);
           
        }

        public static void SelectGradeIsSameRadioBtn()
        {
            ClickButton(theGradeIsTheSameRadioBtn);
        }

        public static void SelectINeedToUpdateTheGradeRadioBtn()
        {
            ClickButton(iNeedToUpdateTheGradeRadioBtn);
        }

        public static void ClickContinueBtn()
        {
            ClickButton(continueBtn);
        }

        public static void VerifyRadioButtonsNotPrepopulated()
        {
            Assert.AreEqual(false, WebDriver.FindElement(iNeedToUpdateTheGradeRadioBtn).Selected);
            Assert.AreEqual(false, WebDriver.FindElement(theGradeIsTheSameRadioBtn).Selected);
        }




    }
}
