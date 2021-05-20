using NUnit.Framework;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.StatementOfAchievement;
using System;
using TechTalk.SpecFlow;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.StepDefinations.StatementOfAchievement
{
    [Binding]
    public class _3103_StatementOfAchievementNotAVailableYetPageSteps
    {
        [Then(@"I am navigated to the SOA not yet available page if the date is less than (.*)th August (.*)")]
        public void ThenIAmNavigatedToTheSOANotYetAvailablePageIfTheDateIsLessThanThAugust(int p0, int p1)
        {
            DateTime date1 = DateTime.UtcNow;
            Console.WriteLine(date1);
            DateTime SOADate = new DateTime(2021,08,10);
            Console.WriteLine(SOADate);

            int result = DateTime.Compare(date1, SOADate);
          
            if (result < 0)
            {
                SOANotAvailableYetPage.VerifySOANotAvailableYetPage();
            }

            else
            {
                Console.WriteLine("Insert redirect for when the sysdate is the same or greater than the SOA date.");
            }         
        }


        [When(@"I click the Back to home button on the SOA not yet available page then I am taken back to the dashboard")]
        public void ThenIClickTheBackToHomeButtonOnTheSOANotYetAvailablePageThenIAmTakenBackToTheDashboard()
        {
            SOANotAvailableYetPage.ClickBackToHomeButton();
        }

        [When(@"I click the back link on the SOA not yet available page then I am taken back to the dashboard")]
        public void WhenIClickTheBackLinkOnTheSOANotYetAvailablePageThenIAmTakenBackToTheDashboard()
        {
            SOANotAvailableYetPage.ClickBackLink();
        }



    }
}
