using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostalAddress;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostalAddress
{
    [Binding]
    public class _3215_NoAddressFoundPageSteps : NoAddressFoundPage
    {
        [Then(@"I shoud see no address found page for ""(.*)""")]
        public void ThenIShoudSeeNoAddressFoundPageFor(string postcode)
        {
            VerifyNoAddressessFoundPage(postcode);
        }
        [Then(@"clicking on Back link should takes be back to search postal address page")]
        public void ThenClickingOnBackLinkShouldTakesBeBackToSearchPostalAddressPage()
        {
            ClickBackLink();
            AddPostcodePage.VerifyAddPostalAddressPage();
        }
        [Then(@"I should see Add address manually page")]
        public void ThenIShouldSeeAddAddressManuallyPage()
        {
            AddAddressManually.VerifyNavigateToAddAddressManuallyPage();
        }
        [Then(@"I should see search postal address page")]
        public void ThenIShouldSeeSearchPostalAddressPage()
        {
            AddPostcodePage.VerifyAddPostalAddressPage();
        }
    }
}
