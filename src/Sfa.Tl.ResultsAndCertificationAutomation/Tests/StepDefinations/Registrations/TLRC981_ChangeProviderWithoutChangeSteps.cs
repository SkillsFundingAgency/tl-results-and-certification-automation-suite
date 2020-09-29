using NUnit.Framework;
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

        [When(@"I click on Back To Registration button")]
        public void WhenIClickOnBackToRegistrationButton()
        {
            ClickElement(BackToRegistrationDetailsBtn);
        }

        [Then(@"I should be navigated back to registration details page")]
        public void ThenIShouldBeNavigatedBackToRegistrationDetailsPage()
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
