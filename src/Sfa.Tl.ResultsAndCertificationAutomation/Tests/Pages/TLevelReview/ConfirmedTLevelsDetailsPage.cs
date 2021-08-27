using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.TLevelReview
{
    public class ConfirmedTLevelsDetailsPage : ElementHelper
    {
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "tlevel-confirmed-details");
        private static string pageTitle { get; } = "T Level details – Manage T Level results – GOV.UK";
        private static string pageHeader { get; } = "Confirmed T Level details";
        private static readonly By pageHeaderElement = By.XPath("//*[@id='main-content']//h1");
        private static string pageText { get; } = "You have told us this T Level’s details are correct. If something is wrong";
        private static readonly By InsetTextElement = By.ClassName("govuk-inset-text");
        private static readonly By TLevelDetailsElement = By.ClassName("govuk-main-wrapper");
        private static By backToConfirmedTLevelsButton { get; } = By.Id("backToConfirmedTlevelsButton");
        private static By backLink { get; } = By.Id("backLink");
        private static By raiseAQueryLink { get; } = By.LinkText("raise a query");

        public static void VerifyConfirmedTLevelDetailsPage()
        {          
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            Assert.AreEqual(WebDriver.Title, pageTitle);
            Assert.AreEqual(WebDriver.FindElement(pageHeaderElement).Text, pageHeader);
            Assert.IsTrue(WebDriver.FindElement(InsetTextElement).Text.Contains(pageText));
            //Verify table headers:
            Assert.IsTrue(WebDriver.FindElement(TLevelDetailsElement).Text.Contains("T Level title"));
            Assert.IsTrue(WebDriver.FindElement(TLevelDetailsElement).Text.Contains("Core"));
            Assert.IsTrue(WebDriver.FindElement(TLevelDetailsElement).Text.Contains("Occupational specialism"));

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
   
        public static void ClickBackToConfirmedTLevelsBtn()
        {
            ClickElement(backToConfirmedTLevelsButton);
        }
        public static void ClickBackLink()
        {
            ClickElement(backLink);
        }
        public static void ClickRaiseAQueryLink()
        {
            ClickElement(raiseAQueryLink);
        }

    }
}
