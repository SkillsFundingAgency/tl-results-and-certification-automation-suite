using System;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers
{
    [Binding]
    public class _2694_HasLearnerAchievedMinimumStandardForEnglishMathsPageSteps
    {

        private readonly ScenarioContext _scenarioContext;
        public _2694_HasLearnerAchievedMinimumStandardForEnglishMathsPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [Given(@"I click the back link on the '(.*)' page")]
        public void GivenIClickTheBackLinkOnThePage(string p0)
        {
            LearnerAchievedMinStandardForEnglishAndMathsPage.ClickBackLink();
        }
        
        [Given(@"I select the minimum standards link")]
        public void GivenISelectTheMinimumStandardsLink()
        {
            LearnerAchievedMinStandardForEnglishAndMathsPage.ClickAchievedMinStandardLink();
        }
        
        [Then(@"I am navigated to the Learner Enter ULN page")]
        public void ThenIAmNavigatedToTheLearnerEnterULNPage()
        {
            Pages.CommonUlnDbSteps.VerifyAddANewLearnerRecordPage();
        }
        
        [Then(@"the ULN field is still populated with the previously entered ULN")]
        public void ThenTheULNFieldIsStillPopulatedWithThePreviouslyEnteredULN()
        {
            var uln = _scenarioContext["uln"] as string;
            Pages.CommonUlnDbSteps.VerifyEnterULNFieldPopulated(uln);
        }
        
        [Then(@"no text is shown above above the Continue buttton")]
        public void ThenNoTextIsShownAboveAboveTheContinueButtton()
        {
            LearnerAchievedMinStandardForEnglishAndMathsPage.VerifyRadioButtonDeclarationTextIsNotDisplayed();
        }
        
        [Then(@"the radio button caption text is shown above the Continue buttton")]
        public void ThenTheRadioButtonCaptionTextIsShownAboveTheContinueButtton()
        {
            LearnerAchievedMinStandardForEnglishAndMathsPage.VerifyRadioButtonDeclarationTextIsDisplayed();
        }
        
        [Then(@"the Minimum standards text is displayed")]
        public void ThenTheMinimumStandardsTextIsDisplayed()
        {
            LearnerAchievedMinStandardForEnglishAndMathsPage.VerifyMinStandardTextIsDisplayed();
        }
        
        [Then(@"I select the minimum standards link")]
        public void ThenISelectTheMinimumStandardsLink()
        {
            LearnerAchievedMinStandardForEnglishAndMathsPage.ClickWhatAreTheMinStandardsLink();
        }
        
        [Then(@"the Minimum standards text is hidden")]
        public void ThenTheMinimumStandardsTextIsHidden()
        {
            LearnerAchievedMinStandardForEnglishAndMathsPage.VerifyMinStandardTextIsNotDisplayed();
        }

        [Then(@"the error message ""(.*)"" is shown on the MathAndEnglish page")]
        public void ThenTheErrorMessageIsShownOnTheMathAndEnglishPage(string ErrorMessage)
        {
            LearnerAchievedMinStandardForEnglishAndMathsPage.VerifyErrorMessage(ErrorMessage);
        }

        [Then(@"I select the ""(.*)"" radio button")]
        [Given(@"I select the ""(.*)"" radio button")]
        public void GivenISelectTheRadioButton(string RadioButton)
        {
            LearnerAchievedMinStandardForEnglishAndMathsPage.SelectRadioButton(RadioButton);
        }


    }
}
