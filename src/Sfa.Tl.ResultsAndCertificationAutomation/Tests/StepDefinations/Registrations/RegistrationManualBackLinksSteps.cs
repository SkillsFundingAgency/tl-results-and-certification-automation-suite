using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationManualBackLinksSteps : RegistrationsManualPage
    {
        [When(@"I am on Select Specialism page")]
        public void WhenIAmOnSelectSpecialismPage()
        {
            RegistrationsPage.ClickRegLink();
            SqlQueries.DeleteFromRegistrationTables();
            AddNewRegistrations();
            EnterUln("9900000001");
            ClickContiune();
            EnterLearnerName("FirstName1", "LastName1");
            ClickContiune();
            EnterDob("1", "1", "2010");
            ClickContiune();
            SelectProviderFromList(InputPovider);
            ClickContiune();
            SelectCoreFromList(InputCore);
            ClickContiune();
            ClickElement(DecideYes);
            ClickContiune();
        }
        
        [When(@"I click Back link on each page")]
        public void WhenIClickBackLinkOnEachPage()
        {
            VerifySpecialismPage();
            ClickBackLink();
        }
        
        [Then(@"I should navigate to previous page")]
        public void ThenIShouldNavigateToPreviousPage()
        {
            VerifySpecialismDecidePage();
            ClickBackLink();
            VerifyCorePage();
            ClickBackLink();
            VerifyProviderPage();
            ClickBackLink();
            VerifyDobPage();
            ClickBackLink();
            VerifyLearnersPage();
            ClickBackLink();
            VerifyUlnPage();
            ClickBackLink();
            RegistrationsPage.VerifyRegistrationDashboardPage();
        }
    }
}
