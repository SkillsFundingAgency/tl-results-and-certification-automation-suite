using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostalAddress;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostalAddress
{
    [Binding]
    public class _3187_SearchPostcodeSteps : AddPostcodePage
    {
        [Then(@"I should see address result page")]
        public void ThenIShouldSeeAddressResultPage()
        {
            VerifySelectAddressPage();
        }
        
        [Then(@"back link takes me to find postal address page")]
        public void ThenBackLinkTakesMeToFindPostalAddressPage()
        {
            ManagePostalAddress.ClickBackLink();
            VerifyAddPostalAddressPage();
        }
        [Then(@"I see postcode is retained")]
        public void ThenISeePostcodeIsRetained(Table table)
        {
            foreach (var row in table.Rows)
            {
                var expectedVal =row[0];
                var actualVal = GetPostcodeFieldValue();
                Assert.AreEqual(expectedVal, actualVal);
            }
        }
        [Then(@"it should takes me to find postal address page")]
        public void ThenItShouldTakesMeToFindPostalAddressPage()
        {
            VerifyChangeAddPostalAddressPage();
            Assert.AreEqual("", GetPostcodeFieldValue());
        }
        [Given(@"I click Can't find address link")]
        public void GivenIClickCanTFindAddressLink()
        {
            ClickCantFindAddressLink();
        }

        [Then(@"I should be navigated to add address manually page")]
        public void ThenIShouldBeNavigatedToAddAddressManuallyPage()
        {
            AddAddressManually.VerifyNavigateToAddAddressManuallyPage();
        }
        [Then(@"it should return addresses")]
        public void ThenItShouldReturnAddresses()
        {
            VerifyAddressCount();
        }
    }
}
