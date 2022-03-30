using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostResults;

[Binding]
public class _5890_CheckAppealOutcomeCoreStepDefinitions : CheckAppealOutcomePage
{
    [When(@"I select ""([^""]*)"" grade and click continue in change the grade after an appeal page")]
    public void WhenISelectGradeAndClickContinueInChangeTheGradeAfterAnAppealPage(string grade)
    {
        ChangeTheGradeAfterRommPge.SelectRommGrade(grade);
    }

    [Then(@"check the appeal outcome page is shown")]
    public void ThenCheckTheAppealOutcomePageIsShown()
    {
        VerifyCheckAppealOutcomePage();
    }

    [Then(@"Core details shown on check the appeal outcome page")]
    public void ThenCoreDetailsShownOnCheckTheAppealOutcomePage()
    {
        VerifyLearnerCoreDetailsCheckAppealOutcomePage();
    }
    [Then(@"back link takes me to change the grade after appeal page")]
    public void ThenBackLinkTakesMeToChangeTheGradeAfterAppealPage()
    {
        BackLinkToChangeTheGradeAfterAppealPage();
    }
    [Then(@"back link takes me to add appeal outcome page")]
    public void ThenBackLinkTakesMeToAddAppealOutcomePage()
    {
        BackLinkToAddAppealOutcomePage();
    }

}