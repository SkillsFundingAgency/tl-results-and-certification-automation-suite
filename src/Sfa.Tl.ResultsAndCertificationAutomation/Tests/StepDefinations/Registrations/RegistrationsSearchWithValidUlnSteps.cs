using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationsSearchWithValidUlnSteps : RegistrationsManualPage
    {
        [Given(@"I click on Add a new registration link")]
        public void GivenIClickOnAddANewRegistrationLink()
        {
            SqlQueries.DeleteFromRegistrationTables();
            RegistrationsPage.ClickRegLink();
            AddNewRegistrations();
        }
        
        [Given(@"I enter (.*) and click Continue button")]
        public void GivenIEnterAndClickContinueButton(string Uln)
        {
            EnterUln(Uln);
            ClickContiune();
        }
        
        [Given(@"I enter (.*) (.*) in learners page and click Contiune")]
        public void GivenIEnterInLearnersPageAndClickContiune(string FirstName, string LastName)
        {
            EnterLearnerName(FirstName, LastName);
            ClickContiune();
        }
        
        [Given(@"I enter (.*) (.*) (.*) in DOB page and click Continue")]
        public void GivenIEnterInDOBPageAndClickContinue(string Day, string Month, string Year)
        {
            EnterDob(Day, Month, Year);
            ClickContiune();
        }
        
        [Given(@"I select (.*) from the Provider list and click Continue")]
        public void GivenISelectFromTheProviderListAndClickContinue(string Provider)
        {
            SelectProviderFromList(Provider);
            ClickContiune();
        }
        
        [Given(@"I select (.*) from the Core list and click Continue")]
        public void GivenISelectFromTheCoreListAndClickContinue(string Core)
        {
            SelectCoreFromList(Core);
            ClickContiune();
        }
        
        [Given(@"I select No from has decided specialism and click Continue")]
        public void GivenISelectNoFromHasDecidedSpecialismAndClickContinue()
        {
            ClickElement(DecideNo);
            ClickContiune();
        }
        
        [Given(@"I click Continue in Academic Year page")]
        public void GivenIClickContinueInAcademicYearPage()
        {
            ClickContiune();
        }
        
        [Given(@"I click Submit button")]
        public void GivenIClickSubmitButton()
        {
            ClickSubmit();
        }
        
        [Given(@"I click on back to registration link")]
        public void GivenIClickOnBackToRegistrationLink()
        {
            ClickElement(RegistrationsPage.BacktoRegistrationLink);
        }
        
        [Given(@"I click on Search for registrations link")]
        public void GivenIClickOnSearchForRegistrationsLink()
        {
            ClickElement(RegistrationsSearchPage.SearchRegistrationLink);
        }
        
        [When(@"I enter (.*) and click on Search")]
        public void WhenIEnterAndClickOnSearch(string p0)
        {
            EnterText(RegistrationsSearchPage.SearchBox, p0);
            ClickElement(RegistrationsSearchPage.SearchBtn);
        }
        
        [Then(@"I should see results in the page")]
        public void ThenIShouldSeeResultsInThePage()
        {
            RegistrationsSearchPage.VerifySearchResultPage();
        }
    }
}
