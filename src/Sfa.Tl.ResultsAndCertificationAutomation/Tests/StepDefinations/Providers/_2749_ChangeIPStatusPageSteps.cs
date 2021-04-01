using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers
{
    [Binding]
    public class _2749_ChangeIPStatusPageSteps : CrateRegistrationInDb
    {
        [When(@"I click on IP change link")]
        public void WhenIClickOnIPChangeLink()
        {
            ClickElement(LearnerHasTheLearnerCompletedIPPage.RadioButtonYesCompleted);
        }
        [Then(@"I expect to see the learner completed Industry Placement change page")]
        public void ThenIExpectToSeeTheLearnerCompletedIndustryPlacementChangePage()
        {
            LearnerHasTheLearnerCompletedIPPage.VerifyChangeHasTheLearnerCompletedIPPage();
        }
        [Then(@"previously selected ""(.*)"" radio option is selected")]
        public void ThenPreviouslySelectedRadioOptionIsSelected(string radioButton)
        {
            switch (radioButton)
            {
                case "Yes, completed":
                    Assert.AreEqual(true, WebDriver.FindElement(LearnerHasTheLearnerCompletedIPPage.RadioButtonYesCompleted).Selected);
                    break;
                case "Yes, completed with special consideration":
                    Assert.AreEqual(true, WebDriver.FindElement(LearnerHasTheLearnerCompletedIPPage.RadioButtonYesSpecialConsideration).Selected);
                    break;
                case "No, still to be completed":
                    Assert.AreEqual(true, WebDriver.FindElement(LearnerHasTheLearnerCompletedIPPage.RadioButtonNo).Selected);
                    break;
            }
        }
        [When(@"I select ""(.*)"" radio button and press change")]
        public void WhenISelectRadioButtonAndPressChange(string RadioButton)
        {
            LearnerHasTheLearnerCompletedIPPage.ClickRadioButton(RadioButton);
        }

        [Then(@"I should see new IP status in check and submit page")]
        public void ThenIShouldSeeNewIPStatusInCheckAndSubmitPage()
        {
            LearnerCheckAndSubmitPage.VerifyProviderCheckAndSubmitPage();
        }

    }
}
