using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostResults;

[Binding]
public class _5892_AppealRecordedSuccessfullyCoreStepDefinitions : PostResultsLearnerDetailsPage
{
    [Given(@"I select ""([^""]*)"" radio and click continue in do you know outcome appeal page")]
    [When(@"I select ""([^""]*)"" radio and click continue in do you know outcome appeal page")]
    public void WhenISelectRadioAndClickContinueInDoYouKnowOutcomeAppealPage(string radio)
    {
        DoYouKnowTheAppealOutcomePage.DoYouKnowAppealOutcomeOptions(radio);
    }

    [Then(@"appeal recorded successfully messgage shown on learner details page")]
    public void ThenAppealRecordedSuccessfullyMessgageShownOnLearnerDetailsPage()
    {
        VerifyAppealRecordedForCore();
    }
    [Then(@"appeal recorded successfully for specialism messgage shown on learner details page")]
    public void ThenAppealRecordedSuccessfullyForSpecialismMessgageShownOnLearnerDetailsPage()
    {
        VerifyAppealRecordedForOs();
    }
}