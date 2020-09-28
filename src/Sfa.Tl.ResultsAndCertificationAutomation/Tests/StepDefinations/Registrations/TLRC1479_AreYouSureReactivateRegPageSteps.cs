using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1479_AreYouSureReactivateRegPageSteps : RegistrationReactivate
    {
        [Given(@"I have a registration in Withdrawn state")]
        public void GivenIHaveARegistrationInWithdrawnState()
        {
            SqlQueries.DeleteFromRegistrationTables();
            CreateWithdrawnReg();
        }
        
        [Given(@"I click on Change status link in registraion details page")]
        public void GivenIClickOnChangeStatusLinkInRegistraionDetailsPage()
        {
            ClickElement(ChangeStatusLink);
        }
        
        [When(@"I select Reactivate with same course radio button and click continue")]
        public void WhenISelectReactivateWithSameCourseRadioButtonAndClickContinue()
        {
            ClickElement(ReactivateRegistration);
            ClickElement(ContinueBtn);
        }
        
        [Then(@"I should see Are you sure you want to reactivate page")]
        public void ThenIShouldSeeAreYouSureYouWantToReactivatePage()
        {
            VerifyAreYouSureReactivatePage();
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
