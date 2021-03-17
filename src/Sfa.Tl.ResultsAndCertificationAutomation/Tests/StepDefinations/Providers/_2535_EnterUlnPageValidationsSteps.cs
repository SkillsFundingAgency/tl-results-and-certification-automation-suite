using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers
{
    [Binding]
    public class _2535_EnterUlnPageValidationsSteps : Pages.CommonUlnDbSteps
    {
        [Given(@"I clear Uln data")]
        public void GivenIClearUlnData()
        {
            WebDriver.FindElement(By.Id("enteruln")).Clear();
        }

        [Then(@"I should see the following error message for the Uln")]
        public void ThenIShouldSeeTheFollowingErrorMessageForTheUln(Table table)
        {
            VerifyAddANewLearnerRecordErrorPage();
            CommonPage.VerifyValidationMessage(table);
        }
        
        [When(@"I enter following data")]
        public void WhenIEnterFollowingData(Table table)
        {
            CommonPage.FillFormWithData(table);
        }

    }
}
