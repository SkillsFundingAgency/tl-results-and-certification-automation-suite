using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals
{
    public class RAUExceptionsRequestCompletePage : ElementHelper
    {
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "appeal-after-deadline-request-sent");
        private static string pageTitle { get; } = "Appeal after deadline request sent – Manage T Level results – GOV.UK";
        private static By pageHeaderElement { get; } = By.XPath("//*[@id='main-content']//h1");
        private static string  PageHeader { get; } = "Request to record an appeal complete";
        private static By searchAgainBtn { get; } = By.Id("submitButton");
        private static By backToHomeBtn { get; } = By.Id("backLink");    

        public static void VerifyExceptionConfirmAppealPage()
        {
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            Assert.AreEqual(pageTitle, WebDriver.Title);
            Assert.AreEqual(PageHeader, WebDriver.FindElement(pageHeaderElement).Text);
        }
 

        public static void ClickBackToHomeBtn()
        {
            ClickButton(backToHomeBtn);
           
        }

        public static void ClickSearchAgainBtn()
        {
            ClickButton(searchAgainBtn);
        }     
    }
}
