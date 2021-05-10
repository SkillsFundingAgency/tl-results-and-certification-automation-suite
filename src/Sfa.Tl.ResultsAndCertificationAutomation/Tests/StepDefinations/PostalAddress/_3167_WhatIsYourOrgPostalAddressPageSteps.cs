using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostalAddress;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostalAddress
{
    [Binding]
    public class _3167_WhatIsYourOrgPostalAddressPageSteps : ManagePostalAddress
    {
        [When(@"I click on ""(.*)"" button on Org postal address page")]
        public void WhenIClickOnButtonOnOrgPostalAddressPage(string buttonName)
        {
            ClickBtnByName(buttonName);
        }

        [Then(@"I should see What is your Org postal address page")]
        public void ThenIShouldSeeWhatIsYourOrgPostalAddressPage()
        {
            VerifySearchPostalAddressPage();
        }
        
        [Then(@"clicking on Back link should takes be back to Manage org postal address page")]
        public void ThenClickingOnBackLinkShouldTakesBeBackToManageOrgPostalAddressPage()
        {
            ClickBackLink();
            VerifyManageOrgPostalAddressPage();
        }
    }
}
