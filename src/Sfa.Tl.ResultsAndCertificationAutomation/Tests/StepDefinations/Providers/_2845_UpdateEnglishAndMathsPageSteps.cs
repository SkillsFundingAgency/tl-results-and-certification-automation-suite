using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers
{
    [Binding]
    public class _2845_UpdateEnglishAndMathsPageSteps : UpdateEnglishAndMathsPage
    {
        [Then(@"I should see Update English and Maths page")]
        public void ThenIShouldSeeUpdateEnglishAndMathsPage()
        {
            VerifyUpdateIPSuccessPage();
        }
        
        [Then(@"""(.*)"" radio option is pre selected in English and Maths page")]
        public void ThenRadioOptionIsPreSelectedInEnglishAndMathsPage(string radioOption)
        {
            VerifyRadioButtonsSelected(radioOption);
        }
    }
}
