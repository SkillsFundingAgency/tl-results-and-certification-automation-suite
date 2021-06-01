using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.StatementOfAchievement;
using TechTalk.SpecFlow;


namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.StatementOfAchievement
{
    [Binding]
    public class _3106_StatementOfAchievement_SearchForALearnerSteps
    {
        [When(@"I enter ""(.*)"" in the Search ULN box on the Request SOA - Search for a learner page and click Search")]
        public void WhenIEnterInTheSearchULNBoxOnTheRequestSOA_SearchForALearnerPageAndClickSearch(string ULN)
        {
            RequestSOA_SearchForALearnerPage.EnterULN(ULN);
        }

        [Given(@"I click Search without entering a ULN on the Request SOA - Search for a learner page")]
        [When(@"I click Search without entering a ULN on the Request SOA - Search for a learner page")]
        public void WhenIClickSearchWithoutEnteringAULNOnTheRequestSOA_SearchForALearnerPage()
        {
            RequestSOA_SearchForALearnerPage.ClickSearch();
        }


        [When(@"I click on Continue on the Request SOA page")]
        [Given(@"I click on Continue on the Request SOA page")]
        public void GivenIClickOnContinueOnTheRequestSOAPage()
        {
            RequestStatementOfAchievementPage.ClickContinueButton();
        }


        [Then(@"I will be navigated to the Request Statement of Achievement - Search for a learner page")]
        public void ThenIWillBeNavigatedToTheRequestStatementOfAchievement_SearchForALearnerPage()
        {
            RequestSOA_SearchForALearnerPage.VerifySearchForALearnerPage();
        }
        
        [Then(@"the error message ""(.*)"" is shown on the Request SOA - Search for a learner page")]
        public void ThenTheErrorMessageIsShownOnTheRequestSOA_SearchForALearnerPage(string errorMessage)
        {
            RequestSOA_SearchForALearnerPage.VerifyErrorMessage(errorMessage);
        }

        [Given(@"I click the Request Statement of Achievement breadcrumb")]
        public void GivenIClickTheRequestStatementOfAchievementBreadcrumb()
        {
            RequestSOA_SearchForALearnerPage.ClickRequestStatementOfAchievementBreadcrumb();
        }

        [When(@"I click on the Home Breadcrumb on the Request SOA - Search for a learner page")]
        public void WhenIClickOnTheHomeBreadcrumbOnTheRequestSOA_SearchForALearnerPage()
        {
            RequestSOA_SearchForALearnerPage.ClickHomeBreadcrumb();
        }


    }
}
