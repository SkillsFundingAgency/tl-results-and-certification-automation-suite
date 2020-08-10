using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationManualChangeAcademicYearSteps : RegistrationsManualPage
    {
        [Given(@"I click Academic Year change link")]
        public void GivenIClickAcademicYearChangeLink()
        {
            ClickChangeAcademicYearLink();
        }
        
        [Given(@"I click Change button in academic year page")]
        public void GivenIClickChangeButtonInAcademicYearPage()
        {
            Assert.AreEqual(Constants.SelectAcademicYearTitle, WebDriver.Title);
            Assert.IsTrue(WebDriver.Url.Contains(AcademicYearPageUrl));
            ClickChangeBtn();
        }
        
        [Then(@"i should see changed Academic year in the Check and Submit page")]
        public void ThenIShouldSeeChangedAcademicYearInTheCheckAndSubmitPage()
        {
            VerifyRegistrationSummaryPage();
        }
    }
}
