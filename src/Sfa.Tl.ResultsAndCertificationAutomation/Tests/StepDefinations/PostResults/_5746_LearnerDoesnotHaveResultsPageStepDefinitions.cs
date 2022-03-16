using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostResults;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostResults;

[Binding]
public class _5746_LearnerDoesnotHaveResultsPageStepDefinitions : NoResultsPage
{
    [Then(@"learner has no results page is shown")]
    public void ThenLearnerHasNoResultsPageIsShown()
    {
        VerifyNoResultsPage();
    }
    [Then(@"learner result page is shown")]
    public void ThenLearnerResultPageIsShown()
    {
        ResultsLearnersResultsPage.VerifyLearnersResultsPage();
    }
}