using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ProviderJourney
{
    [Binding]
    public class BackLinkSelectProviderPageSteps : ProviderPage
    {
        [Given(@"click on Provider link in dashboard page")]
        public void GivenClickOnProviderLinkInDashboardPage()
        {
            ClickProviderLink();
            DeleteTlevelFromDB();
        }
        
        [Given(@"I serch the Provider")]
        public void GivenISerchTheProvider()
        {
            FindProvider();
            Assert.IsTrue(WebDriver.Title.Equals(SelectProvidersTlevelPageTitle));
            Assert.IsTrue(WebDriver.Url.Contains(SelectProviderUrl));
        }
        
        [When(@"I click on Back link")]
        public void WhenIClickOnBackLink()
        {
            ClickElement(BackLink);
        }

        [Then(@"I will be navigated to the Find a Provider page")]
        [Then(@"I should be navigated back to Find a Provider page")]
        public void ThenIShouldBeNavigatedBackToFindAProviderPage()
        {
            Assert.IsTrue(WebDriver.Title.Equals(FindProviderPageTitle));
            Assert.IsTrue(WebDriver.Url.Contains(ProviderUrl));
            Assert.IsTrue(WebDriver.FindElement(PageHeader).Text.Contains(FindProviderPageHead));
        }

        [Given(@"I click on the Provider link in dashboard page")]
        public void GivenIClickOnTheProviderLinkInDashboardPage()
        {
            ClickProviderLink();
        }

        [When(@"I click the I cannot find a provider link on the Which provider do you want to manage\? page")]
        [Given(@"I click the I cannot find a provider link on the Which provider do you want to manage\? page")]
        public void GivenIClickTheICannotFindAProviderLinkOnTheWhichProviderDoYouWantToManagePage()
        {
            ClickICannotFindAProviderLink();
        }

        [Given(@"I click the ""(.*)"" button on the Which provider do you want to manage\? page")]
        public void GivenIClickTheButtonOnTheWhichProviderDoYouWantToManagePage(string p0)
        {
            ClickViewExistingProvidersBtn();
        }

        [Given(@"I click the Confirm your T Levels link on the Which provider do you want to manage\? page")]
        public void GivenIClickTheConfirmYourTLevelsLinkOnTheWhichProviderDoYouWantToManagePage()
        {
            ClickConfirmYourTLevelsLink();
        }

        [When(@"I click the Contact us link on the Which provider do you want to manage\? page")]
        public void WhenIClickTheContactUsLinkOnTheWhichProviderDoYouWantToManagePage()
        {
            ClickContactUsLink();
        }
    }
}
