using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers
{
    [Binding]
    public class _6245_HasLearnerCompletedIPPageStepDefinitions : HasLearnerCompletedIpPage
    {
        private readonly ScenarioContext _scenarioContext;
        public _6245_HasLearnerCompletedIPPageStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I have registration without maths English and Ip")]
        public void GivenIHaveRegistrationWithoutMathsEnglishAndIp()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;
            CrateRegistrationInDb.RegistationWithoutEngMatIp(uln, 2021);
        }

        [Given(@"I am on learner details page")]
        public void GivenIAmOnLearnerDetailsPage()
        {
            var uln = _scenarioContext["uln"] as string;
            LearnerDetailPage.NavigateLearnerDetailsPage(uln);
        }

        [When(@"I click '([^']*)' link on learner details page")]
        [Given(@"I click '([^']*)' link on learner details page")]
        public void WhenIClickLinkOnLearnerDetailsPage(string status)
        {
            LearnerDetailPage.AddEmip(status);
        }

        [Then(@"Has learner completed Ip page is shown")]
        public void ThenHasLearnerCompletedIpPageIsShown()
        {
            VerifyHasLearnerCompletedIpPage();
        }

        [Then(@"Bank link takes me back to learner details page")]
        public void ThenBankLinkTakesMeBackToLearnerDetailsPage()
        {
            VerifyBackLink();
        }
        [Then(@"click on '([^']*)' takes me to Has learner completed Ip page")]
        public void ThenClickOnTakesMeToHasLearnerCompletedIpPage(string status)
        {
            LearnerDetailPage.AddEmip(status);
            VerifyHasLearnerCompletedIpPage();
        }

        [When(@"I click continue without selecting completed Ip option")]
        public void WhenIClickContinueWithoutSelectingCompletedIpOption()
        {
            ClickContinueBtn();
        }

        [Then(@"the following error message shown on has learner completed Ip page")]
        public void ThenTheFollowingErrorMessageShownOnHasLearnerCompletedIpPage(Table table)
        {
            VerifyHasLearnerCompletedIpErrorPage();
            CommonPage.VerifyValidationMessage(table);
        }

        [Then(@"the flowwing error summary shown on has learner completed Ip page")]
        public void ThenTheFlowwingErrorSummaryShownOnHasLearnerCompletedIpPage(Table table)
        {
            CommonPage.VerifyValidationSummaryMessages(table);
        }

    }
}
