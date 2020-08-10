using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationManualChangeLearnerSteps : RegistrationsManualPage
    {
        [When(@"I click on Learner change link")]
        public void WhenIClickOnLearnerChangeLink()
        {
            ClickChangeLearnerLink();
        }
        
        [When(@"I changed lerner fisrt and last nanme and click change button")]
        public void WhenIChangedLernerFisrtAndLastNanmeAndClickChangeButton()
        {
            Assert.AreEqual(Constants.LearnerPageTitle, WebDriver.Title);
            Assert.AreEqual(LearnerPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(LearnerNameUrl));
            WebDriver.FindElement(FirstName).Clear();
            WebDriver.FindElement(FirstName).SendKeys("FirstName");
            WebDriver.FindElement(LastName).Clear();
            WebDriver.FindElement(LastName).SendKeys("FirstName");
            ClickChangeBtn();
        }
        
        [Then(@"i shoud see change lerner names in confirm and submit page")]
        public void ThenIShoudSeeChangeLernerNamesInConfirmAndSubmitPage()
        {
            VerifyRegistrationSummaryPage();
        }
    }
}
