using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class _4713_AssessmentLearnerDetailsSteps : AssessmentEntriesPage
    {

        [Then(@"I am navigated to the Assessment Details page for (.*)")]
        public void ThenIAmNavigatedToTheAssessmentDetailsPageFor(string ULN)
        {
            AssessmentEntriesLearnersDetailsPage.VerifyAssessmentEntriesDetailsPage();
            AssessmentEntriesLearnersDetailsPage.VerifyLearnerDetails(ULN);
        }


        [Then(@"the Core section will state ""(.*)""")]
        public void ThenTheCoreSectionWillState(string CoreText)
        {
            AssessmentEntriesLearnersDetailsPage.VerifyCoreDetailsText(CoreText);
        }

        [Then(@"the Core section will state No assessment entries have yet been recorded for the current open assessment period")]
        public void ThenTheCoreSectionWillStateNoAssessmentEntriesHaveYetBeenRecordedForTheCurrentOpenAssessmentPeriod()
        {
            AssessmentEntriesLearnersDetailsPage.VerifyCoreNoAssessSeriesAddedText();
        }


        [Then(@"the Core section Add/Remove link will state ""(.*)""")]
        public void ThenTheCoreSectionAddRemoveLinkWillState(string LinkText)
        {
            AssessmentEntriesLearnersDetailsPage.VerifyAddRemoveCoreLinkText(LinkText);

        }


        [Then(@"the core code will display ""(.*)""")]
        public void ThenTheCoreCodeWillDisplay(string CoreText)
        {
            AssessmentEntriesLearnersDetailsPage.VerifyCoreDetailsText(CoreText);
        }

        [Then(@"the specialism section will state ""(.*)""")]
        public void ThenTheSpecialismSectionWillState(string SpecialismText)
        {
            AssessmentEntriesLearnersDetailsPage.VerifySpecialismDetailsText(SpecialismText);
        }

        [Then(@"the specialism section Add/Remove link will state ""(.*)""")]
        public void ThenTheSpecialismSectionAddRemoveLinkWillState(string LinkText)
        {
            AssessmentEntriesLearnersDetailsPage.VerifySpecialismDetailsText(LinkText);
        }


        [Then(@"the specialism section will state No assessment entries have yet been recorded for the current open assessment period")]
        public void ThenTheSpecialismSectionWillStateNoAssessmentEntriesHaveYetBeenRecordedForTheCurrentOpenAssessmentPeriod()
        {
            AssessmentEntriesLearnersDetailsPage.VerifySpecialismNoAssessSeriesAddedText();
        }


        [Then(@"the Specialism code will display ""(.*)""")]
        public void ThenTheSpecialismCodeWillDisplay(string SpecialismText)
        {
            AssessmentEntriesLearnersDetailsPage.VerifySpecialismDetailsText(SpecialismText);
        }

        [Then(@"when I click on the Add an occupational specialism recorded on this service link")]
        public void ThenWhenIClickOnTheAddAnOccupationalSpecialismRecordedOnThisServiceLink()
        {
            AssessmentEntriesLearnersDetailsPage.VerifyAddOccupationalSpecialismLinkText();
            AssessmentEntriesLearnersDetailsPage.PressAddOccupationalSpecialismLink();
        }

        [Then(@"I am navigated to the Search for a learner page")]
        public void ThenIAmNavigatedToTheSearchForALearnerPage()
        {
            AssessmentEntriesSearchForLearnerPage.VerifyAssessmentEntriesSearchForLearnerPage();
        }

        [When(@"I click the Search for a learner breadcrumb on the Assessment Entry Learner Details page")]
        public void WhenIClickTheSearchForALearnerBreadcrumbOnTheAssessmentEntryLearnerDetailsPage()
        {
            AssessmentEntriesLearnersDetailsPage.PressSearchForALearnerBreadcrumb();
        }

        [Then(@"I am navigated to the assessments dashboard")]
        public void ThenIAmNavigatedToTheAssessmentsDashboard()
        {
            AssessmentEntriesPage.VerifyAssessmentEntriesPage();
        }

        [When(@"I search for the (.*) and click the Asessments breadcrumb on the Assessment Entry Learner Details page")]
        public void WhenISearchForTheAndClickTheAsessmentsBreadcrumbOnTheAssessmentEntryLearnerDetailsPage(string ULN)
        {
            AssessmentEntriesSearchForLearnerPage.EnterULN(ULN);
            AssessmentEntriesLearnersDetailsPage.PressAssessmentsBreadcrumb();
        }

        [When(@"I search for the (.*) and click the Home breadcrumb on the Assessment Entry Learner Details page")]
        public void WhenISearchForTheAndClickTheHomeBreadcrumbOnTheAssessmentEntryLearnerDetailsPage(string ULN)
        {
            AssessmentEntriesPage.ClickElement(SearchForLearnerLink);
            AssessmentEntriesSearchForLearnerPage.EnterULN(ULN);
            AssessmentEntriesLearnersDetailsPage.PressHomeBreadcrumb();
        }


        [Given(@"I update the registrations to the previous year")]
        [When(@"I update the registrations to the previous year")]
        public void WhenIUpdateTheRegistrationsToThePreviousYear()
        {
            SqlQueries.UpdateAcademicYearToPreviousYear();
        }

        [When(@"I click the Add assessment series link")]
        public void WhenIClickTheAddAssessmentSeriesLink()
        {
            AssessmentEntriesLearnersDetailsPage.PressAddACoreAssessmentSeries();
        }

        [Then(@"the success banner is displayed for the core assessment series added for ""(.*)""")]
        public void ThenTheSuccessBannerIsDisplayedForTheCoreAssessmentSeriesAddedFor(string CoreTitle)
        {
            AssessmentEntriesLearnersDetailsPage.VerifyAddCoreSuccessBanner(CoreTitle);
        }

        [Then(@"the success banner is removed for the core assessment series added for ""(.*)""")]
        public void ThenTheSuccessBannerIsRemovedForTheCoreAssessmentSeriesAddedFor(string CoreTitle)
        {
            AssessmentEntriesLearnersDetailsPage.VerifyRemoveCoreAssessmentSuccessBanner(CoreTitle);
        }


        [Then(@"the new assessment entry which has been added is displayed in the Core\(code\) section")]
        public void ThenTheNewAssessmentEntryWhichHasBeenAddedIsDisplayedInTheCoreCodeSection()
        {
            AssessmentEntriesLearnersDetailsPage.VerifyCoreAssessmentEntryDetails();
        }

        [Then(@"the remove link will be displayed next to the Core Assessment series details")]
        public void ThenTheRemoveLinkWillBeDisplayedNextToTheCoreAssessmentSeriesDetails()
        {
            AssessmentEntriesLearnersDetailsPage.VerifyAddRemoveCoreLinkTextIsDisplayed();
        }

        [When(@"I click the remove link on the Assessment Details page")]
        public void GivenIClickTheRemoveLinkOnTheAssessmentDetailsPage()
        {
            AssessmentEntriesLearnersDetailsPage.ClickRemoveLink();
        }




    }
}
