using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers;

[Binding]
public class _6249_WasMultipleEmployerUsedStepDefinitions : WasMultipleEmployerUsedPage
{
    [Given(@"I select '([^']*)' radio in has learner completed Ip page")]
    public void GivenISelectRadioInHasLearnerCompletedIpPage(string option)
    {
        HasLearnerCompletedIpPage.SelectIpCompletedOption(option);
    }

    [When(@"I select '([^']*)' radio in was Ip model used page")]
    public void WhenISelectRadioInWasIpModelUsedPage(string option)
    {
        WasIpModelUsedPage.SelectIpModelOption(option);
    }

    [Then(@"Multiple employer model used page is shown")]
    public void ThenMultipleEmployerModelUsedPageIsShown()
    {
        VerifyMultipleEmployerUsedPage();
    }

    [Then(@"Back link takes me back to was Ip model used page")]
    public void ThenBackLinkTakesMeBackToWasIpModelUsedPage()
    {
        VerifyBackLink();
    }
    [When(@"I click continue without selecting multiple employer option")]
    public void WhenIClickContinueWithoutSelectingMultipleEmployerOption()
    {
        WasIpModelUsedPage.ClickContinue();
    }

    [Then(@"the following error message shown on was multiple employer used page")]
    public void ThenTheFollowingErrorMessageShownOnWasMultipleEmployerUsedPage(Table table)
    {
        VerifyMultipleEmployerUsedErrorPage();
        CommonPage.VerifyValidationMessage(table);
    }

    [Then(@"the follwing error summary shown on was multiple employer used page")]
    public void ThenTheFollwingErrorSummaryShownOnWasMultipleEmployerUsedPage(Table table)
    {
        CommonPage.VerifyValidationSummaryMessages(table);
    }

}