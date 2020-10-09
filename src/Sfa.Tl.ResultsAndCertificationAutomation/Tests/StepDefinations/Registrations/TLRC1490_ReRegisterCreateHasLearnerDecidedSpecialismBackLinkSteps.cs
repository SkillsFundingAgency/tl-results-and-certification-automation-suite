using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1490_ReRegisterCreateHasLearnerDecidedSpecialismBackLinkSteps : ReregisterHasLearnerDecidePage
    {
        [When(@"I click on back link in Has learner decide page")]
        public void WhenIClickOnBackLinkInHasLearnerDecidePage()
        {
            VerifyReregisterLearnerDecidePage();
            ClickElement(Backlink);
        }
        
        [Then(@"I should be navigated back to select core page")]
        public void ThenIShouldBeNavigatedBackToSelectCorePage()
        {
            VerifyReregisterCorePage();
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
