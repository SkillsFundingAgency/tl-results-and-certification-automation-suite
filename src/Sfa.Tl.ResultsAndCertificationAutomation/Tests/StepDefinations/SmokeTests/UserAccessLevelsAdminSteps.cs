﻿using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.SmokeTests
{
    [Binding]
    public class UserAccessLevelsAdminSteps : UserAccessLevels
    {
        [Then(@"I should get access to all services")]
        public void ThenIShouldGetAccessToAllServices()
        {
            AccessLevelAdmin();
        }
        [Given(@"I have passed provider dashboard url in the browser")]
        public void GivenIHavePassedProviderDashboardUrlInTheBrowser()
        {
            NavigateProviderDashboard();
        }
        [Given(@"I have passed AO dashboard url in the browser")]
        public void GivenIHavePassedAODashboardUrlInTheBrowser()
        {
            NavigateAoDashboard();
        }
    }
}
