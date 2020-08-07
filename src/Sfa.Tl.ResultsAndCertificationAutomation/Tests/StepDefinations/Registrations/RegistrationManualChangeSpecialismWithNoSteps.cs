using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationManualChangeSpecialismWithNoSteps : RegistrationsManualPage
    {
        [Given(@"I select the specialism and click Change button")]
        public void GivenISelectTheSpecialismAndClickContinue()
        {
            ClickElement(SelectSpecialismFinancial);
            ClickChangeBtn();
        }
    }
}
