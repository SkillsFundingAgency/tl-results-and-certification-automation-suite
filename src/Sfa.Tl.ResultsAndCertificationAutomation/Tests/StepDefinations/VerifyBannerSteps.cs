﻿using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using NUnit.Framework;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class VerifyBannerSteps : StartPage
    {
        private static string DfEUserName = WebDriverFactory.Config["DfEUserName"];
        private static string DfEPassword = WebDriverFactory.Config["DfEPassword"];
        
        [Given(@"A Tlevel start page")]
        public void GivenATlevelStartPage()
        {
            WebDriver.Navigate().GoToUrl(StartPageUrl);
        }
        
        [Given(@"I have clicked in Start Now button")]
        public void GivenIHaveClickedInStartNowButton()
        {
            WebDriver.FindElement(StartNowButton).Click();
        }
        
        [When(@"i sign in with valid DfE Username and password")]
        public void WhenISignInWithValidDfEUsernameAndPassword()
        {
            DfESignInPage.DfESignIn(DfEUserName, DfEPassword);
        }
        
        [Then(@"I should page Banner information on top of the page")]
        public void ThenIShouldPageBannerInformationOnTopOfThePage()
        {
            PageHelper.WaitForElement(by: TlevelDashboardPage.BannerInfo, 30);
            Assert.True(WebDriver.FindElement(TlevelDashboardPage.BannerInfo).Text.Contains(TlevelDashboardPage.BannerText));
        }
    }
}
