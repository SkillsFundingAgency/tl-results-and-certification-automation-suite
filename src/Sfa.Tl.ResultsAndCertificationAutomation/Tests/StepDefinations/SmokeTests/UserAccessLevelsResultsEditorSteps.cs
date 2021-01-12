using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.SmokeTests
{
    [Binding]
    public class UserAccessLevelsResultsEditorSteps : UserAccessLevels
    {
        [Then(@"I should get access to Resuts and Account pages only")]
        public void ThenIShouldGetAccessToResutsAndAccountPagesOnly()
        {
            AccessLevelResultsEditor();
        }
    }
}
