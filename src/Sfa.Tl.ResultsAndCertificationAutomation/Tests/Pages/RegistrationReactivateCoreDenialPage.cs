using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using System;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class RegistrationReactivateCoreDenialPage : ElementHelper
    {
        private static readonly string ExpectedPageUrl = string.Concat(StartPage.StartPageUrl, "cannot-select-same-core");
        private const string ExpectedPageTitle = "Cannot select same core page – Manage T Level results – GOV.UK";
        private static readonly string ExpectedPageHeader = "You cannot select this core";
        
        private static By BackLink { get; } = By.Id("backLink");
        
        private const string RegisterLearnerOnNewCourseTxt = "Register learner on a new course";
        private static By PageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By PageSubHeader1 { get; } = By.XPath("//*[@id='main-content']/div/div/div/p[1]");
        private static By PageSubHeader2 { get; } = By.XPath("//*[@id='main-content']/div/div/div/p[2]");
        private const string ExpectedPageSubHeader1Txt = "You cannot select the same core because you chose to register the learner on a different core.";
        private const string ExpectedPageSubHeader2Txt = "To register the learner on the same core you need to reactivate the registration.";


        public static By ReactivateRegistrationButton { get; } = By.Id("registrationDetailsButton");
        private static readonly string ExpectedButtonText = "Reactivate the registration";
      
        public static void VerifyRegReactivateChangeCorePageDetails()
        {
            Assert.IsTrue((WebDriver.Url).Contains(ExpectedPageUrl));
            Assert.AreEqual(ExpectedPageTitle, WebDriver.Title);
            Assert.AreEqual(ExpectedPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(ExpectedPageSubHeader1Txt, WebDriver.FindElement(PageSubHeader1).Text);
            Assert.AreEqual(ExpectedPageSubHeader2Txt, WebDriver.FindElement(PageSubHeader2).Text);
            Assert.AreEqual(ExpectedButtonText, WebDriver.FindElement(ReactivateRegistrationButton).Text);
        }


        public static void ClickBackLink()
        {
            ClickElement(BackLink);
        }

        public static void ClickReactiveRegButton()
        {
            ClickElement(ReactivateRegistrationButton);
        }

        public static void NavigateToBookmarkedPage(String URL)
        {
            WebDriver.Navigate().GoToUrl(URL);
        }

    }
}
