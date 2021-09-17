using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class ResultsUploadSuccessSteps : ResultsDashboardPage
    {
        [Then(@"I should see results upload success page")]
        public void ThenIShouldSeeResultsUploadSuccessPage()
        {
            VerifyUploadResultsSuccessPage();
        }
        
        [Then(@"I should see number of records been uploaded message")]
        public void ThenIShouldSeeNumberOfRecordsBeenUploadedMessage()
        {
            VerifyResultsUploadCount(ResultsSuccessCountMsg);
        }
        
        [Then(@"I should go back to results dashboad on clicking Back to Results button")]
        public void ThenIShouldGoBackToResultsDashboadOnClickingBackToResultsButton()
        {
            VerifyBackToResultsBtn();
        }

        [When(@"I click the Back to home button on the results upload success page")]
        public void WhenIClickTheBackToHomeButtonOnTheResultsUploadSuccessPage()
        {
            ResultDashboardSteps.ClickBacktoHomeBtn();
        }

        [When(@"I click the Upload another file button on the results upload success page")]
        public void WhenIClickTheUploadAnotherFileButtonOnTheResultsUploadSuccessPage()
        {
            ResultDashboardSteps.ClickUploadAnotherFileBtn();
        }

        [Then(@"I am shown the Upload Results file page")]
        public void ThenIAmShownTheUploadResultsFilePage()
        {
            ResultsDashboardPage.VerifyUploadResultsPage();
        }

        [When(@"I click the upload another multiple registrations file link on the results upload success page")]
        public void WhenIClickTheUploadAnotherMultipleRegistrationsFileLinkOnTheResultsUploadSuccessPage()
        {
            ResultsDashboardPage.ClickUploadAnotherFileLink();
        }

        [When(@"I click the appeal link on the results upload success page")]
        public void WhenIClickTheAppealLinkOnTheResultsUploadSuccessPage()
        {
            ResultsDashboardPage.ClickAppealLink();
        }

        [Then(@"I should see the Appeals dashboard")]
        public void ThenIShouldSeeTheAppealsDashboard()
        {
            ReviewAndAppealsStartPage.VerifyReviewAndAppealsStartPage();
        }        
    }
}
