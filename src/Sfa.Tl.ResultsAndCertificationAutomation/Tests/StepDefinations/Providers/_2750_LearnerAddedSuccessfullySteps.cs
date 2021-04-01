using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers
{
    [Binding]
    public class _2750_LearnerAddedSuccessfullySteps : CrateRegistrationInDb
    {
        private readonly ScenarioContext _scenarioContext;
        public _2750_LearnerAddedSuccessfullySteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I have a registration with LRS qualifications - English and Maths acheived")]
        public void GivenIHaveARegistrationWithLRSQualifications_EnglishAndMathsAcheived()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;
            CreateDbRegistationForLrsWithEMAcheived(uln);
        }
        [Given(@"I select ""(.*)"" in english and maths page and press continue")]
        public void GivenISelectInEnglishAndMathsPageAndPressContinue(string radioOption)
        {
            LearnerAchievedMinStandardForEnglishAndMathsPage.ClickRadioButton(radioOption);
        }

        [Then(@"I should get Submit successfully page")]
        public void ThenIShouldGetSubmitSuccessfullyPage()
        {
            string uln = _scenarioContext["uln"] as string;
            SubmitSuccessPage.VerifySubmitSuccessPage();
            SubmitSuccessPage.VerifyLinksOnSubmitSuccessPage();
            SubmitSuccessPage.VerifyDataInSuccessPage(uln);
        }

        [Then(@"The Ip table is updated with ""(.*)""")]
        public void ThenTheIpTableIsUpdatedWith(string text)
        {
            string uln = _scenarioContext["uln"] as string;
            var expectedResult = LearnerHasTheLearnerCompletedIPPage.GetIpStatusByLabel(text);
            var actualResult = GetIPStatus(uln);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Then(@"the profile table is updated with ""(.*)""")]
        public void ThenTheProfileTableIsUpdatedWith(string text)
        {
            string uln = _scenarioContext["uln"] as string;
            var expectedResult = LearnerHasTheLearnerCompletedIPPage.GetEMStatusByLabel(text);
            var actualResult = GetEMStatus(uln);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Then(@"I should see Manage learner records page when i click on Back to learner page link")]
        public void ThenIShouldSeeManageLearnerRecordsPageWhenIClickOnBackToLearnerPageLink()
        {
            SubmitSuccessPage.ClickBackToManageLearnerLink();
            LearnerManageLearnerRecordsPage.VerifyManageLearnerRecordsPage();
        }
        [Then(@"I should see add learner page when i click on Add anopther learner button")]
        public void ThenIShouldSeeAddLearnerPageWhenIClickOnAddAnoptherLearnerButton()
        {
            SubmitSuccessPage.ClickAddNotherLearnerBtn();
            Pages.CommonUlnDbSteps.VerifyAddANewLearnerRecordPage();

        }

    }
}
