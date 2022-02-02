using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Results;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class _5192_SelectSpecialismResultPageStepDefinitions : AddSpecialismResultPage
    {
        [Then(@"I should see add result page for Assessment")]
        public void ThenIShouldSeeAddResultPageForAssessment()
        {
            VerifyLearnerSpecialismResultPage();
            VerifyAddGradesUnchecked();
        }
        [Then(@"I should see the following error message on specialism result page")]
        public void ThenIShouldSeeTheFollowingErrorMessageOnSpecialismResultPage(Table table)
        {
            VerifyLearnerSpecialismResultErrorPage();
            CommonPage.VerifyValidationMessage(table);
        }

    }
}
