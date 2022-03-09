using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostResults;

[Binding]
public class _5743_SearchForLearnerStepDefinitions : SearchForLearnerPage
{
    [When(@"I click ""([^""]*)"" button")]
    public void WhenIClickButton(string @continue)
    {
        PressContinueBtn();
    }

    [Then(@"Post result search for a learner page is shown")]
    public void ThenPostResultSearchForALearnerPageIsShown()
    {
        VerifySearchLearnerPage();
    }

    [Then(@"clicking on Post-results breadcrumb takes to Post result home page")]
    public void ThenClickingOnPost_ResultsBreadcrumbTakesToPostResultHomePage()
    {
        ClickPostResultBreadcrumb();
        PressContinueBtn();
    }
    [When(@"I click ""([^""]*)"" button on search learner page")]
    public void WhenIClickButtonOnSearchLearnerPage(string search)
    {
        ClickSearchBtn();
    }

    [Then(@"I see following error message on search learner page")]
    public void ThenISeeFollowingErrorMessageOnSearchLearnerPage(Table table)
    {
        VerifySearchLearnerErrorPage();
        CommonPage.VerifyValidationMessage(table);
    }

    [Then(@"I see following error summary on search learner page")]
    public void ThenISeeFollowingErrorSummaryOnSearchLearnerPage(Table table)
    {
        CommonPage.VerifyValidationSummaryMessages(table);
    }
    [When(@"I enter ""([^""]*)"" and click search button")]
    public void WhenIEnterAndClickSearchButton(string text)
    {
        EnterUln(text);
        ClickSearchBtn();
    }
}