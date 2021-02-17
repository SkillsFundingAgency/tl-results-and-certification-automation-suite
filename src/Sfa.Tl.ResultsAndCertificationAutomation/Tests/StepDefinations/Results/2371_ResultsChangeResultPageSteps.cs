using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class _2371CreateSelectTheCoreResultPageChangeSteps
    {
        [When(@"I press the Change link on the Results Learners Results page")]
        public void WhenIPressTheChangeLinkOnTheResultsLearnersResultsPage()
        {
            ResultsLearnersResultsPage.ClickChangeResultLink();
        }
        
        [When(@"I press the back link in the Results Change Results page")]
        public void WhenIPressTheBackLinkInTheResultsChangeResultsPage()
        {
            ResultsChangeCoreGradePage.ClickBackLink();
        }

        [Then(@"the Results Change Result page is displayed for is displayed for the registration with core ""(.*)"" and assessment series of ""(.*)""")]
        public void ThenTheResultsChangeResultPageIsDisplayedForIsDisplayedForTheRegistrationWithCoreAndAssessmentSeriesOf(string Core, string AssessmentSeries)
        {
            ResultsChangeCoreGradePage.VerifyChangeCoreGradePage(Core, AssessmentSeries);
        }


        [When(@"I press the Change button on the Results Change Results page without changing the grade")]
        public void WhenIPressTheChangeButtonOnTheResultsChangeResultsPageWithoutChangingTheGrade()
        {
            ResultsChangeCoreGradePage.ClickChangeButton();
        }


        [Given(@"I have a (.*) with core result of ""(.*)"" with core ""(.*)"" and assessment series ""(.*)"" and specialism ""(.*)""")]
        public void GivenIHaveAWithCoreResultOfWithCoreAndAssessmentSeriesAndSpecialism(string ULN, string Grade, string CoreText, string AssessmentSeries, string SpecialismText)
        {
            ResultsSearchForALearnerPage.EnterULN(ULN);
            ResultsLearnersResultsPage.MaximiseWindow();
            ResultsLearnersResultsPage.ClickAddResultLink();
            ResultsSelectCorePage.VerifyAddCorePage(CoreText, AssessmentSeries);
            ResultsSelectCorePage.SelectAStarResult();
            ResultsResultAddedConfirmationPage.VerifyResultAddeddConfirmationPage(ULN);
            ResultsResultAddedConfirmationPage.ClickBackToLearnersResultsButton();
            ResultsLearnersResultsPage.VerifyAssessmenSeriesText(AssessmentSeries, Grade);
        }

    }
}
