using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class Tlrc1881UpdateUserGuideForAssessmentEntriesSteps : StartPage
    {
        [Given(@"I have navigated to the Start Page")]
        public void GivenIHaveNavigatedToTheStartPage()
        {
            WebDriver.Navigate().GoToUrl(StartPageUrl);
        }
        
        [When(@"I click the data format and rules link")]
        public void WhenIClickTheDataFormatAndRulesLink()
        {
            ClickDataFormatLink();
        }

        [Then(@"the User Guide page will be displayed")]
        public void ThenTheUserGuidePageWillBeDisplayed()
        {
            VerifyTechSpecPage();
        }

        [Then(@"registration data rule file will be download on clicking the link")]
        public void ThenRegistrationDataRuleFileWillBeDownloadOnClickingTheLink()
        {
            VerifyRegistrationDataFormat();
        }
        [Then(@"assessment data rule file will be download on clicking the link")]
        public void ThenAssessmentDataRuleFileWillBeDownloadOnClickingTheLink()
        {
            VerifyAssessmentDataFormat();
        }
        [Then(@"result data rule file will be download on clicking the link")]
        public void ThenResultDataRuleFileWillBeDownloadOnClickingTheLink()
        {
            VerifyResultDataFormat();
        }
    }
}
