using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1491_ReregisterCreateSpecialismBackLinkSteps : ReregisterCreateSpecialismPage
    {
        [Then(@"I should be navigated back to Reregister Has learner decide page")]
        public void ThenIShouldBeNavigatedBackToReregisterHasLearnerDecidePage()
        {
            VerifyReregisterLearnerDecidePage();
        }
        
        [Then(@"the add specialism now radio box should be checked")]
        public void ThenTheAddSpecialismNowRadioBoxShouldBeChecked()
        {
            Assert.AreEqual(true, WebDriver.FindElement(AddSpecialismNow).Selected);
        }
    }
}
