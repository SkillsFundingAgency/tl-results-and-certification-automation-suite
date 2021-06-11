using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.StatementOfAchievement;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.StatementOfAchievement
{
    [Binding]
    public class _3157_StatementOfAchievement_StatementsOfAchievementAreNotYetAvailableSteps
    {
        private readonly ScenarioContext _scenarioContext;
        public _3157_StatementOfAchievement_StatementsOfAchievementAreNotYetAvailableSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [Given(@"I click the Accept and send request button")]
        public void GivenIClickTheAcceptAndSendRequestButton()
        {
            SOACheckAndSubmitPage.ClickAcceptAndRequestBtn();
        }
        
        [Then(@"the Request statement of achievement confirmation page is displayed")]
        public void ThenTheRequestStatementOfAchievementConfirmationPageIsDisplayed()
        {
            var uln = _scenarioContext["uln"] as string;
            SOAConfirmationPage.VerifyRequestSOAConfirmationPage(uln, "Db FirstName Db LastName");
        }
        
        [Then(@"I press the Back to home button on the statement of achievement confirmation page")]
        public void ThenIPressTheBackToHomeButtonOnTheStatementOfAchievementConfirmationPage()
        {
            SOAConfirmationPage.ClickBackToHomeBtn();
        }

        [Then(@"the Registration and Request Statement of achievement Print records are deleted for this test")]
        public void ThenTheRegistrationAndPrintRecordsAreDeletedForThisTest()
        {
            var uln = _scenarioContext["uln"] as string;
            SqlQueries.DeletePrintTableRecords(uln);
            CrateRegistrationInDb createReg = new CrateRegistrationInDb();
            createReg.DeleteLrsRecordsFromTables(uln);
        }

    }
}
