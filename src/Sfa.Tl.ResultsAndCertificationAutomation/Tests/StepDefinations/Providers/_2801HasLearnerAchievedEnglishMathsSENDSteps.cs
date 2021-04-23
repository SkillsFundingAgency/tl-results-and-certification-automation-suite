using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;

using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers
{
    [Binding]
    public class _2801HasLearnerAchievedEnglishMathsSENDSteps : CrateRegistrationInDb
    {

        private readonly ScenarioContext _scenarioContext;
        public _2801HasLearnerAchievedEnglishMathsSENDSteps (ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [Given(@"I have a registraion from LRS with EM and no IP")]
        public void GivenIHaveARegistraionFromLRSWithEMAndNoIP()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;
            CreateDbRegistationForLrsWithEMOnly(uln);
        }

        [Then(@"I am navigated to the '(.*)' page")]
        public void ThenIAmNavigatedToThePage(string p0)
        {
            HasLearnersAchievedEMSendPage.VerifyHasLearnersAchievedEMSendPage();
        }

        [When(@"I enter the ULN on the Add learner page")]
        public void WhenIEnterTheULNOnTheAddLearnerPage()
        {
            var uln = _scenarioContext["uln"] as string;
            Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.CommonUlnDbSteps.EnterULN(uln);
            
        }

        [Then(@"the radio buttons will not be populated on '(.*)' page")]
        public void ThenTheRadioButtonsWillNotBePopulatedOnPage(string p0)
        {
            HasLearnersAchievedEMSendPage.VerifyRadioButtonsNotSelected();
        }

        [When(@"I select the ""(.*)"" radio button on the Min standard for EM Page")]
        [Then(@"I select the ""(.*)"" radio button on the Min standard for EM Page")]
        [Given(@"I select the ""(.*)"" radio button on the Min standard for EM Page")]
        public void GivenISelectTheRadioButtonOnTheMinStandardForEMPage(string RadioButton)
        {
            HasLearnersAchievedEMSendPage.SelectRadioButton(RadioButton);
        }

        [Then(@"no text is shown above above the Continue buttton on the Min standard for EM Page")]
        public void ThenNoTextIsShownAboveAboveTheContinueButttonOnTheMinStandardForEMPage()
        {
            HasLearnersAchievedEMSendPage.VerifyDeclarationTextNotDisplayed();
        }

        [Then(@"the radio button caption text is shown above the Continue buttton on the Min standard for EM Page")]
        public void ThenTheRadioButtonCaptionTextIsShownAboveTheContinueButttonOnTheMinStandardForEMPage()
        {
            HasLearnersAchievedEMSendPage.VerifyDeclarationTextDisplayed();
        }

        [When(@"I click the back link on the '(.*)' page")]
        public void WhenIClickTheBackLinkOnThePage(string p0)
        {
            HasLearnersAchievedEMSendPage.ClickBackLink();
        }

        [Then(@"I am shown the Provider - Enter a ULN page")]
        public void ThenIAmShownTheProvider_EnterAULNPage()
        {
            Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.CommonUlnDbSteps.VerifyAddULNPage();
        }

        [Then(@"the ULN is retained on the Provider - Enter a ULN page")]
        public void ThenTheULNIsRetainedOnTheProvider_EnterAULNPage()
        {
            var uln = _scenarioContext["uln"] as string;
            Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.CommonUlnDbSteps.VerifyEnterULNFieldRetainsULN(uln);
        }

        [Given(@"I click submit without selecting a radio button on the Min standard for EM Page")]
        public void GivenIClickSubmitWithoutSelectingARadioButtonOnTheMinStandardForEMPage()
        {
            HasLearnersAchievedEMSendPage.ClickSubmitButton();
        }

        [Then(@"I am shown an error message stating ""(.*)"" on the Min standard for EM Page")]
        public void ThenIAmShownAnErrorMessageStatingOnTheMinStandardForEMPage(string ErrorMessage)
        {
            HasLearnersAchievedEMSendPage.ValidateErrorMessage(ErrorMessage);
        }

        [When(@"I add non SEND qualifications to the registration")]
        public void WhenIAddNonSENDQualificationsToTheRegistration()
        {
            var uln = _scenarioContext["uln"] as string;
            AddNonSendQualificationsToRegistration(uln);
        }

        [Then(@"I am navigated to the Has the learner completed their industry placement\? page")]
        public void ThenIAmNavigatedToTheHasTheLearnerCompletedTheirIndustryPlacementPage()
        {
            var uln = _scenarioContext["uln"] as string;
            LearnerHasTheLearnerCompletedIPPage.VerifyLearnerHasTheLearnerCompletedIPPage(uln);
        }

        [Then(@"I update the ISSend flag to ""(.*)""")]
        [When(@"I update the ISSend flag to ""(.*)""")]
        public void WhenIUpdateTheISSendFlagTo(string ISSendFlag)
        {
            var uln = _scenarioContext["uln"] as string;
            string UpdateSQL = "update TqRegistrationProfile set Issendlearner = '" + ISSendFlag + "' where uniquelearnernumber = '" + uln + "'";
            SqlQueries.UpdateRegistrationProfileRecord(UpdateSQL);
        }


        [Then(@"I click back on the Has the learner completed their industry placement\? page")]
        public void ThenIClickBackOnTheHasTheLearnerCompletedTheirIndustryPlacementPage()
        {
            LearnerHasTheLearnerCompletedIPPage.ClickBackLink();
        }

        [Then(@"I click continue")]
        public void ThenIClickContinue()
        {
            Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.CommonUlnDbSteps.ClickContinue();
        }



    }
}
