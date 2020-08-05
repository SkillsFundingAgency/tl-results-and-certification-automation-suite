using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class TechSpecDownloadSteps : StartPage
    {
        [Given(@"I have naviageted to tech spec page")]
        public void GivenIHaveNaviagetedToTechSpecPage()
        {
            WebDriver.Navigate().GoToUrl(TechSpecPageUrl);
        }
        
        [Then(@"I should see Tech spec page with download file link")]
        public void ThenIShouldSeeTechSpecPageWithDownloadFileLink()
        {
            VerifyTechSpecPage();
        }
    }
}
