using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1492_ReregisterAcademicYearBackToLearnerDecideSteps : ReregisterHasLearnerDecidePage
    {
        [Then(@"previous selected radio option retained")]
        public void ThenPreviousSelectedRadioOptionRetained()
        {
            Assert.AreEqual(true, WebDriver.FindElement(AddSpecialismLater).Selected);
        }
    }
}
