using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class _2308CreateSearchForALearnerPageResultsSteps
    {
        
        //[Then(@"I will be navigated to the Results Search for a Learner page")]
        //public void ThenIWillBeNavigatedToTheResultsSearchForALearnerPage()
        //{
        //    ResultsSearchForALearnerPage.VerifyResultsSearchLearnerPage();
        //}

        [Then(@"I will be navigated to the Results Search for a Learner page")]
        public void ThenIWillBeNavigatedToTheResultsSearchForALearnerPage()
        {
            ResultsSearchForALearnerPage.VerifyResultsSearchLearnerPage();
        }


        [Then(@"I will see an error message stating Invalid ULN")]
        public void ThenIWillSeeAnErrorMessageStatingInvalidULN()
        {
            ResultsSearchForALearnerPage.VerifyInvalidUlnSearchErrorMessage();
        }

        [When(@"I enter an invalid ULN as ""(.*)""")]
        public void WhenIEnterAnInvalidULNAs(string ULN)
        {
            ResultsSearchForALearnerPage.EnterUln(ULN);
        }

        [Then(@"I will see an error message stating Enter a ULN")]
        public void ThenIWillSeeAnErrorMessageStatingEnterAULN()
        {
            ResultsSearchForALearnerPage.VerifyEmptyUlnSearchErrorMessage();
        }

        [When(@"I click on the Results breadcrumb link")]
        public void WhenIClickOnTheResultsBreadcrumbLink()
        {
            ResultsSearchForALearnerPage.ClickResultsBreadcrumb();
        }

        [When(@"I click on the Home breadcrumb link")]
        public void WhenIClickOnTheHomeBreadcrumbLink()
        {
            ResultsSearchForALearnerPage.ClickHomeBreadcrumb();
        }



    }
}
