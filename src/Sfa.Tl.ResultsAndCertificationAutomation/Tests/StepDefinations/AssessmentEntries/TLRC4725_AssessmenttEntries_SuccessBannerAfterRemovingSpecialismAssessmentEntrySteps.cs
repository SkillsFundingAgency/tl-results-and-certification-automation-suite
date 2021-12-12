using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using OpenQA.Selenium;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.AssessmentEntries
{
    [Binding]
    public class TLRC_4725MANUALJOURNEYASSESSMENTENTRYCHANGES_SuccessBannerAfterRemovingSpecialismAssessmentEntrySteps : ElementHelper
    {
        [When(@"I add a specialism entry")]
        public void WhenIAddASpecialismEntry()
        {
            AssessmentEntriesLearnersDetailsPage.PressAddSpecialismAssessmentSeriesForCouplet();
            AssessmentEntriesAddSpecialismAssessmentEntryPage.PressYesRadioButton();
        }

        [When(@"I add a specialism assessment entry for a single specialism")]
        public void WhenIAddASpecialismAssessmentEntryForASingleSpecialism()
        {
            AssessmentEntriesLearnersDetailsPage.PressAddSpecialismAssessmentforSingleSpecialism();
            AssessmentEntriesAddSpecialismAssessmentEntryPage.PressYesRadioButton();
        }

        [When(@"I click the remove link on the Assessment Details page for the specialism/s")]
        public void WhenIClickTheRemoveLinkOnTheAssessmentDetailsPageForTheSpecialismS()
        {
            AssessmentEntriesLearnersDetailsPage.ClickRemoveAssessmentSeriesLink();
        }

        [When(@"I click the Yes, remove the entry radio button and press Submit")]
        public void WhenIClickTheYesRemoveTheEntryRadioButtonAndPressSubmit()
        {
            WebDriver.FindElement(By.Id("canremoveassessmententry")).Click();
            WebDriver.FindElement(By.Id("submitButton")).Click();
        }

        [Then(@"the success banner is shown for the specialism assessment series removed for ""(.*)""")]
        public void ThenTheSuccessBannerIsShownForTheSpecialismAssessmentSeriesRemovedFor(string Specialism)
        {
            AssessmentEntriesLearnersDetailsPage.VerifyRemoveSpecialismAssessmentSeriesSuccessBanner(Specialism);
        }

    }
}
