using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostalAddress;
using System;
using TechTalk.SpecFlow;


namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostalAddress
{
    [Binding]
    public class _3171_ProviderPostalAddress_OrgPostalAddressAddedSuccessfullySteps
    {
        [When(@"I click Submit")]
        public void WhenIClickSubmit()
        {
            CheckAndSubmit.ClickSubmitBtn();
        }
        
        [Then(@"I am shown the Address address confirmation page")]
        public void ThenIAmShownTheAddressAddressConfirmationPage()
        {
            AddAddressConfirmationPage.VerifyAddPostalAddressPage();
        }


        [Then(@"the record will be written to the database with '(.*)' '(.*)' '(.*)' '(.*)' '(.*)' '(.*)'")]
        public void ThenTheRecordWillBeWrittenToTheDatabaseWith(string OrgName, string DeptName, string AddLine1, string AddLine2, string Town, string Postcode)
        {
            AddAddressConfirmationPage.VerifyAddressAdded(OrgName, DeptName, AddLine1, AddLine2,Town,Postcode);
        }

        [Then(@"I enter a department name as ""(.*)""")]
        public void ThenIEnterADepartmentNameAs(string DepartmentName)
        {
            AddPostcodePage.EnterDepartmentName(DepartmentName);
        }

        [Then(@"when I press the Back to home link")]
        public void ThenWhenIPressTheBackToHomeLink()
        {
            AddAddressConfirmationPage.ClickBackToHomeLink();
        }




    }
}
