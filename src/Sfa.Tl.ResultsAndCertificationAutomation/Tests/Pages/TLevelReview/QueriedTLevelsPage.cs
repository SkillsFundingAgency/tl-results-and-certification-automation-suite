using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using System.Collections.Generic;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.TLevelReview
{
    public class QueriedTLevelsPage : ElementHelper
    {
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "queried-tlevels");
        private static string pageTitle { get; } = "Queried T Levels – Manage T Level results – GOV.UK";
        private static string pageHeader { get; } = "Queried T Levels";
        private static readonly By pageHeaderElement = By.XPath("//*[@id='main-content']//h1");

        private static By homeBreadcrumb { get; } = By.Id("breadcrumb0");
        private static By tLevelsBreadcrumb { get; } = By.Id("breadcrumb1");
        private static By backToTLevelsButton { get; } = By.Id("tLevelsButton");        
        private static By contactUsLink = By.Id("contactusLink");
        private static By reviewink = By.Id("reviewLink");
        private static By confirmedLink = By.Id("confirmedLink");
        private static By iCannotFindATLevelLink = By.XPath("//*[contains(text(),'I cannot find a T Level')]");
       
        public static void VerifyQueriedTLevelsPage()
        {          
            Assert.IsTrue(WebDriver.Url.Contains(pageUrl));
            Assert.AreEqual(WebDriver.Title, pageTitle);
            Assert.AreEqual(WebDriver.FindElement(pageHeaderElement).Text, pageHeader);
        }

        public static void ClickHomeBreadcrumb()
        {
            ClickElement(homeBreadcrumb);
        }

        public static void ClickTLevelsBreadcrumb()
        {
            ClickElement(tLevelsBreadcrumb);
        }
        public static void ClickBackToTLevelsBtn()
        {
            ClickElement(backToTLevelsButton);
        }

        public static void VerifyContactUsLinkPresent()
        {
            bool ContactUsLinkPresent = IsPresent(contactUsLink);
            bool ExpectedContactUsLinkPresence = true;
            Assert.AreEqual(ExpectedContactUsLinkPresence, ContactUsLinkPresent);
        }

        public static void ClickReviewLink()
        {
            ClickElement(reviewink);
        }

        public static void ClickConfirmedLink()
        {
            ClickElement(confirmedLink);
        }
        public static void ClickICannotFinaATLevelLink()
        {
            ClickElement(iCannotFindATLevelLink);
        }

        public static void ClickTLevelLink(string TLevel)
        {
            IList<IWebElement> all = WebDriver.FindElements(By.XPath("//*[@id='main-content']/div/div/dl/div"));

            string[] allText = new string[all.Count];
            int i = 0;
            foreach (IWebElement element in all)
            {

                allText[i] = element.Text;
                string Test = allText[i];
                int indexOfSteam = Test.IndexOf("View");
                if (indexOfSteam >= 0)
                {
                    Test = Test.Remove(indexOfSteam).Trim();
                }

                i = i + 1;

                if (Test == TLevel)
                {
                    string ExpectedXpath = "//*[@id='main-content']/div/div/dl/div[" + i + "]/dd[2]/a";
                    WebDriver.FindElement(By.XPath(ExpectedXpath)).Click();
                    break;
                }
            }
        }
    }
}
