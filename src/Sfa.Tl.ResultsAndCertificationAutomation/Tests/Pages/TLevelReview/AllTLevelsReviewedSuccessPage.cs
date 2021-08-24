using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.TLevelReview
{
    public class AllTLevelsReviewedSuccessPage : ElementHelper
    {
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "all-tlevels-reviewed-success");
        private static string pageTitle { get; } = "All T Levels reviewed – Manage T Level results – GOV.UK";
        private static string pageHeader { get; } = "T Level details confirmed";
        private static readonly By pageHeaderElement = By.XPath("//*[@id='main-content']//h1");
        private static By pageSubheaderElement = By.ClassName("govuk-panel__body");
        private static By backToHomeButton { get; } = By.Id("backToHomeButton");
        private static By backToTLevelsBtn = By.Id("backToTlevelsButton");
        private static string subPageHeader { get; } = "You can now:";
        private static readonly By subPageHeaderElement = By.XPath("//*[@id='main-content']//h2");
        private static By confirmedTLevelLink { get; } = By.LinkText("confirmed T Levels");
        private static By registerLink { get; } = By.LinkText("Register");
        private static By addTLevelsLink { get; } = By.LinkText("Add T Levels");
        public static readonly string ExpectedAddTLevelsLink = WebDriver.FindElement(By.LinkText("Add T Levels")).GetAttribute("href");
        public static readonly string ExpectedRegisterLink = WebDriver.FindElement(By.LinkText("Register")).GetAttribute("href");
        public static readonly string ExpectedConfirmedTLevelLink = WebDriver.FindElement(By.LinkText("confirmed T Levels")).GetAttribute("href");


        public static void VerifyALLTLevelsReviewedSuccessPage()
        {          
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            Assert.AreEqual(WebDriver.Title, pageTitle);
            Assert.AreEqual(WebDriver.FindElement(pageHeaderElement).Text, pageHeader);
        }
        public static void VerifyTLevelNameDisplayed(string TLevel)
        {
            Assert.AreEqual(WebDriver.FindElement(pageSubheaderElement).Text, TLevel);
        }

        public static void VerifyPageText()
        {
          Assert.AreEqual(subPageHeader,WebDriver.FindElement(subPageHeaderElement).Text);
        }

        public static void ClickBackToHomeBtn()
        {
            ClickElement(backToHomeButton);
        }
        public static void ClickBackToTLevelsBtn()
        {
            ClickElement(backToTLevelsBtn);
        }
        public static void ClickConfirmedTLevelsLink()
        {
            ClickElement(confirmedTLevelLink);
        }
        public static void ClickRegisterLink()
        {
            ClickElement(registerLink);
        }

        public static void ClickAddTLevelsLink()
        {
            ClickElement(addTLevelsLink);
        }

        public static void VerifyLinks()
        {
            Assert.AreEqual(ExpectedAddTLevelsLink, "https://test.manage-tlevel-results.tlevels.gov.uk/find-provider");
            //Assert.IsTrue(ExpectedConfirmedTLevelLink.Contains("https://test.manage-tlevel-results.tlevels.gov.uk/confirmed-tlevels"));
            Assert.AreEqual(ExpectedRegisterLink, "https://test.manage-tlevel-results.tlevels.gov.uk/registrations");
        }
    }
}
