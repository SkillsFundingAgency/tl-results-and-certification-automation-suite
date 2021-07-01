using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewsAndAppeals
{
    [Binding]
    public class _3474_ReviewsAndAppealsSearchForLearnerSteps : ReviewsAndAppealsSearchLearner
    {
        [When(@"I click on ""(.*)"" button in start page")]
        public void WhenIClickOnButtonInStartPage(string p0)
        {
            ReviewAndAppealsStartPage.PressContinueBtn();
        }

        [Then(@"I should see reviews and appeals search for learner page")]
        public void ThenIShouldSeeReviewsAndAppealsSearchForLearnerPage()
        {
            VerifySearchLearnerPage();
        }
        
        [Then(@"clicking on Reviews and appeals breadcrumb takes me reviews start page")]
        public void ThenClickingOnReviewsAndAppealsBreadcrumbTakesMeReviewsStartPage()
        {
            ClickReviewsBreadcrumb();
            ReviewAndAppealsStartPage.PressContinueBtn();
        }
        [When(@"I click on Search button")]
        public void WhenIClickOnSearchButton()
        {
            ClickSearchBtn();
        }

        [Then(@"I should see following error message in Reviews and Appeals page")]
        public void ThenIShouldSeeFollowingErrorMessageInReviewsAndAppealsPage(Table table)
        {
            VerifySearchLearnerErrorPage();
            CommonPage.VerifyValidationMessage(table);
        }

        [Then(@"I should see the following error summary message in Reviews and Appeals page")]
        public void ThenIShouldSeeTheFollowingErrorSummaryMessageInReviewsAndAppealsPage(Table table)
        {
            CommonPage.VerifyValidationSummaryMessages(table);
        }
        [When(@"I enter ""(.*)""")]
        public void WhenIEnter(string text)
        {
            EnterUln(text);
        }
    }
}
