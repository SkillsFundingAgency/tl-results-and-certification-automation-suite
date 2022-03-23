using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostResults;

[Binding]
public class _5752_ChangeTheGradeAfterRommStepDefinitions : ChangeTheGradeAfterRommPge
{
    [Then(@"change the grade after a Romm page is shown")]
    public void ThenChangeTheGradeAfterARommPageIsShown()
    {
        VerifyChangeTheGradeAfterRommPage();
    }
    [When(@"I click continue without selecting grade on change grade after romm page")]
    public void WhenIClickContinueWithoutSelectingGradeOnChangeGradeAfterRommPage()
    {
        AddRommPage.ClickContinueBtn();
    }

    [Then(@"error message shown on change grade after romm page")]
    public void ThenErrorMessageShownOnChangeGradeAfterRommPage(Table table)
    {
        VerifyChangeTheGradeAfterRommErrorPage();
        CommonPage.VerifyValidationMessage(table);
    }

    [Then(@"error summary shown on change grade after romm page")]
    public void ThenErrorSummaryShownOnChangeGradeAfterRommPage(Table table)
    {
        CommonPage.VerifyValidationSummaryMessages(table);
    }
    [Then(@"specialism details shown in change the grade romm page")]
    public void ThenSpecialismDetailsShownInChangeTheGradeRommPage()
    {
        VerifyLearnerOs1DetailsChangeGradeAfterRommPage();
    }

}