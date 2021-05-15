using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostalAddress;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostalAddress
{
    [Binding]
    public class _3215_ProviderPostalAddress_SelectAddress_0AddressesFoundSteps
    {
        [Then(@"I will see the No addresses found page for postcode ""(.*)""")]
        public void ThenIWillSeeTheNoAddressesFoundPageForPostcode(string postCode)
        {
            NoAddressFoundPage.VerifyNoAddressessFoundPage(postCode);
        }

        [When(@"I search for (.*)")]
        public void WhenISearchFor(string postCode)
        {
            AddPostcodePage.EnterPostcode(postCode);
        }

        [Then(@"I will see the No addresses found page for (.*)")]
        public void ThenIWillSeeTheNoAddressesFoundPageFor(string postCode)
        {
            NoAddressFoundPage.VerifyNoAddressessFoundPage(postCode);
        }

        [Then(@"I click the back link")]
        public void ThenIClickTheBackLink()
        {
            NoAddressFoundPage.ClickBackLink();
        }

        [Then(@"I click the Add address manually link")]
        public void ThenIClickTheAddAddressManuallyLink()
        {
            NoAddressFoundPage.ClickAddAdressManuallyLink();
        }

        [Then(@"I click the Try another postcode button")]
        public void ThenIClickTheTryAnotherPostcodeButton()
        {
            NoAddressFoundPage.ClickTryAnotherPostcodeBtn();

        }

        [Then(@"the postcode field will be empty")]
        public void ThenThePostcodeFieldWillBeEmpty()
        {
            AddPostcodePage.VerifyPostcodeFieldIsEmpty();
        }

    }
}
