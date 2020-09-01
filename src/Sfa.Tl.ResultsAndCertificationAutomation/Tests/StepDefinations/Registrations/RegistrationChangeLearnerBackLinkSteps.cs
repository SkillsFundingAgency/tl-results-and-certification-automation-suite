using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationChangeLearnerBackLinkSteps : RegistrationsManualPage
    {
        [Given(@"I click on Learner change link")]
        public void GivenIClickOnLearnerChangeLink()
        {
            ClickChangeLearnerLink();
            Assert.IsTrue(WebDriver.Url.Contains(LearnerNameUrl));
            Assert.AreEqual(Constants.LearnerPageTitle, WebDriver.Title);
            Assert.AreEqual(LearnerPageHeader, WebDriver.FindElement(PageHeader).Text);
        }
    }
}
