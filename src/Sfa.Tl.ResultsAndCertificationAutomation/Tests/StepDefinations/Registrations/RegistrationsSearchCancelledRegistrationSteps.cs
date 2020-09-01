using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationsSearchCancelledRegistrationSteps : RegistrationsSearchPage
    {
        [Given(@"I click on Search another registration button")]
        public void GivenIClickOnSearchAnotherRegistrationButton()
        {
            SearchAnotherReg();
        }
        
        [Then(@"I should see (.*) can not be found page")]
        public void ThenIShouldSeeCanNotBeFoundPage(string p0)
        {
            VerifyUlnNotFoundPage(p0);
        }

    }
}
