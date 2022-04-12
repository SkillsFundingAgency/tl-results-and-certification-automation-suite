using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostResults;

[Binding]
public class _5986_CancelAppealOutcomeCoreStepDefinitions : CancelAppealOutcomePage
{
    [When(@"I click cancel in check appeal outcome page")]
    public void WhenIClickCancelInCheckAppealOutcomePage()
    {
        CheckAppealOutcomePage.ClickCancelLink();
    }

    [Then(@"cancel appeal outcome page is shown")]
    public void ThenCancelAppealOutcomePageIsShown()
    {
        VerifyCancelAppealOutcomePage();
    }

    [Then(@"Back link takes me to check appeal outcome page")]
    public void ThenBackLinkTakesMeToCheckAppealOutcomePage()
    {
        BackLinkToAppealOutcomePage();
    }
    [Then(@"error message shown on cancel appeal outcome page")]
    public void ThenErrorMessageShownOnCancelAppealOutcomePage(Table table)
    {
        VerifyCancelAppealOutcomeErrorPage();
        CommonPage.VerifyValidationMessage(table);
    }

    [Then(@"error summary shown on cancel appeal outcome page")]
    public void ThenErrorSummaryShownOnCancelAppealOutcomePage(Table table)
    {
        CommonPage.VerifyValidationSummaryMessages(table);
    }
    [Then(@"selecting no radio option takes me to check appeal outcome page")]
    public void ThenSelectingNoRadioOptionTakesMeToCheckAppealOutcomePage()
    {
        CheckNoCancelRadio();
    }
}