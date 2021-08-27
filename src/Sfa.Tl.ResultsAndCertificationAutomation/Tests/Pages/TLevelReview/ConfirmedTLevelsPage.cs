using NUnit.Framework;
using OpenQA.Selenium;
using Sfa.Tl.ResultsAndCertificationAutomation.Framework.Helpers;
using Sfa.Tl.ResultsAndCertificationAutomation.Tests.TestSupport;
using System;
using System.Collections.Generic;

namespace Sfa.Tl.ResultsAndCertificationAutomation.Tests.Pages.TLevelReview
{
    public class ConfirmedTLevelsPage : ElementHelper
    {
        private static string pageUrl { get; } = string.Concat(StartPage.StartPageUrl, "confirmed-tlevels");
        private static string pageTitle { get; } = "Confirmed T Levels – Manage T Level results – GOV.UK";
        private static string pageHeader { get; } = "Confirmed T Levels";
        private static readonly By pageHeaderElement = By.XPath("//*[@id='main-content']//h1");

        private static By homeBreadcrumb { get; } = By.Id("breadcrumb0");
        private static By tLevelsBreadcrumb { get; } = By.Id("breadcrumb1");
        private static By backToTLevelsButton { get; } = By.Id("tLevelsButton");        
        private static By contactUsLink = By.Id("contactusLink");
        private static By reviewink = By.Id("reviewLink");
        private static By queriedLink = By.Id("queriedLink");
        private static By iCannotFindATLevelLink = By.XPath("//*[contains(text(),'I cannot find a T Level')]");
       
        public static void VerifyConfirmedTLevelsPage()
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

        public static void ClickContactUsLink()
        {
            ClickElement(contactUsLink);
        }

        public static void ClickReviewLink()
        {
            ClickElement(reviewink);
        }

        public static void ClickQueriedLink()
        {
            ClickElement(queriedLink);
        }
        public static void ClickICannotFinaATLevelLink()
        {
            ClickElement(iCannotFindATLevelLink);
        }

        public static void VerifyContactUsLinkPresent()
        {
            bool ContactUsLinkPresent = IsPresent(contactUsLink);
            bool ExpectedContactUsLinkPresence = true;
            Assert.AreEqual(ExpectedContactUsLinkPresence, ContactUsLinkPresent);
        }

        public static void ClickTLevelLink(string TLevel)
        {
             IList<IWebElement> all = WebDriver.FindElements(By.XPath("//*[@id='main-content']/div/div/dl/div"));

            String[] allText = new String[all.Count];
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
                    String ExpectedXpath = "//*[@id='main-content']/div/div/dl/div[" + i + "]/dd[2]/a";
                    WebDriver.FindElement(By.XPath(ExpectedXpath)).Click();
                    //break;
                }
            }
        }

    }
}
