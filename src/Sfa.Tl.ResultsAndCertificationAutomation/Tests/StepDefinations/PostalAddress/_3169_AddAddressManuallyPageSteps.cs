using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostalAddress;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostalAddress
{
    [Binding]
    public class _3169_AddAddressManuallyPageSteps : AddAddressManually
    {
        [Given(@"I deleted the address in database")]
        public void GivenIDeletedTheAddressInDatabase()
        {
            SqlQueries.DeleteAddress();
        }

        [Given(@"I see Add address manually page")]
        public void GivenISeeAddAddressManuallyPage()
        {
            VerifyAddAddressManuallyPage();
        }
        
        [Given(@"I see following fields in the page")]
        public void GivenISeeFollowingFieldsInThePage(Table table)
        {
            CommonPage.VerifyExpectedFieldsPresent(table);
        }
        [Then(@"I should see error in page title")]
        public void ThenIShouldSeeErrorInPageTitle()
        {
            VerifyAddAddressManuallyErrorPage();
        }
        [Given(@"Back link takes me to what is Org postal address page")]
        public void GivenBackLinkTakesMeToWhatIsOrgPostalAddressPage()
        {
            ManagePostalAddress.ClickBackLink();
            ManagePostalAddress.VerifySearchPostalAddressBackPage();
        }
    }
}
