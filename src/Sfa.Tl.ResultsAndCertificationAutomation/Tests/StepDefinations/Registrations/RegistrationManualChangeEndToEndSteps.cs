using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationManualChangeEndToEndSteps : RegistrationsManualPage
    {
        [Given(@"I click submit the registration")]
        public void GivenIClickSubmitTheRegistration()
        {
            ClickSubmit();
            VerifyRegistrationSuccessPage();
        }
        
        [Given(@"Go to Search registration page")]
        public void GivenGoToSearchRegistrationPage()
        {
            ClickBackToRegistrations();
            ClickSearchForRegistrationLink();
        }

        [Given(@"I enter the (.*) and click search")]
        public void GivenIEnterTheAndClickSearch(string Uln)
        {
            EnterText(RegistrationsSearchPage.SearchBox, Uln);
            ClickElement(RegistrationsSearchPage.SearchBtn);
        }


        [Then(@"I should see Registration with newly added data")]
        public void ThenIShouldSeeRegistrationWithNewlyAddedData()
        {
            RegistrationsSearchPage.verifyName("FirstName1 LastName1");
            RegistrationsSearchPage.verifyDob("01/01/2010");
            RegistrationsSearchPage.verifyProvider("Automation Test2 (99999902)");
            RegistrationsSearchPage.verifyCore("Legal, Finance and Accounting (55555555)");
            RegistrationsSearchPage.verifySpecialism("Financial (50000002)");
        }
    }
}
