using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1481_ChangeSpecialismSteps : RegistrationsSearchPage
    {
        [Given(@"I have created a registration without Specialism")]
        public void GivenIHaveCreatedARegistrationWithoutSpecialism()
        {
            SqlQueries.DeleteFromRegistrationTables();
            RegistrationsManualPage.CreateRegistrationWithoutSpecialism("9900000001");
        }
        
        [Then(@"I should see change specialism page with all specialisms")]
        public void ThenIShouldSeeChangeSpecialismPageWithAllSpecialisms()
        {
            Assert.AreEqual(ChangeSpecialismPageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(SelectSpecialismPageUrl));
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
