using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1783_ReregisterChangeAnotherSpecialismSteps : ReregisterCheckAndSubmitPage
    {
        [Given(@"I click on reregister change specialism link")]
        public void GivenIClickOnReregisterChangeSpecialismLink()
        {
            ClickElement(ChangeSpecialism);
        }
        
        [Given(@"I click continue in reregister has learner decide page")]
        public void GivenIClickContinueInReregisterHasLearnerDecidePage()
        {
            ClickContinueBtn();
        }
        
        [Given(@"I unchecked the original value and select another specialism and click change")]
        public void GivenIUncheckedTheOriginalValueAndSelectAnotherSpecialismAndClickChange()
        {
            ClickElement(ReregisterCreateSpecialismPage.SelectSpecialism);
            ClickElement(ReregisterCreateSpecialismPage.SelectSpecialism2);
            ClickButton(ChangeBtn);
        }
        
        [Then(@"I should see new specialism in check and submit page")]
        public void ThenIShouldSeeNewSpecialismInCheckAndSubmitPage()
        {
            RegistrationsSearchPage.VerifySpecialism(ExpectedSpecialism2);
        }
    }
}
