using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostalAddress;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostalAddress
{
    [Binding]
    public class _3170_AddAddress_CheckAndSubmitSteps
    {

        [Then(@"I should see the Add Address Check and Submit page")]
        public void ThenIShouldSeeTheAddAddressCheckAndSubmitPage()
        {
            CheckAndSubmit.VerifyCheckAndSubmitPage();
        }

        [Then(@"I select the first option from the dropdown and select Continue")]
        public void ThenISelectTheFirstOptionFromTheDropdownAndSelectContinue()
        {
            AddPostcodePage.SelectAddressFromDropdown();
        }

        [When(@"I click the Back link on the Add Address Check and Submit page")]
        public void WhenIClickTheBackLinkOnTheAddAddressCheckAndSubmitPage()
        {
            CheckAndSubmit.ClickBackLink();
        }

        [Then(@"I should see the Add Postal Address Select page")]
        public void ThenIShouldSeeTheAddPostalAddressSelectPage()
        {
            AddPostcodePage.VerifySelectAddressPage();
        }

        [When(@"I filled form with following information")]
        public void WhenIFilledFormWithFollowingInformation(Table table)
        {
            CommonPage.FillFormWithData(table);
        }

        [Then(@"I should see the Add your address manually page")]
        public void ThenIShouldSeeTheAddYourAddressManuallyPage()
        {
            AddAddressManually.VerifyNavigateToAddAddressManuallyPage();
        }

        [When(@"I click the Change address link on the Add Address Check and Submit page")]
        public void WhenIClickTheChangeAddressLinkOnTheAddAddressCheckAndSubmitPage()
        {
            CheckAndSubmit.ClickChangeAddressLink();
        }

        [When(@"I click the Cancel link on the Add Address Check and Submit page")]
        public void WhenIClickTheCancelLinkOnTheAddAddressCheckAndSubmitPage()
        {
            CheckAndSubmit.ClickCancelLink();
        }

        [Then(@"I should see the Cancel Address page")]
        public void ThenIShouldSeeTheCancelAddressPage()
        {
            CancelPage.VerifyCancelPage();
            CancelPage.VerifyYesRadioButtonsPopulated();
        }


    }
}
