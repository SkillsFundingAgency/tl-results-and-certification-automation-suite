using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1540_ChangeProviderAndCorePageValidationsSteps : RegistrationsSearchPage
    {
        [When(@"I click Continue button without selecting options")]
        public void WhenIClickContinueButtonWithoutSelectingOptions()
        {
            ClickButton(ContinueBtn);
        }
        
        [Then(@"I should see validation errors")]
        public void ThenIShouldSeeValidationErrors()
        {
            Assert.AreEqual(DoYouWantToChangeCorePageErrorTitle, WebDriver.Title);
            Assert.AreEqual(CanChangeCodeErrorMsg, WebDriver.FindElement(ChangeCoreError).Text);
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
