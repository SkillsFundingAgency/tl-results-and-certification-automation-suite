using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationSearchAnotherAOSteps : RegistrationsSearchPage
    {
        [Given(@"I created registration for the AO")]
        public void GivenICreatedRegistrationForTheAO()
        {
            RegistrationsManualPage.CreateRegistrationForPearson("9900000054", "FirstName1", "LastName1", "01", "01", "2010");
        }
        
        [Given(@"I click Sigh Out link")]
        public void GivenIClickSighOutLink()
        {
            WebDriver.FindElement(TlevelDashboardPage.SignOutLink).Click();
        }
        
        [Given(@"I navigated to serach registration page")]
        public void GivenINavigatedToSerachRegistrationPage()
        {
            RegistrationsPage.ClickRegLink();
            ClickElement(SearchRegistrationLink);
        }
        
        [Given(@"I entered the (.*) and click serach")]
        public void GivenIEnteredTheAndClickSerach(string Uln)
        {
            WebDriver.FindElement(SearchBox).Clear();
            EnterText(SearchBox, Uln);
            ClickElement(SearchBtn);
        }
        
        [Then(@"I should see an error with (.*)")]
        public void ThenIShouldSeeAnErrorWith(string Uln)
        {
            VerifyUlnNotFoundPage(Uln);
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
