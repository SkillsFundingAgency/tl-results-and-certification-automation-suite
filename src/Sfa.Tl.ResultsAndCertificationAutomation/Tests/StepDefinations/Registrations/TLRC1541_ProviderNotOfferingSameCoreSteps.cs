using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1541_ProviderNotOfferingSameCoreSteps : RegistrationsSearchPage
    {
        [When(@"I select No, I want to keep same core option and click continue button")]
        public void WhenISelectNoIWantToKeepSameCoreOptionAndClickContinueButton()
        {
            ClickElement(CanChangeCoreNo);
            ClickButton(ContinueBtn);
        }
        
        [Then(@"I should see Provider not offering same core page")]
        public void ThenIShouldSeeProviderNotOfferingSameCorePage()
        {
            RegistrationChangeProviderPage.VerifyProviderNotOfferSameCorePage();
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
