using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class TLRC1782_ReregisterChangeCoreChangeProviderSteps : ReregisterCheckAndSubmitPage
    {
        [When(@"I select different provider and click continue")]
        public void WhenISelectDifferentProviderAndClickContinue()
        {
            RegistrationsManualPage.SelectProviderFromList(ChangeAnotherProvider);
            ClickContinueBtn();
        }
        
        [Then(@"Core dropdown value shoule be reset")]
        public void ThenCoreDropdownValueShouleBeReset()
        {
            VerifyChangeCoreDefaultValue();
        }
    }
}
