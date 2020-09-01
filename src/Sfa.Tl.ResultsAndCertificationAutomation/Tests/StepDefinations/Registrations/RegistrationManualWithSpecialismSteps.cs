using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationManualWithSpecialismSteps : RegistrationsManualPage
    {
        [When(@"I enter (.*) (.*) (.*) in DOB page and click Continue")]
        public void WhenIEnterInDOBPageAndClickContinue(string p0, string p1, string p2)
        {
            VerifyDobPage();
            EnterDob(p0, p1, p2);
            ClickContiune();
        }
        
        [When(@"I select Provider from the list and click Continue")]
        public void WhenISelectProviderFromTheListAndClickContinue()
        {
            VerifyProviderPage();
            SelectProviderFromList(InputPovider);
            ClickContiune();
        }
        
        [When(@"I select Core from the list and click Continue")]
        public void WhenISelectCoreFromTheListAndClickContinue()
        {
            VerifyCorePage();
            SelectCoreFromList(InputCore);
            ClickContiune();
        }
        
        [When(@"I select Yes from has decided specialism and click Continue")]
        public void WhenISelectYesFromHasDecidedSpecialismAndClickContinue()
        {
            VerifySpecialismDecidePage();
            ClickElement(DecideYes);
            ClickContiune();
        }
        
        [When(@"I select Specialism and click Continue")]
        public void WhenISelectSpecialismAndClickContinue()
        {
            VerifySpecialismPage();
            ClickElement(SelectSpecialismLegal);
            ClickContiune();
        }
        
        [When(@"I click Continue in Academic Year page")]
        public void WhenIClickContinueInAcademicYearPage()
        {
            VerifyAcademicYearPage();
            ClickContiune();
        }
        
        [When(@"I click Submit button")]
        public void WhenIClickSubmitButton()
        {
            VerifyRegistrationSummaryPage();
            ClickSubmit();
        }
        
        [Then(@"I should see ULN Added successfully message")]
        public void ThenIShouldSeeULNAddedSuccessfullyMessage()
        {
            VerifyRegistrationSuccessPage();
            
        }


        [When(@"I create a registration using (.*) (.*) (.*) (.*) (.*) (.*) without specialisms")]
        public void WhenICreateARegistrationUsingWithoutSpecialisms(string ULN, string FirstName, string LastName, string Day, string Month, string Year)
        {
            CreateRegistrationWithoutSpecialism(ULN, FirstName, LastName, Day, Month, Year);
        }

    }
}
