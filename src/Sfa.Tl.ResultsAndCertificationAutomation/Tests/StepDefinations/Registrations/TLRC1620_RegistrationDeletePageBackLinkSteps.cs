using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1620_RegistrationDeletePageBackLinkSteps : RegistrationDeletePage
    {
        [Then(@"I should be navigated back to Amend registration options page")]
        public void ThenIShouldBeNavigatedBackToAmendRegistrationOptionsPage()
        {
            VerifyAmendActiveRegPage();
            Assert.AreEqual(true, WebDriver.FindElement(DeleteRadioBtn).Selected);
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
