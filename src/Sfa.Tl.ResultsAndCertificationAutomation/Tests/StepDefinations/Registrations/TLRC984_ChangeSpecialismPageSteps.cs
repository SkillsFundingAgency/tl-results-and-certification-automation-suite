using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC984_ChangeSpecialismPageSteps : RegistrationsSearchPage
    {
        [When(@"I click on change Specialism link")]
        public void WhenIClickOnChangeSpecialismLink()
        {
            ClickElement(SpecialismChangeLink);
        }

        [Then(@"I should be navigated to Do you want to change or remove your specialism page")]
        public void ThenIShouldBeNavigatedToDoYouWantToChangeOrRemoveYourSpecialismPage()
        {
            VerifyDecideSpecialismChangePage();
        }

        [Then(@"I should be navigated to Has learner decided on specialism page")]
        public void ThenIShouldBeNavigatedToHasLearnerDecidedOnSpecialismPage()
        {
            VerifyDecideSpecialismPage();
        }
        
        [Then(@"the redio button is selected to yes")]
        public void ThenTheRedioButtonIsSelectedToYes()
        {
            WebDriver.FindElement(DecideSpecialismYes).GetAttribute("checked");
        }
        
        [Then(@"button name should be continue")]
        public void ThenButtonNameShouldBeContinue()
        {
            _ = IsPresent(ContinueBtn);
            SqlQueries.DeleteFromRegistrationTables();
        }
    }
}
