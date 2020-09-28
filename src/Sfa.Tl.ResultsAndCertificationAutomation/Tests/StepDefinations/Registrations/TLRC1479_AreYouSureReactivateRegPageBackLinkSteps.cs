using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1479_AreYouSureReactivateRegPageBackLinkSteps : RegistrationReactivate
    {
        [Then(@"I should be navigated back to Reactivte options page")]
        public void ThenIShouldBeNavigatedBackToReactivteOptionsPage()
        {
            VerifyAmendWithdrawnPage();
            SqlQueries.DeleteFromRegistrationTables();
        }
        
        [Then(@"the Reactivate with same course radoi button should be selected")]
        public void ThenTheReactivateWithSameCourseRadoiButtonShouldBeSelected()
        {
            Assert.AreEqual(true, WebDriver.FindElement(ReactivateRegistration).Selected);
            Assert.AreEqual(false, WebDriver.FindElement(RegisterDifferentCourse).Selected);
        }
        
        [Then(@"the register learner on different course radio button should be selected")]
        public void ThenTheRegisterLearnerOnDifferentCourseRadioButtonShouldBeSelected()
        {
            Assert.AreEqual(true, WebDriver.FindElement(RegisterDifferentCourse).Selected);
            Assert.AreEqual(false, WebDriver.FindElement(ReactivateRegistration).Selected);
        }


    }
}
