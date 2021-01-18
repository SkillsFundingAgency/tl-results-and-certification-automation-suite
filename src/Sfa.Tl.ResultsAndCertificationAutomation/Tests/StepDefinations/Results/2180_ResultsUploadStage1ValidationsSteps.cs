using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class ResultsUploadStage1ValidationsSteps : ResultsDashboardPage
    {
        [Given(@"I am on results upload page")]
        [When(@"I am on results upload page")]
        public void GivenIAmOnResultsUploadPage()
        {
            ClickResultsLink();
            WebDriver.FindElement(UploadResultLink).Click();
            VerifyUploadResultsPage();
        }
        [Then(@"I should see following error message in Results page")]
        public void ThenIShouldSeeFollowingErrorMessageInResultsPage(Table table)
        {
            VerifyUploadResultsErrorPage();
            CommonPage.VerifyValidationMessage(table);
        }

        [Then(@"I should see the following error summary message in Results page")]
        public void ThenIShouldSeeTheFollowingErrorSummaryMessageInResultsPage(Table table)
        {
            CommonPage.VerifyValidationSummaryMessages(table);
        }

    }
}
