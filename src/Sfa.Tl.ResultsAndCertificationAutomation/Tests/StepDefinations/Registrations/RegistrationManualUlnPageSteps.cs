using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationManualUlnPageSteps : RegistrationsManualPage
    {
        [When(@"I click on Add a new registration link")]
        public void WhenIClickOnAddANewRegistrationLink()
        {
            SqlQueries.DeleteFromRegistrationTables();
            RegistrationsPage.ClickRegLink();
            AddRegistrations();
        }
        
        [Then(@"I should see ULn Page")]
        public void ThenIShouldSeeULnPage()
        {
            VerifyUlnPage();
        }

        [Then(@"I will be presented with an error stating ULN is invalid")]
        public void ThenIWillBePresentedWithAnErrorStatingULNIsInvalid()
        {
            VerifyInvalidULNError();
        }

        [Then(@"I will be presented with an error stating Enter a ULN")]
        public void ThenIWillBePresentedWithAnErrorStatingEnterAULN()
        {
            VerifyNullULNError();
        }

        [Then(@"I enter (.*) into the ULN field and press Submit")]
        public void ThenIEnterIntoTheULNFieldAndPressSubmit(string ULN)
        {
            EnterSearchUln(ULN);
            ClickSearchButton();
        }

        [Then(@"the Registration Details page is displayed")]
        public void ThenTheRegistrationDetailsPageIsDisplayed()
        {
            VerifyRegistrationDetailsPage();
        }


    }
}
