using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using System;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.TLevelReview
{
    public class QueriedTLevelsDetailsPage : ElementHelper
    {
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "tlevel-queried-details");
        private static string pageTitle { get; } = "Queried T Level – Manage T Level results – GOV.UK";
        private static string pageHeader { get; } = "Queried T Level details";
        private static readonly By pageHeaderElement = By.XPath("//*[@id='main-content']//h1");
        private static string pageText { get; } = "We are investigating this query and will update your organisation within 3 working days of it being submitted.";
        private static readonly By InsetTextElement = By.ClassName("govuk-inset-text");
        private static readonly By TLevelDetailsElement = By.ClassName("govuk-main-wrapper");
        private static By backToQueriedTLevelsButton { get; } = By.Id("queriedTlevelsButton");
        private static By backLink { get; } = By.Id("backLink");
        private static By contactUsLink { get; } = By.Id("contactusLink");

        public static void VerifyQueriedTLevelDetailsPage()
        {          
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            Assert.AreEqual(WebDriver.Title, pageTitle);
            Assert.AreEqual(WebDriver.FindElement(pageHeaderElement).Text, pageHeader);
            Assert.IsTrue(WebDriver.FindElement(InsetTextElement).Text.Contains(pageText));
            //Verify table headers:
            Assert.IsTrue(WebDriver.FindElement(TLevelDetailsElement).Text.Contains("T Level title"));
            Assert.IsTrue(WebDriver.FindElement(TLevelDetailsElement).Text.Contains("Core"));
            Assert.IsTrue(WebDriver.FindElement(TLevelDetailsElement).Text.Contains("Occupational specialism"));
            Assert.IsTrue(WebDriver.FindElement(TLevelDetailsElement).Text.Contains("Queried by"));
            Assert.IsTrue(WebDriver.FindElement(TLevelDetailsElement).Text.Contains("Date queried"));
            VerifyContactUsLinkPresent();
        }

        public static void VerifyTLevelDetails(string TLevel)
        {
            switch (TLevel)
            {
                case "T Level in Digital Support and Services":
                    Assert.IsTrue(WebDriver.FindElement(TLevelDetailsElement).Text.Contains("T Level in Digital Support and Services"));
                    Assert.IsTrue(WebDriver.FindElement(TLevelDetailsElement).Text.Contains("Digital Support Services"));
                    Assert.IsTrue(WebDriver.FindElement(TLevelDetailsElement).Text.Contains("(10623456)"));
                    Assert.IsTrue(WebDriver.FindElement(TLevelDetailsElement).Text.Contains("Digital Infrastructure"));
                    Assert.IsTrue(WebDriver.FindElement(TLevelDetailsElement).Text.Contains("(31234567)"));
                    Assert.IsTrue(WebDriver.FindElement(TLevelDetailsElement).Text.Contains("Network Cabling"));
                    Assert.IsTrue(WebDriver.FindElement(TLevelDetailsElement).Text.Contains("(32234567)"));
                    Assert.IsTrue(WebDriver.FindElement(TLevelDetailsElement).Text.Contains("Unified Communications"));
                    Assert.IsTrue(WebDriver.FindElement(TLevelDetailsElement).Text.Contains("(33234567)"));
                    Assert.IsTrue(WebDriver.FindElement(TLevelDetailsElement).Text.Contains("Digital Support"));
                    Assert.IsTrue(WebDriver.FindElement(TLevelDetailsElement).Text.Contains("(34234567)"));
                    Assert.IsTrue(WebDriver.FindElement(TLevelDetailsElement).Text.Contains("Test User"));

                    var DateQueried = DateTime.Now;
                    DateTime oDate = Convert.ToDateTime(DateQueried);
                    string DateQueried1 = oDate.ToString("dd MMMM yyyy");
                    Assert.IsTrue(WebDriver.FindElement(TLevelDetailsElement).Text.Contains(DateQueried1));
                    break;
            }            
        }
   
        public static void ClickBackToQueriedTLevelsBtn()
        {
            ClickElement(backToQueriedTLevelsButton);
        }
        public static void ClickBackLink()
        {
            ClickElement(backLink);
        }

        public static void VerifyContactUsLinkPresent()
        {
            bool ContactUsLinkPresent = IsPresent(contactUsLink);
            bool ExpectedContactUsLinkPresence = true;
            Assert.AreEqual(ExpectedContactUsLinkPresence, ContactUsLinkPresent);
        }
    }
}
