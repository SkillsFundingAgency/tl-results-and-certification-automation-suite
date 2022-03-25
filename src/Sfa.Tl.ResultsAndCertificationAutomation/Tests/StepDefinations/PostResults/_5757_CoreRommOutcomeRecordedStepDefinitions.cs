using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostResults;

[Binding]
public class _5757_CoreRommOutcomeRecordedStepDefinitions : PostResultsLearnerDetailsPage
{
    [Given(@"I select ""([^""]*)"" grade and click continue in change the grade after Romm page")]
    public void GivenISelectGradeAndClickContinueInChangeTheGradeAfterRommPage(string grade)
    {
        ChangeTheGradeAfterRommPge.SelectRommGrade(grade);
    }

    [When(@"I click submit button in check the Romm outcome page")]
    public void WhenIClickSubmitButtonInCheckTheRommOutcomePage()
    {
        CheckRommOutcomePage.ClickSubmitBtn();
    }

    [Then(@"Romm outcomne recorded success message is shown")]
    public void ThenRommOutcomneRecordedSuccessMessageIsShown()
    {
        VerifyRommOutcomeRecordedSuccessfully();
    }

    [Then(@"button is changed to add apeal")]
    public void ThenButtonIsChangedToAddApeal()
    {
        IsCoreAddAppealBtnVisible();
    }
    [Then(@"Romm outcome recorded for specialism success message is shown")]
    public void ThenRommOutcomeRecordedForSpecialismSuccessMessageIsShown()
    {
        VerifyRommOutcomeRecordedForOs();
    }

}