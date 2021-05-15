using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostalAddress;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostalAddress
{
    [Binding]
    public class _3220_ProviderPostalAddress_Address_CheckAndSubmit_CancelSteps : ElementHelper
    {
        [Given(@"I navigate to the cancel page")]
        public void GivenINavigateToTheCancelPage()
        {
            ClickLinkByLabel("Manage your organisation’s postal address");
            ManagePostalAddress.ClickBtnByName("Add address");
            AddPostcodePage.VerifyAddPostalAddressPage();
            AddPostcodePage.EnterPostcode("B43 6JN");
            AddPostcodePage.SelectAddressFromDropdown();
            CheckAndSubmit.VerifyCheckAndSubmitPage();
            CheckAndSubmit.ClickCancelLink();
            CancelPage.VerifyCancelPage();
            CancelPage.VerifyYesRadioButtonsPopulated();
        }
        
        [Given(@"I click the ""(.*)"" radio button and press Continue on the Cancel page")]
        public void WhenIClickTheRadioButtonAndPressContinueOnTheCancelPage(string RadioButton)
        {
            CancelPage.SelectRadioButton(RadioButton);
            CancelPage.ClickContinueButton();
        }
        
         [Given(@"I click the Back link on the Cancel page")]
        public void GivenIClickTheBackLinkOnTheCancelPage()
        {
            CancelPage.ClickBackLink();
        }


        [Then(@"I will be navigated to the T Levels Dashboard page")]
        public void ThenIWillBeNavigatedToTheTLevelsDashboardPage()
        {
            TlevelDashboardPage.VerifyDashboardpage(); 
        }
    }
}
