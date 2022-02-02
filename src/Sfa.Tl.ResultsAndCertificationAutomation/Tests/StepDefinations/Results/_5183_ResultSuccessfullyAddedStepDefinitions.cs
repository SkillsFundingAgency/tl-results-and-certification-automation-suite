using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Results;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class _5183_ResultSuccessfullyAddedStepDefinitions : LearnerResultsPage
    {
        [When(@"I select '([^']*)'")]
        public void WhenISelect(string grade)
        {
            AddCoreResultPage.SelectGrade(grade);
        }

        [Then(@"'([^']*)' message is shown")]
        public void ThenMessageIsShown(string message)
        {
            VerifyBanner(message);
        }
    }
}
