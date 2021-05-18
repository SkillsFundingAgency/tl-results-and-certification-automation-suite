using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostalAddress;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.PostalAddress
{
    [Binding]
    public class _3140_ManageOrgPostalAddressPageSteps : ManagePostalAddress
    {
        [Then(@"I should see Manage organisation postal address page")]
        public void ThenIShouldSeeManageOrganisationPostalAddressPage()
        {
            VerifyManageOrgPostalAddressPage();
        }
        
        [Then(@"I should retun to dashboard when i click on Home breadcrumb")]
        public void ThenIShouldRetunToDashboardWhenIClickOnHomeBreadcrumb()
        {
            ClickHomeBreadCrumb();
            Assert.AreEqual(TlevelDashboardPage.DashboardUrl, WebDriver.Url);
        }
    }
}
