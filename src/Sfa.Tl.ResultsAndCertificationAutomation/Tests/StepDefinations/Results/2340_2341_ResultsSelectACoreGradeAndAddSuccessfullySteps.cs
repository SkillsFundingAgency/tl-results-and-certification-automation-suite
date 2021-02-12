using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class _2340_CreateSelectTheCoreResultPageAddSteps
    {
        [When(@"I click the Add result link")]
        public void WhenIClickTheAddResultLink()
        {
            ResultsLearnersResultsPage.MaximiseWindow();
            ResultsLearnersResultsPage.ClickAddResultLink();
        }

        [When(@"I click Submit on the Select a core result page without making any changes")]
        public void WhenIClickSubmitOnTheSelectACoreResultPageWithoutMakingAnyChanges()
        {
            ResultsSelectCorePage.ClickSubmitButton();
        }

        [Then(@"the Select the core result page is displayed")]
        public void ThenTheSelectTheCoreResultPageIsDisplayed()
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"the Select the core result page is displayed  for a registration with core ""(.*)"" and assessment series of ""(.*)""")]
        public void ThenTheSelectTheCoreResultPageIsDisplayedForARegistrationWithCoreAndAssessmentSeriesOf(string Core, string AssessmentSeries)
        {
            ResultsSelectCorePage.VerifyAddCorePage(Core, AssessmentSeries);
        }

        [When(@"I click the back link on the results select core page")]
        public void WhenIClickTheBackLinkOnTheResultsSelectCorePage()
        {
            ResultsSelectCorePage.ClickBackLink();
        }

        [When(@"I select a core result as ""(.*)""")]
        public void WhenISelectACoreResultAs(string Result)
        {
            ResultsSelectCorePage.SelectAStarResult();
        }

        [Then(@"the result added successfully confirmation page is displayed for (.*)")]
        public void ThenTheResultAddedSuccessfullyConfirmationPageIsDisplayedFor(string ULN)
        {
            ResultsResultAddedConfirmationPage.VerifyResultAddeddConfirmationPage(ULN);
        }

        [When(@"I press the Back to learners results button")]
        public void WhenIPressTheBackToLearnersResultsButton()
        {
            ResultsResultAddedConfirmationPage.ClickBackToLearnersResultsButton();
        }

    }
}
