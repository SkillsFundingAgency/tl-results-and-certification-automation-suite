using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages
{
    public class ReactivateRegistrationSuccessPage : ElementHelper
    {
        private static string ExpectedChangeNamePageUrl => string.Concat(StartPage.StartPageUrl, "new-course-registration-confirmation");
        private static readonly By PageHeader = By.XPath("//*[@id='main-content']//h1");
        private static readonly By PageSubHeader = By.XPath("//*[@id='main-content']/div/div/div/div");
        public static By ViewThisRegistrationButton = By.Id("viewRegistrationButton");
        private static string ExpectedPageHeading = "Registration created successfully";
        private static string ExpectedPageSubHeading = "ULN: " + Constants.ManualRegUln;
        private static string ExpectedSubText = "You successfully registered the learner on a new course.";
        private static string ExpectedPageTitle = "New registration created confirmation page – Manage T Level results – GOV.UK";
        private static string ExpectedButtonText = "View registration";


        public static void ClickViewRegistrationButton()
        {
            ClickElement(ViewThisRegistrationButton);
        }
                
        public static void VerifyReRegistrationSuccessPage()
        {
            Assert.AreEqual(ExpectedChangeNamePageUrl, WebDriver.Url);
            Assert.AreEqual(ExpectedPageTitle, WebDriver.Title);
            Assert.AreEqual(ExpectedPageHeading, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(ExpectedPageSubHeading, WebDriver.FindElement(PageSubHeader).Text);
            Assert.AreEqual(ExpectedButtonText, WebDriver.FindElement(ViewThisRegistrationButton).Text);
            Assert.IsTrue(WebDriver.FindElement(By.Id("main-content")).Text.Contains(ExpectedSubText));
        }

        
    }
}
