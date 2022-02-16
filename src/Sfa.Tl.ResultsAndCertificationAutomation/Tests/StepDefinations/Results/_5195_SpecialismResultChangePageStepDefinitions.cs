using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Results;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results;

[Binding]
public class _5195_SpecialismResultChangePageStepDefinitions : ChangeSpecialismResultPage
{
    [Then(@"change specialism result page is open")]
    public void ThenChangeSpecialismResultPageIsOpen()
    {
        VerifyChangeAssessmentResultsPage();
        AddSpecialismResultPage.VerifyChangeGradesUnchecked();
    }

    [Then(@"I should see the following error message on change specialism result page")]
    public void ThenIShouldSeeTheFollowingErrorMessageOnChangeSpecialismResultPage(Table table)
    {
        VerifyChangeAssessmentResultsErrorPage();
        CommonPage.VerifyValidationMessage(table);
    }
}