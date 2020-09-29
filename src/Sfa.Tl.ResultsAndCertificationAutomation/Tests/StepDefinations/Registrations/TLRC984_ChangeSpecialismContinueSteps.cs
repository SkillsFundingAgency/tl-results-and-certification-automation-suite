using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC984_ChangeSpecialismContinueSteps: RegistrationsSearchPage
    {
        [Then(@"I should see placeholder page")]
        public void ThenIShouldSeePlaceholderPage()
        {
            Assert.AreEqual(ChangeSpecialismPageTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(SelectSpecialismPageUrl));
        }
    }
}
