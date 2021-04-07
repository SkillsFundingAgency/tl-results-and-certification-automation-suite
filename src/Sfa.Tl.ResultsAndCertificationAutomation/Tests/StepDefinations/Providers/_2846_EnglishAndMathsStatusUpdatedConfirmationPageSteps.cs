using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers
{
    [Binding]
    public class _2846_EnglishAndMathsStatusUpdatedConfirmationPageSteps : UpdateEMSuccessPage
    {
        private readonly ScenarioContext _scenarioContext;
        public _2846_EnglishAndMathsStatusUpdatedConfirmationPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [When(@"I change the radio option to ""(.*)"" in update English and Maths page")]
        public void WhenIChangeTheRadioOptionToInUpdateEnglishAndMathsPage(string radioOption)
        {
            UpdateEnglishAndMathsPage.SelectRadioButton(radioOption);
        }
        
        [Then(@"I should see update English and Maths acheivement success page")]
        public void ThenIShouldSeeUpdateEnglishAndMathsAcheivementSuccessPage()
        {
            VerifyUpdateIPSuccessPage();
            string uln = _scenarioContext["uln"] as string;
            VerifyUpdateIPSuccessData(uln);
        }
    }
}
