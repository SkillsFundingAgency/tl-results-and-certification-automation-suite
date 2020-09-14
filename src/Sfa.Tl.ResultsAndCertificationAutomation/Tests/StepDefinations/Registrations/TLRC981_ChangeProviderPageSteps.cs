using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC981_ChangeProviderPageSteps : RegistrationsSearchPage
    {
        [Given(@"I have created a manul registration")]
        public void GivenIHaveCreatedAManulRegistration()
        {
            SqlQueries.DeleteFromRegistrationTables();
            RegistrationsManualPage.CreateManualRegistrationWithSpecialism("9900000001");
        }
        
        [Given(@"I am on registration deails page")]
        public void GivenIAmOnRegistrationDeailsPage()
        {
            ClickElement(SearchRegistrationLink);
            EnterText(SearchBox, "9900000001");
            ClickButton(SearchBtn);
            VerifySearchResultPage();
        }
        
        [When(@"I click on change Provider link on Regisration details page")]
        public void WhenIClickOnChangeProviderLinkOnRegisrationDetailsPage()
        {
            ClickElement(ProviderChangeLink);
        }
        
        [Then(@"I should see Change provider page")]
        public void ThenIShouldSeeChangeProviderPage()
        {
            Assert.AreEqual(ChangeProviderPageTitle, WebDriver.Title);
            Assert.AreEqual(ChangeProviderPageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(ChangeProviderUrl));
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
