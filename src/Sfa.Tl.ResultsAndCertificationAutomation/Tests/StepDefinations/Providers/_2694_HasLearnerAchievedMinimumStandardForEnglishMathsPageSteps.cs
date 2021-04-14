using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;
using System;
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

        [Given(@"I select the ""(.*)"" radio button")]
        public void GivenISelectTheRadioButton(string Radio)
        {
            LearnerAchievedMinStandardForEnglishAndMathsPage.SelectRadioButton(Radio);
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
            Pages.CommonUlnDbSteps.VerifySeachUlnField(uln);
        }

        [Then(@"no text is shown above above the Continue buttton")]
        public void ThenNoTextIsShownAboveAboveTheContinueButtton()
        {
            LearnerAchievedMinStandardForEnglishAndMathsPage.VerifyDeclarationTextNotDisplayed();
        }

        [Then(@"I select the ""(.*)"" radio button")]
        public void ThenISelectTheRadioButton(string Radio)
        {
            LearnerAchievedMinStandardForEnglishAndMathsPage.SelectRadioButton(Radio);
        }

        [Then(@"the radio button caption text is shown above the Continue buttton")]
        public void ThenTheRadioButtonCaptionTextIsShownAboveTheContinueButtton()
        {
            LearnerAchievedMinStandardForEnglishAndMathsPage.VerifyDeclarationTextDisplayed();
        }

        [Then(@"the error message ""(.*)"" is shown on the MathAndEnglish page")]
        public void ThenTheErrorMessageIsShownOnTheMathAndEnglishPage(string ErrorMessage)
        {
            LearnerAchievedMinStandardForEnglishAndMathsPage.VerifyErrorMessage(ErrorMessage);
        }
    }
}
