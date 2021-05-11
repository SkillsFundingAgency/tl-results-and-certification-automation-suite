using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostalAddress;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostalAddress
{
    [Binding]
    public class _3168_ProviderPostalAddress_AddAddress_EnterPostcode_PostcodeSearchSteps
    {
        [When(@"I click on ""(.*)""")]
        public void WhenIClickOn(string BtnName)
        {
            ManagePostalAddress.ClickBtnByName(BtnName);
        }
        
        [Then(@"I should see the '(.*)'s postal address\?' page")]
        public void ThenIShouldSeeTheSPostalAddressPage(string p0)
        {
            AddPostcodePage.VerifyAddPostalAddressPage();
        }
        
        [Then(@"when I click the Find Address button without entering a postcode")]
        public void ThenWhenIClickTheFindAddressButtonWithoutEnteringAPostcode()
        {
            AddPostcodePage.ClickFindAddressBtn();
        }
        
        [Then(@"I will be shown the following (.*) on the '(.*)'s postal address\?' page")]
        public void ThenIWillBeShownTheFollowingOnTheSPostalAddressPage(string ErrorMessage, string p1)
        {
            AddPostcodePage.ValidateErrorMessage(ErrorMessage);
        }
        
        [Then(@"when I click the Find Address button after entering postcode as ""(.*)""")]
        public void ThenWhenIClickTheFindAddressButtonAfterEnteringPostcodeAs(string postCode)
        {
            AddPostcodePage.EnterPostcode(postCode); ;
        }
    }
}
