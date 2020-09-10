using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC981_ChangeProviderDifferentCoreSteps : RegistrationsSearchPage
    {
        private static readonly string ChangeProvider = "Automation Test1 (99999901)";
        [When(@"I change another provider has different core from the list")]
        public void WhenIChangeAnotherProviderHasDifferentCoreFromTheList()
        {
            RegistrationsManualPage.SelectProviderFromList(ChangeProvider);
        }
        
        [Then(@"I should see generic error page")]
        public void ThenIShouldSeeGenericErrorPage()
        {
            Assert.AreEqual(CannotChangeProviderPageTitle, WebDriver.Title);
            Assert.AreEqual(CannotChangeProviderPageUrl, WebDriver.Url);
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
