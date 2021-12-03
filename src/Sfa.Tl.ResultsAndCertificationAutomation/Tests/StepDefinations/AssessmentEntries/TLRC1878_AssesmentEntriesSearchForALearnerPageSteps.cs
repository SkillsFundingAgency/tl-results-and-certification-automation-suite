using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class TLRC1878_AssesmentEntriesSearchForALearnerPageSteps 
    {

        private readonly ScenarioContext _scenarioContext;
        public TLRC1878_AssesmentEntriesSearchForALearnerPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [Then(@"the Assessments Search for a learner page is shown")]
        [Then(@"the heading, page title and URL will be as expected")]
        public void ThenTheHeadingPageTitleAndURLWillBeAsExpected()
        {
            AssessmentEntriesSearchForLearnerPage.VerifyAssessmentEntriesSearchForLearnerPage();
        }

        [Then(@"the expected page text will be displayed")]
        public void ThenTheExpectedPageTextWillBeDisplayed()
        {
            AssessmentEntriesSearchForLearnerPage.VerifyAssessmentEntriesSearchForLearnerPageText();
        }

        [Given(@"I enter the unregistered (.*)")]
        public void GivenIEnterTheUnregistered(string ULN)
        {
            SqlQueries.DeleteFromRegistrationTables();
            AssessmentEntriesSearchForLearnerPage.EnterULN(ULN);
        }

        [When(@"I enter the following (.*)")]
        [Given(@"I enter the following (.*)")]
        public void GivenIEnterTheFollowing(string ULN)
        {
            AssessmentEntriesSearchForLearnerPage.EnterULN(ULN);
        }



        [Then(@"I am shown an error on the Assessment Entry Search for a learner page for invalid URL")]
        public void ThenIAmShownAnErrorOnTheAssessmentEntrySearchForALearnerPageForInvalidURL()
        {
            AssessmentEntriesSearchForLearnerPage.VerifyInvalidULNErrorMessage();
        }


        [Given(@"I press Search without entering a ULN")]
        public void GivenIPressSearchWithoutEnteringAULN()
        {
            AssessmentEntriesSearchForLearnerPage.PressSearch();
        }

        [Then(@"I am shown an error on the Assessment Entry Search for a learner page for missing URL")]
        public void ThenIAmShownAnErrorOnTheAssessmentEntrySearchForALearnerPageForMissingURL()
        {
            AssessmentEntriesSearchForLearnerPage.VerifyNullULNErrorMessage();
        }

        [Given(@"I press the Assessment Entries breadcrumb link")]
        public void GivenIPressTheAssessmentEntriesBreadcrumbLink()
        {
            AssessmentEntriesSearchForLearnerPage.PressAssessmentEntriesBreadcrumb();
        }


        [Given(@"I press the Home breadcrumb link")]
        public void GivenIPressTheHomeBreadcrumbLink()
        {
            AssessmentEntriesSearchForLearnerPage.PressHomeBreadcrumb();
        }

        [Then(@"I am navigated to the Assessment Entries page")]
        public void ThenIAmNavigatedToTheAssessmentEntriesPage()
        {
            AssessmentEntriesPage.VerifyAssessmentEntriesPage();
        }


        [Then(@"I am taken to the home page")]
        public void ThenIAmTakenToTheHomePage()
        {
            TlevelDashboardPage.VerifyDashboardpage();
        }



        [Then(@"I am navigated to the ULN connot be found page which shows a header with the (.*)")]
        public void ThenIAmNavigatedToTheULNConnotBeFoundPageWhichShowsAHeaderWithThe(string ULN)
        {
            AssessmentEntriesULNCannotBeFoundPage.VerifyPageText(ULN);
            AssessmentEntriesULNCannotBeFoundPage.VerifyAssessmentEntriesULNNotFoundPage();
            SqlQueries.DeleteFromRegistrationTables();
        }


        [Then(@"I press the Back Link on ULN not found page")]
        public void ThenIPressTheBackLinkOnULNNotFoundPage()
        {
            AssessmentEntriesULNCannotBeFoundPage.PressBackLink();
        }


        [Then(@"I am navigated back to the Search for a learner page")]
        public void ThenIAmNavigatedBackToTheSearchForALearnerPage()
        {
            AssessmentEntriesSearchForLearnerPage.VerifyAssessmentEntriesSearchForLearnerPageText();
        }

        [Then(@"the search field on the ULN not found page still shows the (.*) entered")]
        public void ThenTheSearchFieldOnTheULNNotFoundPageStillShowsTheEntered(string ULN)
        {
            AssessmentEntriesSearchForLearnerPage.VerifyULNSearchFieldValue(ULN);
            SqlQueries.DeleteFromRegistrationTables();
        }

        [Then(@"Search field on the ULN not found page is shown and the Search field is empty")]
        public void ThenSearchFieldOnTheULNNotFoundPageIsShownAndTheSearchFieldIsEmpty()
        {
            AssessmentEntriesSearchForLearnerPage.VerifyULNSearchFieldIsEmpty();
        }


        [Then(@"I press the Back to search button on the ULN not found page")]
        public void ThenIPressTheBackToSearchButtonOnTheULNNotFoundPage()
        {
            //AssessmentEntriesULNCannotBeFoundPage.PressBackToSearch();
        }

        [Given(@"I search for my withdrawn registration")]
        public void GivenISearchForMyWithdrawnRegistration()
        {
            var uln = _scenarioContext["uln"] as string;
            AssessmentEntriesSearchForLearnerPage.EnterULN(uln);
        }

        [When(@"I click on the back link on the learner withdrawn page")]
        public void WhenIClickOnTheBackLinkOnTheLearnerWithdrawnPage()
        {
            AssessmentEntriesWithdrawnPage.PressBackLink();
        }



        [Then(@"I am taken to the Assessment search page with Uln prepopulated")]
        public void ThenIAmTakenToTheAssessmentSearchPageWithUlnPrepopulated()
        {
            var uln = _scenarioContext["uln"] as string;
            AssessmentEntriesSearchForLearnerPage.VerifyULNSearchFieldValue(uln);
        }

        [When(@"I press the Search again button on the learner withdrawn page")]
        public void WhenIPressTheSearchAgainButtonOnTheLearnerWithdrawnPage()
        {
            AssessmentEntriesSearchForLearnerPage.PressSearch();
            AssessmentEntriesWithdrawnPage.PressSearchAgain();
        }

        [Then(@"I am taken to the Assessment search page with the Search field empty")]
        public void ThenIAmTakenToTheAssessmentSearchPageWithTheSearchFieldEmpty()
        {
            AssessmentEntriesSearchForLearnerPage.VerifyULNSearchFieldIsEmpty();
        }

        [Then(@"I press the Search again button on the ULN not found page")]
        public void ThenIPressTheSearchAgainButtonOnTheULNNotFoundPage()
        {
            AssessmentEntriesULNCannotBeFoundPage.PressSearchAgainBtn();
        }

        [When(@"I press the Back link on the Assessment ULN not found page")]
        public void WhenIPressTheBackLinkOnTheAssessmentULNNotFoundPage()
        {
            AssessmentEntriesULNCannotBeFoundPage.PressBackLink();
        }

        [When(@"I press the Search again button on the ULN not found page")]
        public void WhenIPressTheSearchAgainButtonOnTheULNNotFoundPage()
        {
            AssessmentEntriesULNCannotBeFoundPage.PressSearchAgainBtn();
        }

        [When(@"I press the Back to home button")]
        public void WhenIPressTheBackToHomeButton()
        {
            AssessmentEntriesULNCannotBeFoundPage.PressBackToHomeBtn();
        }

        [Then(@"I am navigated to the Assessment Search for a learner page")]
        public void ThenIAmNavigatedToTheAssessmentSearchForALearnerPage()
        {
            AssessmentEntriesSearchForLearnerPage.VerifyAssessmentEntriesSearchForLearnerPage();
        }

    }
}
