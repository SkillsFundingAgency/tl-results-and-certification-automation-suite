using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1490_ReRegisterCreateHasLearnerDecidedSpecialismSteps : ReregisterHasLearnerDecidePage
    {
        [Given(@"I select register learner on different course and click on continue")]
        public void GivenISelectRegisterLearnerOnDifferentCourseAndClickOnContinue()
        {
            ClickElement(RegistrationReactivate.RegisterDifferentCourse);
            ClickContinueBtn();
        }

        [Given(@"I select the provider and core from dropdown and click continue")]
        public void GivenISelectTheProviderAndCoreFromDropdownAndClickContinue()
        {
            SelectProviderAndCore();
        }

        [When(@"I click on continue without selecting any options")]
        public void WhenIClickOnContinueWithoutSelectingAnyOptions()
        {
            ClickContinueBtn();
        }
        
        [Then(@"I should see error on as Learner Decided Specialism page")]
        public void ThenIShouldSeeErrorOnAsLearnerDecidedSpecialismPage()
        {
            VerifyReregisterLearnerDecideErrorPage();
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
