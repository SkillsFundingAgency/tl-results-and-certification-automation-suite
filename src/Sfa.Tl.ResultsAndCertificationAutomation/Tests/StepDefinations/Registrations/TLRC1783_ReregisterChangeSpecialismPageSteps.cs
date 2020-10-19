using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1783_ReregisterChangeSpecialismPageSteps : ReregisterCheckAndSubmitPage
    {
        [When(@"I click on reregister change specialism link")]
        public void WhenIClickOnReregisterChangeSpecialismLink()
        {
            ClickElement(ChangeSpecialism);
        }
        
        [Then(@"I should see has learner decide page and Yes option is prechecked")]
        public void ThenIShouldSeeHasLearnerDecidePageAndYesOptionIsPrechecked()
        {
            VerifyReregisterLearnerDecidePage();
            Assert.AreEqual(true, WebDriver.FindElement(AddSpecialismNow).Selected);
        }
    }
}
