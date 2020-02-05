﻿using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using TechTalk.SpecFlow;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using NUnit;
using NUnit.Framework;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations
{
    [Binding]
    public class ErrorPages404Steps : StartPage
    {
        [Given(@"I have opend browser")]
        public void GivenIHaveOpendBrowser()
        {
            WebDriver.Navigate().GoToUrl(Error404);
        }

        [When(@"I enter invalid Url")]
        
        [Then(@"I should see Page not found error")]
        public void ThenIShouldSeePageNotFoundError()
        {
            PageHelper.WaitForPageElementBy(5, PageHeader);
            Assert.AreEqual(Expected404,WebDriver.Url);
            Assert.AreEqual(Constants.Error404, WebDriver.FindElement(PageHeader).Text);
        }
    }
}
