using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewsAndAppeals
{
    [Binding]
    public class _3636_ChangeLinkFromCheckSubmitPageSteps
    {

        private readonly ScenarioContext _scenarioContext;
        public _3636_ChangeLinkFromCheckSubmitPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;

        }

        [When(@"I click on the Change link next to the new grade")]
        public void WhenIClickOnTheChangeLinkNextToTheNewGrade()
        {
            RAUCheckAndSubmitPage.ClickChangeLink();
        }
        
        [Then(@"I am shown the update appealed grade page")]
        public void ThenIAmShownTheUpdateAppealedGradePage()
        {
            RAUSelectCoreComponentGradePage.VerifySelectTheCoreComponentGradePage();
        }
    }
}
