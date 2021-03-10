using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers
{
    [Binding]
    public class _2535_EnterUlnPageValidationsSteps : Pages.CommonUlnDbSteps
    {
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
