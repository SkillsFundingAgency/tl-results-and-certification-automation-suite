using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.StatementOfAchievement;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.PostalAddress;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.StatementOfAchievement
{
    [Binding]
    public class _3160SOAChangePostalAddressSteps
    {
        [Given(@"I click on the Change link next to the organisation’s postal address")]
        public void GivenIClickOnTheChangeLinkNextToTheOrganisationSPostalAddress()
        {
            SOACheckAndSubmitPage.ClickTLevelPostalAddress_ChangeLink();
        }
        
        [Given(@"I click the Change address button on the Statement of Achievement - Change Learner's T-Level Component Achievements page")]
        public void GivenIClickTheChangeAddressButtonOnTheStatementOfAchievement_ChangeLearnerST_LevelComponentAchievementsPage()
        {
            SOAChangePostalAddressPage.ClickChangeAddressBtn();
        }
        
        [Then(@"I am shown the Change your organisation’s postal address page")]
        public void ThenIAmShownTheChangeYourOrganisationSPostalAddressPage()
        {
            SOAChangePostalAddressPage.VerifySOAChangeOrganisationsPostalAddressPage();
        }
        
        [Then(@"I click the Back link on the Statement of Achievement - Change your organisation’s postal address page")]
        public void ThenIClickTheBackLinkOnTheStatementOfAchievement_ChangeYourOrganisationSPostalAddressPage()
        {
            SOAChangePostalAddressPage.ClickBackLink();
        }
        
        [Then(@"the Manage Postal Address page is displayed")]
        public void ThenTheManagePostalAddressPageIsDisplayed()
        {
            ManagePostalAddress.VerifyManageOrgPostalAddressPage();
            ManagePostalAddress.VerifyPostalAddress();
        }
    }
}
