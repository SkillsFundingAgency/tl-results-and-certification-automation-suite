using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using System.Threading;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class ProviderAddMultipleTlevelsSteps : ProviderPage
    {
        [When(@"I select multiple tlevels")]
        public void WhenISelectMultipleTlevels()
        {
            SelectTlevel(Agriculture);
            Thread.Sleep(1500);
            SelectTlevel(Education);
        }

        [Then(@"TLevels should be added to the Provide")]
        public void ThenTLevelsShouldBeAddedToTheProvide()
        {
            Assert.AreEqual(TlevelsSuccessMsg, WebDriver.FindElement(PageHeader).Text);
            Assert.AreEqual(SubmitTlevel, WebDriver.Url);
            Assert.IsTrue(WebDriver.Title.Equals(TlevelsSuccessMsg));
            Assert.IsTrue(WebDriver.FindElement(PageContent).Text.Contains(Constants.TlevelTitleAgricluture));
            Assert.IsTrue(WebDriver.FindElement(PageContent).Text.Contains(Constants.TlevelTitleEducation));
        }
    }
}
