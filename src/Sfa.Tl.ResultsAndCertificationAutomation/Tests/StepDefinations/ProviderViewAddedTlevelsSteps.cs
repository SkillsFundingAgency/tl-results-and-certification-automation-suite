using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class ProviderViewAddedTlevelsSteps : ProviderPage
    {
        [Then(@"Added Tlevels should be displayed when i click Manage Tlevels link")]
        public void ThenAddedTlevelsShouldBeDisplayedWhenIClickManageTlevelsLink()
        {
            ManageTlevels();
            Assert.IsTrue(WebDriver.FindElement(PageContent).Text.Contains(Constants.TlevelTitleAgricluture));
            Assert.IsTrue(WebDriver.FindElement(PageContent).Text.Contains(Constants.TlevelTitleEducation));
        }
    }
}
