using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class _1879_CreateLearnerSAssessmentEntriesPageSteps : AssessmentEntriesPage
    {
        [Given(@"I upload registrations and associated assessments")]
        public void GivenIUploadRegistrationsAndAssociatedAssessments()
        {
            SqlQueries.DeleteFromAssessmentTables();
            SqlQueries.DeleteFromRegistrationTables();
            SqlQueries.DeleteFromRegistrationTables();
            RegistrationsPage.ClickRegLink();
            AssessmentEntriesPage.ClickElement(RegistrationsPage.UploadRegistationLink);
            AssessmentEntriesPage.UploadFile(RegistrationsPage.ChooseFile, "1879RegistrationsDataForAssessments.csv");
            AssessmentEntriesPage.ClickElement(RegistrationsPage.SubmitFileBtn);
            RegistrationsPage.VerifyRegistrationSuccessPage();
            AssessmentEntriesPage.ClickElement(TlevelDashboardPage.DashboardHeadLink);
            AssessmentEntriesPage.ClickElement(AssessmentEntriesLink);
            AssessmentEntriesPage.ClickElement(UploadAssessmentEntryLink);
            AssessmentEntriesPage.VerifyAssessmentEntriesUploadPage();
            AssessmentEntriesPage.UploadFile(RegistrationsPage.ChooseFile, "1879AssessmentEntrySuccessfulData.csv");
            CommonPage.ClickButtonByLabel("Submit");
            VerifyAssessmentUploadSuccessPage();
            AssessmentEntriesPage.ClickBacktoAssessmentEntriesButton();
        }


        [Then(@"I am shown the Learner's Assessment Entries page with details for (.*)")]
        public void ThenIAmShownTheLearnerSAssessmentEntriesPageWithDetailsFor(string ULN)
        {
            AssessmentEntriesLearnersAssessmentEntriesPage.VerifyLearnersAssessmentEntriesPage();
            AssessmentEntriesLearnersAssessmentEntriesPage.VerifyDynamicHeaders(ULN);
        }


        [Then(@"the Core and Specialism is displayed in grey text")]
        public void ThenTheCoreAndSpecialismIsDisplayedInGreyText()
        {
            AssessmentEntriesLearnersAssessmentEntriesPage.VerifyCoreAndSpecialismText();
        }

        [Then(@"the Core Assessment entry is displayed underneath")]
        public void ThenTheCoreAssessmentEntryIsDisplayedUnderneath()
        {
            AssessmentEntriesLearnersAssessmentEntriesPage.VerifyCoreAssessmentEntryDisplayed();
        }

        [Then(@"the Core Assessment entry '(.*)' is displayed underneath")]
        public void ThenTheCoreAssessmentEntryIsDisplayedUnderneath(string AssessmentEntry)
        {
            AssessmentEntriesLearnersAssessmentEntriesPage.VerifySummer2021CoreAssessmentEntryDisplayed(AssessmentEntry);
        }


        [Then(@"the Core Assessment entry displays ""(.*)""")]
        public void ThenTheCoreAssessmentEntryDisplays(string p0)
        {
            AssessmentEntriesLearnersAssessmentEntriesPage.VerifyNoCoreAssessmentEntryDisplayed();
        }

        [Then(@"the specialism entry is displayed")]
        public void ThenTheSpecialismEntryIsDisplayed()
        {
            AssessmentEntriesLearnersAssessmentEntriesPage.VerifySpecialismAssessmentEntryDisplayed();
        }

        [Then(@"the specialism entry displays ""(.*)""")]
        public void ThenTheSpecialismEntryDisplays(string p0)
        {
            AssessmentEntriesLearnersAssessmentEntriesPage.VerifyNoSpecialismAssessmentEntryDisplayed();
        }

        [Given(@"I navigate to the Search for a learner page and enter the (.*)")]
        public void GivenINavigateToTheSearchForALearnerPageAndEnterThe(string ULN)
        {
            AssessmentEntriesPage.ClickElement(SearchForLearnerLink);
            AssessmentEntriesSearchForLearnerPage.EnterULN(ULN);

        }

        [When(@"I click the '(.*)' link")]
        public void WhenIClickTheLink(string p0)
        {
            AssessmentEntriesLearnersAssessmentEntriesPage.PressViewAmendLearnersRegistrationDetailsLink();
        }

        [When(@"I click the Search again link on the learners assessment entries page")]
        public void WhenIClickTheSearchAgainLinkOnTheLearnersAssessmentEntriesPage()
        {
            AssessmentEntriesLearnersAssessmentEntriesPage.PressSearchAgain();
        }


        [Then(@"I am navigated to the Registration Details page for the learner's (.*)")]
        public void ThenIAmNavigatedToTheRegistrationDetailsPageForTheLearnerS(string ULN)
        {
            RegistrationsSearchPage.VerifySearchResultPage();
            RegistrationsSearchPage.VerifyRegistrationDetailsPageULNSubHeading(ULN);
        }

        [When(@"I press the Assessment Entries breadcrumb link on the Assessment Entries Learner page")]
        public void WhenIPressTheAssessmentEntriesBreadcrumbLinkOnTheAssessmentEntriesLearnerPage()
        {
            AssessmentEntriesLearnersAssessmentEntriesPage.PressAssessmentEntriesBreadcrumb();
        }

        [Given(@"I press the Home breadcrumb link on the Assessment Entries Learner page")]
        public void GivenIPressTheHomeBreadcrumbLinkOnTheAssessmentEntriesLearnerPage()
        {
            AssessmentEntriesLearnersAssessmentEntriesPage.PressHomeBreadcrumb();
        }


        [Given(@"I press the Search for a learner breadcrumb link on the Assessment Entries Learner page")]
        public void GivenIPressTheSearchForALearnerBreadcrumbLinkOnTheAssessmentEntriesLearnerPage()
        {
            AssessmentEntriesLearnersAssessmentEntriesPage.PressSearchAgain();
        }

        [Then(@"the core and specialism heading displays '(.*)'")]
        public void ThenTheCoreAndSpecialismHeadingDisplays(string p0)
        {
            AssessmentEntriesLearnersAssessmentEntriesPage.VerifyCoreSpecialismTableHeaders();
        }

        [Then(@"the text '(.*)' is displayed for the Specialism")]
        public void ThenTheTextIsDisplayedForTheSpecialism(string p0)
        {
            AssessmentEntriesLearnersAssessmentEntriesPage.VerifySpecialismAssessmentEntryText();
        }

        [Then(@"the Add Remove link displays '(.*)'")]
        public void ThenTheAddRemoveLinkDisplays(string LinkText)
        {
            AssessmentEntriesLearnersAssessmentEntriesPage.VerifyAddRemoveLinkText(LinkText);
        }








    }
}
