using System;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Registrations;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class _4889_RemoveAbilityToChangeWithdrawnStatusForLearnersThatHaveAnActiveRegistrationWithADifferentAOSteps : CrateRegistrationInDb
    {
        private readonly ScenarioContext scenarionContext;

        public _4889_RemoveAbilityToChangeWithdrawnStatusForLearnersThatHaveAnActiveRegistrationWithADifferentAOSteps(ScenarioContext scenarionContext)
        {
            this.scenarionContext = scenarionContext;
        }

        [Given(@"I navigate to the Registration details page for my registration which is withdrawn and active with another AO")]
        public void GivenINavigateToTheRegistrationDetailsPageForMyRegistrationWhichIsWithdrawnAndActiveWithAnotherAO()
        {
            var uln = scenarionContext["uln"] as string;
            RegistrationsPage.ClickRegLink();
            RegistrationsPage.ClickManageExistingRegistrationsLink();
            RegistrationsSearchPage.SearchForULN(uln);
        }

        [Given(@"I register the registration with another AO")]
        public void GivenIRegisterTheRegistrationWithAnotherAO()
        {
            string uln = scenarionContext["uln"] as string;
            RegisterWithdrawnLearnerWithAnotherAo(uln);
        }

        [Then(@"the Change Status link is not displayed")]
        public void ThenTheChangeStatusLinkIsNotDisplayed()
        {
            RegistrationsSearchPage.VerifyChangeStatusLinkNotPresent();
        }

        [Then(@"the sub heading will state the registration is withdrawn and registered with another AO")]
        public void ThenTheSubHeadingWillStateTheRegistrationIsWithdrawnAndRegisteredWithAnotherAO()
        {
            RegistrationsSearchPage.VerifyWithdrawnLearnerRegisteredWithAnotherAOTextDisplayed();
        }

        [Then(@"the Change Status link is displayed")]
        public void ThenTheChangeStatusLinkIsDisplayed()
        {
            RegistrationsSearchPage.VerifyChangeStatusLinkIsPresent();
        }





    }
}
