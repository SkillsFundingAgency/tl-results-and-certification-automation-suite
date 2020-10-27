using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1542_CannotChangeProviderAndCorePageSteps : RegistrationsSearchPage
    {
        [When(@"I select Yes, I also want to change the core option and click continue button")]
        public void WhenISelectYesIAlsoWantToChangeTheCoreOptionAndClickContinueButton()
        {
            ClickElement(CanChangeCoreYes);
            ClickButton(ContinueBtn);
        }
        
        [Then(@"I should see can not change provider and core page")]
        public void ThenIShouldSeeCanNotChangeProviderAndCorePage()
        {
            RegistrationChangeProviderAndCorePage.VerifyChangeProviderCore();
            _ = IsDisplayed(WithDrawRegistrationBtn);
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
