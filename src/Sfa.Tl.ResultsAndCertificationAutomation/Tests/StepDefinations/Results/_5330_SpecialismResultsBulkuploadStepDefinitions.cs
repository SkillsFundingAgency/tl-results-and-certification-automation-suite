using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Results
{
    [Binding]
    public class _5330_SpecialismResultsBulkuploadStepDefinitions : ElementHelper
    {
        [When(@"I upload results ""([^""]*)"" file")]
        public void WhenIUploadResultsFile(string file)
        {
            UploadFile(RegistrationsPage.ChooseFile, file);
            ClickElement(RegistrationsPage.SubmitFileBtn);
        }

        [Then(@"results upload successfully message shown")]
        public void ThenResultsUploadSuccessfullyMessageShown()
        {
            ResultsDashboardPage.VerifyUploadResultsSuccessPage();
        }
    }
}
