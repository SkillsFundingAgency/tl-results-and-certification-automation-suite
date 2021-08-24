using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.TLevelReview
{
    public class QueryTLevelPageDetailsPage : ElementHelper
    {
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "query-t-level");
        private static string pageTitle { get; } = "Query T Level – Manage T Level results – GOV.UK";
        private static string pageHeader { get; } = "Query T Level details";
        private static readonly By pageHeaderElement = By.XPath("//*[@id='main-content']//h1");
        private static string subPageHeader { get; } = "Tell us what is wrong with this T Levels details";
        private static readonly By subPageHeaderElement = By.XPath("//*[@id='main-content']//h2");

        private static By submitButton { get; } = By.Id("submitButton");
        private static By mainErrorMesg = By.ClassName("govuk-error-summary__body");
        private static By subErrorMesg = By.ClassName("govuk-error-message");
        private static By TLevelDetailsElement = By.XPath("//*[@id='main-content']//form/dl");
        private static By textBoxElement = By.Id("query");
       private static By backLink { get; } = By.Id("backLink");

        public static void VerifyQueryTLevelDetailsPage()
        {          
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            Assert.AreEqual(WebDriver.Title, pageTitle);
            Assert.AreEqual(WebDriver.FindElement(pageHeaderElement).Text, pageHeader);
        }

        public static void VerifyTLevelDetails(string TLevel)
        {
            switch (TLevel)
            {
                case "T Level in Agriculture, Environmental and Animal Care":
                    Assert.IsTrue(WebDriver.FindElement(TLevelDetailsElement).Text.Contains("T Level in Agriculture, Environmental and Animal Care"));
                    Assert.IsTrue(WebDriver.FindElement(TLevelDetailsElement).Text.Contains("Agriculture, Environmental and Animal Care"));
                    Assert.IsTrue(WebDriver.FindElement(TLevelDetailsElement).Text.Contains("(77777777)"));
                    Assert.IsTrue(WebDriver.FindElement(TLevelDetailsElement).Text.Contains("Animal Care and Management"));
                    Assert.IsTrue(WebDriver.FindElement(TLevelDetailsElement).Text.Contains("(70000001)"));
                    Assert.IsTrue(WebDriver.FindElement(TLevelDetailsElement).Text.Contains("Agriculture, Land Management and Production"));
                    Assert.IsTrue(WebDriver.FindElement(TLevelDetailsElement).Text.Contains("(70000002)"));
                    break;

                case "T Level in Business and Administration":
                    Assert.IsTrue(WebDriver.FindElement(TLevelDetailsElement).Text.Contains("T Level in Business and Administration"));
                    Assert.IsTrue(WebDriver.FindElement(TLevelDetailsElement).Text.Contains("Business and Administration"));
                    Assert.IsTrue(WebDriver.FindElement(TLevelDetailsElement).Text.Contains("(88888888)"));
                    Assert.IsTrue(WebDriver.FindElement(TLevelDetailsElement).Text.Contains("Management and Administration"));
                    Assert.IsTrue(WebDriver.FindElement(TLevelDetailsElement).Text.Contains("(80000001)"));
                    Assert.IsTrue(WebDriver.FindElement(TLevelDetailsElement).Text.Contains("Human Resources"));
                    Assert.IsTrue(WebDriver.FindElement(TLevelDetailsElement).Text.Contains("(80000002)"));
                    break;
            }
            
        }

   
        public static void ClickSubmitBtn()
        {
            ClickElement(submitButton);
        }
        public static void ClickBackLink()
        {
            ClickElement(backLink);
        }


        public static void VerifyErrorMessage(string ErrorMsg)
        {
            Assert.IsTrue(WebDriver.FindElement(mainErrorMesg).Text.Contains(ErrorMsg));
            Assert.IsTrue(WebDriver.FindElement(subErrorMesg).Text.Contains(ErrorMsg));
        }
    }
}
