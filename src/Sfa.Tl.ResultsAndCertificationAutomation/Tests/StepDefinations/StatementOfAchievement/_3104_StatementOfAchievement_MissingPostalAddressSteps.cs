using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostalAddress;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.StatementOfAchievement;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.StatementOfAchievement
{
    [Binding]
    public class _3104_StatementOfAchievement_MissingPostalAddressSteps
    {
        [When(@"I click the back link on the Missing Postal Address page")]
        public void WhenIClickTheBackLinkOnTheMissingPostalAddressPage()
        {
            PostalAddressMissing.ClickBackLink();
        }
        
        [When(@"I click the Add address button on the Missing Postal Address page")]
        public void WhenIClickTheAddAddressButtonOnTheMissingPostalAddressPage()
        {
            PostalAddressMissing.ClickAddAddressBtn();
        }
        
        [When(@"I click the Back to Home link on the Missing Postal Address page")]
        public void WhenIClickTheBackToHomeLinkOnTheMissingPostalAddressPage()
        {
            PostalAddressMissing.ClickBackToHomeLink();
        }
        
        [Then(@"I am navigated to the Missing Postal Address page")]
        public void ThenIAmNavigatedToTheMissingPostalAddressPage()
        {
            PostalAddressMissing.VerifyMissingAddressPage();
        }

        [When(@"I click the back link on the Add '(.*)'s postal address\?' page")]
        public void WhenIClickTheBackLinkOnTheAddSPostalAddressPage(string p0)
        {
            AddPostcodePage.ClickBackLink(); ;
        }

    }
}
