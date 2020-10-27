using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1620_RegistrationDeleteSearchSteps : RegistrationDeletePage
    {
        [When(@"I click on search for registration button")]
        public void WhenIClickOnSearchForRegistrationButton()
        {
            ClickElement(SearchAnotherRegBtn);
        }
        
        [When(@"I search for deleted registration")]
        public void WhenISearchForDeletedRegistration()
        {
            RegistrationsSearchPage.SearchForULN();
        }
        
        [Then(@"I should see ULN not found page")]
        public void ThenIShouldSeeULNNotFoundPage()
        {
            RegistrationsSearchPage.VerifyUlnNotFoundPage("9900000001");
        }

    }
}
