using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.Providers;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Providers
{
    [Binding]
    public class _2748_ChangeEnglishAndMathsPageSteps : CrateRegistrationInDb
    {
        [When(@"I click change english and maths link")]
        public void WhenIClickChangeEnglishAndMathsLink()
        {
            ClickElement(LearnerCheckAndSubmitPage.changeEnglishMaths);
        }
        [Then(@"previously selected ""(.*)"" radio option is selected on '(.*)' page")]
        public void ThenPreviouslySelectedRadioOptionIsSelectedOnPage(string radioButton, string p1)
        {
            LearnerAchievedMinStandardForEnglishAndMathsPage.VerifyRadioButtonsSelected(radioButton);
        }

        [Then(@"I expect to see english and maths change page")]
        public void ThenIExpectToSeeEnglishAndMathsChangePage()
        {
            LearnerAchievedMinStandardForEnglishAndMathsPage.VerifyChangeMinStandardAchievedForEnglishMathsPage();
        }
    }
}
