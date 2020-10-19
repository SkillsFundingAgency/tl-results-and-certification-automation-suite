using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.Registrations
{
    [Binding]
    public class CreateSelectCorePageRe_Register_Story1539Steps : RegistrationReactivateCoreDenialPage
    {

        private readonly ScenarioContext scenarionContext;

        public CreateSelectCorePageRe_Register_Story1539Steps(ScenarioContext scenarionContext)
        {
            this.scenarionContext = scenarionContext;
        }


        [When(@"I select a core which is identical to the current one")]
        public void WhenISelectACoreWhichIsIdenticalToTheCurrentOne()
        {
            RegistrationsManualPage.SelectCoreFromList(RegistrationsManualPage.InputCore);
            RegistrationsManualPage.ClickContiune();
        }
        
        [Then(@"I am shown the Core Denial page")]
        public void ThenIAmShownTheCoreDenialPage()
        {
            RegistrationReactivateCoreDenialPage.VerifyRegReactivateChangeCorePageDetails();
            scenarionContext["CoreDenialURL"] = RegistrationChangeDOBPage.CapturePageURL();
        }

        [When(@"I click the back link on the Core Denial page")]
        public void WhenIClickTheBackLinkOnTheCoreDenialPage()
        {
            RegistrationReactivateCoreDenialPage.ClickBackLink();

        }

        [Then(@"I am taken back to the Select the Core Page for reactivate registration")]
        public void ThenIAmTakenBackToTheSelectTheCorePageForReactivateRegistration()
        {
            RegistrationReactivateChangeCorePage.VerifyRegReactivateChangeCorePageDetails();
        }

        [When(@"I navigate away from the Core Denial page and attempt to navigate back using the URL")]
        public void WhenINavigateAwayFromTheCoreDenialPageAndAttemptToNavigateBackUsingTheURL()
        {
             RegistrationReactivateCoreDenialPage.ClickBackLink();
             RegistrationReactivateCoreDenialPage.NavigateToBookmarkedPage(scenarionContext["CoreDenialURL"].ToString());
        }

        [When(@"I reactivate my registration and attempt to navigate back to the Core Denial page using the URL")]
        public void WhenIReactivateMyRegistrationAndAttemptToNavigateBackToTheCoreDenialPageUsingTheURL()
        {
            RegistrationReactivateCoreDenialPage.ClickReactiveRegButton();
            RegistrationReactivateAreYouSurePage.ClickYesRadioButton();
            RegistrationReactivateAreYouSurePage.ClickSubmitButton();
            RegistrationReactivateCoreDenialPage.NavigateToBookmarkedPage(scenarionContext["CoreDenialURL"].ToString());
        }

        [When(@"I click the Reactivate the registration button")]
        public void WhenIClickTheReactivateTheRegistrationButton()
        {
            RegistrationReactivateCoreDenialPage.ClickReactiveRegButton();
        }

        [Then(@"I am shown the Are you sure you want to reactivate page")]
        public void ThenIAmShownTheAreYouSureYouWantToReactivatePage()
        {
            RegistrationReactivateAreYouSurePage.VerifyRegReactivateChangeCorePageDetails();
        }

        [When(@"I click the back link on the Are you sure you want to reactivate page")]
        public void WhenIClickTheBackLinkOnTheAreYouSureYouWantToReactivatePage()
        {
            RegistrationReactivateAreYouSurePage.ClickBackLink();
        }









    }
}
