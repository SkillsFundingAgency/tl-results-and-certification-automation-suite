using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1491_ReregisterCreateSpecialismPageSteps : ReregisterCreateSpecialismPage
    {
        [Given(@"I select Add specialism option and click continue")]
        public void GivenISelectAddSpecialismOptionAndClickContinue()
        {
            ClickElement(AddSpecialismNow);
            ClickContinueBtn();
        }
        
        [Then(@"I should see Learner new course Specialism page")]
        public void ThenIShouldSeeLearnerNewCourseSpecialismPage()
        {
            VerifyReregisterSelectSpecialismPage();
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
