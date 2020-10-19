using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1620_RegistrationDeletePageSteps : RegistrationDeletePage
    {
        [When(@"I select Delete this registration radio button and click continue")]
        public void WhenISelectDeleteThisRegistrationRadioButtonAndClickContinue()
        {
            ClickElement(DeleteRadioBtn);
            ClickElement(ContinueBtn);
        }
        
        [Then(@"I should see Are you sure delete registration page")]
        public void ThenIShouldSeeAreYouSureDeleteRegistrationPage()
        {
            VerifyDeleteRegCheckPage();
            Assert.AreEqual(false, WebDriver.FindElement(DeleteYesRadio).Selected);
            Assert.AreEqual(false, WebDriver.FindElement(DeleteNoRadio).Selected);
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
