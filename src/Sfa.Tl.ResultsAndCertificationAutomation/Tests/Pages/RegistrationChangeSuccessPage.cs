using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class RegistrationChangeSuccessPage : ElementHelper
    {
        private static string ExpectedChangeNamePageUrl => string.Concat(StartPage.StartPageUrl, "registration-details-change-confirmation");
        private static readonly By PageHeader = By.XPath("//*[@id='main-content']//h1");
        private static readonly By PageSubHeader = By.XPath("//*[@id='main-content']/div/div/div/div");
        public static By BackToRegistrationsButton = By.Id("BackToRegButton");
        private static string PageSubHeading = "ULN: " + Constants.ManualRegUln;



        public static void ClickBackToRegistrationsButton()
        {
            ClickElement(BackToRegistrationsButton);
        }
                
        public static void VerifyRegistrationChangeSuccessPage()
        {
            Assert.AreEqual(ExpectedChangeNamePageUrl, WebDriver.Url);
            Assert.AreEqual(Constants.RegistrationChangeSuccessPageTitle, WebDriver.Title);
            Assert.AreEqual(Constants.RegistrationChangeSuccessPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.FindElement(PageSubHeader).Text.Contains(PageSubHeading));
        }
    }
}
