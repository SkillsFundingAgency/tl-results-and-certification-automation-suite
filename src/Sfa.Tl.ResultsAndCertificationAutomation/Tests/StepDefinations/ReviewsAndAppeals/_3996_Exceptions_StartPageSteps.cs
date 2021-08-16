using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewsAndAppeals
{
    [Binding]
    public class _3996PostResultsServices_Exceptions_StartPageSteps
    {
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
