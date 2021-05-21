using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.StatementOfAchievement;
using Sfa.Tl.ResultsAndCertificationAutomation.Data;
using System;
using TechTalk.SpecFlow;


namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.StatementOfAchievement
{
    [Binding]
    public class _3105_RequestStatementOfAchievementSteps : SqlQueries
    {
        [Given(@"I add an address for Barnsley")]
        public void GivenIAddAnAddressForBarnsley()
        {
            InsertAddress();
        }
        
        [When(@"I click the back link on the Request SOA page")]
        public void WhenIClickTheBackLinkOnTheRequestSOAPage()
        {
            RequestStatementOfAchievementPage.ClickBackLink();
        }
        
        [Then(@"I am navigated to the Request SOA page if the date is greater than (.*)th August (.*)")]
        public void ThenIAmNavigatedToTheRequestSOAPageIfTheDateIsGreaterThanThAugust(int p0, int p1)
        {
            RequestStatementOfAchievementPage.VerifyRequestStatementOfAchievementPage();
        }
    }
}
