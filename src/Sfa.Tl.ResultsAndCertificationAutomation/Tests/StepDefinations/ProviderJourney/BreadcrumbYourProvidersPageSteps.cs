using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ProviderJourney
{
    [Binding]
    public class BreadcrumbYourProvidersPageSteps : ProviderPage
    {
        [When(@"I am on your Providers page")]
        public void WhenIAmOnYourProvidersPage()
        {
            DeleteTlevelFromDB();
            FindProvider();
            SelectTlevel(Agriculture);
            Submit();
            ManageTlevels();
            ClickElement(BcYourProvider);
        }
    }
}
