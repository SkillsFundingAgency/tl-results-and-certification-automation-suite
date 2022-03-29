using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostResults;

[Binding]
public class _5888_DoYouKnowTheAppealOutcomeCoreStepDefinitions : DoYouKnowTheAppealOutcomePage
{
    [Then(@"do you know the appeal outcome page is shown")]
    public void ThenDoYouKnowTheAppealOutcomePageIsShown()
    {
        VerifyDoYouKnowTheAppealOutcomePage();
    }

    [Then(@"core details shown on do you know the core appeal page")]
    public void ThenCoreDetailsShownOnDoYouKnowTheCoreAppealPage()
    {
        VerifyLearnerCoreDoYouKnowAppealOutcomePage();
    }

    [Then(@"back link takes me to add an appeal page")]
    public void ThenBackLinkTakesMeToAddAnAppealPage()
    {
        VerifyBackLink();
    }
    [Then(@"error message shown on appeal outcome page")]
    public void ThenErrorMessageShownOnAppealOutcomePage(Table table)
    {
        VerifyDoYouKnowTheAppealOutcomeErrorPage();
        CommonPage.VerifyValidationMessage(table);
    }

    [Then(@"error summary shown on appeal outcome page")]
    public void ThenErrorSummaryShownOnAppealOutcomePage(Table table)
    {
        CommonPage.VerifyValidationSummaryMessages(table);
    }

}