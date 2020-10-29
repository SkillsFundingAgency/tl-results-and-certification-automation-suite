using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.SmokeTests
{
    [Binding]
    public class UserAccessLevelsRegistrationEditorSteps : UserAccessLevels
    {
        [Then(@"I should get access to Registrations, Assessment entries and Account pages only")]
        public void ThenIShouldGetAccessToRegistrationsAssessmentEntriesAndAccountPagesOnly()
        {
            AccessLevelRegistrationEditor();
        }
    }
}
