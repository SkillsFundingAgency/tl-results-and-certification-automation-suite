using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Hooks;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class TLRC_1881_UpdateUserGuideForAssessmentEntriesSteps : Hooks
    {
        [Given(@"I have navigated to the Start Page")]
        public void GivenIHaveNavigatedToTheStartPage()
        {
            WebDriver.Navigate().GoToUrl(StartPage.StartPageUrl);
            

        }
        
        [When(@"I click the User Guide link")]
        public void WhenIClickTheUserGuideLink()
        {
            StartPage.ClickUserGuideLink();
        }
        
        [Then(@"the User Guide page will be displayed")]
        public void ThenTheUserGuidePageWillBeDisplayed()
        {
            UserGuidePage.CheckUserGuidePage();
        }
    }
}
