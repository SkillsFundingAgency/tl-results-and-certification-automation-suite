using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC983_ChangeCorePageSteps : RegistrationsSearchPage
    {
        [When(@"I click on Change core link")]
        public void WhenIClickOnChangeCoreLink()
        {
            ClickElement(CoreChangeLink);
        }
        
        [Then(@"I should see change Core page")]
        public void ThenIShouldSeeChangeCorePage()
        {
            Assert.AreEqual(ChangeCorePageTitle, WebDriver.Title);
            Assert.AreEqual(ChangeCorePageHeader, WebDriver.FindElement(PageHeader).Text);
            Assert.IsTrue(WebDriver.Url.Contains(ChangeCorePageUrl));
        }
    }
}
