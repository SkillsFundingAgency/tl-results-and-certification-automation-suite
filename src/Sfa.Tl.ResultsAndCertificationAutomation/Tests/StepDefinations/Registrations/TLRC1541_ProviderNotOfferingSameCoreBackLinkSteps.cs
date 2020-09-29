using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1541_ProviderNotOfferingSameCoreBackLinkSteps : RegistrationsSearchPage
    {
        [Then(@"I should be navigated back to Do you also want to change Core page")]
        public void ThenIShouldBeNavigatedBackToDoYouAlsoWantToChangeCorePage()
        {
            VerifyDoYouWantChangeCorePage();
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
