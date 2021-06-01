using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostalAddress;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.StatementOfAchievement;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostalAddress
{
    [Binding]
    public class _3171_ProviderPostalAddress_OrgPostalAddressAddedSuccessfullySteps : AddAddressConfirmationPage
    {
        [When(@"I click Submit")]
        public void WhenIClickSubmit()
        {
            CheckAndSubmit.ClickSubmitBtn();
        }
        
        [Then(@"I am shown the Address address confirmation page")]
        public void ThenIAmShownTheAddressAddressConfirmationPage()
        {
            VerifyAddPostalAddressPage();
        }

        [Then(@"the record will be written to the database with '(.*)' '(.*)' '(.*)' '(.*)' '(.*)' '(.*)'")]
        public void ThenTheRecordWillBeWrittenToTheDatabaseWith(string OrgName, string DeptName, string AddLine1, string AddLine2, string Town, string Postcode)
        {
            VerifyAddressAdded(OrgName, DeptName, AddLine1, AddLine2,Town,Postcode);
        }

        [Then(@"I enter a department name as ""(.*)""")]
        public void ThenIEnterADepartmentNameAs(string DepartmentName)
        {
            AddPostcodePage.EnterDepartmentName(DepartmentName);
        }

        [Then(@"when I press the Back to home link")]
        public void ThenWhenIPressTheBackToHomeLink()
        {
            ClickBackToHomeLink();
        }
        [When(@"I click on Request SOA button")]
        public void WhenIClickOnRequestSOAButton()
        {
            ClickRequestSOABtn();
        }

        [Then(@"I am taken to request SOA page")]
        public void ThenIAmTakenToRequestSOAPage()
        {
            RequestStatementOfAchievementPage.VerifyRequestStatementOfAchievementPage();
        }
    }
}
