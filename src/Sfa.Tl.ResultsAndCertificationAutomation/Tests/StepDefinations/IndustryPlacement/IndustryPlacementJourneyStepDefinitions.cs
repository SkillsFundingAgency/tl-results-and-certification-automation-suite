using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.IndustryPlacement;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation
{
    [Binding]
    public class IndustryPlacementJourneyStepDefinitions
    {

        private readonly ScenarioContext _scenarioContext;
        public IndustryPlacementJourneyStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I have an active registration with an Education and Childcare T Level")]
        public void GivenIHaveAnActiveRegistrationWithAnEducationAndChildcareTLevel()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;
            RegistrationsForSoa.RegistrationForEducationChildCare(uln);
        }

        [Given(@"I have an active registration with Digital production, design and development T Level")]
        public void GivenIHaveAnActiveRegistrationWithDigitalProductionDesignAndDevelopmentTLevel()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;
            RegistrationsForSoa.RegistrationForDigitalProductionDesign(uln);
        }

        [Given(@"I have an active registration with an Health T Level")]
        public void GivenIHaveAnActiveRegistrationWithAnHealthTLevel()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;
            RegistrationsForSoa.RegistrationForHealth(uln);
        }

        [Given(@"I have an active registration with a Digital Business Services T Level")]
        public void GivenIHaveAnActiveRegistrationWithADigitalBusinessServicesTLevel()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;
            RegistrationsForSoa.RegistrationForDigitalBusinessService(uln); 
        }

        [Given(@"I have an active registration with a Onsite Construction T Level T Level")]
        public void GivenIHaveAnActiveRegistrationWithAOnsiteConstructionTLevelTLevel()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            _scenarioContext["uln"] = uln;
            RegistrationsForSoa.RegistrationForOnsiteConstruction(uln);
        }

        [When(@"I click ""([^""]*)"" on the Did learner use the blended placement temporary flexibility\? page")]
        public void WhenIClickOnTheDidLearnerUseTheBlendedPlacementTemporaryFlexibilityPage(string RadioButton)
        {
            var uln = _scenarioContext["uln"] as string;
            BlendedPlacementTemporaryFlexibilityPage.VerifyBlendedPlacementTemporaryFlexibilityPage(uln);
            BlendedPlacementTemporaryFlexibilityPage.ClickRadioButton(RadioButton);
        }

        [When(@"I click ""([^""]*)"" on the Did learner use the employer-led activities/projects temporary flexibility\? page")]
        public void WhenIClickOnTheDidLearnerUseTheEmployer_LedActivitiesProjectsTemporaryFlexibilityPage(string RadioButton)
        {
            var uln = _scenarioContext["uln"] as string;
            EmployerLedActivitiesPage.VerifyEmployerLedActivitiesPage(uln);
            EmployerLedActivitiesPage.ClickRadioButton(RadioButton);
        }

        [Given(@"I update the registration to be (.*)")]
        public void GivenIUpdateTheRegistrationToBe(int p0)
        {
            var uln = _scenarioContext["uln"] as string;
            SqlQueries.UpdateRegistrationAcademicYearTo2021(uln);
        }





        [When(@"I enter the ULN on the search page")]
        public void WhenIEnterTheULNOnTheSearchPage()
        {
            var uln = _scenarioContext["uln"] as string;
            SearchLearnerPage.SearchUln(uln);
        }

        [When(@"I click the following link ""([^""]*)""")]
        public void WhenIClickTheFollowingLink(string Link)
        {
            LearnerDetailsPage.AddEmip(Link);
        }

        [When(@"I click '([^']*)' on the Has learner completed their industry placement\? page")]
        public void WhenIClickOnTheHasLearnerCompletedTheirIndustryPlacementPage(string RadioButton)
        {
            var uln = _scenarioContext["uln"] as string;
            IndustryPlacementCompletionPage.VerifyIndustryPlacementCompletionPage(uln);
            IndustryPlacementCompletionPage.ClickRadioButton(RadioButton);
        }

        [When(@"I click ""([^""]*)"" hours on the How many industry placement hours did learner complete\?")]
        public void WhenIClickHoursOnTheHowManyIndustryPlacementHoursDidLearnerComplete(string Hours)
        {
            var uln = _scenarioContext["uln"] as string;
            SpecialConsiderationHoursPage.VerifySpecialConsiderationHoursPage(uln);
            SpecialConsiderationHoursPage.EnterHours(Hours);
        }

        [When(@"I enter invalid value of ""([^""]*)"" hours on the How many industry placement hours did learner complete\?")]
        public void WhenIEnterInvlaidValueOfHoursOnTheHowManyIndustryPlacementHoursDidLearnerComplete(string Hours)
        {
            SpecialConsiderationHoursPage.EnterHours(Hours);
        }



        [When(@"I click ""([^""]*)"" on Why was learner granted special consideration for their industry placement\? page")]
        public void WhenIClickOnWhyWasLearnerGrantedSpecialConsiderationForTheirIndustryPlacementPage(string Option)
        {
            var uln = _scenarioContext["uln"] as string;
            IndustryPlacementSpecialConsiderationReasonsPage.VerifyIndustryPlacementSpecialConsiderationReasonsPage(uln);
            IndustryPlacementSpecialConsiderationReasonsPage.ClickCheckBox(Option);
        }


        [When(@"I click ""([^""]*)"" on the Was an industry placement model used for learner\? page")]
        public void WhenIClickOnTheWasAnIndustryPlacementModelUsedForLearnerPage(string RadioButton)
        {
            var uln = _scenarioContext["uln"] as string;
            WasAnIndustryPlacementModelUsedPage.VerifyTemporaryPlacementModelUsedPage(uln);
            WasAnIndustryPlacementModelUsedPage.ClickRadioButton(RadioButton);
        }



        [When(@"I click ""([^""]*)"" on the Was a multiple employer model used for learner page")]
        public void WhenIClickOnTheWasAMultipleEmployerModelUsedForLearnerPage(string RadioButton)
        {
            var uln = _scenarioContext["uln"] as string;
            WasMultipleEmployerModelUsedPage.VerifyWasMultipleEmployerModelUsedPage(uln);
            WasMultipleEmployerModelUsedPage.ClickRadioButton(RadioButton);
        }


        [When(@"I click ""([^""]*)"" on the Did learner use any other industry placement models\? page")]
        public void WhenIClickOnTheDidLearnerUseAnyOtherIndustryPlacementModelsPage(string PlacementModel)
        {
            var uln = _scenarioContext["uln"] as string;
            AnyOtherIndustryPlacementModelsPage.VerifyAnyOtherIndustryPlacementModelsPage(uln);
            AnyOtherIndustryPlacementModelsPage.ClickCheckBox(PlacementModel);
        }

        [When(@"I click ""([^""]*)"" on the Which industry placement models were used by learner\? page")]
        public void WhenIClickOnTheWhichIndustryPlacementModelsWereUsedByLearnerPage(string PlacementModel)
        {
            var uln = _scenarioContext["uln"] as string;
            IndustryPlacementModelsUsedPage.VerifyIndustryPlacementModelsUsedPage(uln);
            IndustryPlacementModelsUsedPage.ClickCheckBox(PlacementModel);
        }



        [When(@"I click ""([^""]*)"" on the Was learner granted a temporary flexibility\? page")]
        public void WhenIClickOnTheWasLearnerGrantedATemporaryFlexibilityPage(string RadioButton)
        {
            var uln = _scenarioContext["uln"] as string;
            WasGrantedTemporaryFlexibilityPage.VerifyWasGrantedTemporaryFlexibilityPage(uln);
            WasGrantedTemporaryFlexibilityPage.ClickRadioButton(RadioButton);
        }


        [Then(@"I am shown the IP Check your answer page")]
        public void ThenIAmShownTheIPCheckYourAnswerPage()
        {
            var uln = _scenarioContext["uln"] as string;
            CheckYourAnswersPage.VerifyCheckYourAnswersPage(uln);
        }


        [When(@"I click ""([^""]*)"" on the Which temporary flexibilities were granted to learner page")]
        public void WhenIClickOnTheWhichTemporaryFlexibilitiesWereGrantedToLearnerPage(string Option)
        {
            var uln = _scenarioContext["uln"] as string;
            WhichTemporaryFlexibilitiesWereGrantedPage.VerifyWhichTemporaryFlexibilitiesWereGrantedPage(uln);
            WhichTemporaryFlexibilitiesWereGrantedPage.ClickCheckBox(Option);
        }

        [Then(@"I click Submit on the Check your answers page")]
        public void ThenIClickSubmitOnTheCheckYourAnswersPage()
        {
            CheckYourAnswersPage.ClickSubmitBtn();
        }

        [Then(@"the learner details page is displayed with a success banner")]
        public void ThenTheLearnerDetailsPageIsDisplayedWithASuccessBanner()
        {
            var uln = _scenarioContext["uln"] as string;
            LearnerDetailsPage.VerifySuccessBanner();
            LearnerDetailsPage.VerifyAddIPLinkNotPresent();
            LearnerDetailsPage.VerifyLearnerDetails(uln);
        }

        [When(@"I click Continue on the Has learner completed their industry placement\? page")]
        public void WhenIClickContinueOnTheHasLearnerCompletedTheirIndustryPlacementPage()
        {
            IndustryPlacementCompletionPage.ClickContinueBtn();
        }

        [Then(@"the user is shown an error message which says Tell us whether this learner has completed their industry placement")]
        public void ThenTheUserIsShownAnErrorMessageWhichSaysTellUsWhetherThisLearnerHasCompletedTheirIndustryPlacement()
        {
            IndustryPlacementCompletionPage.VerifyErrorIndustryPlacementCompletionPage();
            IndustryPlacementCompletionPage.ClickRadioButton("Yes, completed with special consideration");
        }

        [When(@"I click Continue on the How many industry placement hours did learner complete\? page")]
        public void WhenIClickContinueOnTheHowManyIndustryPlacementHoursDidLearnerCompletePage()
        {
            SpecialConsiderationHoursPage.ClickContinueBtn();
        }

        [Then(@"the user is shown an error message which says Enter number of hours the learner spent on placement")]
        public void ThenTheUserIsShownAnErrorMessageWhichSaysEnterNumberOfHoursTheLearnerSpentOnPlacement()
        {
            SpecialConsiderationHoursPage.VerifyNoHoursEnteredErrorMessage();
        }

        [Then(@"the user is shown an error message which says The placement duration must be a whole number between (.*) and (.*) hours")]
        public void ThenTheUserIsShownAnErrorMessageWhichSaysThePlacementDurationMustBeAWholeNumberBetweenAndHours(int p0, int p1)
        {
            SpecialConsiderationHoursPage.VerifyInvalidEntryErrorMessage();
            SpecialConsiderationHoursPage.EnterHours("300");
        }

        [When(@"I click Continue on the Why was learner granted special consideration for their industry placement\? page")]
        public void WhenIClickContinueOnTheWhyWasLearnerGrantedSpecialConsiderationForTheirIndustryPlacementPage()
        {
            IndustryPlacementSpecialConsiderationReasonsPage.ClickContinueBtn();
        }

        [Then(@"the user is shown an error message which says Select one or more reasons for granting special consideration")]
        public void ThenTheUserIsShownAnErrorMessageWhichSaysSelectOneOrMoreReasonsForGrantingSpecialConsideration()
        {
            IndustryPlacementSpecialConsiderationReasonsPage.VerifyErrorIndustryPlacementSpecialConsiderationReasonsPage();
            IndustryPlacementSpecialConsiderationReasonsPage.ClickCheckBox("Learner's medical reasons");
        }

        [When(@"I click Continue on the Was an industry placement model used for learner\? page")]
        public void WhenIClickContinueOnTheWasAnIndustryPlacementModelUsedForLearnerPage()
        {
            WasAnIndustryPlacementModelUsedPage.ClickContinueBtn();
        }

        [Then(@"the user is shown an error message which says Select yes if learner used an industry placement model")]
        public void ThenTheUserIsShownAnErrorMessageWhichSaysSelectYesIfLearnerUsedAnIndustryPlacementModel()
        {
            WasAnIndustryPlacementModelUsedPage.VerifyErrorMessage();
            WasAnIndustryPlacementModelUsedPage.ClickRadioButton("Yes");
        }

        [When(@"I click Continue on the Was a multiple employer model used for learner page")]
        public void WhenIClickContinueOnTheWasAMultipleEmployerModelUsedForLearnerPage()
        {
            WasMultipleEmployerModelUsedPage.ClickContinueBtn();
        }

        [Then(@"the user is shown an error message which says Select yes if learner used the multiple employer model")]
        public void ThenTheUserIsShownAnErrorMessageWhichSaysSelectYesIfLearnerUsedTheMultipleEmployerModel()
        {
            WasMultipleEmployerModelUsedPage.VerifyErrorWasMultipleEmployerModelUsedPage();
            WasMultipleEmployerModelUsedPage.ClickRadioButton("Yes");
        }

        [When(@"I click Continue on the Was learner granted a temporary flexibility\? page")]
        public void WhenIClickContinueOnTheWasLearnerGrantedATemporaryFlexibilityPage()
        {
            WasGrantedTemporaryFlexibilityPage.ClickContinueBtn();
        }

        [Then(@"the user is shown an error message which says Select whether the learner was granted a temporary flexibility")]
        public void ThenTheUserIsShownAnErrorMessageWhichSaysSelectWhetherTheLearnerWasGrantedATemporaryFlexibility()
        {
            WasGrantedTemporaryFlexibilityPage.VerifyWasGrantedTemporaryFlexibilityErrorPage();
            WasGrantedTemporaryFlexibilityPage.ClickRadioButton("Yes");
        }

        [When(@"I click Continue on the Which temporary flexibilities were granted to learner page")]
        public void WhenIClickContinueOnTheWhichTemporaryFlexibilitiesWereGrantedToLearnerPage()
        {
            WhichTemporaryFlexibilitiesWereGrantedPage.ClickContinueBtn();
        }

        [Then(@"the user is shown an error message which says Select one or more temporary flexibilities")]
        public void ThenTheUserIsShownAnErrorMessageWhichSaysSelectOneOrMoreTemporaryFlexibilities()
        {
            WhichTemporaryFlexibilitiesWereGrantedPage.VerifyErrorWhichTemporaryFlexibilitiesWereGrantedPage();
            WhichTemporaryFlexibilitiesWereGrantedPage.ClickCheckBox("Reduction in hours");
        }

        [When(@"I click Continue on the Which industry placement models were used by learner\? page")]
        public void WhenIClickContinueOnTheWhichIndustryPlacementModelsWereUsedByLearnerPage()
        {
            IndustryPlacementModelsUsedPage.ClickContinueBtn();
        }

        [Then(@"the user is shown an error message which says Select one or more industry placement models")]
        public void ThenTheUserIsShownAnErrorMessageWhichSaysSelectOneOrMoreIndustryPlacementModels()
        {
            IndustryPlacementModelsUsedPage.VerifyErrorIndustryPlacementModelsUsedPage();
            IndustryPlacementModelsUsedPage.ClickCheckBox("Relevant part-time work");
        }

        [When(@"I click Continue on the blended placement temporary flexibility\? page")]
        public void WhenIClickContinueOnTheBlendedPlacementTemporaryFlexibilityPage()
        {
            BlendedPlacementTemporaryFlexibilityPage.ClickContinueBtn();
        }

        [Then(@"the user is shown an error message which says Select whether the learner has used the blended placement temporary flexibility")]
        public void ThenTheUserIsShownAnErrorMessageWhichSaysSelectWhetherTheLearnerHasUsedTheBlendedPlacementTemporaryFlexibility()
        {
            BlendedPlacementTemporaryFlexibilityPage.VerifyErrorBlendedPlacementTemporaryFlexibilityPage();
            BlendedPlacementTemporaryFlexibilityPage.ClickRadioButton("No");
        }

        [When(@"I click Continue on the employer-led activities/projects temporary flexibility\? page")]
        public void WhenIClickContinueOnTheEmployer_LedActivitiesProjectsTemporaryFlexibilityPage()
        {
            EmployerLedActivitiesPage.ClickContinueBtn();
        }

        [Then(@"the user is shown an error message which says Select whether the learner used the employer-led activities/projects temporary flexibility")]
        public void ThenTheUserIsShownAnErrorMessageWhichSaysSelectWhetherTheLearnerUsedTheEmployer_LedActivitiesProjectsTemporaryFlexibility()
        {
            EmployerLedActivitiesPage.VerifyErrorEmployerLedActivitiesPage();
            EmployerLedActivitiesPage.ClickRadioButton("Yes");
        }

        [Then(@"the IP learner details page is displayed")]
        public void ThenTheIPLearnerDetailsPageIsDisplayed()
        {
            var uln = _scenarioContext["uln"] as string;
            LearnerDetailsPage.VerifyLearnerDetails(uln);
            LearnerDetailsPage.VerifyAddIPLinkIsPresent();
        }
    }
}
