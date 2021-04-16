using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers
{
    public class RegistrationCannotBeDeletedPage : ElementHelper
    {
        private static string PageUrl { get; } = "registration-cannot-be-deleted";
        private static string PageTitle { get; } = "Registration cannot be deleted page – Manage T Level results – GOV.UK";
        private static string PageHeaderText { get; } = "You cannot delete this registration";
        private static By pageHeader { get; } = By.XPath("//*[@id='main-content']//h1");
        private static By BackToRegBtn { get; } = By.Id("backButton");
        public static By backLink { get; } = By.Id("backLink");
   
      
        public static void VerifyRegistrationCannotBeDeletedPage()
        {
            Assert.AreEqual(PageTitle, WebDriver.Title);
            Assert.AreEqual(PageHeaderText, WebDriver.FindElement(pageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(PageUrl));
        }

        public static void ClickBackLink()=> ClickButton(backLink);
        public static void ClickBackToRegistrationDetailsBtn() => ClickButton(BackToRegBtn);

    }
}
