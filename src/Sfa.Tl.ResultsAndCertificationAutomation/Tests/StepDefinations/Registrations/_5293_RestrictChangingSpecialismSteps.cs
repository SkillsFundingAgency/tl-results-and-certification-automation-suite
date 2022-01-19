using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Registrations;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class _5293_RestrictChangingSpecialismSteps : CrateRegistrationInDb
    {
        private readonly ScenarioContext scenarioContext;

        public _5293_RestrictChangingSpecialismSteps(ScenarioContext scenarionContext)
        {
            scenarioContext = scenarionContext;
        }

        [Given(@"I have a registration with specialism assessment")]
        public void GivenIHaveARegistrationWithSpecialismAssessment()
        {
            var uln = UlnHelper.GenerateUln().ToString();
            scenarioContext["uln"] = uln;
            CreateDbRegWithSpecialismAssessment(uln);
        }
        
        [Then(@"I should see change specialism restrict page")]
        public void ThenIShouldSeeChangeSpecialismRestrictPage()
        {
            RestrictChangeSpecialismPage.VerifyRestrictChangeSpecialismPage();
        }
        
        [Then(@"clicking on remove assessment entry button should take to assessment details page")]
        public void ThenClickingOnRemoveAssessmentEntryButtonShouldTakeToAssessmentDetailsPage()
        {
            RestrictChangeSpecialismPage.ClickRemoveSpecialismBtn();
            AssessmentEntriesLearnersDetailsPage.VerifyAssessmentEntriesDetailsPage();
        }
    }
}
