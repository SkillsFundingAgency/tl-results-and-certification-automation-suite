using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1476_WithdrawnOptionsPageSteps : RegistrationReactivate
    {
        [When(@"I click on Change status link in registraion details page")]
        public void WhenIClickOnChangeStatusLinkInRegistraionDetailsPage()
        {
            ClickElement(ChangeStatusLink);
        }
        
        [Then(@"I should see withdrawn option page")]
        public void ThenIShouldSeeWithdrawnOptionPage()
        {
            VerifyAmendWithdrawnPage();
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
