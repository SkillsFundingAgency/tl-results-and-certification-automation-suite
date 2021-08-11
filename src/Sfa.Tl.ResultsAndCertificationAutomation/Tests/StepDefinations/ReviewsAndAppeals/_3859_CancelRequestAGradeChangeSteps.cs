using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.ReviewsAndAppeals;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.ReviewsAndAppeals
{
    [Binding]
    public class _3859_PostResultsServices_CancelRequestAGradeChangeSteps
    {
        [When(@"I click Cancel on the the '(.*)' page")]
        public void WhenIClickCancelOnTheThePage(string p0)
        {
            RAURequestAChangeToThisLearnersGradePage.ClickCancelLink();
        }
        
        [When(@"I press the Back link on the Cancel request a grade change page")]
        public void WhenIPressTheBackLinkOnTheCancelRequestAGradeChangePage()
        {
            RAUCancelSelectRequestGradeChangePage.ClickBackLink();
        }
        
        [When(@"I press Continue without selecting a radio button")]
        public void WhenIPressContinueWithoutSelectingARadioButton()
        {
            RAUCancelSelectRequestGradeChangePage.ClickContinueBtn();
        }
        
        [Then(@"I am shown the Cancel request a grade change page")]
        public void ThenIAmShownTheCancelRequestAGradeChangePage()
        {
            RAUCancelSelectRequestGradeChangePage.VerifyCancelSelectRequestGradeChangePage();
        }
        
        [Then(@"the radio buttons will not be populated")]
        public void ThenTheRadioButtonsWillNotBePopulated()
        {
            RAUCancelSelectRequestGradeChangePage.VerifyRadioButtonsNotPopulated();
        }

        [When(@"I press the Yes radio button and click Continue on the Cancel request a grade change page")]
        public void WhenIPressTheYesRadioButtonAndClickContinueOnTheCancelRequestAGradeChangePage()
        {
            RAUCancelSelectRequestGradeChangePage.ClickYesRadioButton();
            RAUCancelSelectRequestGradeChangePage.ClickContinueBtn();
        }

        [When(@"I press the No radio button and click Continue on the Cancel request a grade change page")]
        public void WhenIPressTheNoRadioButtonAndClickContinueOnTheCancelRequestAGradeChangePage()
        {
            RAUCancelSelectRequestGradeChangePage.ClickNoRadioButton();
            RAUCancelSelectRequestGradeChangePage.ClickContinueBtn();
        }


    }
}
