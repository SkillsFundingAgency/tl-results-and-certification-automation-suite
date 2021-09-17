using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewsAndAppeals
{
    [Binding]
    public class _3996PostResultsServices_Exceptions_StartPageSteps
    {
        [When(@"I click the Raise a request link")]
        [Then(@"I click the Raise a request link")]
        public void ThenIClickTheRaiseARequestLink()
        {
            RAULearnersComponentGradesStatusPage.ClickRaiseARequestLink();
        }
        
        [Then(@"the Exceptions start page is displayed")]
        public void ThenTheExceptionsStartPageIsDisplayed()
        {
            RAUExceptionsStartPage.VerifyExceptionsStartPage();
        }
        
        [Then(@"when I click the back link on the Exceptions start page")]
        public void ThenWhenIClickTheBackLinkOnTheExceptionsStartPage()
        {
            RAUExceptionsStartPage.ClickBackLink();
        }
    }
}
