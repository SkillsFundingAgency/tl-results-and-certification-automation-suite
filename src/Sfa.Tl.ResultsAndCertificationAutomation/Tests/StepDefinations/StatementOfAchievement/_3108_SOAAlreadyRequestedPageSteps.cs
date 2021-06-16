using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.StatementOfAchievement;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostalAddress;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.StatementOfAchievement
{
    [Binding]
    public class FeatureTLRC_3108StatementOfAchievement_CheckTheLearnerDetailsBeforeSendingYourRequestSteps : ElementHelper
    {

        private readonly ScenarioContext _scenarioContext;
        public FeatureTLRC_3108StatementOfAchievement_CheckTheLearnerDetailsBeforeSendingYourRequestSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [Given(@"I requested a statement of achievement")]
        public void GivenIRequestedAStatementOfAchievement()
        {
            ClickLinkByLabel("Request statement of achievement");
            ClickLinkByLabel("Continue");
            var uln = _scenarioContext["uln"] as string;
            RequestSOA_SearchForALearnerPage.EnterULN(uln);
            SOACheckAndSubmitPage.ClickAcceptAndRequestBtn();           

        }
        
        [Given(@"I attempt to request a statement of achievement again within (.*) days")]
        public void GivenIAttemptToRequestAStatementOfAchievementAgainWithinDays(int p0)
        {
            var uln = _scenarioContext["uln"] as string;
            SOAConfirmationPage.ClickBackToHomeBtn();
            ClickLinkByLabel("Request statement of achievement");
            ClickLinkByLabel("Continue");
            RequestSOA_SearchForALearnerPage.EnterULN(uln);
        }
        
        [Then(@"I am shown the Statement of achievement already requested page")]
        public void ThenIAmShownTheStatementOfAchievementAlreadyRequestedPage()
        {
            SOARequestAlreadySubmitted.VerifySOARequestAlreadySubmittedtPage();
            SOARequestAlreadySubmitted.VerifyRequestedByDetails();
        }

        [Then(@"the learners T Level component achievement details display '(.*)' and IP displays '(.*)' on the Request already submitted page")]
        public void ThenTheLearnersTLevelComponentAchievementDetailsDisplayAndIPDisplaysOnTheRequestAlreadySubmittedPage(string MathEngStatus, string IndPlacementStatus)
        {
            SOARequestAlreadySubmitted.VerifyLearnersTLevelComponentAchievements(MathEngStatus, IndPlacementStatus);
        }

        [Then(@"the learners registration and qualification details are shown on the Request already submitted page")]
        public void ThenTheLearnersRegistrationAndQualificationDetailsAreShownOnTheRequestAlreadySubmittedPage()
        {
            var uln = _scenarioContext["uln"] as string;
            SOARequestAlreadySubmitted.VerifyLearnerDetails(uln);
            SOARequestAlreadySubmitted.VerifyQualificationDetails();
            SOARequestAlreadySubmitted.VerifyPostalAddress();
        }

        [When(@"I navigate back to the SOA Request already submitted page from the Request Statement of Achievement -  Search for a learner page")]
        public void WhenINavigateBackToTheSOARequestAlreadySubmittedPageFromTheRequestStatementOfAchievement_SearchForALearnerPage()
        {
            var uln = _scenarioContext["uln"] as string;
            RequestSOA_SearchForALearnerPage.EnterULN(uln);
        }

        [When(@"I navigate back to the SOA Request already submitted page from the request Statement of Achievement page")]
        public void WhenINavigateBackToTheSOARequestAlreadySubmittedPageFromTheRequestStatementOfAchievementPage()
        {
            ClickLinkByLabel("Continue");
            var uln = _scenarioContext["uln"] as string;
            RequestSOA_SearchForALearnerPage.EnterULN(uln);
        }

        [When(@"I press the '(.*)' breadcrumb on the SOA Request already submitted page")]
        [Then(@"I press the '(.*)' breadcrumb on the SOA Request already submitted page")]
        public void ThenIPressTheBreadcrumbOnTheSOARequestAlreadySubmittedPage(string Breadcrumb)
        {
            SOARequestAlreadySubmitted.ClickBreadCrumb(Breadcrumb);
        }


        [Then(@"I press the Back to Home button")]
        public void ThenIPressTheBackToHomeButton()
        {
            SOARequestAlreadySubmitted.ClickBackToHomeBtn();
        }



        [Then(@"I navigate back to the Statement of achievement already requested page")]
        public void ThenINavigateBackToTheStatementOfAchievementAlreadyRequestedPage()
        {
            var uln = _scenarioContext["uln"] as string;
            ClickLinkByLabel("Request statement of achievement");
            ClickLinkByLabel("Continue");
            RequestSOA_SearchForALearnerPage.EnterULN(uln);
        }



    }
}
