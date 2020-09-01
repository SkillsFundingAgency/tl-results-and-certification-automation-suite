using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationChangeAcademicYearBackLinkSteps : RegistrationsManualPage
    {
        [Given(@"I click on Academic Year change link")]
        public void GivenIClickOnAcademicYearChangeLink()
        {
            ClickChangeAcademicYearLink();
            Assert.IsTrue(WebDriver.Url.Contains(AcademicYearPageUrl));
            Assert.AreEqual(Constants.SelectAcademicYearTitle, WebDriver.Title);
        }
    }
}
