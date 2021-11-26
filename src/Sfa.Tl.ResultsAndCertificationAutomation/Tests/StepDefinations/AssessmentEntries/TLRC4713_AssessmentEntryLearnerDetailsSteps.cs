using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class _4713_AssessmentLearnerDetailsSteps : AssessmentEntriesPage
    {
        [Then(@"I am navigated to the Assessment Details page")]
        public void ThenIAmNavigatedToTheAssessmentDetailsPage()
        {
            AssessmentEntriesLearnersDetailsPage.VerifyAssessmentEntriesDetailsPage();
            
        }

        [Then(@"the Core section will state ""(.*)""")]
        public void ThenTheCoreSectionWillState(string CoreText)
        {
            AssessmentEntriesLearnersDetailsPage.VerifyCoreDetailsText(CoreText);
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



    }
}
