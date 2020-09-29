using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1488_ReregisterWithAnotherCourseProviderSteps : RegistrationReactivate
    {
        [When(@"I select register learner on different course and click continue button")]
        public void WhenISelectRegisterLearnerOnDifferentCourseAndClickContinueButton()
        {
            ClickElement(RegisterDifferentCourse);
            ClickElement(ContinueBtn);
        }
        
        [Then(@"I should register learner on a new course provider page")]
        public void ThenIShouldRegisterLearnerOnANewCourseProviderPage()
        {
            VerifyReactivateWithAnotherProviderPage();
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
