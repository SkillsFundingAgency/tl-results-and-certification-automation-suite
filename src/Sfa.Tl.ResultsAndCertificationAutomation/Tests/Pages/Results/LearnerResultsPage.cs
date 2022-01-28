using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Results
{
    public class LearnerResultsPage: ElementHelper
    {
        private static string PageUrl { get; } = "learner-results";
        private static string PageTitle { get; } = "Learner's results – Manage T Level results – GOV.UK";
        private static By AddCoreAssessment { get; } = By.Id(("addCoreAssessmentLink"));
        private static By AddSpecialismAssessment { get; } = By.Id(("addSpecialismAssessmentLink"));

        public static void VerifyLearnerResultsPage()
        {
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
        }

        public static void AddAssessmentLink(string linkName)
        {
            switch (linkName)
            {
                case "Add core assessment":
                    ClickElement(AddCoreAssessment);
                    break;
                case "Add specialism assessment":
                    ClickElement(AddSpecialismAssessment);
                    break;
                case "Core add result":
                    ClickCoreAddResult();
                    break;
                case "Assessment1 add result":
                    ClickAssessment1AddResult();
                    break;
                case "Assessment2 add result":
                    ClickAssessment2AddResult();
                    break;
            }
        }

        private static void ClickCoreAddResult()
        {
            IList<IWebElement> all = WebDriver.FindElements(By.XPath("//*[contains(text(),'Add result')]"));
            all[0].Click();
        }
        private static void ClickAssessment1AddResult()
        {
            IList<IWebElement> all = WebDriver.FindElements(By.XPath("//*[contains(text(),'Add result')]"));
            all[1].Click();
        }
        private static void ClickAssessment2AddResult()
        {
            IList<IWebElement> all = WebDriver.FindElements(By.XPath("//*[contains(text(),'Add result')]"));
            all[2].Click();
        }
    }
}
