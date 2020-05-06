using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ProviderJourney
{
    [Binding]
    public class BackLinkRemoveTlevelPageSteps : ProviderPage
    {
        [Given(@"I am on Remove Tlevel page")]
        public void GivenIAmOnRemoveTlevelPage()
        {
            DeleteTlevelFromDB();
            ClickProviderLink();
            FindProvider();
            SelectTlevel(Agriculture);
            Submit();
            ManageTlevels();
            ClickRemoveTlevel();
        }
    }
}
