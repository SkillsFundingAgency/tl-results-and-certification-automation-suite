using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostResults;

[Binding]
public class _5895_AppealOutcomeRecordedCoreStepDefinitions
{
    [When(@"I click submit in appeal outcome page")]
    public void WhenIClickSubmitInAppealOutcomePage()
    {
        AddAppealOutcomePage.ClickSubmitBtn();
    }

    [Then(@"appeal outcome recorded successfully messgage shown on learner details page")]
    public void ThenAppealOutcomeRecordedSuccessfullyMessgageShownOnLearnerDetailsPage()
    {
        PostResultsLearnerDetailsPage.VerifyAppealOutcomeRecordedForCore();
    }
}