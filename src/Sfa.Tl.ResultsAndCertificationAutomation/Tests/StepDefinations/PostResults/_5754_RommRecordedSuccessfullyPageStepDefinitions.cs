using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostResults;

[Binding]
public class _5754_RommRecordedSuccessfullyPageStepDefinitions : PostResultsLearnerDetailsPage
{
    [Then(@"Romm recorded success message is shown")]
    public void ThenRommRecordedSuccessMessageIsShown()
    {
        VerifyRommAddedSuccessfully();
    }
    [Then(@"button is changed to add outcome")]
    public void ThenButtonIsChangedToAddOutcome()
    {
        IsCoreAddOutcomeBtnVisible();
    }
    [Then(@"Romm recorded success message for specialism is shown")]
    public void ThenRommRecordedSuccessMessageForSpecialismIsShown()
    {
        VerifyRommRecordedForOs();
    }
}