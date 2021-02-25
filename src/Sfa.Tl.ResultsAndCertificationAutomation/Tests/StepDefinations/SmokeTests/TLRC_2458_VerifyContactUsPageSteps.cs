using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.SmokeTests
{
    [Binding]
    public class CreateContactUsPageSteps
    {
        [Given(@"I click the Contact link on the start page when I am not logged in")]
        public void GivenIClickTheContactLinkOnTheStartPageWhenIAmNotLoggedIn()
        {
            StartPage.ClickContactLink();
        }
        
        [Given(@"I click the Contact link on the Dashboard page \(when I am logged in\)")]
        public void GivenIClickTheContactLinkOnTheDashboardPageWhenIAmLoggedIn()
        {
            StartPage.ClickContactLink();
        }
        
        [Then(@"Contact us page should open with a heading of ""(.*)""")]
        public void ThenContactUsPageShouldOpenWithAHeadingOf(string ExpectedH1Text)
        {
            ContactUsPage.VerifyContactUsPage(ExpectedH1Text);
        }


        [Then(@"there will be no breadcrumbs present")]
        public void ThenThereWillBeNoBreadcrumbsPresent()
        {
            ContactUsPage.VerifyBreadcrumbsNotPresent();
        }
        
        [Then(@"the support link will navigate to the Discussion forum")]
        public void ThenTheSupportLinkWillNavigateToTheDiscussionForum()
        {
            ContactUsPage.SupportLink();
        }
        
        [Then(@"there will be breadcrumbs present")]
        public void ThenThereWillBeBreadcrumbsPresent()
        {
            ContactUsPage.VerifyBreadcrumbs();
        }

        [Then(@"the Home breadcrumb will navigate to the Dasboard page")]
        public void ThenTheHomeBreadcrumbWillNavigateToTheDasboardPage()
        {
            ContactUsPage.ClickHomeBreadcrumb();
            TlevelDashboardPage.VerifyDashboardpage();
        }


    }
}
