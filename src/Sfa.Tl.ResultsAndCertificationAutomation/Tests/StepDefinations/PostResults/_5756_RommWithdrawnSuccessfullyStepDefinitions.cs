using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostResults
{
    [Binding]
    public class _5756_RommWithdrawnSuccessfullyStepDefinitions : PostResultsLearnerDetailsPage
    {
        [When(@"I select ""([^""]*)"" on do you know romm outcome page")]
        public void WhenISelectOnDoYouKnowRommOutcomePage(string option)
        {
            DoYouKnowTheRommOutcomePage.DoYouKnowRommOutcomeOptions(option);
        }

        [Then(@"Romm withdrawn successfully message is shown")]
        public void ThenRommWithdrawnSuccessfullyMessageIsShown()
        {
            VerifyRommWithdrawnSuccessfully();
        }

        [Then(@"button is changed to add Romm")]
        public void ThenButtonIsChangedToAddRomm()
        {
            IsCoreAdRommBtnVisible();
        }
        [Then(@"Romm withdrawn successfully for specialism message is shown")]
        public void ThenRommWithdrawnSuccessfullyForSpecialismMessageIsShown()
        {
            VerifyRommWithdrawnForOs();
        }
    }
}
