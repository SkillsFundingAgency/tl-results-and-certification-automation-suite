using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class _2266_CreateProblemWithResultsUploadPageSteps
    {
        [Given(@"I navigate to the Results Upload Problem page")]
        public void GivenINavigateToTheResultsUploadProblemPage()
        {
            ResultsProblemWithUploadPage.NavigateToResultsUploadProblemPage();
        }

        [When(@"I press the Back to upload file button")]
        public void WhenIPressTheBackToUploadFileButton()
        {
            ResultsProblemWithUploadPage.PressBackToUploadButton();
        }

        [Then(@"I will be shown the Results Problem with Upload Page")]
        public void ThenIWillBeShownTheResultsProblemWithUploadPage()
        {
            ResultsProblemWithUploadPage.VerifyAssesmenEntryUploadProblemPage();
        }


        [When(@"I press the Back to Results button")]
        public void GivenIPressTheBackToResultsButton()
        {
            ResultsProblemWithUploadPage.PressBackToResultsButton();
        }
        
        [Then(@"I am on results upload page")]
        public void ThenIAmOnResultsUploadPage()
        {
            ResultsDashboardPage.VerifyUploadResultsPage();
        }
    }
}
