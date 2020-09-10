using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC981_ChangeProviderWithoutChangeSteps : RegistrationsSearchPage
    {
        [When(@"I click on Change button without changing provider")]
        public void WhenIClickOnChangeButtonWithoutChangingProvider()
        {
            ClickButton(ChangeBtn);
        }
        
        [Then(@"I should be nativigated back to registration details page")]
        public void ThenIShouldBeNativigatedBackToRegistrationDetailsPage()
        {
            VerifySearchResultPage();
        }
        
        [Then(@"I should see same provider in the details")]
        public void ThenIShouldSeeSameProviderInTheDetails()
        {
            VerifyProvider(RegistrationsManualPage.InputPovider);
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
