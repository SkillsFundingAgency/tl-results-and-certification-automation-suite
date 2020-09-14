using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class RegistrationDetailsPageSteps
    {
        [When(@"I click the Change link next to Name")]
        public void WhenIClickTheChangeLinkNextToName()
        {
            RegistrationsSearchPage.ClickNameChangeLink();
        }

        [When(@"I click the Change link next to DOB")]
        public void WhenIClickTheChangeLinkNextToDOB()
        {
            RegistrationsSearchPage.ClickDOBChangeLink();
        }

    }
}
