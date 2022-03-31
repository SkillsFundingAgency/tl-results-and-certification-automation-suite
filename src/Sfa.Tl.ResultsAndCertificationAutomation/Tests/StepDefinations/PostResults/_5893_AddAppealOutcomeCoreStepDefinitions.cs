using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostResults;

[Binding]
public class _5893_AddAppealOutcomeCoreStepDefinitions : AddAppealOutcomePage
{
    [Then(@"add appeal outcome page is shown")]
    public void ThenAddAppealOutcomePageIsShown()
    {
        VerifyAddAppealOutcomePage();
    }
    [Then(@"core details shown on add appeal outcome page")]
    public void ThenCoreDetailsShownOnAddAppealOutcomePage()
    {
        VerifyLearnerCoreDetailsAddAppealOutcomePage();
    }

    [When(@"I click continue without selecting any radio options")]
    public void WhenIClickContinueWithoutSelectingAnyRadioOptions()
    {
        ClickContinueBtn();
    }

    [Then(@"error message shown on add appeal outcome page")]
    public void ThenErrorMessageShownOnAddAppealOutcomePage(Table table)
    {
        VerifyAddAppealOutcomeErrorPage();
        CommonPage.VerifyValidationMessage(table);
    }

    [Then(@"error summary shown on change appeal outcome page")]
    public void ThenErrorSummaryShownOnChangeAppealOutcomePage(Table table)
    {
        CommonPage.VerifyValidationSummaryMessages(table);
    }

}